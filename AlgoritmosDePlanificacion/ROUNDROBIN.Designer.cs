namespace AlgoritmosDePlanificacion
{
    partial class ROUNDROBIN
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
            btnAceptar = new Button();
            txtNoProcesos = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            txtQuantum = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            lbLlegada = new ListBox();
            lbCPU = new ListBox();
            lbProcesos = new ListBox();
            txtContexto = new TextBox();
            label5 = new Label();
            label8 = new Label();
            txtSumaCPU = new TextBox();
            label9 = new Label();
            lblEntrada = new ListBox();
            label10 = new Label();
            lbFinalizacion = new ListBox();
            label11 = new Label();
            txtPromFinalizacion = new TextBox();
            txtPromEntrada = new TextBox();
            btnLimpiar = new Button();
            panelGrafico = new Panel();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAceptar.Location = new Point(455, 186);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(105, 37);
            btnAceptar.TabIndex = 66;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button2_Click;
            // 
            // txtNoProcesos
            // 
            txtNoProcesos.BorderStyle = BorderStyle.FixedSingle;
            txtNoProcesos.Cursor = Cursors.IBeam;
            txtNoProcesos.Font = new Font("Segoe UI", 11F);
            txtNoProcesos.Location = new Point(547, 91);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(120, 32);
            txtNoProcesos.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(300, 22);
            label3.TabIndex = 64;
            label3.Text = "Ingrese el Número de Procesos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(370, 23);
            label2.Name = "label2";
            label2.Size = new Size(297, 48);
            label2.TabIndex = 63;
            label2.Text = "ROUND ROBIN";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.Location = new Point(33, 34);
            button1.Name = "button1";
            button1.Size = new Size(106, 31);
            button1.TabIndex = 67;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtQuantum
            // 
            txtQuantum.BorderStyle = BorderStyle.FixedSingle;
            txtQuantum.Cursor = Cursors.IBeam;
            txtQuantum.Font = new Font("Segoe UI", 11F);
            txtQuantum.Location = new Point(547, 135);
            txtQuantum.Name = "txtQuantum";
            txtQuantum.Size = new Size(120, 32);
            txtQuantum.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 140);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 22);
            label1.TabIndex = 68;
            label1.Text = "Ingrese el Quantum:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(342, 243);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(174, 23);
            label7.TabIndex = 75;
            label7.Text = "TIEMPO DE LLEGADA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(200, 243);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 74;
            label6.Text = "RÁFAGA DE CPU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(100, 243);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 73;
            label4.Text = "PROCESOS";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbLlegada
            // 
            lbLlegada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbLlegada.BorderStyle = BorderStyle.FixedSingle;
            lbLlegada.Enabled = false;
            lbLlegada.Font = new Font("Segoe UI", 11F);
            lbLlegada.FormattingEnabled = true;
            lbLlegada.ItemHeight = 25;
            lbLlegada.Location = new Point(342, 268);
            lbLlegada.Margin = new Padding(2);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(164, 252);
            lbLlegada.TabIndex = 72;
            // 
            // lbCPU
            // 
            lbCPU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbCPU.BorderStyle = BorderStyle.FixedSingle;
            lbCPU.Enabled = false;
            lbCPU.Font = new Font("Segoe UI", 11F);
            lbCPU.FormattingEnabled = true;
            lbCPU.ItemHeight = 25;
            lbCPU.Location = new Point(200, 268);
            lbCPU.Margin = new Padding(2);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(128, 252);
            lbCPU.TabIndex = 71;
            // 
            // lbProcesos
            // 
            lbProcesos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbProcesos.BorderStyle = BorderStyle.FixedSingle;
            lbProcesos.Enabled = false;
            lbProcesos.Font = new Font("Segoe UI", 11F);
            lbProcesos.FormattingEnabled = true;
            lbProcesos.ItemHeight = 25;
            lbProcesos.Location = new Point(100, 268);
            lbProcesos.Margin = new Padding(2);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(88, 252);
            lbProcesos.TabIndex = 70;
            // 
            // txtContexto
            // 
            txtContexto.BorderStyle = BorderStyle.FixedSingle;
            txtContexto.Cursor = Cursors.IBeam;
            txtContexto.Font = new Font("Segoe UI", 11F);
            txtContexto.Location = new Point(512, 586);
            txtContexto.Name = "txtContexto";
            txtContexto.ReadOnly = true;
            txtContexto.Size = new Size(120, 32);
            txtContexto.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(308, 595);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(198, 23);
            label5.TabIndex = 77;
            label5.Text = "CAMBIO DE CONTEXTO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(138, 533);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 79;
            label8.Text = "SUMA:";
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.BorderStyle = BorderStyle.FixedSingle;
            txtSumaCPU.Font = new Font("Segoe UI", 11F);
            txtSumaCPU.Location = new Point(202, 530);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.Size = new Size(128, 32);
            txtSumaCPU.TabIndex = 78;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(519, 243);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(179, 23);
            label9.TabIndex = 81;
            label9.Text = "TIEMPO DE ENTRADA";
            // 
            // lblEntrada
            // 
            lblEntrada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblEntrada.BorderStyle = BorderStyle.FixedSingle;
            lblEntrada.Enabled = false;
            lblEntrada.Font = new Font("Segoe UI", 11F);
            lblEntrada.FormattingEnabled = true;
            lblEntrada.ItemHeight = 25;
            lblEntrada.Location = new Point(519, 268);
            lblEntrada.Margin = new Padding(2);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(167, 252);
            lblEntrada.TabIndex = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(698, 243);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(217, 23);
            label10.TabIndex = 83;
            label10.Text = "TIEMPO DE FINALIZACION";
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbFinalizacion.BorderStyle = BorderStyle.FixedSingle;
            lbFinalizacion.Enabled = false;
            lbFinalizacion.Font = new Font("Segoe UI", 11F);
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.ItemHeight = 25;
            lbFinalizacion.Location = new Point(701, 268);
            lbFinalizacion.Margin = new Padding(2);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(200, 252);
            lbFinalizacion.TabIndex = 82;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(402, 535);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(112, 23);
            label11.TabIndex = 86;
            label11.Text = "PROMEDIOS:";
            // 
            // txtPromFinalizacion
            // 
            txtPromFinalizacion.BorderStyle = BorderStyle.FixedSingle;
            txtPromFinalizacion.Font = new Font("Segoe UI", 11F);
            txtPromFinalizacion.Location = new Point(701, 533);
            txtPromFinalizacion.Name = "txtPromFinalizacion";
            txtPromFinalizacion.Size = new Size(200, 32);
            txtPromFinalizacion.TabIndex = 85;
            // 
            // txtPromEntrada
            // 
            txtPromEntrada.BorderStyle = BorderStyle.FixedSingle;
            txtPromEntrada.Font = new Font("Segoe UI", 11F);
            txtPromEntrada.Location = new Point(519, 533);
            txtPromEntrada.Name = "txtPromEntrada";
            txtPromEntrada.Size = new Size(165, 32);
            txtPromEntrada.TabIndex = 84;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(701, 583);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 34);
            btnLimpiar.TabIndex = 87;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(12, 624);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(994, 271);
            panelGrafico.TabIndex = 88;
            // 
            // ROUNDROBIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 907);
            Controls.Add(panelGrafico);
            Controls.Add(btnLimpiar);
            Controls.Add(label11);
            Controls.Add(txtPromFinalizacion);
            Controls.Add(txtPromEntrada);
            Controls.Add(label10);
            Controls.Add(lbFinalizacion);
            Controls.Add(label9);
            Controls.Add(lblEntrada);
            Controls.Add(label8);
            Controls.Add(txtSumaCPU);
            Controls.Add(label5);
            Controls.Add(txtContexto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lbLlegada);
            Controls.Add(lbCPU);
            Controls.Add(lbProcesos);
            Controls.Add(txtQuantum);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnAceptar);
            Controls.Add(txtNoProcesos);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "ROUNDROBIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ROUNDROBIN";
            FormClosing += ROUNDROBIN_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtNoProcesos;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox txtQuantum;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label4;
        private ListBox lbLlegada;
        private ListBox lbCPU;
        private ListBox lbProcesos;
        private TextBox txtContexto;
        private Label label5;
        private Label label8;
        private TextBox txtSumaCPU;
        private Label label9;
        private ListBox lblEntrada;
        private Label label10;
        private ListBox lbFinalizacion;
        private Label label11;
        private TextBox txtPromFinalizacion;
        private TextBox txtPromEntrada;
        private Button btnLimpiar;
        private Panel panelGrafico;
    }
}