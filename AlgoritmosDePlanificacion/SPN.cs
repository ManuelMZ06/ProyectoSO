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
using Microsoft.VisualBasic; // Asegúrate de tener esta referencia para Interaction.InputBox


namespace AlgoritmosDePlanificacion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int[] CPU; // Ráfaga de CPU
        int[] llegada; // Tiempo de llegada
        int[] finalizacion; // Tiempo de finalización
        bool[] procesado; // Para marcar los procesos que ya se han procesado
        int tiempoActual = 0; // Controla el tiempo actual en la simulación uwu
        int sumaCPU = 0;
        double retorno = 0;
        double espera = 0;

        // Variables adicionales
        int[] ordenOriginal; // Guardará el orden en que los procesos fueron ingresados

        private void AceptarDatos()
        {
            try
            {
                int dato = int.Parse(txtNoProcesos.Text); // Número de procesos
                CPU = new int[dato];
                llegada = new int[dato];
                finalizacion = new int[dato];
                procesado = new bool[dato]; // Inicializa todos los procesos como no procesados
                ordenOriginal = new int[dato]; // Guarda el orden original

                // Solicitar los datos de cada proceso
                for (int i = 0; i < dato; i++)
                {
                    int proceso = i + 1;

                    // Solicitar el nombre del proceso
                    string nombre = Interaction.InputBox("Ingrese el nombre del Proceso " + proceso);
                    lbProcesos.Items.Add(nombre);

                    // Solicitar la ráfaga de CPU
                    CPU[i] = int.Parse(Interaction.InputBox("Ingrese la ráfaga de CPU del Proceso " + proceso));
                    lbCPU.Items.Add(CPU[i]);

                    // Solicitar el tiempo de llegada
                    llegada[i] = int.Parse(Interaction.InputBox("Ingrese el Tiempo de Llegada del Proceso " + proceso));
                    lbLlegada.Items.Add(llegada[i]);

                    procesado[i] = false; // Marca el proceso como no procesado
                    ordenOriginal[i] = i; // Guarda el índice original del proceso
                }

                // Llamada a la función para evaluar los procesos con SPN y calcular tiempos
                EvaluarProcesosSPN(dato);
                LlenarListasFinal(dato); // Llenar los ListBox con el orden original

                DibujarGrafica(); // Llamar al método para dibujar la gráfica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Método para limpiar todos los controles
        private void LimpiarTodo()
        {
            // Limpiar los ListBox
            lbProcesos.Items.Clear();
            lbCPU.Items.Clear();
            lbLlegada.Items.Clear();
            lbFinalizacion.Items.Clear();
            lbRetorno.Items.Clear();
            lbEspera.Items.Clear();

            // Limpiar los TextBox
            txtNoProcesos.Clear();
            txtSumaCPU.Clear();
            txtPromRetorno.Clear();
            txtPromEspera.Clear();

            // Restablecer las variables
            CPU = null;
            llegada = null;
            finalizacion = null;
            procesado = null;
            tiempoActual = 0;
            sumaCPU = 0;
            retorno = 0;
            espera = 0;

            // Limpiar el panel gráfico
            panelGrafico.Invalidate();
            panelGrafico.Update();
        }

        // Asignar el método LimpiarTodo al evento Click del botón "Limpiar"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 reset = new Form3();
            reset.Show();
        }

        // Modificar esta función para llenar las listas con el orden original después de calcular
        private void LlenarListasFinal(int dato)
        {
            lbFinalizacion.Items.Clear();
            lbRetorno.Items.Clear();
            lbEspera.Items.Clear();

            // Llena las listas según el orden original de los procesos
            for (int i = 0; i < dato; i++)
            {
                int originalIndex = ordenOriginal[i];
                lbFinalizacion.Items.Add(finalizacion[originalIndex]);

                double Retorno = finalizacion[originalIndex] - llegada[originalIndex];
                lbRetorno.Items.Add(Retorno);

                double Espera = Retorno - CPU[originalIndex];
                lbEspera.Items.Add(Espera);
            }
        }

        // Función que implementa el proceso SPN (Evaluar los tiempos de CPU más cortos)
        private void EvaluarProcesosSPN(int dato)
        {
            int procesosCompletados = 0;

            while (procesosCompletados < dato)
            {
                // Encontrar el proceso con la menor ráfaga de CPU y que pueda ejecutarse
                int indice = EncontrarMenorRafaga(CPU, procesado, tiempoActual);

                // Si se encuentra un proceso disponible
                if (indice != -1)
                {
                    // Calcular tiempo de finalización
                    tiempoActual += CPU[indice]; // Actualiza el tiempo actual
                    finalizacion[indice] = tiempoActual;

                    // Calcular tiempo de retorno
                    double Retorno = finalizacion[indice] - llegada[indice];
                    retorno += Retorno;

                    // Calcular tiempo de espera
                    double Espera = Retorno - CPU[indice];
                    espera += Espera;


                    // Sumar la ráfaga de CPU del proceso
                    sumaCPU += CPU[indice];

                    // Marcar el proceso como procesado
                    procesado[indice] = true;
                    procesosCompletados++;
                }
                else
                {
                    tiempoActual++; // Incrementar el tiempo si ningún proceso está disponible
                }
            }

            // Mostrar resultados finales en los TextBox
            txtSumaCPU.Text = sumaCPU.ToString();
            double PromRetorno = retorno / dato;
            txtPromRetorno.Text = Math.Round(PromRetorno, 2).ToString();
            double PromEspera = espera / dato;
            txtPromEspera.Text = Math.Round(PromEspera, 2).ToString();
        }


        private void DibujarGrafica()
        {
            // Limpiar el panel
            panelGrafico.Invalidate();
            panelGrafico.Update();

            // Obtener el objeto Graphics del panel
            using (Graphics g = panelGrafico.CreateGraphics())
            {
                // Variables para la posición inicial en el eje X
                int anchoBarra = 40; // Ancho de cada barra
                int alturaBarra = 30; // Altura de cada barra
                int offsetY = 50; // Offset Y para el primer proceso
                int tiempoInicio = 0; // Variable para manejar el tiempo de inicio de cada proceso

                // Colores para cada proceso
                Color[] colores = { Color.Green, Color.Gray, Color.Purple, Color.Orange, Color.Blue };

                for (int i = 0; i < CPU.Length; i++)
                {
                    // Calcular el tiempo de inicio del proceso
                    tiempoInicio = finalizacion[i] - CPU[i];

                    // Definir el rectángulo para la barra
                    Rectangle rect = new Rectangle(tiempoInicio * anchoBarra, offsetY, CPU[i] * anchoBarra, alturaBarra);

                    // Elegir el color para la barra
                    g.FillRectangle(new SolidBrush(colores[i % colores.Length]), rect);

                    // Dibujar el borde de la barra
                    g.DrawRectangle(Pens.Black, rect);

                    // Etiqueta para el proceso
                    g.DrawString(lbProcesos.Items[i].ToString(), new Font("Arial", 10), Brushes.Black,
                                 tiempoInicio * anchoBarra, offsetY - 20);
                }

                // Etiquetas de tiempo en el eje X
                for (int i = 0; i <= tiempoActual; i++)
                {
                    g.DrawString(i.ToString(), new Font("Arial", 8), Brushes.Black, i * anchoBarra, offsetY + alturaBarra + 5);
                }
            }
        }


        // Función para encontrar el índice del proceso con la menor ráfaga de CPU
        private int EncontrarMenorRafaga(int[] cpu, bool[] procesado, int tiempoActual)
        {
            int indiceMenor = -1;
            int menorRafaga = int.MaxValue;

            for (int i = 0; i < cpu.Length; i++)
            {
                // Si el proceso no ha sido procesado y ha llegado antes o durante el tiempo actual
                if (!procesado[i] && llegada[i] <= tiempoActual && cpu[i] < menorRafaga)
                {
                    menorRafaga = cpu[i];
                    indiceMenor = i;
                }
            }

            return indiceMenor; // Retorna el índice del proceso con la menor ráfaga de CPU
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Regresar al submenú
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AceptarDatos(); // Llamada a la función para procesar los datos
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 reset = new Form3();
            reset.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }

}
