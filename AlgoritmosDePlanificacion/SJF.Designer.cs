namespace AlgoritmosDePlanificacion
{
    partial class SJF
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
            btnLimpiar = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtSumaCPU = new TextBox();
            label4 = new Label();
            txtPromEspera = new TextBox();
            txtPromRetorno = new TextBox();
            label3 = new Label();
            lbEspera = new ListBox();
            lbRetorno = new ListBox();
            lbFinalizacion = new ListBox();
            lbLlegada = new ListBox();
            lbCPU = new ListBox();
            btnAceptar = new Button();
            lbProcesos = new ListBox();
            txtNoProcesos = new TextBox();
            label2 = new Label();
            btnRegresar = new Button();
            label1 = new Label();
            panelGrafico = new Panel();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(506, 137);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 30);
            btnLimpiar.TabIndex = 46;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(852, 188);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(162, 23);
            label10.TabIndex = 45;
            label10.Text = "TIEMPO DE ESPERA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(671, 188);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(181, 23);
            label9.TabIndex = 44;
            label9.Text = "TIEMPO DE RETORNO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(451, 188);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(217, 23);
            label8.TabIndex = 43;
            label8.Text = "TIEMPO DE FINALIZACION";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(274, 188);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(174, 23);
            label7.TabIndex = 42;
            label7.Text = "TIEMPO DE LLEGADA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(128, 188);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 41;
            label6.Text = "RÁFAGA DE CPU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(50, 491);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 40;
            label5.Text = "SUMA:";
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.BorderStyle = BorderStyle.FixedSingle;
            txtSumaCPU.Font = new Font("Segoe UI", 11F);
            txtSumaCPU.Location = new Point(128, 487);
            txtSumaCPU.Margin = new Padding(2);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.ReadOnly = true;
            txtSumaCPU.Size = new Size(128, 32);
            txtSumaCPU.TabIndex = 39;
            txtSumaCPU.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(542, 496);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 38;
            label4.Text = "PROMEDIOS:";
            // 
            // txtPromEspera
            // 
            txtPromEspera.BorderStyle = BorderStyle.FixedSingle;
            txtPromEspera.Font = new Font("Segoe UI", 11F);
            txtPromEspera.Location = new Point(852, 487);
            txtPromEspera.Margin = new Padding(2);
            txtPromEspera.Name = "txtPromEspera";
            txtPromEspera.ReadOnly = true;
            txtPromEspera.Size = new Size(151, 32);
            txtPromEspera.TabIndex = 37;
            txtPromEspera.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPromRetorno
            // 
            txtPromRetorno.BorderStyle = BorderStyle.FixedSingle;
            txtPromRetorno.Font = new Font("Segoe UI", 11F);
            txtPromRetorno.Location = new Point(671, 487);
            txtPromRetorno.Margin = new Padding(2);
            txtPromRetorno.Name = "txtPromRetorno";
            txtPromRetorno.ReadOnly = true;
            txtPromRetorno.Size = new Size(168, 32);
            txtPromRetorno.TabIndex = 36;
            txtPromRetorno.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(24, 188);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 35;
            label3.Text = "PROCESOS";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbEspera
            // 
            lbEspera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbEspera.BorderStyle = BorderStyle.FixedSingle;
            lbEspera.Enabled = false;
            lbEspera.Font = new Font("Segoe UI", 11F);
            lbEspera.FormattingEnabled = true;
            lbEspera.ItemHeight = 25;
            lbEspera.Location = new Point(852, 223);
            lbEspera.Margin = new Padding(2);
            lbEspera.Name = "lbEspera";
            lbEspera.Size = new Size(151, 227);
            lbEspera.TabIndex = 34;
            // 
            // lbRetorno
            // 
            lbRetorno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbRetorno.BorderStyle = BorderStyle.FixedSingle;
            lbRetorno.Enabled = false;
            lbRetorno.Font = new Font("Segoe UI", 11F);
            lbRetorno.FormattingEnabled = true;
            lbRetorno.ItemHeight = 25;
            lbRetorno.Location = new Point(671, 223);
            lbRetorno.Margin = new Padding(2);
            lbRetorno.Name = "lbRetorno";
            lbRetorno.Size = new Size(168, 227);
            lbRetorno.TabIndex = 33;
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbFinalizacion.BorderStyle = BorderStyle.FixedSingle;
            lbFinalizacion.Enabled = false;
            lbFinalizacion.Font = new Font("Segoe UI", 11F);
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.ItemHeight = 25;
            lbFinalizacion.Location = new Point(454, 223);
            lbFinalizacion.Margin = new Padding(2);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(200, 227);
            lbFinalizacion.TabIndex = 32;
            // 
            // lbLlegada
            // 
            lbLlegada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbLlegada.BorderStyle = BorderStyle.FixedSingle;
            lbLlegada.Enabled = false;
            lbLlegada.Font = new Font("Segoe UI", 11F);
            lbLlegada.FormattingEnabled = true;
            lbLlegada.ItemHeight = 25;
            lbLlegada.Location = new Point(274, 223);
            lbLlegada.Margin = new Padding(2);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(164, 227);
            lbLlegada.TabIndex = 31;
            // 
            // lbCPU
            // 
            lbCPU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbCPU.BorderStyle = BorderStyle.FixedSingle;
            lbCPU.Enabled = false;
            lbCPU.Font = new Font("Segoe UI", 11F);
            lbCPU.FormattingEnabled = true;
            lbCPU.ItemHeight = 25;
            lbCPU.Location = new Point(128, 223);
            lbCPU.Margin = new Padding(2);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(128, 227);
            lbCPU.TabIndex = 30;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAceptar.Location = new Point(406, 137);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(87, 30);
            btnAceptar.TabIndex = 29;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lbProcesos
            // 
            lbProcesos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbProcesos.BorderStyle = BorderStyle.FixedSingle;
            lbProcesos.Enabled = false;
            lbProcesos.Font = new Font("Segoe UI", 11F);
            lbProcesos.FormattingEnabled = true;
            lbProcesos.ItemHeight = 25;
            lbProcesos.Location = new Point(24, 223);
            lbProcesos.Margin = new Padding(2);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(88, 227);
            lbProcesos.TabIndex = 28;
            // 
            // txtNoProcesos
            // 
            txtNoProcesos.BorderStyle = BorderStyle.FixedSingle;
            txtNoProcesos.Cursor = Cursors.IBeam;
            txtNoProcesos.Font = new Font("Segoe UI", 11F);
            txtNoProcesos.Location = new Point(594, 90);
            txtNoProcesos.Margin = new Padding(2);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(120, 32);
            txtNoProcesos.TabIndex = 27;
            txtNoProcesos.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 94);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 22);
            label2.TabIndex = 26;
            label2.Text = "Ingrese el Número de Procesos:";
            // 
            // btnRegresar
            // 
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatStyle = FlatStyle.System;
            btnRegresar.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            btnRegresar.Location = new Point(35, 48);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(106, 31);
            btnRegresar.TabIndex = 25;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(317, 31);
            label1.Name = "label1";
            label1.Size = new Size(365, 48);
            label1.TabIndex = 24;
            label1.Text = "SHORT JOB FIRST";
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(24, 524);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(979, 258);
            panelGrafico.TabIndex = 48;
            // 
            // SJF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 794);
            Controls.Add(panelGrafico);
            Controls.Add(btnLimpiar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSumaCPU);
            Controls.Add(label4);
            Controls.Add(txtPromEspera);
            Controls.Add(txtPromRetorno);
            Controls.Add(label3);
            Controls.Add(lbEspera);
            Controls.Add(lbRetorno);
            Controls.Add(lbFinalizacion);
            Controls.Add(lbLlegada);
            Controls.Add(lbCPU);
            Controls.Add(btnAceptar);
            Controls.Add(lbProcesos);
            Controls.Add(txtNoProcesos);
            Controls.Add(label2);
            Controls.Add(btnRegresar);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "SJF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SJF";
            FormClosing += SJF_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtSumaCPU;
        private Label label4;
        private TextBox txtPromEspera;
        private TextBox txtPromRetorno;
        private Label label3;
        private ListBox lbEspera;
        private ListBox lbRetorno;
        private ListBox lbFinalizacion;
        private ListBox lbLlegada;
        private ListBox lbCPU;
        private Button btnAceptar;
        private ListBox lbProcesos;
        private TextBox txtNoProcesos;
        private Label label2;
        private Button btnRegresar;
        private Label label1;
        private Panel panelGrafico;
    }
}