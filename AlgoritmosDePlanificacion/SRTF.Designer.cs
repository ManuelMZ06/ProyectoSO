namespace AlgoritmosDePlanificacion
{
    partial class SRTF
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
            label3 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbProcesos = new ListBox();
            lbCPU = new ListBox();
            lbLlegada = new ListBox();
            lbFinalizacion = new ListBox();
            lbRetorno = new ListBox();
            lbEspera = new ListBox();
            txtNoProcesos = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtSumaCPU = new TextBox();
            txtPromRetorno = new TextBox();
            txtPromEspera = new TextBox();
            label4 = new Label();
            label8 = new Label();
            button3 = new Button();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(396, 185);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(344, 24);
            label3.TabIndex = 53;
            label3.Text = "Ingrese el Número de Procesos:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(1083, 316);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(80, 28);
            label11.TabIndex = 52;
            label11.Text = "ESPERA";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(883, 316);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(101, 28);
            label10.TabIndex = 51;
            label10.Text = "RETORNO";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(658, 316);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 28);
            label9.TabIndex = 50;
            label9.Text = "FINALIZACION";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(443, 316);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 28);
            label7.TabIndex = 49;
            label7.Text = "TIEMPO/LLEGADA";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(310, 316);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 48;
            label6.Text = "CPU";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(90, 316);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 47;
            label5.Text = "PROCESOS";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(579, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 58);
            label2.TabIndex = 46;
            label2.Text = "SRTF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(225, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(808, 58);
            label1.TabIndex = 45;
            label1.Text = "SHORTEST REMAINING TIME FIRST";
            // 
            // lbProcesos
            // 
            lbProcesos.Font = new Font("Segoe UI", 11F);
            lbProcesos.FormattingEnabled = true;
            lbProcesos.ItemHeight = 30;
            lbProcesos.Location = new Point(57, 348);
            lbProcesos.Margin = new Padding(4);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(185, 304);
            lbProcesos.TabIndex = 54;
            // 
            // lbCPU
            // 
            lbCPU.Font = new Font("Segoe UI", 11F);
            lbCPU.FormattingEnabled = true;
            lbCPU.ItemHeight = 30;
            lbCPU.Location = new Point(250, 348);
            lbCPU.Margin = new Padding(4);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(185, 304);
            lbCPU.TabIndex = 55;
            // 
            // lbLlegada
            // 
            lbLlegada.Font = new Font("Segoe UI", 11F);
            lbLlegada.FormattingEnabled = true;
            lbLlegada.ItemHeight = 30;
            lbLlegada.Location = new Point(447, 348);
            lbLlegada.Margin = new Padding(4);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(185, 304);
            lbLlegada.TabIndex = 56;
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.Font = new Font("Segoe UI", 11F);
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.ItemHeight = 30;
            lbFinalizacion.Location = new Point(643, 348);
            lbFinalizacion.Margin = new Padding(4);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(185, 304);
            lbFinalizacion.TabIndex = 57;
            // 
            // lbRetorno
            // 
            lbRetorno.Font = new Font("Segoe UI", 11F);
            lbRetorno.FormattingEnabled = true;
            lbRetorno.ItemHeight = 30;
            lbRetorno.Location = new Point(841, 348);
            lbRetorno.Margin = new Padding(4);
            lbRetorno.Name = "lbRetorno";
            lbRetorno.Size = new Size(185, 304);
            lbRetorno.TabIndex = 58;
            // 
            // lbEspera
            // 
            lbEspera.Font = new Font("Segoe UI", 11F);
            lbEspera.FormattingEnabled = true;
            lbEspera.ItemHeight = 30;
            lbEspera.Location = new Point(1035, 348);
            lbEspera.Margin = new Padding(4);
            lbEspera.Name = "lbEspera";
            lbEspera.Size = new Size(185, 304);
            lbEspera.TabIndex = 59;
            // 
            // txtNoProcesos
            // 
            txtNoProcesos.BorderStyle = BorderStyle.FixedSingle;
            txtNoProcesos.Cursor = Cursors.IBeam;
            txtNoProcesos.Font = new Font("Segoe UI", 11F);
            txtNoProcesos.Location = new Point(746, 179);
            txtNoProcesos.Margin = new Padding(4);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(150, 37);
            txtNoProcesos.TabIndex = 60;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.Location = new Point(41, 42);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(133, 39);
            button1.TabIndex = 61;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(590, 236);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 62;
            button2.Text = "ACEPTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.BorderStyle = BorderStyle.FixedSingle;
            txtSumaCPU.Font = new Font("Segoe UI", 11F);
            txtSumaCPU.Location = new Point(250, 666);
            txtSumaCPU.Margin = new Padding(4);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.Size = new Size(185, 37);
            txtSumaCPU.TabIndex = 63;
            // 
            // txtPromRetorno
            // 
            txtPromRetorno.BorderStyle = BorderStyle.FixedSingle;
            txtPromRetorno.Font = new Font("Segoe UI", 11F);
            txtPromRetorno.Location = new Point(841, 661);
            txtPromRetorno.Margin = new Padding(4);
            txtPromRetorno.Name = "txtPromRetorno";
            txtPromRetorno.Size = new Size(185, 37);
            txtPromRetorno.TabIndex = 64;
            // 
            // txtPromEspera
            // 
            txtPromEspera.BorderStyle = BorderStyle.FixedSingle;
            txtPromEspera.Font = new Font("Segoe UI", 11F);
            txtPromEspera.Location = new Point(1035, 661);
            txtPromEspera.Margin = new Padding(4);
            txtPromEspera.Name = "txtPromEspera";
            txtPromEspera.Size = new Size(183, 37);
            txtPromEspera.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(169, 669);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 67;
            label4.Text = "SUMA:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(698, 664);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 28);
            label8.TabIndex = 66;
            label8.Text = "PROMEDIOS:";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(590, 715);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(112, 38);
            button3.TabIndex = 68;
            button3.Text = "LIMPIAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label12.Location = new Point(57, 768);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(169, 28);
            label12.TabIndex = 70;
            label12.Text = "TABLA DE COLAS";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 800);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(772, 236);
            dataGridView1.TabIndex = 72;
            // 
            // SRTF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 1069);
            Controls.Add(dataGridView1);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(txtPromEspera);
            Controls.Add(txtPromRetorno);
            Controls.Add(txtSumaCPU);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNoProcesos);
            Controls.Add(lbEspera);
            Controls.Add(lbRetorno);
            Controls.Add(lbFinalizacion);
            Controls.Add(lbLlegada);
            Controls.Add(lbCPU);
            Controls.Add(lbProcesos);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "SRTF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosing += SRTF_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private ListBox lbProcesos;
        private ListBox lbCPU;
        private ListBox lbLlegada;
        private ListBox lbFinalizacion;
        private ListBox lbRetorno;
        private ListBox lbEspera;
        private TextBox txtNoProcesos;
        private Button button1;
        private Button button2;
        private TextBox txtSumaCPU;
        private TextBox txtPromRetorno;
        private TextBox txtPromEspera;
        private Label label4;
        private Label label8;
        private Button button3;
        private Label label12;
        private DataGridView dataGridView1;
    }
}