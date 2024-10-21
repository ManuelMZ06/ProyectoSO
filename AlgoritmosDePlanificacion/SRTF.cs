
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlgoritmosDePlanificacion.SRTF;

namespace AlgoritmosDePlanificacion
{
    public partial class SRTF : Form
    {
        public SRTF()
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
                int cantidadProcesos = int.Parse(txtNoProcesos.Text);
                List<string> nombresProcesos = new List<string>();
                List<int> rafagaCPU = new List<int>();
                List<int> tiempoLlegada = new List<int>();
                List<int> tiempoRestante = new List<int>();

                for (int i = 0; i < cantidadProcesos; i++)
                {
                    // Pedir nombre del proceso
                    string nombreProceso = Interaction.InputBox("Ingrese el nombre del Proceso " + (i + 1));
                    nombresProcesos.Add(nombreProceso);
                    lbProcesos.Items.Add(nombreProceso);

                    // Pedir ráfaga de CPU
                    int cpu = int.Parse(Interaction.InputBox("Ingrese la ráfaga de CPU del Proceso " + (i + 1)));
                    rafagaCPU.Add(cpu);
                    tiempoRestante.Add(cpu); // Inicialmente, el tiempo restante es igual a la ráfaga
                    lbCPU.Items.Add(cpu);

                    // Pedir tiempo de llegada
                    int llegada = int.Parse(Interaction.InputBox("Ingrese el tiempo de llegada del Proceso " + (i + 1)));
                    tiempoLlegada.Add(llegada);
                    lbLlegada.Items.Add(llegada);
                }

                // Ahora que tenemos los datos, pasamos a simular el algoritmo SRTF
                SimularSRTF(nombresProcesos, rafagaCPU, tiempoLlegada, tiempoRestante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        public void SimularSRTF(List<string> nombres, List<int> cpu, List<int> llegada, List<int> tiempoRestante)
        {
            int tiempoActual = 0;
            List<int> finalizacion = new List<int>(new int[nombres.Count]);
            List<int> retorno = new List<int>(new int[nombres.Count]);
            List<int> espera = new List<int>(new int[nombres.Count]);
            int procesosTerminados = 0;

            // Inicializar el DataGridView antes de la simulación
            InicializarDataGridView();

            while (procesosTerminados < nombres.Count)
            {
                // Buscar el proceso con el menor tiempo restante que haya llegado
                int procesoEjecutando = -1;
                int menorTiempo = int.MaxValue;

                for (int i = 0; i < nombres.Count; i++)
                {
                    if (llegada[i] <= tiempoActual && tiempoRestante[i] > 0 && tiempoRestante[i] < menorTiempo)
                    {
                        menorTiempo = tiempoRestante[i];
                        procesoEjecutando = i;
                    }
                }

                if (procesoEjecutando != -1)
                {
                    // Ejecutar el proceso por una unidad de tiempo
                    tiempoRestante[procesoEjecutando]--;
                    tiempoActual++;

                    // Actualizar el DataGridView en cada interrupción o ejecución
                    ActualizarDataGridView(procesoEjecutando, nombres[procesoEjecutando], cpu[procesoEjecutando], tiempoRestante[procesoEjecutando], llegada[procesoEjecutando], "En ejecución");

                    // Si el proceso ha terminado
                    if (tiempoRestante[procesoEjecutando] == 0)
                    {
                        finalizacion[procesoEjecutando] = tiempoActual;
                        retorno[procesoEjecutando] = finalizacion[procesoEjecutando] - llegada[procesoEjecutando];
                        espera[procesoEjecutando] = retorno[procesoEjecutando] - cpu[procesoEjecutando];
                        procesosTerminados++;

                        // Mostrar los resultados en las listas visuales
                        lbFinalizacion.Items.Add(finalizacion[procesoEjecutando]);
                        lbRetorno.Items.Add(retorno[procesoEjecutando]);
                        lbEspera.Items.Add(espera[procesoEjecutando]);

                        // Actualizar el DataGridView al finalizar el proceso
                        ActualizarDataGridView(procesoEjecutando, nombres[procesoEjecutando], cpu[procesoEjecutando], 0, llegada[procesoEjecutando], "Finalizado");
                    }
                }
                else
                {
                    // Si no hay procesos disponibles, avanzar el tiempo
                    tiempoActual++;
                }
            }

            // Mostrar los resultados finales en las listas visuales
            MostrarResultados(finalizacion, retorno, espera);
        }


        private void ActualizarDataGridView(int indice, string nombreProceso, int cpu, int tiempoRestante, int llegada, string estado)
        {
            dataGridView1.Rows.Add(new object[] {
        nombreProceso,        // Nombre del proceso
        cpu,                  // Tiempo de CPU asignado
        tiempoRestante,       // Tiempo restante
        llegada,              // Tiempo de llegada
        estado                // Estado actual del proceso (En ejecución, Finalizado, etc.)
        });
        }


        private void MostrarResultados(List<int> finalizacion, List<int> retorno, List<int> espera)
        {
            // Calcular sumas y promedios
            int sumaFinalizacion = finalizacion.Sum();
            int sumaRetorno = retorno.Sum();
            int sumaEspera = espera.Sum();

            txtSumaCPU.Text = sumaFinalizacion.ToString();
            txtPromRetorno.Text = (sumaRetorno / finalizacion.Count).ToString();
            txtPromEspera.Text = (sumaEspera / finalizacion.Count).ToString();
        }

        private void InicializarDataGridView()
        {
            dataGridView1.Rows.Clear();  // Limpia las filas anteriores si es necesario
            dataGridView1.Columns.Clear();  // Limpia las columnas anteriores si es necesario

            // Añadir las columnas al DataGridView
            dataGridView1.Columns.Add("Proceso", "Proceso");
            dataGridView1.Columns.Add("CPU", "CPU");
            dataGridView1.Columns.Add("Tiempo Restante", "Tiempo Restante");
            dataGridView1.Columns.Add("Llegada", "Tiempo de Llegada");
            dataGridView1.Columns.Add("Estado", "Estado");
        }


        private void ActualizarDataGridView(int proceso, int tiempoRestante, int tiempoLlegada, int tiempoFinalizacion, string estado)
        {
            dataGridView1.Rows.Add("Proceso " + proceso, tiempoRestante, tiempoLlegada, tiempoFinalizacion, estado);
        }


        private void button1_Click(object sender, EventArgs e)
        { //Regresar al sub Menú
            SubMenuExpropiativos nuevoForm = new SubMenuExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            AceptarDatos();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SRTF reset = new SRTF();
            reset.Show();
        }

        private void SRTF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}