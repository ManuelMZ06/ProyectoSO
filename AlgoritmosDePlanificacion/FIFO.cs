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
//
//
namespace AlgoritmosDePlanificacion
{
    public partial class FIFO : Form
    {
        public FIFO()
        {
            InitializeComponent();
        }
        //
        int dato;

        int[] CPU;
        int[] llegada;
        int sumaCPU;
        double retorno;
        double espera;
        int[] finalizacion; // Finalización de cada proceso
        int[] tiemposInicio; // Tiempos de inicio de cada proceso

        public void AceptarDatos()
        {
            try
            {
                dato = int.Parse(txtNoProcesos.Text);
                CPU = new int[dato];
                llegada = new int[dato];
                finalizacion = new int[dato];
                tiemposInicio = new int[dato]; // Inicializa la lista para tiempos de inicio

                for (int i = 0; i < dato; i++)
                {
                    int proceso = i + 1;
                    string nombre = Interaction.InputBox("Ingrese el nombre del Proceso " + proceso);
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        lbProcesos.Items.Add(nombre);
                    }

                    CPU[i] = int.Parse(Interaction.InputBox("Ingrese la ráfaga de CPU del Proceso " + proceso));
                    lbCPU.Items.Add(CPU[i]);

                    llegada[i] = int.Parse(Interaction.InputBox("Ingrese el Tiempo de Llegada del Proceso " + proceso));
                    lbLlegada.Items.Add(llegada[i]);

                    sumaCPU += CPU[i];

                    // Calcular tiempo de finalización
                    if (i == 0)
                    {
                        tiemposInicio[i] = llegada[i]; // El primer proceso comienza en su tiempo de llegada
                    }
                    else
                    {
                        tiemposInicio[i] = Math.Max(finalizacion[i - 1], llegada[i]); // Comienza cuando termina el anterior o en su llegada
                    }
                    finalizacion[i] = tiemposInicio[i] + CPU[i];

                    // Añadir finalización
                    lbFinalizacion.Items.Add(finalizacion[i]);

                    // Calcular tiempo de retorno y espera
                    double Retorno = finalizacion[i] - llegada[i];
                    lbRetorno.Items.Add(Retorno);
                    retorno += Retorno;
                    //
                    double Espera = Retorno - CPU[i];
                    lbEspera.Items.Add(Espera);
                    espera += Espera;

                    // Suma de CPU
                    txtSumaCPU.Text = sumaCPU.ToString();

                    // Promedios
                    txtPromRetorno.Text = (retorno / dato).ToString("F2");
                    txtPromEspera.Text = (espera / dato).ToString("F2");
                }

                // Llamar a la función para dibujar la gráfica
                DibujarGrafica();

            }
            //
            catch
            {
                //
            }
        }

        // Función para dibujar la gráfica de Gantt
        private void DibujarGrafica()
        {
            // Limpiar el panel
            panelGrafico.Invalidate();
            panelGrafico.Update();

            using (Graphics g = panelGrafico.CreateGraphics())
            {
                int anchoBarra = 40;  // Ancho de cada barra
                int alturaBarra = 30; // Altura de cada barra
                int offsetY = 50;     // Offset inicial en Y
                int espacioEntreFilas = 30; // Espacio entre filas

                Color[] colores = { Color.Green, Color.Gray, Color.Purple, Color.Orange, Color.Blue };

                // Lista de procesos (puedes adaptarla a tu estructura de datos si tienes otra)
                var procesos = CPU.Select((rafaga, i) => new
                {
                    Proceso = "P" + (i + 1),
                    RafagaCPU = rafaga,
                    TiempoInicio = tiemposInicio[i],
                    TiempoFinalizacion = finalizacion[i],
                    Color = colores[i % colores.Length]
                }).ToList();

                // Dibujar etiquetas de tiempo
                int tiempoTotal = procesos.Max(p => p.TiempoFinalizacion);
                for (int i = 0; i <= tiempoTotal; i++)
                {
                    g.DrawString(i.ToString(), new Font("Arial", 8), Brushes.Black, i * anchoBarra, offsetY - 30);
                }

                // Dibujar las barras
                for (int i = 0; i < procesos.Count; i++)
                {
                    Rectangle rect = new Rectangle(procesos[i].TiempoInicio * anchoBarra, offsetY + (i * espacioEntreFilas), procesos[i].RafagaCPU * anchoBarra, alturaBarra);

                    // Dibujar la barra
                    g.FillRectangle(new SolidBrush(procesos[i].Color), rect);
                    g.DrawRectangle(Pens.Black, rect); // Dibujar el borde

                    // Dibujar el nombre del proceso
                    g.DrawString(procesos[i].Proceso, new Font("Arial", 10), Brushes.Black, procesos[i].TiempoInicio * anchoBarra - 40, offsetY + (i * espacioEntreFilas));

                    // Dibujar líneas en medio de cada proceso
                    for (int j = procesos[i].TiempoInicio; j < procesos[i].TiempoFinalizacion; j++)
                    {
                        int lineaX = j * anchoBarra;
                        g.DrawLine(Pens.Red, lineaX, offsetY + (i * espacioEntreFilas), lineaX, offsetY + (i * espacioEntreFilas) + alturaBarra);
                    }
                }
            }
            //
        }
        //
        //
        //
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar al sub Menú
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }
        //
        private void FIFO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FIFO reset = new FIFO();
            reset.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verificar si el campo de texto de número de procesos está vacío o es cero
            if (string.IsNullOrWhiteSpace(txtNoProcesos.Text) || int.Parse(txtNoProcesos.Text) <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido de procesos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no hay datos
            }

            AceptarDatos(); // Llamada a la función para procesar los datos
        }
    }
}
