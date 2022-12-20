namespace AppEventosTempo.Formularios
{
    partial class FormSemaforo
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
            this.components = new System.ComponentModel.Container();
            this.btVerde = new System.Windows.Forms.Button();
            this.btAmarelo = new System.Windows.Forms.Button();
            this.btVermelho = new System.Windows.Forms.Button();
            this.tempoLuzVerde = new System.Windows.Forms.Timer(this.components);
            this.tempoLuzAmarela = new System.Windows.Forms.Timer(this.components);
            this.tempoLuzVermelha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btVerde
            // 
            this.btVerde.Location = new System.Drawing.Point(81, 108);
            this.btVerde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVerde.Name = "btVerde";
            this.btVerde.Size = new System.Drawing.Size(227, 279);
            this.btVerde.TabIndex = 0;
            this.btVerde.UseVisualStyleBackColor = true;
            // 
            // btAmarelo
            // 
            this.btAmarelo.Location = new System.Drawing.Point(396, 108);
            this.btAmarelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAmarelo.Name = "btAmarelo";
            this.btAmarelo.Size = new System.Drawing.Size(227, 279);
            this.btAmarelo.TabIndex = 1;
            this.btAmarelo.UseVisualStyleBackColor = true;
            // 
            // btVermelho
            // 
            this.btVermelho.Location = new System.Drawing.Point(751, 108);
            this.btVermelho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVermelho.Name = "btVermelho";
            this.btVermelho.Size = new System.Drawing.Size(227, 279);
            this.btVermelho.TabIndex = 2;
            this.btVermelho.UseVisualStyleBackColor = true;
            // 
            // tempoLuzVerde
            // 
            this.tempoLuzVerde.Tick += new System.EventHandler(this.tempoLuzVerde_Tick);
            // 
            // tempoLuzAmarela
            // 
            this.tempoLuzAmarela.Tick += new System.EventHandler(this.tempoLuzAmarela_Tick);
            // 
            // tempoLuzVermelha
            // 
            this.tempoLuzVermelha.Tick += new System.EventHandler(this.tempoLuzVermelha_Tick);
            // 
            // FormSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btVermelho);
            this.Controls.Add(this.btAmarelo);
            this.Controls.Add(this.btVerde);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSemaforo";
            this.Text = "FormSemaforo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVerde;
        private System.Windows.Forms.Button btAmarelo;
        private System.Windows.Forms.Button btVermelho;
        private System.Windows.Forms.Timer tempoLuzVerde;
        private System.Windows.Forms.Timer tempoLuzAmarela;
        private System.Windows.Forms.Timer tempoLuzVermelha;
    }
}