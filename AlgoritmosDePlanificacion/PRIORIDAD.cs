using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AlgoritmosDePlanificacion
{
    public partial class PRIORIDAD : Form
    {
        public PRIORIDAD()
        {
            InitializeComponent();
        }

        private void PRIORIDAD_Load(object sender, EventArgs e)
        {
            // Bloquear columnas específicas
            dataGridView1.Columns["TIEMPODEFINALIZACION"].ReadOnly = true; // Tiempo de finalización
            dataGridView1.Columns["TIEMPODERETORNO"].ReadOnly = true; // Tiempo de retorno
            dataGridView1.Columns["TIEMPODEESPERA"].ReadOnly = true; // Tiempo de espera
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProcesos_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se presionó la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar que la tecla Enter haga el salto a la siguiente celda
                e.Handled = true;

                // Obtener la posición de la celda seleccionada actualmente
                int currentColumn = dataGridView1.CurrentCell.ColumnIndex;
                int currentRow = dataGridView1.CurrentCell.RowIndex;

                // Verificar si estamos en la última columna de la última fila existente
                if (currentColumn == dataGridView1.Columns.Count - 1 && currentRow == dataGridView1.Rows.Count - 1)
                {
                    // Agregar una nueva fila
                    dataGridView1.Rows.Add();

                    // Mover el foco a la primera celda de la nueva fila
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentRow + 1].Cells[0];
                }
                else
                {
                    // Si no estamos en la última columna, mover el foco a la siguiente celda
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[currentColumn + 1];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si el DataGridView está vacío
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("El DataGrid está vacío. Por favor, agrega procesos antes de calcular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si está vacío
            }

            CalcularAlgoritmoPrioridad();
            DibujarGrafico();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRIORIDAD reset = new PRIORIDAD();
            reset.Show();
        }


        private void CalcularAlgoritmoPrioridad()
        {
            int tiempoActual = 0; // Inicializar el tiempo actual en 0

            // Filtrar solo las filas con datos
            var procesos = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow &&
                              row.Cells["Prioridad1"].Value != null &&
                              row.Cells["RAFAGA"].Value != null &&
                              row.Cells["TIEMPODELLEGADA"].Value != null)
                .Select(row => new
                {
                    Prioridad = int.Parse(row.Cells["Prioridad1"].Value.ToString()),
                    RafagaCPU = int.Parse(row.Cells["RAFAGA"].Value.ToString()),
                    TiempoLlegada = int.Parse(row.Cells["TIEMPODELLEGADA"].Value.ToString()),
                    Row = row // Mantener referencia a la fila original
                })
                .OrderBy(p => p.TiempoLlegada) // Primero ordenar por tiempo de llegada
                .ThenBy(p => p.Prioridad) // Luego por prioridad
                .ToList();

            while (procesos.Count > 0)
            {
                // Filtrar procesos que han llegado y están listos para ser ejecutados
                var procesosListos = procesos.Where(p => p.TiempoLlegada <= tiempoActual).ToList();

                if (procesosListos.Count > 0)
                {
                    // Ordenar procesos listos por prioridad (menor valor de prioridad es mayor prioridad)
                    var procesoActual = procesosListos.OrderBy(p => p.Prioridad).ThenBy(p => p.TiempoLlegada).First();

                    // Si el tiempo actual es menor que el tiempo de llegada del proceso,
                    // el sistema debe esperar hasta que llegue el proceso
                    if (tiempoActual < procesoActual.TiempoLlegada)
                    {
                        tiempoActual = procesoActual.TiempoLlegada; // Ajustar el tiempo actual
                    }

                    // Calcular el tiempo de finalización: tiempo actual más la ráfaga de CPU
                    int tiempoFinalizacion = tiempoActual + procesoActual.RafagaCPU;

                    // Calcular el tiempo de retorno: tiempo de finalización menos tiempo de llegada
                    int tiempoRetorno = tiempoFinalizacion - procesoActual.TiempoLlegada;

                    // Calcular el tiempo de espera: tiempo de retorno menos la ráfaga de CPU
                    int tiempoEspera = tiempoRetorno - procesoActual.RafagaCPU;

                    // Actualizar los valores en la fila correspondiente
                    procesoActual.Row.Cells["TIEMPODEFINALIZACION"].Value = tiempoFinalizacion;
                    procesoActual.Row.Cells["TIEMPODERETORNO"].Value = tiempoRetorno;
                    procesoActual.Row.Cells["TIEMPODEESPERA"].Value = tiempoEspera;

                    // Actualizar el tiempo actual para el siguiente proceso
                    tiempoActual = tiempoFinalizacion;

                    // Eliminar el proceso que ya ha sido ejecutado
                    procesos.Remove(procesoActual);
                }
                else
                {
                    // Si no hay procesos listos, avanzar el tiempo al siguiente tiempo de llegada
                    tiempoActual = procesos.Min(p => p.TiempoLlegada);
                }
            }

            MessageBox.Show("Cálculos realizados correctamente.", "Éxito");
        }

        private void LimpiarDataGridView()
        {
            // Limpiar todas las filas del DataGridView
            dataGridView1.Rows.Clear();

            // (Opcional) Puedes también reiniciar cualquier otro estado que desees, como el tiempo actual
            // tiempoActual = 0; // Si tienes una variable para el tiempo actual, reiníciala aquí

            MessageBox.Show("Datos limpiados correctamente.", "Éxito");
        }

        private void DibujarGrafico()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Crear y configurar un nuevo área de gráfico
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Inicializar el tiempo actual
            int tiempoActual = 0;
            List<int> tiemposInicio = new List<int>();
            List<int> tiemposFin = new List<int>();

            // Filtrar y ordenar los procesos
            var procesos = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow &&
                              row.Cells["Prioridad1"].Value != null &&
                              row.Cells["RAFAGA"].Value != null &&
                              row.Cells["TIEMPODELLEGADA"].Value != null)
                .Select(row => new
                {
                    Prioridad = int.Parse(row.Cells["Prioridad1"].Value.ToString()),
                    RafagaCPU = int.Parse(row.Cells["RAFAGA"].Value.ToString()),
                    TiempoLlegada = int.Parse(row.Cells["TIEMPODELLEGADA"].Value.ToString()),
                    Row = row
                })
                .OrderBy(p => p.TiempoLlegada)
                .ThenBy(p => p.Prioridad)
                .ToList();

            // Asegurarse de que hay procesos para graficar
            if (!procesos.Any())
            {
                MessageBox.Show("No hay procesos para graficar.");
                return;
            }

            // Procesar cada proceso para calcular tiempos de inicio y fin
            foreach (var proceso in procesos)
            {
                // Si el tiempo actual es menor que el tiempo de llegada del proceso,
                // el sistema debe esperar hasta que llegue el proceso
                if (tiempoActual < proceso.TiempoLlegada)
                {
                    tiempoActual = proceso.TiempoLlegada; // Ajustar el tiempo actual
                }

                // Agregar tiempos de inicio y fin a las listas
                tiemposInicio.Add(tiempoActual);
                tiemposFin.Add(tiempoActual + proceso.RafagaCPU);

                // Actualizar el tiempo actual para el siguiente proceso
                tiempoActual += proceso.RafagaCPU;
            }

            // Crear una nueva serie de tipo Bar (horizontal)
            Series series = new Series
            {
                Name = "Ráfagas CPU",
                Color = Color.Blue,
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.RangeBar // Usar RangeBar para mostrar tiempos de inicio y fin
            };

            // Agregar datos a la serie para el gráfico de Gantt
            for (int i = 0; i < procesos.Count; i++)
            {
                // Longitud de la barra
                int longitudBarra = tiemposFin[i] - tiemposInicio[i];

                // Agregar el tiempo de inicio y longitud de la barra
                series.Points.AddXY(tiemposInicio[i], longitudBarra); // Solo X (tiempo de inicio) y Y (longitud de la barra)
            }

            // Agregar la serie al gráfico
            chart1.Series.Add(series);

            // Configurar los valores de los ejes
            chart1.ChartAreas[0].AxisX.Minimum = 0; // Ajustar el mínimo del eje X
            chart1.ChartAreas[0].AxisX.Maximum = tiemposFin.Last(); // Máximo del eje X al tiempo final del último proceso

            // Configuración adicional para el eje Y
            chart1.ChartAreas[0].AxisY.Title = "Procesos";
            chart1.ChartAreas[0].AxisX.Title = "Tiempo";

            // Opcional: Mostrar un mensaje si se graficaron correctamente
            MessageBox.Show("Gráfico generado con éxito.");
        }




        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Regresar al sub Menú
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de mensaje con "Hola"
            MessageBox.Show("Es un algoritmo de planificación de procesos en el que se asigna una prioridad a cada proceso. Los procesos con mayor prioridad son ejecutados antes que los de menor prioridad. Si dos o más procesos tienen la misma prioridad, se pueden manejar de acuerdo a otros criterios, como el tiempo de llegada. Este enfoque ayuda a asegurar que los procesos críticos se completen antes que los menos importantes, optimizando así el uso de recursos y mejorando el rendimiento del sistema.", "Proceso de Prioridad");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de mensaje con "Hola"
            MessageBox.Show("La planificación por prioridades ejecuta procesos según su nivel de prioridad, dando preferencia a los más críticos. Si llega un proceso de mayor prioridad, puede interrumpir el actual, lo que puede causar problemas como starvation para los de baja prioridad.", "Proceso de Planificación por Prioridades");

        }

        private void PRIORIDAD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}
