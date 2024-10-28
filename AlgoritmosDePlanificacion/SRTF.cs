
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
        // Variables globales
        List<string> nombresProcesos;
        List<int> rafagaCPU;
        List<int> tiempoLlegada;
        List<int> tiempoRestante;
        List<int> ordenLlegada; // Para mantener el orden original
        List<int> finalizacion; // Hacerla variable global
        int tiempoActual = 0;

        // Método para aceptar datos del usuario
        public void AceptarDatos()
        {
            try
            {
                int cantidadProcesos = int.Parse(txtNoProcesos.Text);
                nombresProcesos = new List<string>();
                rafagaCPU = new List<int>();
                tiempoLlegada = new List<int>();
                tiempoRestante = new List<int>();
                ordenLlegada = new List<int>(); // Lista para almacenar el orden original de llegada

                for (int i = 0; i < cantidadProcesos; i++)
                {
                    // Pedir el nombre del proceso
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
                    ordenLlegada.Add(i); // Mantener el índice del proceso original
                    lbLlegada.Items.Add(llegada);
                }

                // Pasar los datos al simulador del algoritmo SRTF
                SimularSRTF();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        // Agregar una lista para almacenar el historial de ejecución de procesos
        List<(int tiempo, int proceso)> historialEjecucion = new List<(int, int)>();

        public void SimularSRTF()
        {
            finalizacion = new List<int>(new int[nombresProcesos.Count]); // Inicializar aquí
            List<int> retorno = new List<int>(new int[nombresProcesos.Count]);
            List<int> espera = new List<int>(new int[nombresProcesos.Count]);
            int procesosTerminados = 0;
            int procesoEjecutando = -1;

            while (procesosTerminados < nombresProcesos.Count)
            {
                int procesoMenorTiempo = -1;
                int menorTiempo = int.MaxValue;

                for (int i = 0; i < nombresProcesos.Count; i++)
                {
                    if (tiempoLlegada[i] <= tiempoActual && tiempoRestante[i] > 0 && tiempoRestante[i] < menorTiempo)
                    {
                        menorTiempo = tiempoRestante[i];
                        procesoMenorTiempo = i;
                    }
                }

                if (procesoMenorTiempo != -1)
                {
                    if (procesoEjecutando != procesoMenorTiempo)
                    {
                        procesoEjecutando = procesoMenorTiempo;
                    }

                    // Ejecutar el proceso por una unidad de tiempo
                    tiempoRestante[procesoEjecutando]--;
                    historialEjecucion.Add((tiempoActual, procesoEjecutando)); // Registrar el tiempo y el proceso
                    tiempoActual++;

                    if (tiempoRestante[procesoEjecutando] == 0)
                    {
                        finalizacion[procesoEjecutando] = tiempoActual; // Registrar tiempo de finalización
                        retorno[procesoEjecutando] = finalizacion[procesoEjecutando] - tiempoLlegada[procesoEjecutando]; // Tiempo de retorno
                        espera[procesoEjecutando] = retorno[procesoEjecutando] - rafagaCPU[procesoEjecutando]; // Tiempo de espera
                        procesosTerminados++;

                    }
                    //
                }
                else
                {
                    tiempoActual++; // Si no hay proceso para ejecutar, avanzamos el tiempo
                }

            }

            // Mostrar resultados al final de la simulación
            MostrarResultados(finalizacion, retorno, espera);
        }

        private void MostrarResultados(List<int> finalizacion, List<int> retorno, List<int> espera)
        {
            // Limpiar listas visuales antes de agregar datos
            lbFinalizacion.Items.Clear();
            lbRetorno.Items.Clear();
            lbEspera.Items.Clear();

            // Mostrar resultados en el orden en que llegaron los procesos
            for (int i = 0; i < ordenLlegada.Count; i++)
            {
                int idx = ordenLlegada[i]; // Índice del proceso original
                lbFinalizacion.Items.Add(finalizacion[idx]);
                lbRetorno.Items.Add(retorno[idx]);
                lbEspera.Items.Add(espera[idx]);
            }

            // Calcular la suma correcta del uso de CPU, basada en las ráfagas de CPU
            int sumaCPU = rafagaCPU.Sum();  // Ahora estamos sumando las ráfagas de CPU, no los tiempos de finalización
            int sumaRetorno = retorno.Sum();
            int sumaEspera = espera.Sum();

            // Asegurarse de que los promedios se calculen correctamente con decimales
            double promedioRetorno = Math.Round((double)sumaRetorno / retorno.Count, 2);
            double promedioEspera = Math.Round((double)sumaEspera / espera.Count, 2);

            // Mostrar resultados finales
            txtSumaCPU.Text = sumaCPU.ToString();  // Mostrar la suma correcta de CPU
            txtPromRetorno.Text = promedioRetorno.ToString("F2");
            txtPromEspera.Text = promedioEspera.ToString("F2");

            // Dibujar la gráfica después de calcular los resultados
            DibujarGrafica();
        }


        private void DibujarGrafica()
        {
            // Limpiar el panel
            panelGrafico.Invalidate();
            panelGrafico.Update();

            using (Graphics g = panelGrafico.CreateGraphics())
            {
                // Variables para la posición inicial en el eje X
                int anchoBarra = 40; // Ancho de cada barra 
                int alturaBarra = 30; // Altura de cada barra
                int offsetY = 50; // Offset Y inicial para el primer proceso
                int espacioEntreFilas = 30; // Espacio entre cada fila de procesos

                // Colores para cada proceso
                Color[] colores = { Color.Green, Color.Gray, Color.Purple, Color.Orange, Color.Blue };

                // Etiquetas de tiempo en el eje X
                for (int i = 0; i <= tiempoActual; i++)
                {
                    g.DrawString(i.ToString(), new Font("Arial", 8), Brushes.Black, i * anchoBarra, offsetY - 30);
                }

                // Dibujar la gráfica basándose en el historial de ejecución
                for (int i = 0; i < historialEjecucion.Count; i++)
                {
                    var (tiempo, proceso) = historialEjecucion[i];
                    // Determinar el tiempo de inicio y el tiempo de fin del proceso
                    int tiempoFin = (i + 1 < historialEjecucion.Count) ? historialEjecucion[i + 1].tiempo : tiempoActual;

                    // Definir el rectángulo para la barra en su propia fila
                    Rectangle rect = new Rectangle(tiempo * anchoBarra, offsetY + (proceso * espacioEntreFilas), (tiempoFin - tiempo) * anchoBarra, alturaBarra);

                    // Dibujar la barra con el color correspondiente
                    g.FillRectangle(new SolidBrush(colores[proceso % colores.Length]), rect);

                    // Dibujar el borde de la barra
                    g.DrawRectangle(Pens.Black, rect);


                }


            }
        }

        //        //
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
            try
            {
                int cantidadProcesos = int.Parse(txtNoProcesos.Text);

                // Validación para asegurar que la cantidad de procesos sea mayor que 0
                if (cantidadProcesos <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un número válido de procesos mayor a 0.", "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si la validación falla
                }

                // Si la validación es correcta, proceder a aceptar los datos
                AceptarDatos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número entero válido para la cantidad de procesos.", "Formato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        //
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