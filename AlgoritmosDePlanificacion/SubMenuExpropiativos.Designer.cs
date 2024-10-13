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
            label1 = new Label();
            lbTitulo = new Label();
            btnRR = new Button();
            btnSRTJ = new Button();
            btnRegresarMenu1 = new Button();
            label4 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 145);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 34);
            label1.TabIndex = 10;
            label1.Text = "EXPROPIATIVOS";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(270, 76);
            lbTitulo.Margin = new Padding(4, 0, 4, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(476, 60);
            lbTitulo.TabIndex = 9;
            lbTitulo.Text = "A L G O R I T M O S";
            // 
            // btnRR
            // 
            btnRR.BackColor = Color.CornflowerBlue;
            btnRR.Cursor = Cursors.Hand;
            btnRR.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRR.Location = new Point(274, 343);
            btnRR.Margin = new Padding(4);
            btnRR.Name = "btnRR";
            btnRR.Size = new Size(453, 48);
            btnRR.TabIndex = 13;
            btnRR.Text = "ROUND ROBIN";
            btnRR.UseVisualStyleBackColor = false;
            btnRR.Click += button1_Click;
            // 
            // btnSRTJ
            // 
            btnSRTJ.BackColor = Color.RoyalBlue;
            btnSRTJ.Cursor = Cursors.Hand;
            btnSRTJ.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSRTJ.Location = new Point(274, 288);
            btnSRTJ.Margin = new Padding(4);
            btnSRTJ.Name = "btnSRTJ";
            btnSRTJ.Size = new Size(453, 48);
            btnSRTJ.TabIndex = 12;
            btnSRTJ.Text = "SHORT REMAINING TIME FIRST -- SRTJ";
            btnSRTJ.UseVisualStyleBackColor = false;
            // 
            // btnRegresarMenu1
            // 
            btnRegresarMenu1.Cursor = Cursors.Hand;
            btnRegresarMenu1.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            btnRegresarMenu1.Location = new Point(376, 417);
            btnRegresarMenu1.Margin = new Padding(4);
            btnRegresarMenu1.Name = "btnRegresarMenu1";
            btnRegresarMenu1.Size = new Size(248, 36);
            btnRegresarMenu1.TabIndex = 15;
            btnRegresarMenu1.Text = "REGRESAR";
            btnRegresarMenu1.UseVisualStyleBackColor = true;
            btnRegresarMenu1.Click += btnRegresarMenu1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(-20, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(1023, 34);
            label4.TabIndex = 16;
            label4.Text = "________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 232);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 17;
            label2.Text = "SELECCIONE UNA OPCIÓN";
            // 
            // SubMenuExpropiativos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label2);
            Controls.Add(btnRegresarMenu1);
            Controls.Add(btnRR);
            Controls.Add(btnSRTJ);
            Controls.Add(label1);
            Controls.Add(lbTitulo);
            Controls.Add(label4);
            Margin = new Padding(4);
            Name = "SubMenuExpropiativos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubMenuExpropiativos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lbTitulo;
        private Button btnRR;
        private Button btnSRTJ;
        private Button btnRegresarMenu1;
        private Label label4;
        private Label label2;
    }
}