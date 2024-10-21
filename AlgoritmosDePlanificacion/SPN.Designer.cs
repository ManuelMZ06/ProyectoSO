namespace AlgoritmosDePlanificacion
{
    partial class Form3
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            lbProcesos = new ListBox();
            lbCPU = new ListBox();
            lbLlegada = new ListBox();
            lbFinalizacion = new ListBox();
            lbRetorno = new ListBox();
            lbEspera = new ListBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtNoProcesos = new TextBox();
            aceptar = new Button();
            txtSumaCPU = new TextBox();
            txtPromRetorno = new TextBox();
            txtPromEspera = new TextBox();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            panelGrafico = new Panel();
            button2 = new Button();
            SuspendLayout();
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
            button1.TabIndex = 0;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(382, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(545, 58);
            label1.TabIndex = 29;
            label1.Text = "SHORT PROCESS NEXT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(593, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 58);
            label2.TabIndex = 30;
            label2.Text = "SPN";
            // 
            // lbProcesos
            // 
            lbProcesos.Font = new Font("Segoe UI", 11F);
            lbProcesos.FormattingEnabled = true;
            lbProcesos.ItemHeight = 30;
            lbProcesos.Location = new Point(59, 336);
            lbProcesos.Margin = new Padding(4);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(185, 304);
            lbProcesos.TabIndex = 31;
            // 
            // lbCPU
            // 
            lbCPU.Font = new Font("Segoe UI", 11F);
            lbCPU.FormattingEnabled = true;
            lbCPU.ItemHeight = 30;
            lbCPU.Location = new Point(252, 336);
            lbCPU.Margin = new Padding(4);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(185, 304);
            lbCPU.TabIndex = 32;
            // 
            // lbLlegada
            // 
            lbLlegada.Font = new Font("Segoe UI", 11F);
            lbLlegada.FormattingEnabled = true;
            lbLlegada.ItemHeight = 30;
            lbLlegada.Location = new Point(446, 336);
            lbLlegada.Margin = new Padding(4);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(185, 304);
            lbLlegada.TabIndex = 33;
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.Font = new Font("Segoe UI", 11F);
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.ItemHeight = 30;
            lbFinalizacion.Location = new Point(637, 336);
            lbFinalizacion.Margin = new Padding(4);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(185, 304);
            lbFinalizacion.TabIndex = 34;
            // 
            // lbRetorno
            // 
            lbRetorno.Font = new Font("Segoe UI", 11F);
            lbRetorno.FormattingEnabled = true;
            lbRetorno.ItemHeight = 30;
            lbRetorno.Location = new Point(831, 336);
            lbRetorno.Margin = new Padding(4);
            lbRetorno.Name = "lbRetorno";
            lbRetorno.Size = new Size(185, 304);
            lbRetorno.TabIndex = 35;
            // 
            // lbEspera
            // 
            lbEspera.Font = new Font("Segoe UI", 11F);
            lbEspera.FormattingEnabled = true;
            lbEspera.ItemHeight = 30;
            lbEspera.Location = new Point(1029, 336);
            lbEspera.Margin = new Padding(4);
            lbEspera.Name = "lbEspera";
            lbEspera.Size = new Size(185, 304);
            lbEspera.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(1077, 304);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(80, 28);
            label11.TabIndex = 43;
            label11.Text = "ESPERA";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(872, 304);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(101, 28);
            label10.TabIndex = 42;
            label10.Text = "RETORNO";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(657, 304);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 28);
            label9.TabIndex = 41;
            label9.Text = "FINALIZACION";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(450, 304);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 28);
            label7.TabIndex = 39;
            label7.Text = "TIEMPO/LLEGADA";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(326, 304);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 38;
            label6.Text = "CPU";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(91, 304);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 37;
            label5.Text = "PROCESOS";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 185);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(344, 24);
            label3.TabIndex = 44;
            label3.Text = "Ingrese el Número de Procesos:";
            // 
            // txtNoProcesos
            // 
            txtNoProcesos.BorderStyle = BorderStyle.FixedSingle;
            txtNoProcesos.Cursor = Cursors.IBeam;
            txtNoProcesos.Font = new Font("Segoe UI", 11F);
            txtNoProcesos.Location = new Point(752, 179);
            txtNoProcesos.Margin = new Padding(4);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(150, 37);
            txtNoProcesos.TabIndex = 45;
            txtNoProcesos.TextAlign = HorizontalAlignment.Center;
            // 
            // aceptar
            // 
            aceptar.Cursor = Cursors.Hand;
            aceptar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            aceptar.Location = new Point(599, 240);
            aceptar.Margin = new Padding(4);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(109, 38);
            aceptar.TabIndex = 46;
            aceptar.Text = "ACEPTAR";
            aceptar.UseVisualStyleBackColor = true;
            aceptar.Click += button2_Click;
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.BorderStyle = BorderStyle.FixedSingle;
            txtSumaCPU.Font = new Font("Segoe UI", 11F);
            txtSumaCPU.Location = new Point(252, 649);
            txtSumaCPU.Margin = new Padding(4);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.Size = new Size(185, 37);
            txtSumaCPU.TabIndex = 47;
            txtSumaCPU.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPromRetorno
            // 
            txtPromRetorno.BorderStyle = BorderStyle.FixedSingle;
            txtPromRetorno.Font = new Font("Segoe UI", 11F);
            txtPromRetorno.Location = new Point(831, 649);
            txtPromRetorno.Margin = new Padding(4);
            txtPromRetorno.Name = "txtPromRetorno";
            txtPromRetorno.Size = new Size(189, 37);
            txtPromRetorno.TabIndex = 48;
            txtPromRetorno.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPromEspera
            // 
            txtPromEspera.BorderStyle = BorderStyle.FixedSingle;
            txtPromEspera.Font = new Font("Segoe UI", 11F);
            txtPromEspera.Location = new Point(1029, 649);
            txtPromEspera.Margin = new Padding(4);
            txtPromEspera.Name = "txtPromEspera";
            txtPromEspera.Size = new Size(185, 37);
            txtPromEspera.TabIndex = 49;
            txtPromEspera.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(588, 784);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 51;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label13.Location = new Point(121, 654);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(68, 28);
            label13.TabIndex = 52;
            label13.Text = "SUMA";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label14.Location = new Point(669, 654);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(114, 28);
            label14.TabIndex = 53;
            label14.Text = "PROMEDIO";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(59, 784);
            panelGrafico.Margin = new Padding(4);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(1155, 118);
            panelGrafico.TabIndex = 54;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(599, 716);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 55;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 935);
            Controls.Add(button2);
            Controls.Add(panelGrafico);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(txtPromEspera);
            Controls.Add(txtPromRetorno);
            Controls.Add(txtSumaCPU);
            Controls.Add(aceptar);
            Controls.Add(txtNoProcesos);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbEspera);
            Controls.Add(lbRetorno);
            Controls.Add(lbFinalizacion);
            Controls.Add(lbLlegada);
            Controls.Add(lbCPU);
            Controls.Add(lbProcesos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private ListBox lbProcesos;
        private ListBox lbCPU;
        private ListBox lbLlegada;
        private ListBox lbFinalizacion;
        private ListBox lbRetorno;
        private ListBox lbEspera;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtNoProcesos;
        private Button aceptar;
        private TextBox txtSumaCPU;
        private TextBox txtPromRetorno;
        private TextBox txtPromEspera;
        private Label label8;
        private Label label13;
        private Label label14;
        private Panel panelGrafico;
        private Button button2;
    }
}