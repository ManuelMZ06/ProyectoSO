using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgoritmosDePlanificacion
{
    public partial class ROUNDROBIN : Form
    {
        public ROUNDROBIN()
        {
            InitializeComponent();
        }

        int dato;
        int quantum;
        string nombre;
        int[] CPU;
        int[] llegada;
        int sumaCPU;

        public void AceptarDatos()
        {
            try
            {
                // Leer el número de procesos y el quantum
                dato = int.Parse(txtNoProcesos.Text);
                quantum = int.Parse(txtQuantum.Text);

                // Inicializar los arreglos
                CPU = new int[dato];
                llegada = new int[dato];

                // Reiniciar suma de CPU
                sumaCPU = 0;

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

                    sumaCPU += CPU[i];

                    // Calcular tiempo de Finalizacion (por ahora solo se suman, se calculará después)
                    lbFinalizacion.Items.Add(0); // Placeholder, se calculará después
                }

                // Mostrar suma total de CPU
                txtSumaCPU.Text = sumaCPU.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un dato válido: " + ex.Message, "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarResultados(int[] tiemposFin, int[] tiemposLlegada, int cambiosDeContexto, double[] tiemposEntrada)
        {
            // Limpiar las listas antes de mostrar los resultados
            lbFinalizacion.Items.Clear();
            lblEntrada.Items.Clear();

            // Inicializar sumas para promedios
            double sumaFinalizacion = 0;
            double sumaEntrada = 0;  // Para el promedio del tiempo de entrada
            double sumaEspera = 0;   // Para el promedio del tiempo de espera

            // Mostrar tiempos de finalización y calcular promedios
            for (int i = 0; i < tiemposFin.Length; i++)
            {
                lbFinalizacion.Items.Add(tiemposFin[i]);
                sumaFinalizacion += tiemposFin[i];

                // Cálculo del tiempo de espera: 
                int tiempoEspera = (tiemposFin[i] - tiemposLlegada[i]) - CPU[i];

                // Actualizar tiempo de entrada sumando el tiempo de espera
                double tiempoEntradaAjustado = tiemposEntrada[i] + tiempoEspera;

                sumaEspera += tiempoEspera;

                // Mostrar el tiempo de entrada ajustado
                lblEntrada.Items.Add(tiempoEntradaAjustado);
                sumaEntrada += tiempoEntradaAjustado;
            }

            // Mostrar promedios
            txtPromFinalizacion.Text = (sumaFinalizacion / tiemposFin.Length).ToString("F2");
            txtPromEntrada.Text = (sumaEntrada / tiemposFin.Length).ToString("F2");

            // Mostrar cambios de contexto
            txtContexto.Text = cambiosDeContexto.ToString();
        }



        private void CalcularRoundRobin()
        {
            // Asegúrate de que CPU y llegada estén inicializados
            if (CPU == null || llegada == null || dato <= 0)
            {
                MessageBox.Show("Por favor, ingrese primero los datos de los procesos.", "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inicializa variables
            int[] remainingTime = new int[dato];
            Array.Copy(CPU, remainingTime, dato); // Copiar el tiempo de CPU a remainingTime
            int tiempoActual = 0;
            Queue<int> cola = new Queue<int>();
            List<(int proceso, int inicio, int duracion)> fragmentos = new List<(int proceso, int inicio, int duracion)>();
            


            // Agregar procesos a la cola, considerando el tiempo de llegada
            for (int i = 0; i < dato; i++)
            {
                cola.Enqueue(i);
            }

            int cambiosDeContexto = 0; // Contador para cambios de contexto
            int[] tiemposFin = new int[dato]; // Arreglo para tiempos de finalización
            int[] tiemposLlegada = new int[dato]; // Arreglo para tiempos de llegada
            double[] tiemposEntrada = new double[dato]; // Arreglo para tiempos de entrada
            int[] tiemposEsperaAntesDeEjecutarse = new int[dato]; // Para guardar el tiempo de espera antes de la primera ejecución

            // Inicializar tiempos de llegada y espera
            for (int i = 0; i < dato; i++)
            {
                tiemposLlegada[i] = llegada[i];
                tiemposEntrada[i] = -1; // Inicialmente no ha sido ejecutado
                tiemposEsperaAntesDeEjecutarse[i] = 0; // Inicialmente no hay espera
            }

            // Algoritmo Round Robin
            while (cola.Count > 0)
            {
                int index = cola.Dequeue();

                // Esperar hasta que el proceso llegue si el tiempo actual es menor que su tiempo de llegada
                if (tiempoActual < llegada[index])
                {
                    tiempoActual = llegada[index]; // Avanza el tiempo actual al tiempo de llegada del proceso
                }

                // Incrementar cambio de contexto aquí, ya que hemos pasado a otro proceso
                cambiosDeContexto++;

                if (remainingTime[index] > 0)
                {
                    // Si es la primera vez que se ejecuta el proceso, registramos el tiempo de entrada ajustado
                    if (tiemposEntrada[index] == -1) // Si no se ha registrado el tiempo de entrada
                    {
                        // Calcular el tiempo de espera antes de la primera ejecución
                        tiemposEsperaAntesDeEjecutarse[index] = tiempoActual - llegada[index];

                        // Registrar el tiempo de entrada como el tiempo actual
                        tiemposEntrada[index] = tiempoActual + 1;
                    }

                    // Calcular el tiempo que se va a ejecutar
                    int tiempoEjecutar = Math.Min(remainingTime[index], quantum);
                    tiempoActual += tiempoEjecutar;

                    // Restar el tiempo ejecutado del tiempo restante
                    remainingTime[index] -= tiempoEjecutar;

                    // Si el proceso ha terminado
                    if (remainingTime[index] == 0)
                    {
                        tiemposFin[index] = tiempoActual; // Guarda el tiempo de finalización
                    }
                    else
                    {
                        cola.Enqueue(index); // Si no ha terminado, lo vuelve a poner al final de la cola
                    }
                    fragmentos.Add((index, tiempoActual, tiempoEjecutar)); // Agregar fragmento
                }


                // Llamada al dibujar la gráfica después de calcular Round Robin
                DibujarGrafica(fragmentos, quantum); // Pasar los fragmentos a la gráfica

            }

            // Ajustar el tiempo de entrada restando el tiempo de espera antes de la primera ejecución
            for (int i = 0; i < dato; i++)
            {
                tiemposEntrada[i] -= tiemposEsperaAntesDeEjecutarse[i]; // Ajuste del tiempo de entrada
            }

            MostrarResultados(tiemposFin, tiemposLlegada, cambiosDeContexto, tiemposEntrada);
        }
        private void DibujarGrafica(List<(int proceso, int inicio, int duracion)> fragmentos, int quantum)
        {
            // Limpiar el panel
            panelGrafico.Invalidate();
            panelGrafico.Update();

            // Obtener el objeto Graphics del panel
            using (Graphics g = panelGrafico.CreateGraphics())
            {
                int anchoBarra = 20; // Ancho de cada barra
                int alturaBarra = 20; // Altura de cada barra
                int offsetY = 30; // Espacio vertical entre las filas de procesos
                int margenVertical = 40; // Espacio inicial desde arriba para el primer proceso

                // Colores para cada proceso
                Color[] colores = { Color.Green, Color.Gray, Color.Purple, Color.Orange, Color.Blue };

                // Variable para controlar el proceso actual
                int procesoActual = -1;

                // Dibujar los fragmentos de ejecución de cada proceso
                foreach (var fragmento in fragmentos)
                {
                    int proceso = fragmento.proceso;
                    int tiempoInicio = fragmento.inicio;
                    int duracion = fragmento.duracion;

                    // Crear el rectángulo para la barra del fragmento
                    Rectangle rect = new Rectangle(tiempoInicio * anchoBarra, margenVertical + proceso * offsetY, duracion * anchoBarra, alturaBarra);
                    g.FillRectangle(new SolidBrush(colores[proceso % colores.Length]), rect); // Rellenar la barra del fragmento
                    g.DrawRectangle(Pens.Black, rect); // Dibujar el contorno del fragmento

                    // Dibujar el nombre del proceso solo si es el primer fragmento de ese proceso
                    if (proceso != procesoActual)
                    {
                        g.DrawString(lbProcesos.Items[proceso].ToString(), new Font("Arial", 8), Brushes.Black,
                                     tiempoInicio * anchoBarra, margenVertical + proceso * offsetY - 15);
                        procesoActual = proceso; // Actualizar el proceso actual
                    }

                    // ** Inicio de la sección añadida para dibujar líneas en medio de cada proceso **
                    for (int j = tiempoInicio; j < tiempoInicio + duracion; j++)
                    {
                        int lineaX = j * anchoBarra;
                        g.DrawLine(Pens.Red, lineaX, margenVertical + proceso * offsetY, lineaX, margenVertical + proceso * offsetY + alturaBarra);
                    }
                    // ** Fin de la sección añadida **
                }

                // Etiquetas del eje X (línea de tiempo en la parte superior)
                int step = 1; // Cambia esto a 1 o 2 según el rango de datos
                for (int i = 0; i <= sumaCPU; i += step)
                {
                    g.DrawString(i.ToString(), new Font("Arial", 6), Brushes.Black, i * anchoBarra, margenVertical - 15); // Mover etiquetas arriba
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Regresar al sub Menú
            SubMenuExpropiativos nuevoForm = new SubMenuExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void ROUNDROBIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AceptarDatos(); // Asegúrate de aceptar los datos antes de calcular

            // Verifica si hay procesos ingresados
            if (lbProcesos.Items.Count == 0 || CPU.Length == 0)
            {
                MessageBox.Show("No se han ingresado procesos. Por favor, ingrese los datos antes de calcular.",
                                "Datos no válidos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Salimos de la función si no hay datos
            }

            CalcularRoundRobin(); // Ahora calcula el Round Robin
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ROUNDROBIN reset = new ROUNDROBIN();
            reset.Show();
        }
    }
}