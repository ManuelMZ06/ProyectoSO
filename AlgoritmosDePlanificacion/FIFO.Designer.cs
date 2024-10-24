namespace AlgoritmosDePlanificacion
{
    partial class FIFO
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
            label1 = new Label();
            btnRegresar = new Button();
            label2 = new Label();
            txtNoProcesos = new TextBox();
            lbProcesos = new ListBox();
            btnAceptar = new Button();
            lbCPU = new ListBox();
            lbLlegada = new ListBox();
            lbFinalizacion = new ListBox();
            lbRetorno = new ListBox();
            lbEspera = new ListBox();
            label3 = new Label();
            txtPromRetorno = new TextBox();
            txtPromEspera = new TextBox();
            label4 = new Label();
            txtSumaCPU = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnLimpiar = new Button();
            panelGrafico = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(314, 17);
            label1.Name = "label1";
            label1.Size = new Size(400, 48);
            label1.TabIndex = 0;
            label1.Text = "FIRST IN FIRST OUT";
            // 
            // btnRegresar
            // 
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatStyle = FlatStyle.System;
            btnRegresar.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            btnRegresar.Location = new Point(33, 34);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(106, 31);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(294, 80);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 22);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el Número de Procesos:";
            // 
            // txtNoProcesos
            // 
            txtNoProcesos.BorderStyle = BorderStyle.FixedSingle;
            txtNoProcesos.Cursor = Cursors.IBeam;
            txtNoProcesos.Font = new Font("Segoe UI", 11F);
            txtNoProcesos.Location = new Point(591, 76);
            txtNoProcesos.Margin = new Padding(2);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(120, 32);
            txtNoProcesos.TabIndex = 3;
            txtNoProcesos.TextAlign = HorizontalAlignment.Center;
            // 
            // lbProcesos
            // 
            lbProcesos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbProcesos.BorderStyle = BorderStyle.FixedSingle;
            lbProcesos.Enabled = false;
            lbProcesos.Font = new Font("Segoe UI", 11F);
            lbProcesos.FormattingEnabled = true;
            lbProcesos.ItemHeight = 25;
            lbProcesos.Location = new Point(22, 209);
            lbProcesos.Margin = new Padding(2);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(88, 227);
            lbProcesos.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAceptar.Location = new Point(324, 125);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 30);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lbCPU
            // 
            lbCPU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbCPU.BorderStyle = BorderStyle.FixedSingle;
            lbCPU.Enabled = false;
            lbCPU.Font = new Font("Segoe UI", 11F);
            lbCPU.FormattingEnabled = true;
            lbCPU.ItemHeight = 25;
            lbCPU.Location = new Point(126, 209);
            lbCPU.Margin = new Padding(2);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(128, 227);
            lbCPU.TabIndex = 6;
            // 
            // lbLlegada
            // 
            lbLlegada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbLlegada.BorderStyle = BorderStyle.FixedSingle;
            lbLlegada.Enabled = false;
            lbLlegada.Font = new Font("Segoe UI", 11F);
            lbLlegada.FormattingEnabled = true;
            lbLlegada.ItemHeight = 25;
            lbLlegada.Location = new Point(271, 209);
            lbLlegada.Margin = new Padding(2);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(164, 227);
            lbLlegada.TabIndex = 7;
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbFinalizacion.BorderStyle = BorderStyle.FixedSingle;
            lbFinalizacion.Enabled = false;
            lbFinalizacion.Font = new Font("Segoe UI", 11F);
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.ItemHeight = 25;
            lbFinalizacion.Location = new Point(451, 209);
            lbFinalizacion.Margin = new Padding(2);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(200, 227);
            lbFinalizacion.TabIndex = 8;
            // 
            // lbRetorno
            // 
            lbRetorno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbRetorno.BorderStyle = BorderStyle.FixedSingle;
            lbRetorno.Enabled = false;
            lbRetorno.Font = new Font("Segoe UI", 11F);
            lbRetorno.FormattingEnabled = true;
            lbRetorno.ItemHeight = 25;
            lbRetorno.Location = new Point(669, 209);
            lbRetorno.Margin = new Padding(2);
            lbRetorno.Name = "lbRetorno";
            lbRetorno.Size = new Size(168, 227);
            lbRetorno.TabIndex = 9;
            // 
            // lbEspera
            // 
            lbEspera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbEspera.BorderStyle = BorderStyle.FixedSingle;
            lbEspera.Enabled = false;
            lbEspera.Font = new Font("Segoe UI", 11F);
            lbEspera.FormattingEnabled = true;
            lbEspera.ItemHeight = 25;
            lbEspera.Location = new Point(850, 209);
            lbEspera.Margin = new Padding(2);
            lbEspera.Name = "lbEspera";
            lbEspera.Size = new Size(151, 227);
            lbEspera.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(22, 174);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 11;
            label3.Text = "PROCESOS";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPromRetorno
            // 
            txtPromRetorno.BorderStyle = BorderStyle.FixedSingle;
            txtPromRetorno.Font = new Font("Segoe UI", 11F);
            txtPromRetorno.Location = new Point(669, 473);
            txtPromRetorno.Margin = new Padding(2);
            txtPromRetorno.Name = "txtPromRetorno";
            txtPromRetorno.ReadOnly = true;
            txtPromRetorno.Size = new Size(168, 32);
            txtPromRetorno.TabIndex = 12;
            txtPromRetorno.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPromEspera
            // 
            txtPromEspera.BorderStyle = BorderStyle.FixedSingle;
            txtPromEspera.Font = new Font("Segoe UI", 11F);
            txtPromEspera.Location = new Point(850, 473);
            txtPromEspera.Margin = new Padding(2);
            txtPromEspera.Name = "txtPromEspera";
            txtPromEspera.ReadOnly = true;
            txtPromEspera.Size = new Size(151, 32);
            txtPromEspera.TabIndex = 13;
            txtPromEspera.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(561, 477);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 14;
            label4.Text = "PROMEDIOS:";
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.BorderStyle = BorderStyle.FixedSingle;
            txtSumaCPU.Font = new Font("Segoe UI", 11F);
            txtSumaCPU.Location = new Point(126, 473);
            txtSumaCPU.Margin = new Padding(2);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.ReadOnly = true;
            txtSumaCPU.Size = new Size(128, 32);
            txtSumaCPU.TabIndex = 15;
            txtSumaCPU.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(62, 475);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 16;
            label5.Text = "SUMA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(126, 174);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 17;
            label6.Text = "RÁFAGA DE CPU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(271, 174);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(174, 23);
            label7.TabIndex = 18;
            label7.Text = "TIEMPO DE LLEGADA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(449, 174);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(217, 23);
            label8.TabIndex = 19;
            label8.Text = "TIEMPO DE FINALIZACION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(669, 174);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(181, 23);
            label9.TabIndex = 20;
            label9.Text = "TIEMPO DE RETORNO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(850, 174);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(162, 23);
            label10.TabIndex = 21;
            label10.Text = "TIEMPO DE ESPERA";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(463, 125);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 30);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(22, 558);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(979, 249);
            panelGrafico.TabIndex = 24;
            // 
            // FIFO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 844);
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
            Name = "FIFO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FIFO";
            FormClosing += FIFO_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegresar;
        private Label label2;
        private TextBox txtNoProcesos;
        private ListBox lbProcesos;
        private Button btnAceptar;
        private ListBox lbCPU;
        private ListBox lbLlegada;
        private ListBox lbFinalizacion;
        private ListBox lbRetorno;
        private ListBox lbEspera;
        private Label label3;
        private TextBox txtPromRetorno;
        private TextBox txtPromEspera;
        private Label label4;
        private TextBox txtSumaCPU;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnLimpiar;
        private Panel panelGrafico;
    }
}