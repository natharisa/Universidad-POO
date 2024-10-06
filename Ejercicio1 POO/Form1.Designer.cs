namespace Ejercicio1_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCargarCombu = new System.Windows.Forms.Button();
            this.BtnAvanzar = new System.Windows.Forms.Button();
            this.BtnEncender = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericCombustible = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarCombu
            // 
            this.BtnCargarCombu.Location = new System.Drawing.Point(82, 135);
            this.BtnCargarCombu.Name = "BtnCargarCombu";
            this.BtnCargarCombu.Size = new System.Drawing.Size(75, 40);
            this.BtnCargarCombu.TabIndex = 0;
            this.BtnCargarCombu.Text = "Cargar Combustible";
            this.BtnCargarCombu.UseVisualStyleBackColor = true;
            this.BtnCargarCombu.Click += new System.EventHandler(this.BtnCargarCombu_Click);
            // 
            // BtnAvanzar
            // 
            this.BtnAvanzar.Location = new System.Drawing.Point(82, 294);
            this.BtnAvanzar.Name = "BtnAvanzar";
            this.BtnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.BtnAvanzar.TabIndex = 1;
            this.BtnAvanzar.Text = "Avanzar";
            this.BtnAvanzar.UseVisualStyleBackColor = true;
            this.BtnAvanzar.Click += new System.EventHandler(this.BtnAvanzar_Click);
            // 
            // BtnEncender
            // 
            this.BtnEncender.Location = new System.Drawing.Point(82, 239);
            this.BtnEncender.Name = "BtnEncender";
            this.BtnEncender.Size = new System.Drawing.Size(75, 23);
            this.BtnEncender.TabIndex = 2;
            this.BtnEncender.Text = "Encender";
            this.BtnEncender.UseVisualStyleBackColor = true;
            this.BtnEncender.Click += new System.EventHandler(this.BtnEncender_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Location = new System.Drawing.Point(183, 239);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(75, 23);
            this.BtnApagar.TabIndex = 3;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(453, 98);
            this.progressBar1.Maximum = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // numericCombustible
            // 
            this.numericCombustible.Location = new System.Drawing.Point(82, 98);
            this.numericCombustible.Name = "numericCombustible";
            this.numericCombustible.Size = new System.Drawing.Size(120, 20);
            this.numericCombustible.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericCombustible);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BtnEncender);
            this.Controls.Add(this.BtnAvanzar);
            this.Controls.Add(this.BtnCargarCombu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarCombu;
        private System.Windows.Forms.Button BtnAvanzar;
        private System.Windows.Forms.Button BtnEncender;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericCombustible;
        private System.Windows.Forms.Label label1;
    }
}

