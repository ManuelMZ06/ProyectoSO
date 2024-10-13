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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(393, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(475, 58);
            label1.TabIndex = 0;
            label1.Text = "FIRST IN FIRST OUT";
            // 
            // btnRegresar
            // 
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatStyle = FlatStyle.System;
            btnRegresar.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            btnRegresar.Location = new Point(41, 42);
            btnRegresar.Margin = new Padding(4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(133, 39);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 92);
            label2.Name = "label2";
            label2.Size = new Size(344, 24);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el Número de Procesos:";
            // 
            // txtNoProcesos
            // 
            txtNoProcesos.BorderStyle = BorderStyle.FixedSingle;
            txtNoProcesos.Cursor = Cursors.IBeam;
            txtNoProcesos.Font = new Font("Segoe UI", 11F);
            txtNoProcesos.Location = new Point(739, 87);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(150, 37);
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
            lbProcesos.ItemHeight = 30;
            lbProcesos.Location = new Point(27, 234);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(110, 302);
            lbProcesos.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAceptar.Location = new Point(565, 133);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(109, 38);
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
            lbCPU.ItemHeight = 30;
            lbCPU.Location = new Point(157, 234);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(160, 302);
            lbCPU.TabIndex = 6;
            // 
            // lbLlegada
            // 
            lbLlegada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbLlegada.BorderStyle = BorderStyle.FixedSingle;
            lbLlegada.Enabled = false;
            lbLlegada.Font = new Font("Segoe UI", 11F);
            lbLlegada.FormattingEnabled = true;
            lbLlegada.ItemHeight = 30;
            lbLlegada.Location = new Point(339, 234);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(204, 302);
            lbLlegada.TabIndex = 7;
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbFinalizacion.BorderStyle = BorderStyle.FixedSingle;
            lbFinalizacion.Enabled = false;
            lbFinalizacion.Font = new Font("Segoe UI", 11F);
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.ItemHeight = 30;
            lbFinalizacion.Location = new Point(564, 234);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(250, 302);
            lbFinalizacion.TabIndex = 8;
            // 
            // lbRetorno
            // 
            lbRetorno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbRetorno.BorderStyle = BorderStyle.FixedSingle;
            lbRetorno.Enabled = false;
            lbRetorno.Font = new Font("Segoe UI", 11F);
            lbRetorno.FormattingEnabled = true;
            lbRetorno.ItemHeight = 30;
            lbRetorno.Location = new Point(836, 234);
            lbRetorno.Name = "lbRetorno";
            lbRetorno.Size = new Size(209, 302);
            lbRetorno.TabIndex = 9;
            // 
            // lbEspera
            // 
            lbEspera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbEspera.BorderStyle = BorderStyle.FixedSingle;
            lbEspera.Enabled = false;
            lbEspera.Font = new Font("Segoe UI", 11F);
            lbEspera.FormattingEnabled = true;
            lbEspera.ItemHeight = 30;
            lbEspera.Location = new Point(1062, 234);
            lbEspera.Name = "lbEspera";
            lbEspera.Size = new Size(188, 302);
            lbEspera.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(27, 190);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 11;
            label3.Text = "PROCESOS";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPromRetorno
            // 
            txtPromRetorno.BorderStyle = BorderStyle.FixedSingle;
            txtPromRetorno.Font = new Font("Segoe UI", 11F);
            txtPromRetorno.Location = new Point(836, 564);
            txtPromRetorno.Name = "txtPromRetorno";
            txtPromRetorno.ReadOnly = true;
            txtPromRetorno.Size = new Size(209, 37);
            txtPromRetorno.TabIndex = 12;
            txtPromRetorno.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPromEspera
            // 
            txtPromEspera.BorderStyle = BorderStyle.FixedSingle;
            txtPromEspera.Font = new Font("Segoe UI", 11F);
            txtPromEspera.Location = new Point(1062, 564);
            txtPromEspera.Name = "txtPromEspera";
            txtPromEspera.ReadOnly = true;
            txtPromEspera.Size = new Size(188, 37);
            txtPromEspera.TabIndex = 13;
            txtPromEspera.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(701, 569);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 14;
            label4.Text = "PROMEDIOS:";
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.BorderStyle = BorderStyle.FixedSingle;
            txtSumaCPU.Font = new Font("Segoe UI", 11F);
            txtSumaCPU.Location = new Point(157, 564);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.ReadOnly = true;
            txtSumaCPU.Size = new Size(160, 37);
            txtSumaCPU.TabIndex = 15;
            txtSumaCPU.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(78, 567);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 16;
            label5.Text = "SUMA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(157, 190);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 17;
            label6.Text = "RÁFAGA DE CPU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(339, 190);
            label7.Name = "label7";
            label7.Size = new Size(204, 28);
            label7.TabIndex = 18;
            label7.Text = "TIEMPO DE LLEGADA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(561, 190);
            label8.Name = "label8";
            label8.Size = new Size(253, 28);
            label8.TabIndex = 19;
            label8.Text = "TIEMPO DE FINALIZACION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(836, 190);
            label9.Name = "label9";
            label9.Size = new Size(209, 28);
            label9.TabIndex = 20;
            label9.Text = "TIEMPO DE RETORNO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(1062, 190);
            label10.Name = "label10";
            label10.Size = new Size(188, 28);
            label10.TabIndex = 21;
            label10.Text = "TIEMPO DE ESPERA";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(562, 630);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 38);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(60, 687);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1151, 388);
            chart1.TabIndex = 22;
            chart1.Text = "chart1";
            // 
            // FIFO
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 1087);
            Controls.Add(btnLimpiar);
            Controls.Add(chart1);
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
            Margin = new Padding(4);
            Name = "FIFO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FIFO";
            FormClosing += FIFO_FormClosing;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}