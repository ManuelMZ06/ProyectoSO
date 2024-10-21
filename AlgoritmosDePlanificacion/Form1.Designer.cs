namespace AlgoritmosDePlanificacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExpropiativo = new Button();
            btnNoExpropiativo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnExpropiativo
            // 
            btnExpropiativo.Cursor = Cursors.Hand;
            btnExpropiativo.FlatStyle = FlatStyle.System;
            btnExpropiativo.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnExpropiativo.Location = new Point(125, 348);
            btnExpropiativo.Margin = new Padding(2);
            btnExpropiativo.Name = "btnExpropiativo";
            btnExpropiativo.Size = new Size(255, 75);
            btnExpropiativo.TabIndex = 0;
            btnExpropiativo.Text = "Expropiativos";
            btnExpropiativo.UseVisualStyleBackColor = true;
            btnExpropiativo.Click += btnExpropiativo_Click;
            // 
            // btnNoExpropiativo
            // 
            btnNoExpropiativo.Cursor = Cursors.Hand;
            btnNoExpropiativo.FlatStyle = FlatStyle.System;
            btnNoExpropiativo.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnNoExpropiativo.Location = new Point(510, 348);
            btnNoExpropiativo.Margin = new Padding(2);
            btnNoExpropiativo.Name = "btnNoExpropiativo";
            btnNoExpropiativo.Size = new Size(255, 75);
            btnNoExpropiativo.TabIndex = 1;
            btnNoExpropiativo.Text = "No Expropiativos";
            btnNoExpropiativo.UseVisualStyleBackColor = true;
            btnNoExpropiativo.Click += btnNoExpropiativo_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(447, 56);
            label1.TabIndex = 2;
            label1.Text = "A L G O R I T M O S";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 41);
            label2.TabIndex = 3;
            label2.Text = "de";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(274, 145);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(363, 58);
            label3.TabIndex = 4;
            label3.Text = "Planificación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(298, 212);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(310, 34);
            label4.TabIndex = 5;
            label4.Text = "(Sistemas Operativos)";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(289, 280);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(318, 34);
            label5.TabIndex = 6;
            label5.Text = "Seleccione su opción:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(377, 451);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(133, 47);
            button1.TabIndex = 7;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNoExpropiativo);
            Controls.Add(btnExpropiativo);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExpropiativo;
        private Button btnNoExpropiativo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
