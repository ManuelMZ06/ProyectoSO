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

namespace AlgoritmosDePlanificacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int dato; // Cantidad de procesos
        string nombre; // Nombre del proceso
        int[] CPU; // Ráfaga de CPU
        int[] llegada; // Tiempo de llegada
        int[] prioridad; // Prioridad de cada proceso
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
                prioridad = new int[dato];

                for (int i = 0; i < dato; i++)
                {
                    int proceso = i + 1;
                    nombre = Interaction.InputBox("Ingrese el nombre del Proceso " + proceso);
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        lbProcesos.Items.Add(nombre);
                    }

                    CPU[i] = int.Parse(Interaction.InputBox("Ingrese la ráfaga de CPU del Proceso " + proceso));
                    lbCPU.Items.Add(CPU[i]);

                    llegada[i] = int.Parse(Interaction.InputBox("Ingrese el Tiempo de Llegada del Proceso " + proceso));
                    lbLlegada.Items.Add(llegada[i]);

                    prioridad[i] = int.Parse(Interaction.InputBox("Ingrese la Prioridad del Proceso " + proceso));
                    lbPrioridad.Items.Add(prioridad[i]);
                }

                OrdenarPorPrioridad(); // Llama a la función para ordenar los procesos
                CalcularTiempos();
                MostrarResultados();
            }
            catch
            {
                MessageBox.Show("Ingrese datos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        // Ordena los procesos según su prioridad
        private void OrdenarPorPrioridad()
        {
            for (int i = 0; i < dato - 1; i++)
            {
                for (int j = i + 1; j < dato; j++)
                {
                    if (prioridad[i] > prioridad[j]) // Orden ascendente de prioridad (más bajo = más importante)
                    {
                        Intercambiar(i, j);
                    }
                }
            }
        }

        // Función para intercambiar los procesos según su prioridad
        private void Intercambiar(int i, int j)
        {
            // Intercambiar ráfagas
            int tempCPU = CPU[i];
            CPU[i] = CPU[j];
            CPU[j] = tempCPU;

            // Intercambiar tiempos de llegada
            int tempLlegada = llegada[i];
            llegada[i] = llegada[j];
            llegada[j] = tempLlegada;

            // Intercambiar prioridades
            int tempPrioridad = prioridad[i];
            prioridad[i] = prioridad[j];
            prioridad[j] = tempPrioridad;

            // Intercambiar nombres (si fuera necesario)
            // Puedes implementar este paso si estás guardando los nombres en un array o lista aparte.
        }

        // Calcula los tiempos de retorno y espera
        private void CalcularTiempos()
        {
            sumaCPU = 0;
            retorno = 0;
            espera = 0;

            for (int i = 0; i < dato; i++)
            {
                sumaCPU += CPU[i];

                // Tiempo de finalización
                double finalizacion = sumaCPU;
                lbFinalizacion.Items.Add(finalizacion);

                // Tiempo de retorno
                double retornoProceso = finalizacion - llegada[i];
                lbRetorno.Items.Add(retornoProceso);
                retorno += retornoProceso;

                // Tiempo de espera
                double esperaProceso = retornoProceso - CPU[i];
                lbEspera.Items.Add(esperaProceso);
                espera += esperaProceso;

                // Actualizar la suma y promedios
                txtSumaCPU.Text = sumaCPU.ToString();
                txtPromRetorno.Text = Math.Round(retorno / dato, 2).ToString();
                txtPromEspera.Text = Math.Round(espera / dato, 2).ToString();
            }
        }

        private void MostrarResultados()
        {
            // Aquí podrías mostrar los resultados en una gráfica si es necesario
        }

        private void Limpiar()
        {
            lbProcesos.Items.Clear();
            lbPrioridad.Items.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Regresar al sub Menú
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AceptarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lbEspera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
