namespace ProgramacionIII_1Pac_2022
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1tb = new System.Windows.Forms.TextBox();
            this.Numero2tb = new System.Windows.Forms.TextBox();
            this.Resultadotb = new System.Windows.Forms.TextBox();
            this.SumarBoton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // Numero1tb
            // 
            this.Numero1tb.Location = new System.Drawing.Point(218, 67);
            this.Numero1tb.Name = "Numero1tb";
            this.Numero1tb.Size = new System.Drawing.Size(125, 27);
            this.Numero1tb.TabIndex = 2;
            // 
            // Numero2tb
            // 
            this.Numero2tb.Location = new System.Drawing.Point(218, 108);
            this.Numero2tb.Name = "Numero2tb";
            this.Numero2tb.Size = new System.Drawing.Size(125, 27);
            this.Numero2tb.TabIndex = 3;
            // 
            // Resultadotb
            // 
            this.Resultadotb.Location = new System.Drawing.Point(218, 156);
            this.Resultadotb.Name = "Resultadotb";
            this.Resultadotb.Size = new System.Drawing.Size(125, 27);
            this.Resultadotb.TabIndex = 4;
            // 
            // SumarBoton
            // 
            this.SumarBoton.Location = new System.Drawing.Point(440, 65);
            this.SumarBoton.Name = "SumarBoton";
            this.SumarBoton.Size = new System.Drawing.Size(94, 29);
            this.SumarBoton.TabIndex = 5;
            this.SumarBoton.Text = "Sumar";
            this.SumarBoton.UseVisualStyleBackColor = true;
            this.SumarBoton.Click += new System.EventHandler(this.SumarBoton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mostrar Mensaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumarBoton);
            this.Controls.Add(this.Resultadotb);
            this.Controls.Add(this.Numero2tb);
            this.Controls.Add(this.Numero1tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Numero1tb;
        private TextBox Numero2tb;
        private TextBox Resultadotb;
        private Button SumarBoton;
        private Label label3;
        private Button button1;
    }
}