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
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAceptar.Location = new Point(569, 233);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 46);
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
            txtNoProcesos.Location = new Point(664, 114);
            txtNoProcesos.Margin = new Padding(4);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(150, 37);
            txtNoProcesos.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(314, 120);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(344, 24);
            label3.TabIndex = 64;
            label3.Text = "Ingrese el Número de Procesos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(462, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(352, 58);
            label2.TabIndex = 63;
            label2.Text = "ROUND ROBIN";
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
            txtQuantum.Location = new Point(664, 169);
            txtQuantum.Margin = new Padding(4);
            txtQuantum.Name = "txtQuantum";
            txtQuantum.Size = new Size(150, 37);
            txtQuantum.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 175);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 24);
            label1.TabIndex = 68;
            label1.Text = "Ingrese el Quantum:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(427, 304);
            label7.Name = "label7";
            label7.Size = new Size(204, 28);
            label7.TabIndex = 75;
            label7.Text = "TIEMPO DE LLEGADA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(250, 304);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 74;
            label6.Text = "RÁFAGA DE CPU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(125, 304);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
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
            lbLlegada.ItemHeight = 30;
            lbLlegada.Location = new Point(427, 335);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(204, 302);
            lbLlegada.TabIndex = 72;
            // 
            // lbCPU
            // 
            lbCPU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbCPU.BorderStyle = BorderStyle.FixedSingle;
            lbCPU.Enabled = false;
            lbCPU.Font = new Font("Segoe UI", 11F);
            lbCPU.FormattingEnabled = true;
            lbCPU.ItemHeight = 30;
            lbCPU.Location = new Point(250, 335);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(160, 302);
            lbCPU.TabIndex = 71;
            // 
            // lbProcesos
            // 
            lbProcesos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbProcesos.BorderStyle = BorderStyle.FixedSingle;
            lbProcesos.Enabled = false;
            lbProcesos.Font = new Font("Segoe UI", 11F);
            lbProcesos.FormattingEnabled = true;
            lbProcesos.ItemHeight = 30;
            lbProcesos.Location = new Point(125, 335);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(110, 302);
            lbProcesos.TabIndex = 70;
            // 
            // txtContexto
            // 
            txtContexto.BorderStyle = BorderStyle.FixedSingle;
            txtContexto.Cursor = Cursors.IBeam;
            txtContexto.Font = new Font("Segoe UI", 11F);
            txtContexto.Location = new Point(640, 733);
            txtContexto.Margin = new Padding(4);
            txtContexto.Name = "txtContexto";
            txtContexto.ReadOnly = true;
            txtContexto.Size = new Size(150, 37);
            txtContexto.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(404, 736);
            label5.Name = "label5";
            label5.Size = new Size(229, 28);
            label5.TabIndex = 77;
            label5.Text = "CAMBIO DE CONTEXTO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(172, 666);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 28);
            label8.TabIndex = 79;
            label8.Text = "SUMA:";
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.BorderStyle = BorderStyle.FixedSingle;
            txtSumaCPU.Font = new Font("Segoe UI", 11F);
            txtSumaCPU.Location = new Point(253, 663);
            txtSumaCPU.Margin = new Padding(4);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.Size = new Size(160, 37);
            txtSumaCPU.TabIndex = 78;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(649, 304);
            label9.Name = "label9";
            label9.Size = new Size(208, 28);
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
            lblEntrada.ItemHeight = 30;
            lblEntrada.Location = new Point(649, 335);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(208, 302);
            lblEntrada.TabIndex = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(873, 304);
            label10.Name = "label10";
            label10.Size = new Size(253, 28);
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
            lbFinalizacion.ItemHeight = 30;
            lbFinalizacion.Location = new Point(876, 335);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(250, 302);
            lbFinalizacion.TabIndex = 82;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(502, 669);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(130, 28);
            label11.TabIndex = 86;
            label11.Text = "PROMEDIOS:";
            // 
            // txtPromFinalizacion
            // 
            txtPromFinalizacion.BorderStyle = BorderStyle.FixedSingle;
            txtPromFinalizacion.Font = new Font("Segoe UI", 11F);
            txtPromFinalizacion.Location = new Point(876, 666);
            txtPromFinalizacion.Margin = new Padding(4);
            txtPromFinalizacion.Name = "txtPromFinalizacion";
            txtPromFinalizacion.Size = new Size(250, 37);
            txtPromFinalizacion.TabIndex = 85;
            // 
            // txtPromEntrada
            // 
            txtPromEntrada.BorderStyle = BorderStyle.FixedSingle;
            txtPromEntrada.Font = new Font("Segoe UI", 11F);
            txtPromEntrada.Location = new Point(649, 666);
            txtPromEntrada.Margin = new Padding(4);
            txtPromEntrada.Name = "txtPromEntrada";
            txtPromEntrada.Size = new Size(206, 37);
            txtPromEntrada.TabIndex = 84;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(569, 795);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 42);
            btnLimpiar.TabIndex = 87;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ROUNDROBIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 869);
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
    }
}