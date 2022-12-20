namespace Avaliacao_3Etapa
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrarInfracao = new System.Windows.Forms.Button();
            this.btCadastrarMorador = new System.Windows.Forms.Button();
            this.btCadastrarOcorrencia = new System.Windows.Forms.Button();
            this.btExibirRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA DE CONTROLE DE INFRAÇÕES DO CONDOMÍNIO DELTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadastrarInfracao
            // 
            this.btCadastrarInfracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarInfracao.Location = new System.Drawing.Point(264, 98);
            this.btCadastrarInfracao.Name = "btCadastrarInfracao";
            this.btCadastrarInfracao.Size = new System.Drawing.Size(277, 49);
            this.btCadastrarInfracao.TabIndex = 3;
            this.btCadastrarInfracao.Text = "Cadastrar Infração";
            this.btCadastrarInfracao.UseVisualStyleBackColor = true;
            this.btCadastrarInfracao.Click += new System.EventHandler(this.btCadastrarInfracao_Click);
            // 
            // btCadastrarMorador
            // 
            this.btCadastrarMorador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarMorador.Location = new System.Drawing.Point(264, 153);
            this.btCadastrarMorador.Name = "btCadastrarMorador";
            this.btCadastrarMorador.Size = new System.Drawing.Size(277, 49);
            this.btCadastrarMorador.TabIndex = 4;
            this.btCadastrarMorador.Text = "Cadastrar Morador";
            this.btCadastrarMorador.UseVisualStyleBackColor = true;
            this.btCadastrarMorador.Click += new System.EventHandler(this.btCadastrarMorador_Click);
            // 
            // btCadastrarOcorrencia
            // 
            this.btCadastrarOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarOcorrencia.Location = new System.Drawing.Point(264, 208);
            this.btCadastrarOcorrencia.Name = "btCadastrarOcorrencia";
            this.btCadastrarOcorrencia.Size = new System.Drawing.Size(277, 49);
            this.btCadastrarOcorrencia.TabIndex = 5;
            this.btCadastrarOcorrencia.Text = "Cadastrar Ocorrência";
            this.btCadastrarOcorrencia.UseVisualStyleBackColor = true;
            this.btCadastrarOcorrencia.Click += new System.EventHandler(this.btCadastrarOcorrencia_Click);
            // 
            // btExibirRelatorio
            // 
            this.btExibirRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibirRelatorio.Location = new System.Drawing.Point(264, 263);
            this.btExibirRelatorio.Name = "btExibirRelatorio";
            this.btExibirRelatorio.Size = new System.Drawing.Size(277, 49);
            this.btExibirRelatorio.TabIndex = 6;
            this.btExibirRelatorio.Text = "Exibir Relatório";
            this.btExibirRelatorio.UseVisualStyleBackColor = true;
            this.btExibirRelatorio.Click += new System.EventHandler(this.btExibirRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.btExibirRelatorio);
            this.Controls.Add(this.btCadastrarOcorrencia);
            this.Controls.Add(this.btCadastrarMorador);
            this.Controls.Add(this.btCadastrarInfracao);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CONTROLE DE INFRAÇÕES - CONDOMÍNIO DELTA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarInfracao;
        private System.Windows.Forms.Button btCadastrarMorador;
        private System.Windows.Forms.Button btCadastrarOcorrencia;
        private System.Windows.Forms.Button btExibirRelatorio;
    }
}

