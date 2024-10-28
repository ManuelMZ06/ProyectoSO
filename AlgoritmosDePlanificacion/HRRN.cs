using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AlgoritmosDePlanificacion
{
    public partial class HRRN : Form
    {
        public HRRN()
        {
            InitializeComponent();
        }

        // Variables globales
        int dato;
        string nombre;
        int[] CPU;
        int[] llegada;
        int[] finalizacion; // Para almacenar los tiempos de finalización
        double[] respuesta; // Para almacenar el Ratio de Respuesta

        int tiempoActual = 0; // Para rastrear el tiempo actual
        bool[] ejecutado; // Para llevar un seguimiento de los procesos ejecutados
        List<string> nombresProcesos; // Para almacenar los nombres de los procesos en orden de llegada

        public void AceptarDatosHRRN()
        {
            try
            {
                dato = int.Parse(txtNoProceso.Text); // TextBox para el número de procesos
                CPU = new int[dato];
                llegada = new int[dato];
                ejecutado = new bool[dato]; // Inicializar el array de ejecutados
                finalizacion = new int[dato]; // Inicializar el array de finalización
                nombresProcesos = new List<string>(); // Inicializar la lista de nombres de procesos
                //
                for (int i = 0; i < dato; i++)
                {
                    int proceso = i + 1;

                    // Pedir el nombre del proceso
                    nombre = Interaction.InputBox("Ingrese el nombre del Proceso " + proceso);
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        lbProcesos.Items.Add(nombre); // Añadir a la lista visual
                        nombresProcesos.Add(nombre); // Almacenar nombre del proceso
                    }

                    // Pedir la ráfaga de CPU
                    CPU[i] = int.Parse(Interaction.InputBox("Ingrese la ráfaga de CPU del Proceso " + proceso));
                    lblCPU.Items.Add(CPU[i]);

                    // Pedir el tiempo de llegada
                    llegada[i] = int.Parse(Interaction.InputBox("Ingrese el Tiempo de Llegada del Proceso " + proceso));
                    lblLlegada.Items.Add(llegada[i]);
                }

                // Ejecutar el primer proceso
                EjecutarPrimerProceso();

                //Ejecutar el tiempo de retorno
                CalcularTiempoRetorno();

                //Ejecutar el tiempo de Espera
                CalcularTiempoEspera();

                //Ejecutar la penalizacion
                CalcularPenalizacion();

                //Ejecutar la suma y los promedios
                CalcularPromedios();
                //Ejecutar grafica
                DibujarGrafica();
            }
            catch
            {
                // En caso de error, limpiar y mostrar mensaje
                txtNoProceso.Text = "";
                MessageBox.Show("Ingrese un dato válido", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                HRRN reset = new HRRN();
                reset.Show();
            }
        }

        private void EjecutarPrimerProceso()
        {
            // Ejecutar el primer proceso
            if (dato > 0 && !ejecutado[0])
            {
                tiempoActual += CPU[0]; // Suponemos que el primer proceso se ejecuta desde 0
                finalizacion[0] = tiempoActual; // Guardar el tiempo de finalización
                lbFinalizacion.Items.Add($"{nombresProcesos[0]} - {finalizacion[0]}"); // Agregar el tiempo de finalización
                ejecutado[0] = true; // Marcar el primer proceso como ejecutado
                OrdenarPorLlegada(); // Llamar a la nueva función para respetar el orden de llegada
            }
        }

        private void CalcularTiempoRetorno()
        {
            for (int i = 0; i < dato; i++)
            {
                int tiempoRetorno = finalizacion[i] - llegada[i]; // Restar el tiempo de finalización con el tiempo de llegada
                lbRetorno.Items.Add(tiempoRetorno); // Mostrar el tiempo de retorno en el ListBox
            }
        }

        private void CalcularTiempoEspera()
        {
            // Creamos un array para almacenar los tiempos de espera
            int[] tiempoEspera = new int[dato];

            for (int i = 0; i < dato; i++)
            {
                // Calculamos el tiempo de espera para cada proceso
                tiempoEspera[i] = (finalizacion[i] - llegada[i]) - CPU[i];

                // Mostramos el tiempo de espera en la lista visual correspondiente
                lblEspera.Items.Add($"{tiempoEspera[i]}");
            }
        }

        private void CalcularPenalizacion()
        {
            for (int i = 0; i < dato; i++)
            {
                // Calcular el tiempo de retorno como finalización - llegada
                int tiempoRetorno = finalizacion[i] - llegada[i];

                // Calcular penalización como tiempo de retorno dividido entre tiempo de CPU
                double penalizacion = tiempoRetorno / (double)CPU[i];

                // Mostrar penalización en lblPenalizacion
                lblPenalizacion.Items.Add(penalizacion.ToString("F2"));
            }
        }

        private void CalcularPromedios()
        {
            double sumaRetorno = 0;
            double sumaEspera = 0;
            double sumaPenalizacion = 0;
            int cantidadProcesos = 0;
            int sumaCPU = 0; // Variable para la suma de CPU

            for (int i = 0; i < dato; i++)
            {
                if (ejecutado[i]) // Solo sumar si el proceso ha sido ejecutado
                {
                    int tiempoRetorno = finalizacion[i] - llegada[i];
                    sumaRetorno += tiempoRetorno; // Calcular el tiempo de retorno
                    sumaEspera += tiempoRetorno - CPU[i]; // Calcular el tiempo de espera

                    // Calcular la penalización nuevamente para obtener la suma total
                    sumaPenalizacion += tiempoRetorno / (double)CPU[i];
                    sumaCPU += CPU[i]; // Sumar las ráfagas de CPU
                    cantidadProcesos++;
                }
            }

            // Calcular promedios
            double promedioRetorno = sumaRetorno / cantidadProcesos;
            double promedioEspera = sumaEspera / cantidadProcesos;
            double promedioPenalizacion = sumaPenalizacion / cantidadProcesos;

            // Mostrar resultados en la interfaz
            lblPromedioRetorno.Text = promedioRetorno.ToString("F2");
            lblPromedioEspera.Text = promedioEspera.ToString("F2");
            lblPromedioPenalizacion.Text = promedioPenalizacion.ToString("F2");
            lblSumaCPU.Text = sumaCPU.ToString(); // Mostrar suma total de CPU
        }




        private void EjecutarProceso(int index)
        {
            // Ejecutar el proceso encontrado
            if (!ejecutado[index])
            {
                tiempoActual += CPU[index]; // Sumar el tiempo de CPU del proceso actual al tiempo actual
                finalizacion[index] = tiempoActual; // Guardar el tiempo de finalización
                lbFinalizacion.Items.Add($"{nombresProcesos[index]} - {finalizacion[index]}"); // Mostrar el tiempo de finalización en la lista
                ejecutado[index] = true; // Marcar el proceso como ejecutado

                // Llamar a funcion1 para gestionar el siguiente proceso
                funcion1();
            }
        }

        private void DibujarGrafica()
        {
            // Limpiar el panel
            panelGrafico.Invalidate();
            panelGrafico.Update();
            //
            using (Graphics g = panelGrafico.CreateGraphics())
            {
                int anchoBarra = 40;  // Ancho de cada barra
                int alturaBarra = 30; // Altura de cada barra
                int offsetY = 50;     // Offset inicial en Y
                int espacioEntreFilas = 30; // Espacio entre filas
                //
                Color[] colores = { Color.Green, Color.Gray, Color.Purple, Color.Orange, Color.Blue };

                // Lista de procesos usando "P" y nombre del proceso
                var procesos = CPU.Select((rafaga, i) => new
                {
                    Proceso = "P" + (i + 1) + " - " + nombresProcesos[i], // "P" más el nombre del proceso
                    RafagaCPU = rafaga, // Ráfaga de CPU
                    TiempoInicio = finalizacion[i] - rafaga, // Tiempo de inicio
                    TiempoFinalizacion = finalizacion[i], // Tiempo de finalización
                    Color = colores[i % colores.Length] // Color para el proceso
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
                    Rectangle rect = new Rectangle(
                        procesos[i].TiempoInicio * anchoBarra,
                        offsetY + (i * espacioEntreFilas),
                        procesos[i].RafagaCPU * anchoBarra,
                        alturaBarra
                    );

                    // Dibujar la barra
                    g.FillRectangle(new SolidBrush(procesos[i].Color), rect);
                    g.DrawRectangle(Pens.Black, rect); // Dibujar el borde

                    // Dibujar el nombre del proceso (P + nombre)
                    g.DrawString(procesos[i].Proceso, new Font("Arial", 10), Brushes.Black,
                        procesos[i].TiempoInicio * anchoBarra - 40, offsetY + (i * espacioEntreFilas));

                    // ** Inicio de la sección añadida para dibujar líneas en medio de cada proceso **
                    for (int j = procesos[i].TiempoInicio; j < procesos[i].TiempoFinalizacion; j++)
                    {
                        int lineaX = j * anchoBarra;
                        g.DrawLine(Pens.Red, lineaX, offsetY + (i * espacioEntreFilas), lineaX, offsetY + (i * espacioEntreFilas) + alturaBarra);
                    }
                    // ** Fin de la sección añadida **

                }
                //
            }
            //
        }

        //
        private void funcion1()
        {
            List<int> procesosDisponibles = new List<int>();

            for (int i = 0; i < dato; i++) // Comienza desde el primer proceso
            {
                if (!ejecutado[i] && llegada[i] <= tiempoActual) // Verificar si el proceso no ha sido ejecutado y el tiempo de llegada es menor o igual que el tiempo actual
                {
                    procesosDisponibles.Add(i); // Agregar índice del proceso disponible
                }
            }

            if (procesosDisponibles.Count > 0) // Si hay procesos disponibles
            {
                // Calcular el Ratio de Respuesta para cada proceso disponible
                double maxPenalizacion = -1;
                int procesoSeleccionado = -1;

                foreach (int index in procesosDisponibles)
                {
                    double tiempoEspera = tiempoActual - llegada[index];
                    double penalizacion = (tiempoEspera + CPU[index]) / (double)CPU[index];

                    if (penalizacion > maxPenalizacion)
                    {
                        maxPenalizacion = penalizacion;
                        procesoSeleccionado = index;
                    }
                }

                // Ejecutar el proceso seleccionado
                if (procesoSeleccionado != -1)
                {
                    EjecutarProceso(procesoSeleccionado);
                }
            }
            else
            {

            }
        }


        private void OrdenarPorLlegada()
        {
            List<int> procesosOrdenados = new List<int>();

            for (int i = 0; i < dato; i++) // Comienza desde el primer proceso
            {
                if (!ejecutado[i]) // Verifica si el proceso no ha sido ejecutado
                {
                    procesosOrdenados.Add(i); // Añade el índice de los procesos en el orden de ingreso
                }
            }

            if (procesosOrdenados.Count > 0) // Si hay procesos que aún no se han ejecutado
            {
                foreach (int index in procesosOrdenados)
                {
                    EjecutarProceso(index); // Ejecuta cada proceso según el orden de ingreso
                }
            }
            //
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            // Regresar al sub Menú
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si el campo txtNoProceso está vacío
            if (string.IsNullOrWhiteSpace(txtNoProceso.Text))
            {
                MessageBox.Show("El campo para el número de procesos no puede estar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si el campo está vacío
            }

            // Si no está vacío, continuar con la ejecución normal
            AceptarDatosHRRN();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HRRN reset = new HRRN();
            reset.Show();
        }

        private void HRRN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}
