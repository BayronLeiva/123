namespace ProgramacionIII_1Pac_2022
{
    partial class FuncionesTexto
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
            this.CadenatextB = new System.Windows.Forms.TextBox();
            this.TextbLongitud = new System.Windows.Forms.TextBox();
            this.BotonProcesar = new System.Windows.Forms.Button();
            this.textBoxPrimerCaracter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUltimoCaracter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longitud";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CadenatextB
            // 
            this.CadenatextB.Location = new System.Drawing.Point(104, 12);
            this.CadenatextB.Name = "CadenatextB";
            this.CadenatextB.Size = new System.Drawing.Size(616, 27);
            this.CadenatextB.TabIndex = 1;
            // 
            // TextbLongitud
            // 
            this.TextbLongitud.Location = new System.Drawing.Point(164, 120);
            this.TextbLongitud.Name = "TextbLongitud";
            this.TextbLongitud.Size = new System.Drawing.Size(132, 27);
            this.TextbLongitud.TabIndex = 2;
            // 
            // BotonProcesar
            // 
            this.BotonProcesar.Location = new System.Drawing.Point(626, 58);
            this.BotonProcesar.Name = "BotonProcesar";
            this.BotonProcesar.Size = new System.Drawing.Size(94, 29);
            this.BotonProcesar.TabIndex = 3;
            this.BotonProcesar.Text = "Procesar";
            this.BotonProcesar.UseVisualStyleBackColor = true;
            this.BotonProcesar.Click += new System.EventHandler(this.BotonProcesar_Click);
            // 
            // textBoxPrimerCaracter
            // 
            this.textBoxPrimerCaracter.Location = new System.Drawing.Point(164, 187);
            this.textBoxPrimerCaracter.Name = "textBoxPrimerCaracter";
            this.textBoxPrimerCaracter.Size = new System.Drawing.Size(132, 27);
            this.textBoxPrimerCaracter.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Primer Caracter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ultimo Caracter";
            // 
            // textBoxUltimoCaracter
            // 
            this.textBoxUltimoCaracter.Location = new System.Drawing.Point(164, 250);
            this.textBoxUltimoCaracter.Name = "textBoxUltimoCaracter";
            this.textBoxUltimoCaracter.Size = new System.Drawing.Size(132, 27);
            this.textBoxUltimoCaracter.TabIndex = 7;
            // 
            // FuncionesTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 452);
            this.Controls.Add(this.textBoxUltimoCaracter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrimerCaracter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonProcesar);
            this.Controls.Add(this.TextbLongitud);
            this.Controls.Add(this.CadenatextB);
            this.Controls.Add(this.label1);
            this.Name = "FuncionesTexto";
            this.Text = "5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox CadenatextB;
        private TextBox TextbLongitud;
        private Button BotonProcesar;
        private TextBox textBoxPrimerCaracter;
        private Label label2;
        private Label label3;
        private TextBox textBoxUltimoCaracter;
    }
}