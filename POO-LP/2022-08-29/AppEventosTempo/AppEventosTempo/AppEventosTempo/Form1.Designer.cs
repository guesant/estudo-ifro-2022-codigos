namespace AppEventosTempo
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
            this.btSemaforo = new System.Windows.Forms.Button();
            this.btEstacionamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSemaforo
            // 
            this.btSemaforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSemaforo.Location = new System.Drawing.Point(277, 138);
            this.btSemaforo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSemaforo.Name = "btSemaforo";
            this.btSemaforo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSemaforo.Size = new System.Drawing.Size(391, 59);
            this.btSemaforo.TabIndex = 0;
            this.btSemaforo.Text = "SOLUÇÃO SEMÁFORO";
            this.btSemaforo.UseVisualStyleBackColor = true;
            this.btSemaforo.Click += new System.EventHandler(this.btSemaforo_Click);
            // 
            // btEstacionamento
            // 
            this.btEstacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstacionamento.Location = new System.Drawing.Point(277, 258);
            this.btEstacionamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEstacionamento.Name = "btEstacionamento";
            this.btEstacionamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btEstacionamento.Size = new System.Drawing.Size(391, 59);
            this.btEstacionamento.TabIndex = 1;
            this.btEstacionamento.Text = "ESTACIONAMENTO";
            this.btEstacionamento.UseVisualStyleBackColor = true;
            this.btEstacionamento.Click += new System.EventHandler(this.btEstacionamento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 554);
            this.Controls.Add(this.btEstacionamento);
            this.Controls.Add(this.btSemaforo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSemaforo;
        private System.Windows.Forms.Button btEstacionamento;
    }
}

