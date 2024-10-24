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
        //
        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si hay datos en el DataGridView
            if (dataGridView1.Rows.Count == 0 ||
                dataGridView1.Rows.Cast<DataGridViewRow>().All(row => row.IsNewRow))
            {
                MessageBox.Show("No hay datos para calcular.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Salir del método si no hay datos
            }

            CalcularAlgoritmoPrioridad();
            //
        }
        //
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRIORIDAD reset = new PRIORIDAD();
            reset.Show();
        }
        //
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

            // Llamar la función para dibujar la gráfica
            DibujarGrafica();

            MessageBox.Show("Cálculos realizados correctamente.", "Éxito");
        }
        private void DibujarGrafica()
        {
            // Limpiar el panel
            panelGrafico.Invalidate();
            panelGrafico.Update();

            using (Graphics g = panelGrafico.CreateGraphics())
            {
                int anchoBarra = 40;
                int alturaBarra = 30;
                int offsetY = 50;
                int espacioEntreFilas = 30;
                Color[] colores = { Color.Green, Color.Gray, Color.Purple, Color.Orange, Color.Blue };

                // Obtener los procesos desde el DataGridView
                var procesos = dataGridView1.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow && row.Cells["RAFAGA"].Value != null && row.Cells["TIEMPODEFINALIZACION"].Value != null)
                    .Select((row, i) => new
                    {
                        Proceso = "P" + (i + 1),
                        RafagaCPU = int.Parse(row.Cells["RAFAGA"].Value.ToString()),
                        TiempoFinalizacion = int.Parse(row.Cells["TIEMPODEFINALIZACION"].Value.ToString()),
                        Color = colores[i % colores.Length]
                    }).ToList();

                // Dibujar etiquetas de tiempo
                int tiempoTotal = procesos.Max(p => p.TiempoFinalizacion);
                for (int i = 0; i <= tiempoTotal; i++)
                {
                    g.DrawString(i.ToString(), new Font("Arial", 8), Brushes.Black, i * anchoBarra, offsetY - 30);
                }

                // Dibujar las barras de los procesos
                for (int i = 0; i < procesos.Count; i++)
                {
                    int tiempoInicio = procesos[i].TiempoFinalizacion - procesos[i].RafagaCPU;
                    Rectangle rect = new Rectangle(tiempoInicio * anchoBarra, offsetY + (i * espacioEntreFilas), procesos[i].RafagaCPU * anchoBarra, alturaBarra);
                    g.FillRectangle(new SolidBrush(procesos[i].Color), rect);
                    g.DrawRectangle(Pens.Black, rect);

                    // Dibujar el nombre del proceso
                    g.DrawString(procesos[i].Proceso, new Font("Arial", 10), Brushes.Black, tiempoInicio * anchoBarra - 40, offsetY + (i * espacioEntreFilas));

                    // ** Inicio de la sección añadida para dibujar líneas en medio de cada proceso **
                    for (int j = tiempoInicio; j < procesos[i].TiempoFinalizacion; j++)
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


        private void PRIORIDAD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Regresar al submenú
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
            //
        }
    }
}
