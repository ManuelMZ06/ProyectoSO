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
            label3 = new Label();
            btnRegresarMenu = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(198, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(400, 51);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "A L G O R I T M O S";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 60);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 1;
            label1.Text = "NO --- EXPROPIATIVOS";
            // 
            // btnFIFO
            // 
            btnFIFO.BackColor = Color.Coral;
            btnFIFO.Location = new Point(-1, 162);
            btnFIFO.Name = "btnFIFO";
            btnFIFO.Size = new Size(803, 38);
            btnFIFO.TabIndex = 2;
            btnFIFO.Text = "FIRST IN FIRST OUT -- FIFO";
            btnFIFO.UseVisualStyleBackColor = false;
            btnFIFO.Click += btnFIFO_Click;
            // 
            // btnPrioridad
            // 
            btnPrioridad.BackColor = Color.IndianRed;
            btnPrioridad.Location = new Point(-1, 250);
            btnPrioridad.Name = "btnPrioridad";
            btnPrioridad.Size = new Size(803, 38);
            btnPrioridad.TabIndex = 3;
            btnPrioridad.Text = "POR PRIORIDAD";
            btnPrioridad.UseVisualStyleBackColor = false;
            // 
            // btnSPN
            // 
            btnSPN.BackColor = Color.RosyBrown;
            btnSPN.Location = new Point(-1, 294);
            btnSPN.Name = "btnSPN";
            btnSPN.Size = new Size(803, 38);
            btnSPN.TabIndex = 4;
            btnSPN.Text = "SHORT PROCESS NEXT -- SPN";
            btnSPN.UseVisualStyleBackColor = false;
            // 
            // brnHRRN
            // 
            brnHRRN.BackColor = Color.MistyRose;
            brnHRRN.Location = new Point(-15, 338);
            brnHRRN.Name = "brnHRRN";
            brnHRRN.Size = new Size(817, 38);
            brnHRRN.TabIndex = 5;
            brnHRRN.Text = "HIGHEST RESPONSE RATIO NEXT -- HRRN";
            brnHRRN.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Location = new Point(-1, 206);
            button1.Name = "button1";
            button1.Size = new Size(803, 38);
            button1.TabIndex = 6;
            button1.Text = "SHORT JOB FIRST -- SJF";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 7;
            label2.Text = "ELIJA UNA OPCIÓN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 88);
            label3.Name = "label3";
            label3.Size = new Size(501, 20);
            label3.TabIndex = 8;
            label3.Text = "__________________________________________________________________________________";
            label3.Click += label3_Click;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(198, 382);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(400, 29);
            btnRegresarMenu.TabIndex = 9;
            btnRegresarMenu.Text = "Regresar al Menú Principal UwU";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            btnRegresarMenu.Click += btnRegresarMenu_Click;
            // 
            // SubMenuNoExpropiativos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresarMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(brnHRRN);
            Controls.Add(btnSPN);
            Controls.Add(btnPrioridad);
            Controls.Add(btnFIFO);
            Controls.Add(label1);
            Controls.Add(lbTitulo);
            Name = "SubMenuNoExpropiativos";
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
        private Label label3;
        private Button btnRegresarMenu;
    }
}