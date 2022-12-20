namespace FormExemplo1QuartaEtapa
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
            this.btCadastroPessoa = new System.Windows.Forms.Button();
            this.btListarPessoas = new System.Windows.Forms.Button();
            this.btConsultarPessoas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastroPessoa
            // 
            this.btCadastroPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroPessoa.Location = new System.Drawing.Point(13, 13);
            this.btCadastroPessoa.Name = "btCadastroPessoa";
            this.btCadastroPessoa.Size = new System.Drawing.Size(334, 53);
            this.btCadastroPessoa.TabIndex = 0;
            this.btCadastroPessoa.Text = "CADASTRAR PESSOAS";
            this.btCadastroPessoa.UseVisualStyleBackColor = true;
            this.btCadastroPessoa.Click += new System.EventHandler(this.btCadastroPessoa_Click);
            // 
            // btListarPessoas
            // 
            this.btListarPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarPessoas.Location = new System.Drawing.Point(12, 72);
            this.btListarPessoas.Name = "btListarPessoas";
            this.btListarPessoas.Size = new System.Drawing.Size(334, 53);
            this.btListarPessoas.TabIndex = 1;
            this.btListarPessoas.Text = "LISTAR PESSOAS";
            this.btListarPessoas.UseVisualStyleBackColor = true;
            this.btListarPessoas.Click += new System.EventHandler(this.btListarPessoas_Click);
            // 
            // btConsultarPessoas
            // 
            this.btConsultarPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarPessoas.Location = new System.Drawing.Point(13, 131);
            this.btConsultarPessoas.Name = "btConsultarPessoas";
            this.btConsultarPessoas.Size = new System.Drawing.Size(334, 53);
            this.btConsultarPessoas.TabIndex = 2;
            this.btConsultarPessoas.Text = "CONSULTAR PESSOAS";
            this.btConsultarPessoas.UseVisualStyleBackColor = true;
            this.btConsultarPessoas.Click += new System.EventHandler(this.btConsultarPessoas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 199);
            this.Controls.Add(this.btConsultarPessoas);
            this.Controls.Add(this.btListarPessoas);
            this.Controls.Add(this.btCadastroPessoa);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo 1 - 4ª Etapa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastroPessoa;
        private System.Windows.Forms.Button btListarPessoas;
        private System.Windows.Forms.Button btConsultarPessoas;
    }
}

