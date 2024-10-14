namespace AlgoritmosDePlanificacion
{
    partial class PRIORIDAD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridView1 = new DataGridView();
            Procesos = new DataGridViewTextBoxColumn();
            Prioridad1 = new DataGridViewTextBoxColumn();
            RAFAGA = new DataGridViewTextBoxColumn();
            TIEMPODELLEGADA = new DataGridViewTextBoxColumn();
            TIEMPODEFINALIZACION = new DataGridViewTextBoxColumn();
            TIEMPODERETORNO = new DataGridViewTextBoxColumn();
            TIEMPODEESPERA = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Procesos, Prioridad1, RAFAGA, TIEMPODELLEGADA, TIEMPODEFINALIZACION, TIEMPODERETORNO, TIEMPODEESPERA });
            dataGridView1.Location = new Point(200, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(934, 363);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Procesos
            // 
            Procesos.HeaderText = "Procesos";
            Procesos.MinimumWidth = 6;
            Procesos.Name = "Procesos";
            Procesos.Width = 125;
            // 
            // Prioridad1
            // 
            Prioridad1.HeaderText = "Prioridad";
            Prioridad1.MinimumWidth = 6;
            Prioridad1.Name = "Prioridad1";
            Prioridad1.Width = 125;
            // 
            // RAFAGA
            // 
            RAFAGA.HeaderText = "Rafaga CPU";
            RAFAGA.MinimumWidth = 6;
            RAFAGA.Name = "RAFAGA";
            RAFAGA.Width = 125;
            // 
            // TIEMPODELLEGADA
            // 
            TIEMPODELLEGADA.HeaderText = "Tiempo de llegada";
            TIEMPODELLEGADA.MinimumWidth = 6;
            TIEMPODELLEGADA.Name = "TIEMPODELLEGADA";
            TIEMPODELLEGADA.Width = 125;
            // 
            // TIEMPODEFINALIZACION
            // 
            TIEMPODEFINALIZACION.HeaderText = "Tiempo de finalizacion";
            TIEMPODEFINALIZACION.MinimumWidth = 6;
            TIEMPODEFINALIZACION.Name = "TIEMPODEFINALIZACION";
            TIEMPODEFINALIZACION.Width = 125;
            // 
            // TIEMPODERETORNO
            // 
            TIEMPODERETORNO.HeaderText = "Tiempo de retorno ";
            TIEMPODERETORNO.MinimumWidth = 6;
            TIEMPODERETORNO.Name = "TIEMPODERETORNO";
            TIEMPODERETORNO.Width = 125;
            // 
            // TIEMPODEESPERA
            // 
            TIEMPODEESPERA.HeaderText = "Tiempo de espera";
            TIEMPODEESPERA.MinimumWidth = 6;
            TIEMPODEESPERA.Name = "TIEMPODEESPERA";
            TIEMPODEESPERA.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(1200, 145);
            button1.Name = "button1";
            button1.Size = new Size(81, 289);
            button1.TabIndex = 1;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1200, 455);
            button2.Name = "button2";
            button2.Size = new Size(81, 64);
            button2.TabIndex = 2;
            button2.Text = "Limpieza";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(200, 403);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(934, 374);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // PRIORIDAD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 799);
            Controls.Add(chart1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "PRIORIDAD";
            Text = "PRIORIDAD";
            Load += PRIORIDAD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Procesos;
        private DataGridViewTextBoxColumn Prioridad1;
        private DataGridViewTextBoxColumn RAFAGA;
        private DataGridViewTextBoxColumn TIEMPODELLEGADA;
        private DataGridViewTextBoxColumn TIEMPODEFINALIZACION;
        private DataGridViewTextBoxColumn TIEMPODERETORNO;
        private DataGridViewTextBoxColumn TIEMPODEESPERA;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}