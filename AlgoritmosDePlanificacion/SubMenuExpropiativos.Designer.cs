namespace AlgoritmosDePlanificacion
{
    partial class SubMenuExpropiativos
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
            label3 = new Label();
            label1 = new Label();
            lbTitulo = new Label();
            btnRR = new Button();
            btnSRTJ = new Button();
            label2 = new Label();
            btnRegresarMenu1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 88);
            label3.Name = "label3";
            label3.Size = new Size(501, 20);
            label3.TabIndex = 11;
            label3.Text = "__________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 60);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 10;
            label1.Text = "EXPROPIATIVOS";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(201, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(400, 51);
            lbTitulo.TabIndex = 9;
            lbTitulo.Text = "A L G O R I T M O S";
            // 
            // btnRR
            // 
            btnRR.BackColor = Color.Salmon;
            btnRR.Location = new Point(-1, 228);
            btnRR.Name = "btnRR";
            btnRR.Size = new Size(803, 38);
            btnRR.TabIndex = 13;
            btnRR.Text = "ROUND ROBIN";
            btnRR.UseVisualStyleBackColor = false;
            btnRR.Click += button1_Click;
            // 
            // btnSRTJ
            // 
            btnSRTJ.BackColor = Color.Coral;
            btnSRTJ.Location = new Point(-1, 184);
            btnSRTJ.Name = "btnSRTJ";
            btnSRTJ.Size = new Size(803, 38);
            btnSRTJ.TabIndex = 12;
            btnSRTJ.Text = "SHORT REMAINING TIME FIRST -- SRTJ";
            btnSRTJ.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 14;
            label2.Text = "ELIJA UNA OPCIÓN";
            // 
            // btnRegresarMenu1
            // 
            btnRegresarMenu1.Location = new Point(201, 287);
            btnRegresarMenu1.Name = "btnRegresarMenu1";
            btnRegresarMenu1.Size = new Size(400, 29);
            btnRegresarMenu1.TabIndex = 15;
            btnRegresarMenu1.Text = "Regresar al Menú Principal UwU";
            btnRegresarMenu1.UseVisualStyleBackColor = true;
            btnRegresarMenu1.Click += btnRegresarMenu1_Click;
            // 
            // SubMenuExpropiativos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresarMenu1);
            Controls.Add(label2);
            Controls.Add(btnRR);
            Controls.Add(btnSRTJ);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lbTitulo);
            Name = "SubMenuExpropiativos";
            Text = "SubMenuExpropiativos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label lbTitulo;
        private Button btnRR;
        private Button btnSRTJ;
        private Label label2;
        private Button btnRegresarMenu1;
    }
}