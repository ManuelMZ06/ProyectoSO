
namespace AlgoritmosDePlanificacion
{
    partial class Form2
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
            button1 = new Button();
            lbProcesos = new ListBox();
            lbPrioridad = new ListBox();
            lbCPU = new ListBox();
            lbLlegada = new ListBox();
            lbFinalizacion = new ListBox();
            lbRetorno = new ListBox();
            lbEspera = new ListBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            txtSumaCPU = new TextBox();
            txtPromRetorno = new TextBox();
            txtPromEspera = new TextBox();
            txtNoProcesos = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(58, 50);
            button1.Name = "button1";
            button1.Size = new Size(101, 38);
            button1.TabIndex = 1;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbProcesos
            // 
            lbProcesos.FormattingEnabled = true;
            lbProcesos.Location = new Point(151, 255);
            lbProcesos.Name = "lbProcesos";
            lbProcesos.Size = new Size(85, 244);
            lbProcesos.TabIndex = 2;
            // 
            // lbPrioridad
            // 
            lbPrioridad.FormattingEnabled = true;
            lbPrioridad.Location = new Point(556, 255);
            lbPrioridad.Name = "lbPrioridad";
            lbPrioridad.Size = new Size(88, 244);
            lbPrioridad.TabIndex = 3;
            // 
            // lbCPU
            // 
            lbCPU.FormattingEnabled = true;
            lbCPU.Location = new Point(259, 255);
            lbCPU.Name = "lbCPU";
            lbCPU.Size = new Size(99, 244);
            lbCPU.TabIndex = 4;
            // 
            // lbLlegada
            // 
            lbLlegada.FormattingEnabled = true;
            lbLlegada.Location = new Point(383, 255);
            lbLlegada.Name = "lbLlegada";
            lbLlegada.Size = new Size(157, 244);
            lbLlegada.TabIndex = 5;
            // 
            // lbFinalizacion
            // 
            lbFinalizacion.FormattingEnabled = true;
            lbFinalizacion.Location = new Point(666, 255);
            lbFinalizacion.Name = "lbFinalizacion";
            lbFinalizacion.Size = new Size(110, 244);
            lbFinalizacion.TabIndex = 6;
            lbFinalizacion.SelectedIndexChanged += this.lbFinalizacion_SelectedIndexChanged;
            // 
            // lbRetorno
            // 
            lbRetorno.FormattingEnabled = true;
            lbRetorno.Location = new Point(792, 255);
            lbRetorno.Name = "lbRetorno";
            lbRetorno.Size = new Size(80, 244);
            lbRetorno.TabIndex = 7;
            lbRetorno.SelectedIndexChanged += this.lbRetorno_SelectedIndexChanged;
            // 
            // lbEspera
            // 
            lbEspera.FormattingEnabled = true;
            lbEspera.Location = new Point(894, 255);
            lbEspera.Name = "lbEspera";
            lbEspera.Size = new Size(73, 244);
            lbEspera.TabIndex = 8;
            lbEspera.SelectedIndexChanged += lbEspera_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(516, 135);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 10;
            button2.Text = "ACEPTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 22);
            label2.TabIndex = 12;
            label2.Text = "Ingrese el Número de Procesos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 533);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(494, 575);
            button3.Name = "button3";
            button3.Size = new Size(106, 40);
            button3.TabIndex = 16;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(100, 620);
            chart1.Margin = new Padding(2);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(921, 310);
            chart1.TabIndex = 23;
            chart1.Text = "chart1";
            // 
            // txtSumaCPU
            // 
            txtSumaCPU.Location = new Point(259, 533);
            txtSumaCPU.Name = "txtSumaCPU";
            txtSumaCPU.Size = new Size(99, 27);
            txtSumaCPU.TabIndex = 24;
            // 
            // txtPromRetorno
            // 
            txtPromRetorno.Location = new Point(792, 533);
            txtPromRetorno.Name = "txtPromRetorno";
            txtPromRetorno.Size = new Size(80, 27);
            txtPromRetorno.TabIndex = 25;
            // 
            // txtPromEspera
            // 
            txtPromEspera.Location = new Point(894, 536);
            txtPromEspera.Name = "txtPromEspera";
            txtPromEspera.Size = new Size(73, 27);
            txtPromEspera.TabIndex = 26;
            // 
            // txtNoProcesos
            // 
            txtNoProcesos.Location = new Point(694, 96);
            txtNoProcesos.Name = "txtNoProcesos";
            txtNoProcesos.Size = new Size(125, 27);
            txtNoProcesos.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(437, 31);
            label1.Name = "label1";
            label1.Size = new Size(241, 48);
            label1.TabIndex = 28;
            label1.Text = "PRIORIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 154);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(151, 211);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 30;
            label5.Text = "PROCESOS";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(284, 209);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 23);
            label6.TabIndex = 31;
            label6.Text = "CPU";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(383, 209);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 23);
            label7.TabIndex = 32;
            label7.Text = "TIEMPO/LLEGADA";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(548, 208);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 33;
            label8.Text = "PRIORIDAD";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(652, 208);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 23);
            label9.TabIndex = 34;
            label9.Text = "FINALIZACION";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label10.Location = new Point(792, 211);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 35;
            label10.Text = "RETORNO";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(894, 211);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 23);
            label11.TabIndex = 36;
            label11.Text = "ESPERA";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(707, 551);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label13.Location = new Point(151, 537);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(58, 23);
            label13.TabIndex = 38;
            label13.Text = "SUMA";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label14.Location = new Point(677, 537);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(99, 23);
            label14.TabIndex = 39;
            label14.Text = "PROMEDIO";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 941);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtNoProcesos);
            Controls.Add(txtPromEspera);
            Controls.Add(txtPromRetorno);
            Controls.Add(txtSumaCPU);
            Controls.Add(chart1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(lbEspera);
            Controls.Add(lbRetorno);
            Controls.Add(lbFinalizacion);
            Controls.Add(lbLlegada);
            Controls.Add(lbCPU);
            Controls.Add(lbPrioridad);
            Controls.Add(lbProcesos);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lbRetorno_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbFinalizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button button1;
        private ListBox lbProcesos;
        private ListBox lbPrioridad;
        private ListBox lbCPU;
        private ListBox lbLlegada;
        private ListBox lbFinalizacion;
        private ListBox lbRetorno;
        private ListBox lbEspera;
        private Button button2;
        private Label label2;
        private Label label3;
        private Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox txtSumaCPU;
        private TextBox txtPromRetorno;
        private TextBox txtPromEspera;
        private TextBox txtNoProcesos;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}