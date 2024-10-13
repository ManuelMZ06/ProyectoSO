using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms.DataVisualization.Charting;


namespace AlgoritmosDePlanificacion
{
    public partial class FIFO : Form
    {
        public FIFO()
        {
            InitializeComponent();
        }

        int dato;
        string nombre;
        int[] CPU;
        int[] llegada;
        int sumaCPU;
        double retorno;
        double espera;

        public void AceptarDatos()
        {
            try
            {
                dato = int.Parse(txtNoProcesos.Text);
                CPU = new int[dato];
                llegada = new int[dato];

                for (int i = 0; i < dato; i++)
                {
                    int proceso;
                    proceso = i + 1;
                    nombre = Interaction.InputBox("Ingrese el nombre del Proceso " + proceso);
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        lbProcesos.Items.Add(nombre);
                    }

                    CPU[i] = int.Parse(Interaction.InputBox("Ingrese la ráfaga de CPU del Proceso " + proceso));
                    lbCPU.Items.Add(CPU[i]);

                    llegada[i] = int.Parse(Interaction.InputBox("Ingrese el Tiempo de Llegada del Proceso " + proceso));
                    lbLlegada.Items.Add(llegada[i]);

                    sumaCPU += CPU[i];

                    //Calcular tiempo de Finalizacion
                    double Finalizacion = sumaCPU;
                    lbFinalizacion.Items.Add(Finalizacion);

                    //Calcular tiempo de Retorno
                    double Retorno = Finalizacion - llegada[i];
                    lbRetorno.Items.Add(Retorno);
                    retorno += Retorno;

                    //Calcular tiempo de Espera
                    double Espera = Retorno - CPU[i];
                    lbEspera.Items.Add(Espera);
                    espera += Espera;

                    //Suma
                    txtSumaCPU.Text = sumaCPU.ToString();

                    //Promedio Retorno
                    double PromRetorno = retorno / dato;
                    txtPromRetorno.Text = Math.Round(PromRetorno, 2).ToString();

                    //Promedio Espera
                    double PromEspera = espera / dato;
                    txtPromEspera.Text = Math.Round(PromEspera, 2).ToString();

                }

            }
            catch
            {
                txtNoProcesos.Text = "";
                MessageBox.Show("Ingrese un dato válido", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbProcesos.Items.Clear();
                lbCPU.Items.Clear();
                lbLlegada.Items.Clear();
                lbFinalizacion.Items.Clear();
                lbRetorno.Items.Clear();
                lbEspera.Items.Clear();
            }
        }

        private void CalcularTiempos(out int[] tiemposInicio, out int[] tiemposFin)
        {
            tiemposInicio = new int[dato];
            tiemposFin = new int[dato];

            for (int i = 0; i < dato; i++)
            {
                if (i == 0)
                {
                    tiemposInicio[i] = llegada[i]; // El primer proceso comienza en su tiempo de llegada
                }
                else
                {
                    tiemposInicio[i] = Math.Max(tiemposFin[i - 1], llegada[i]); // Comienza cuando termina el anterior o en su llegada
                }

                tiemposFin[i] = tiemposInicio[i] + CPU[i]; // El tiempo de fin es inicio más la ráfaga
            }
        }

        private void MostrarGrafica()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Calcular tiempos de inicio y fin
            CalcularTiempos(out int[] tiemposInicio, out int[] tiemposFin);

            // Crear una nueva serie de tipo Bar (horizontal)
            Series series = new Series
            {
                Name = "Procesos",
                Color = System.Drawing.Color.Blue,
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Bar
            };

            // Agregar datos a la serie para el gráfico de Gantt
            for (int i = 0; i < dato; i++)
            {
                series.Points.AddXY("Proceso " + (i + 1), tiemposFin[i] - tiemposInicio[i]); // La longitud de la barra
            }

            // Agregar la serie al gráfico
            chart1.Series.Add(series);

            // Configurar los valores de los ejes
            chart1.ChartAreas[0].AxisX.Minimum = 0; // Ajusta el mínimo del eje X
            chart1.ChartAreas[0].AxisX.Maximum = tiemposFin[^1]; // Máximo del eje X al tiempo final del último proceso
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar al sub Menú
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AceptarDatos();
        }

        private void FIFO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbProcesos.Items.Clear();
            lbCPU.Items.Clear();
            lbLlegada.Items.Clear();
            lbFinalizacion.Items.Clear();
            lbRetorno.Items.Clear();
            lbEspera.Items.Clear();
            txtSumaCPU.Clear();
            txtPromRetorno.Clear();
            txtPromEspera.Clear();
            txtNoProcesos.Clear();
        }
    }
}
