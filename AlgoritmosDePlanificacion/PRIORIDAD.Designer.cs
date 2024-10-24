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
            button3 = new Button();
            label1 = new Label();
            panelGrafico = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Procesos, Prioridad1, RAFAGA, TIEMPODELLEGADA, TIEMPODEFINALIZACION, TIEMPODERETORNO, TIEMPODEESPERA });
            dataGridView1.Location = new Point(33, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 237);
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
            button1.Location = new Point(317, 88);
            button1.Name = "button1";
            button1.Size = new Size(197, 30);
            button1.TabIndex = 1;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(520, 88);
            button2.Name = "button2";
            button2.Size = new Size(199, 30);
            button2.TabIndex = 2;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(33, 34);
            button3.Name = "button3";
            button3.Size = new Size(106, 31);
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
            label1.Location = new Point(342, 26);
            label1.Name = "label1";
            label1.Size = new Size(337, 48);
            label1.TabIndex = 31;
            label1.Text = "POR PRIORIDAD";
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(33, 367);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(927, 268);
            panelGrafico.TabIndex = 32;
            // 
            // PRIORIDAD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 660);
            Controls.Add(panelGrafico);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "PRIORIDAD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRIORIDAD";
            FormClosing += PRIORIDAD_FormClosing;
            Load += PRIORIDAD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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

        private Button button3;
        private Label label1;
        private Panel panelGrafico;
    }
}