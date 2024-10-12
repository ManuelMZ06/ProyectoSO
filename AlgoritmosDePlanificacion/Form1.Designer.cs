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
            SuspendLayout();
            // 
            // btnExpropiativo
            // 
            btnExpropiativo.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpropiativo.Location = new Point(112, 318);
            btnExpropiativo.Margin = new Padding(2);
            btnExpropiativo.Name = "btnExpropiativo";
            btnExpropiativo.Size = new Size(192, 60);
            btnExpropiativo.TabIndex = 0;
            btnExpropiativo.Text = "Expropiativos";
            btnExpropiativo.UseVisualStyleBackColor = true;
            btnExpropiativo.Click += btnExpropiativo_Click;
            // 
            // btnNoExpropiativo
            // 
            btnNoExpropiativo.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            btnNoExpropiativo.Location = new Point(420, 318);
            btnNoExpropiativo.Margin = new Padding(2);
            btnNoExpropiativo.Name = "btnNoExpropiativo";
            btnNoExpropiativo.Size = new Size(192, 60);
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
            label1.Location = new Point(180, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 47);
            label1.TabIndex = 2;
            label1.Text = "A L G O R I T M O S";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 35);
            label2.TabIndex = 3;
            label2.Text = "de";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 123);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(308, 49);
            label3.TabIndex = 4;
            label3.Text = "Planificación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(238, 177);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(270, 30);
            label4.TabIndex = 5;
            label4.Text = "(Sistemas Operativos)";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(231, 261);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(267, 28);
            label5.TabIndex = 6;
            label5.Text = "Seleccione su opción:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 435);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNoExpropiativo);
            Controls.Add(btnExpropiativo);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
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
    }
}
