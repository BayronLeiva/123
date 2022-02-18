namespace ProgramacionIII_1Pac_2022
{
    partial class FuncionesAsincronas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Hornear = new System.Windows.Forms.Button();
            this.Procesos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Sumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Hornear
            // 
            this.Hornear.Location = new System.Drawing.Point(76, 56);
            this.Hornear.Name = "Hornear";
            this.Hornear.Size = new System.Drawing.Size(149, 72);
            this.Hornear.TabIndex = 1;
            this.Hornear.Text = "Hornear Pizza";
            this.Hornear.UseVisualStyleBackColor = true;
            // 
            // Procesos
            // 
            this.Procesos.Location = new System.Drawing.Point(291, 56);
            this.Procesos.Name = "Procesos";
            this.Procesos.Size = new System.Drawing.Size(153, 72);
            this.Procesos.TabIndex = 2;
            this.Procesos.Text = "Otros procesos";
            this.Procesos.UseVisualStyleBackColor = true;
            this.Procesos.Click += new System.EventHandler(this.Procesos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 4;
            // 
            // Sumar
            // 
            this.Sumar.Location = new System.Drawing.Point(270, 230);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(193, 29);
            this.Sumar.TabIndex = 5;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = true;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // FuncionesAsincronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Procesos);
            this.Controls.Add(this.Hornear);
            this.Controls.Add(this.label1);
            this.Name = "FuncionesAsincronas";
            this.Text = "FuncionesAsincronas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Hornear;
        private Button Procesos;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Sumar;
    }
}