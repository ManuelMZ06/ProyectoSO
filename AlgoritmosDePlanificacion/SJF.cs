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
    public partial class SJF : Form
    {
        public SJF()
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
                EvaluarProcesosSJN(dato);


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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EvaluarProcesosSJN(int dato)
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


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar al sub Menú
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void SJF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AceptarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            SJF reset = new SJF();
            reset.Show();
        }
    }
}
