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
            label3.Location = new Point(885, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(300, 22);
            label3.TabIndex = 53;
            label3.Text = "Ingrese el Número de Procesos:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(923, 259);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 23);
            label11.TabIndex = 52;
            label11.Text = "ESPERA";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(763, 259);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 51;
            label10.Text = "RETORNO";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(583, 259);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 23);
            label9.TabIndex = 50;
            label9.Text = "FINALIZACION";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(411, 259);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 23);
            label7.TabIndex = 49;
            label7.Text = "TIEMPO/LLEGADA";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(305, 259);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 23);
            label6.TabIndex = 48;
            label6.Text = "CPU";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(129, 259);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 47;
            label5.Text = "PROCESOS";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(435, 154);
            label2.Name = "label2";
            label2.Size = new Size(117, 48);
            label2.TabIndex = 46;
            label2.Text = "SRTF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(158, 83);
            label1.Name = "label1";
            label1.Size = new Size(680, 48);
            label1.TabIndex = 45;
            label1.Text = "SHORTEST REMAINING TIME FIRST";
            // 
            // lbProcesos
            // 
            lbProcesos.FormattingEnabled = true;
            lbProcesos.Location = new Point(102, 285);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(149, 244);
            lbProcesos.TabIndex = 54;
            // 
            // lbCPU
            // 
            lbCPU.FormattingEnabled = true;
            lbCPU.Location = new Point(257, 285);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(149, 244);
            lbCPU.TabIndex = 55;
            // 
            // lbLlegada
            // 
            lbLlegada.FormattingEnabled = true;
            lbLlegada.Location = new Point(414, 285);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(149, 244);
            lbLlegada.TabIndex = 56;
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.Location = new Point(571, 285);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(149, 244);
            lbFinalizacion.TabIndex = 57;
            // 
            // lbRetorno
            // 
            lbRetorno.FormattingEnabled = true;
            lbRetorno.Location = new Point(730, 285);
            lbRetorno.Name = "lbRetorno";
            lbRetorno.Size = new Size(149, 244);
            lbRetorno.TabIndex = 58;
            // 
            // lbEspera
            // 
            lbEspera.FormattingEnabled = true;
            lbEspera.Location = new Point(885, 285);
            lbEspera.Name = "lbEspera";
            lbEspera.Size = new Size(149, 244);
            lbEspera.TabIndex = 59;
            // 
            // txtNoProcesos
            // 
            txtNoProcesos.Location = new Point(885, 119);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(300, 27);
            txtNoProcesos.TabIndex = 60;
            // 
            // button1
            // 
            button1.Location = new Point(30, 24);
            button1.Name = "button1";
            button1.Size = new Size(113, 52);
            button1.TabIndex = 61;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(885, 154);
            button2.Name = "button2";
            button2.Size = new Size(300, 29);
            button2.TabIndex = 62;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.Location = new Point(257, 539);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.Size = new Size(149, 27);
            txtSumaCPU.TabIndex = 63;
            // 
            // txtPromRetorno
            // 
            txtPromRetorno.Location = new Point(730, 535);
            txtPromRetorno.Name = "txtPromRetorno";
            txtPromRetorno.Size = new Size(149, 27);
            txtPromRetorno.TabIndex = 64;
            // 
            // txtPromEspera
            // 
            txtPromEspera.Location = new Point(885, 535);
            txtPromEspera.Name = "txtPromEspera";
            txtPromEspera.Size = new Size(147, 27);
            txtPromEspera.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(149, 543);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 67;
            label4.Text = "SUMA:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(583, 539);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 23);
            label8.TabIndex = 66;
            label8.Text = "PROMEDIOS:";
            // 
            // button3
            // 
            button3.Location = new Point(885, 189);
            button3.Name = "button3";
            button3.Size = new Size(300, 29);
            button3.TabIndex = 68;
            button3.Text = "limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label12.Location = new Point(102, 611);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(141, 23);
            label12.TabIndex = 70;
            label12.Text = "TABLA DE COLAS";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(102, 637);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(618, 189);
            dataGridView1.TabIndex = 72;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 855);
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
            Name = "Form2";
            Text = "Form2";
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