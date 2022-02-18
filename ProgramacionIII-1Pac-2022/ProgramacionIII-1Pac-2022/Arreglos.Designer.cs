namespace ProgramacionIII_1Pac_2022
{
    partial class Arreglos
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
            this.Ejecutar = new System.Windows.Forms.Button();
            this.Nombres = new System.Windows.Forms.ListBox();
            this.buttonM = new System.Windows.Forms.Button();
            this.Matriz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ejecutar
            // 
            this.Ejecutar.Location = new System.Drawing.Point(35, 44);
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.Size = new System.Drawing.Size(119, 53);
            this.Ejecutar.TabIndex = 0;
            this.Ejecutar.Text = "Ejecutar";
            this.Ejecutar.UseVisualStyleBackColor = true;
            this.Ejecutar.Click += new System.EventHandler(this.Ejecutar_Click);
            // 
            // Nombres
            // 
            this.Nombres.FormattingEnabled = true;
            this.Nombres.ItemHeight = 20;
            this.Nombres.Location = new System.Drawing.Point(35, 130);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(163, 244);
            this.Nombres.TabIndex = 1;
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(307, 44);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(149, 53);
            this.buttonM.TabIndex = 2;
            this.buttonM.Text = "Ejecutar Matriz";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // Matriz
            // 
            this.Matriz.FormattingEnabled = true;
            this.Matriz.ItemHeight = 20;
            this.Matriz.Location = new System.Drawing.Point(307, 130);
            this.Matriz.Name = "Matriz";
            this.Matriz.Size = new System.Drawing.Size(305, 244);
            this.Matriz.TabIndex = 3;
            // 
            // Arreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Matriz);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.Ejecutar);
            this.Name = "Arreglos";
            this.Text = "Arreglos";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Ejecutar;
        private ListBox Nombres;
        private Button buttonM;
        private ListBox Matriz;
    }
}