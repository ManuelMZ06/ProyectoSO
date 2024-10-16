namespace AlgoritmosDePlanificacion
{
    partial class SubMenuNoExpropiativos
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
            lbTitulo = new Label();
            label1 = new Label();
            btnFIFO = new Button();
            btnPrioridad = new Button();
            btnSPN = new Button();
            brnHRRN = new Button();
            button1 = new Button();
            label2 = new Label();
            btnRegresarMenu = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(216, 15);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(400, 51);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "A L G O R I T M O S";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 63);
            label1.Name = "label1";
            label1.Size = new Size(53, 29);
            label1.TabIndex = 1;
            label1.Text = "NO";
            // 
            // btnFIFO
            // 
            btnFIFO.BackColor = Color.RosyBrown;
            btnFIFO.Cursor = Cursors.Hand;
            btnFIFO.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFIFO.Location = new Point(225, 177);
            btnFIFO.Name = "btnFIFO";
            btnFIFO.Size = new Size(362, 38);
            btnFIFO.TabIndex = 2;
            btnFIFO.Text = "FIRST IN FIRST OUT -- FIFO";
            btnFIFO.UseVisualStyleBackColor = false;
            btnFIFO.Click += btnFIFO_Click;
            // 
            // btnPrioridad
            // 
            btnPrioridad.BackColor = Color.Salmon;
            btnPrioridad.Cursor = Cursors.Hand;
            btnPrioridad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPrioridad.Location = new Point(225, 265);
            btnPrioridad.Name = "btnPrioridad";
            btnPrioridad.Size = new Size(362, 38);
            btnPrioridad.TabIndex = 3;
            btnPrioridad.Text = "POR PRIORIDAD";
            btnPrioridad.UseVisualStyleBackColor = false;
            btnPrioridad.Click += btnPrioridad_Click;
            // 
            // btnSPN
            // 
            btnSPN.BackColor = Color.Coral;
            btnSPN.Cursor = Cursors.Hand;
            btnSPN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSPN.Location = new Point(225, 310);
            btnSPN.Name = "btnSPN";
            btnSPN.Size = new Size(362, 38);
            btnSPN.TabIndex = 4;
            btnSPN.Text = "SHORT PROCESS NEXT -- SPN";
            btnSPN.UseVisualStyleBackColor = false;
            // 
            // brnHRRN
            // 
            brnHRRN.BackColor = Color.DarkOrange;
            brnHRRN.Cursor = Cursors.Hand;
            brnHRRN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            brnHRRN.Location = new Point(225, 353);
            brnHRRN.Name = "brnHRRN";
            brnHRRN.Size = new Size(362, 38);
            brnHRRN.TabIndex = 5;
            brnHRRN.Text = "HIGHEST RESPONSE RATIO NEXT -- HRRN";
            brnHRRN.UseVisualStyleBackColor = false;
            brnHRRN.Click += brnHRRN_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.Location = new Point(225, 222);
            button1.Name = "button1";
            button1.Size = new Size(362, 38);
            button1.TabIndex = 6;
            button1.Text = "SHORT JOB FIRST -- SJF";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 147);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 7;
            label2.Text = "SELECCIONE UNA OPCIÓN";
            label2.Click += label2_Click;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Cursor = Cursors.Hand;
            btnRegresarMenu.FlatStyle = FlatStyle.System;
            btnRegresarMenu.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarMenu.Location = new Point(301, 407);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(210, 29);
            btnRegresarMenu.TabIndex = 9;
            btnRegresarMenu.Text = "REGRESAR";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            btnRegresarMenu.Click += btnRegresarMenu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(311, 94);
            label3.Name = "label3";
            label3.Size = new Size(204, 28);
            label3.TabIndex = 10;
            label3.Text = "EXPROPIATIVOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(-8, 110);
            label4.Name = "label4";
            label4.Size = new Size(852, 28);
            label4.TabIndex = 11;
            label4.Text = "________________________________________________________";
            // 
            // SubMenuNoExpropiativos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnRegresarMenu);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(brnHRRN);
            Controls.Add(btnSPN);
            Controls.Add(btnPrioridad);
            Controls.Add(btnFIFO);
            Controls.Add(label1);
            Controls.Add(lbTitulo);
            Controls.Add(label4);
            Name = "SubMenuNoExpropiativos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubMenuNoExpropiativos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label label1;
        private Button btnFIFO;
        private Button btnPrioridad;
        private Button btnSPN;
        private Button brnHRRN;
        private Button button1;
        private Label label2;
        private Button btnRegresarMenu;
        private Label label3;
        private Label label4;
    }
}