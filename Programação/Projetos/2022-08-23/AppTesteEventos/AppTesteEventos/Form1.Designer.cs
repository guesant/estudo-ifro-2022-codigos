namespace AppTesteEventos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSomaDeValores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSomaDeValores
            // 
            this.btSomaDeValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomaDeValores.Location = new System.Drawing.Point(133, 79);
            this.btSomaDeValores.Name = "btSomaDeValores";
            this.btSomaDeValores.Size = new System.Drawing.Size(374, 39);
            this.btSomaDeValores.TabIndex = 0;
            this.btSomaDeValores.Text = "SOMA DE VALORES";
            this.btSomaDeValores.UseVisualStyleBackColor = true;
            this.btSomaDeValores.Click += new System.EventHandler(this.btSomaDeValores_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEMÁFORO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSomaDeValores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSomaDeValores;
        private System.Windows.Forms.Button button1;
    }
}

