namespace AppTesteMensagens
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
            this.btAlerta = new System.Windows.Forms.Button();
            this.btInformacao = new System.Windows.Forms.Button();
            this.btPergunta = new System.Windows.Forms.Button();
            this.btErro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAlerta
            // 
            this.btAlerta.Location = new System.Drawing.Point(37, 28);
            this.btAlerta.Name = "btAlerta";
            this.btAlerta.Size = new System.Drawing.Size(176, 67);
            this.btAlerta.TabIndex = 0;
            this.btAlerta.Text = "ALERTA";
            this.btAlerta.UseVisualStyleBackColor = true;
            this.btAlerta.Click += new System.EventHandler(this.btAlerta_Click);
            // 
            // btInformacao
            // 
            this.btInformacao.Location = new System.Drawing.Point(260, 28);
            this.btInformacao.Name = "btInformacao";
            this.btInformacao.Size = new System.Drawing.Size(176, 67);
            this.btInformacao.TabIndex = 1;
            this.btInformacao.Text = "INFORMAÇÃO";
            this.btInformacao.UseVisualStyleBackColor = true;
            this.btInformacao.Click += new System.EventHandler(this.btInformacao_Click);
            // 
            // btPergunta
            // 
            this.btPergunta.Location = new System.Drawing.Point(260, 138);
            this.btPergunta.Name = "btPergunta";
            this.btPergunta.Size = new System.Drawing.Size(176, 67);
            this.btPergunta.TabIndex = 3;
            this.btPergunta.Text = "PERGUNTA";
            this.btPergunta.UseVisualStyleBackColor = true;
            this.btPergunta.Click += new System.EventHandler(this.btPergunta_Click);
            // 
            // btErro
            // 
            this.btErro.Location = new System.Drawing.Point(37, 138);
            this.btErro.Name = "btErro";
            this.btErro.Size = new System.Drawing.Size(176, 67);
            this.btErro.TabIndex = 2;
            this.btErro.Text = "ERRO";
            this.btErro.UseVisualStyleBackColor = true;
            this.btErro.Click += new System.EventHandler(this.btErro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 242);
            this.Controls.Add(this.btPergunta);
            this.Controls.Add(this.btErro);
            this.Controls.Add(this.btInformacao);
            this.Controls.Add(this.btAlerta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btAlerta;
        private Button btInformacao;
        private Button btPergunta;
        private Button btErro;
    }
}