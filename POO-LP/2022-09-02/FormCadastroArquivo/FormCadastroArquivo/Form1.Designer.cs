namespace FormCadastroArquivo
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
            this.btListarPessoas = new System.Windows.Forms.Button();
            this.btListarVeiculo = new System.Windows.Forms.Button();
            this.btVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btListarPessoas
            // 
            this.btListarPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarPessoas.Location = new System.Drawing.Point(12, 12);
            this.btListarPessoas.Name = "btListarPessoas";
            this.btListarPessoas.Size = new System.Drawing.Size(311, 42);
            this.btListarPessoas.TabIndex = 0;
            this.btListarPessoas.Text = "LISTAR PESSOAS";
            this.btListarPessoas.UseVisualStyleBackColor = true;
            this.btListarPessoas.Click += new System.EventHandler(this.btListarPessoas_Click);
            // 
            // btListarVeiculo
            // 
            this.btListarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarVeiculo.Location = new System.Drawing.Point(12, 78);
            this.btListarVeiculo.Name = "btListarVeiculo";
            this.btListarVeiculo.Size = new System.Drawing.Size(311, 42);
            this.btListarVeiculo.TabIndex = 2;
            this.btListarVeiculo.Text = "LISTAR VEÍCULOS";
            this.btListarVeiculo.UseVisualStyleBackColor = true;
            this.btListarVeiculo.Click += new System.EventHandler(this.btListarVeiculo_Click);
            // 
            // btVendas
            // 
            this.btVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVendas.Location = new System.Drawing.Point(12, 144);
            this.btVendas.Name = "btVendas";
            this.btVendas.Size = new System.Drawing.Size(311, 42);
            this.btVendas.TabIndex = 3;
            this.btVendas.Text = "REALIZAR VENDA";
            this.btVendas.UseVisualStyleBackColor = true;
            this.btVendas.Click += new System.EventHandler(this.btVendas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 202);
            this.Controls.Add(this.btVendas);
            this.Controls.Add(this.btListarVeiculo);
            this.Controls.Add(this.btListarPessoas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListarPessoas;
        private System.Windows.Forms.Button btListarVeiculo;
        private System.Windows.Forms.Button btVendas;
    }
}

