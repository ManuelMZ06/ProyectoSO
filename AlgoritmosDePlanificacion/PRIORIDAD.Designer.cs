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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Procesos, Prioridad1, RAFAGA, TIEMPODELLEGADA, TIEMPODEFINALIZACION, TIEMPODERETORNO, TIEMPODEESPERA });
            dataGridView1.Location = new Point(156, 105);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(929, 296);
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
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.Location = new Point(497, 432);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 1;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(651, 432);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 2;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(156, 594);
            chart1.Margin = new Padding(4);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(929, 271);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(41, 42);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(133, 39);
            button3.TabIndex = 4;
            button3.Text = "REGRESAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(427, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(398, 58);
            label1.TabIndex = 31;
            label1.Text = "POR PRIORIDAD";
            // 
            // button4
            // 
            button4.Location = new Point(572, 488);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(55, 49);
            button4.TabIndex = 32;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(635, 488);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(55, 49);
            button5.TabIndex = 33;
            button5.Text = "!";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // PRIORIDAD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 906);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(chart1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "PRIORIDAD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRIORIDAD";
            FormClosing += PRIORIDAD_FormClosing;
            Load += PRIORIDAD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}