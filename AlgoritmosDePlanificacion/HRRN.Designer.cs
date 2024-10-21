namespace AlgoritmosDePlanificacion
{
    partial class HRRN
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
            components = new System.ComponentModel.Container();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtNoProceso = new TextBox();
            lbProcesos = new ListBox();
            lblCPU = new ListBox();
            lblLlegada = new ListBox();
            lbFinalizacion = new ListBox();
            lbRetorno = new ListBox();
            lblEspera = new ListBox();
            button2 = new Button();
            lblSumaCPU = new TextBox();
            lblPromedioRetorno = new TextBox();
            lblPromedioEspera = new TextBox();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblPenalizacion = new ListBox();
            lblPromedioPenalizacion = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelGrafico = new Panel();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(1101, 320);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(80, 28);
            label10.TabIndex = 29;
            label10.Text = "ESPERA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(894, 320);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 28);
            label9.TabIndex = 28;
            label9.Text = "RETORNO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(716, 291);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 28);
            label8.TabIndex = 27;
            label8.Text = "TIEMPO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(451, 320);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(204, 28);
            label7.TabIndex = 26;
            label7.Text = "TIEMPO DE LLEGADA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(272, 320);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 25;
            label6.Text = "RÁFAGA DE CPU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(114, 320);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 24;
            label3.Text = "PROCESOS";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 180);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(344, 24);
            label2.TabIndex = 23;
            label2.Text = "Ingrese el Número de Procesos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(367, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(771, 58);
            label1.TabIndex = 22;
            label1.Text = "HIGHEST RESPONSE RATIO NEXT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(681, 104);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 58);
            label4.TabIndex = 30;
            label4.Text = "HRRN";
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
            button1.TabIndex = 31;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNoProceso
            // 
            txtNoProceso.BorderStyle = BorderStyle.FixedSingle;
            txtNoProceso.Cursor = Cursors.IBeam;
            txtNoProceso.Font = new Font("Segoe UI", 11F);
            txtNoProceso.Location = new Point(869, 174);
            txtNoProceso.Margin = new Padding(4);
            txtNoProceso.Name = "txtNoProceso";
            txtNoProceso.Size = new Size(150, 37);
            txtNoProceso.TabIndex = 32;
            txtNoProceso.TextAlign = HorizontalAlignment.Center;
            // 
            // lbProcesos
            // 
            lbProcesos.Font = new Font("Segoe UI", 11F);
            lbProcesos.FormattingEnabled = true;
            lbProcesos.ItemHeight = 30;
            lbProcesos.Location = new Point(65, 352);
            lbProcesos.Margin = new Padding(4);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(185, 274);
            lbProcesos.TabIndex = 33;
            // 
            // lblCPU
            // 
            lblCPU.Font = new Font("Segoe UI", 11F);
            lblCPU.FormattingEnabled = true;
            lblCPU.ItemHeight = 30;
            lblCPU.Location = new Point(258, 352);
            lblCPU.Margin = new Padding(4);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(185, 274);
            lblCPU.TabIndex = 34;
            // 
            // lblLlegada
            // 
            lblLlegada.Font = new Font("Segoe UI", 11F);
            lblLlegada.FormattingEnabled = true;
            lblLlegada.ItemHeight = 30;
            lblLlegada.Location = new Point(451, 352);
            lblLlegada.Margin = new Padding(4);
            lblLlegada.Name = "lblLlegada";
            lblLlegada.Size = new Size(204, 274);
            lblLlegada.TabIndex = 35;
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.Font = new Font("Segoe UI", 11F);
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.ItemHeight = 30;
            lbFinalizacion.Location = new Point(663, 352);
            lbFinalizacion.Margin = new Padding(4);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(185, 274);
            lbFinalizacion.TabIndex = 36;
            // 
            // lbRetorno
            // 
            lbRetorno.Font = new Font("Segoe UI", 11F);
            lbRetorno.FormattingEnabled = true;
            lbRetorno.ItemHeight = 30;
            lbRetorno.Location = new Point(856, 352);
            lbRetorno.Margin = new Padding(4);
            lbRetorno.Name = "lbRetorno";
            lbRetorno.Size = new Size(185, 274);
            lbRetorno.TabIndex = 37;
            // 
            // lblEspera
            // 
            lblEspera.Font = new Font("Segoe UI", 11F);
            lblEspera.FormattingEnabled = true;
            lblEspera.ItemHeight = 30;
            lblEspera.Location = new Point(1049, 352);
            lblEspera.Margin = new Padding(4);
            lblEspera.Name = "lblEspera";
            lblEspera.Size = new Size(185, 274);
            lblEspera.TabIndex = 38;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(706, 226);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 39;
            button2.Text = "ACEPTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblSumaCPU
            // 
            lblSumaCPU.BorderStyle = BorderStyle.FixedSingle;
            lblSumaCPU.Font = new Font("Segoe UI", 11F);
            lblSumaCPU.Location = new Point(258, 650);
            lblSumaCPU.Margin = new Padding(4);
            lblSumaCPU.Name = "lblSumaCPU";
            lblSumaCPU.Size = new Size(185, 37);
            lblSumaCPU.TabIndex = 40;
            lblSumaCPU.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPromedioRetorno
            // 
            lblPromedioRetorno.BorderStyle = BorderStyle.FixedSingle;
            lblPromedioRetorno.Font = new Font("Segoe UI", 11F);
            lblPromedioRetorno.Location = new Point(856, 650);
            lblPromedioRetorno.Margin = new Padding(4);
            lblPromedioRetorno.Name = "lblPromedioRetorno";
            lblPromedioRetorno.Size = new Size(185, 37);
            lblPromedioRetorno.TabIndex = 41;
            lblPromedioRetorno.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPromedioEspera
            // 
            lblPromedioEspera.BorderStyle = BorderStyle.FixedSingle;
            lblPromedioEspera.Font = new Font("Segoe UI", 11F);
            lblPromedioEspera.Location = new Point(1049, 650);
            lblPromedioEspera.Margin = new Padding(4);
            lblPromedioEspera.Name = "lblPromedioEspera";
            lblPromedioEspera.Size = new Size(184, 37);
            lblPromedioEspera.TabIndex = 42;
            lblPromedioEspera.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(177, 653);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 44;
            label5.Text = "SUMA:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(717, 653);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(130, 28);
            label11.TabIndex = 43;
            label11.Text = "PROMEDIOS:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label12.Location = new Point(1264, 320);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(145, 28);
            label12.TabIndex = 45;
            label12.Text = "FINALIZACION";
            // 
            // lblPenalizacion
            // 
            lblPenalizacion.Font = new Font("Segoe UI", 11F);
            lblPenalizacion.FormattingEnabled = true;
            lblPenalizacion.ItemHeight = 30;
            lblPenalizacion.Location = new Point(1242, 353);
            lblPenalizacion.Margin = new Padding(4);
            lblPenalizacion.Name = "lblPenalizacion";
            lblPenalizacion.Size = new Size(185, 274);
            lblPenalizacion.TabIndex = 46;
            // 
            // lblPromedioPenalizacion
            // 
            lblPromedioPenalizacion.BorderStyle = BorderStyle.FixedSingle;
            lblPromedioPenalizacion.Font = new Font("Segoe UI", 11F);
            lblPromedioPenalizacion.Location = new Point(1242, 650);
            lblPromedioPenalizacion.Margin = new Padding(4);
            lblPromedioPenalizacion.Name = "lblPromedioPenalizacion";
            lblPromedioPenalizacion.Size = new Size(185, 37);
            lblPromedioPenalizacion.TabIndex = 47;
            lblPromedioPenalizacion.TextAlign = HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(65, 795);
            panelGrafico.Margin = new Padding(4);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(1362, 110);
            panelGrafico.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label13.Location = new Point(686, 320);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(145, 28);
            label13.TabIndex = 49;
            label13.Text = "FINALIZACION";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label14.Location = new Point(901, 291);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(84, 28);
            label14.TabIndex = 50;
            label14.Text = "TIEMPO";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label15.Location = new Point(1100, 291);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(84, 28);
            label15.TabIndex = 51;
            label15.Text = "TIEMPO";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label16.Location = new Point(1290, 291);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(84, 28);
            label16.TabIndex = 52;
            label16.Text = "TIEMPO";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(706, 726);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(112, 38);
            button3.TabIndex = 53;
            button3.Text = "LIMPIAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // HRRN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 960);
            Controls.Add(button3);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(panelGrafico);
            Controls.Add(lblPromedioPenalizacion);
            Controls.Add(lblPenalizacion);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(lblPromedioEspera);
            Controls.Add(lblPromedioRetorno);
            Controls.Add(lblSumaCPU);
            Controls.Add(button2);
            Controls.Add(lblEspera);
            Controls.Add(lbRetorno);
            Controls.Add(lbFinalizacion);
            Controls.Add(lblLlegada);
            Controls.Add(lblCPU);
            Controls.Add(lbProcesos);
            Controls.Add(txtNoProceso);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "HRRN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HRRN";
            FormClosing += HRRN_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button1;
        private TextBox txtNoProceso;
        private ListBox lbProcesos;
        private ListBox lblCPU;
        private ListBox lblLlegada;
        private ListBox lbFinalizacion;
        private ListBox lbRetorno;
        private ListBox lblEspera;
        private Button button2;
        private TextBox lblSumaCPU;
        private TextBox lblPromedioRetorno;
        private TextBox lblPromedioEspera;
        private Label label5;
        private Label label11;
        private Label label12;
        private ListBox lblPenalizacion;
        private TextBox lblPromedioPenalizacion;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelGrafico;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button3;
    }
}