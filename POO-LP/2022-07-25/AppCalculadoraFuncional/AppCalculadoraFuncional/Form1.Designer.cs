namespace AppCalculadoraFuncional
{
    partial class FormMenu
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
            this.btHecParaAlq = new System.Windows.Forms.Button();
            this.btAlcParaHec = new System.Windows.Forms.Button();
            this.btIMC = new System.Windows.Forms.Button();
            this.btFiguasGeometricas = new System.Windows.Forms.Button();
            this.btCalcularArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA FUNCIONAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btHecParaAlq
            // 
            this.btHecParaAlq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHecParaAlq.Location = new System.Drawing.Point(83, 108);
            this.btHecParaAlq.Name = "btHecParaAlq";
            this.btHecParaAlq.Size = new System.Drawing.Size(397, 52);
            this.btHecParaAlq.TabIndex = 1;
            this.btHecParaAlq.Text = "CONVERTER DE HEC PARA ALQUEIRES";
            this.btHecParaAlq.UseVisualStyleBackColor = true;
            this.btHecParaAlq.Click += new System.EventHandler(this.btHecParaAlq_Click);
            // 
            // btAlcParaHec
            // 
            this.btAlcParaHec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlcParaHec.Location = new System.Drawing.Point(83, 185);
            this.btAlcParaHec.Name = "btAlcParaHec";
            this.btAlcParaHec.Size = new System.Drawing.Size(397, 52);
            this.btAlcParaHec.TabIndex = 2;
            this.btAlcParaHec.Text = "CONVERTER DE ALC PARA HECTARES";
            this.btAlcParaHec.UseVisualStyleBackColor = true;
            this.btAlcParaHec.Click += new System.EventHandler(this.btAlcParaHec_Click);
            // 
            // btIMC
            // 
            this.btIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIMC.Location = new System.Drawing.Point(83, 262);
            this.btIMC.Name = "btIMC";
            this.btIMC.Size = new System.Drawing.Size(397, 52);
            this.btIMC.TabIndex = 3;
            this.btIMC.Text = "CALCULAR O IMC";
            this.btIMC.UseVisualStyleBackColor = true;
            this.btIMC.Click += new System.EventHandler(this.btIMC_Click);
            // 
            // btFiguasGeometricas
            // 
            this.btFiguasGeometricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiguasGeometricas.Location = new System.Drawing.Point(83, 341);
            this.btFiguasGeometricas.Name = "btFiguasGeometricas";
            this.btFiguasGeometricas.Size = new System.Drawing.Size(397, 52);
            this.btFiguasGeometricas.TabIndex = 4;
            this.btFiguasGeometricas.Text = "CALCULAR FIGURAS GEOMÉTRICAS";
            this.btFiguasGeometricas.UseVisualStyleBackColor = true;
            this.btFiguasGeometricas.Click += new System.EventHandler(this.btFiguasGeometricas_Click);
            // 
            // btCalcularArea
            // 
            this.btCalcularArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcularArea.Location = new System.Drawing.Point(83, 419);
            this.btCalcularArea.Name = "btCalcularArea";
            this.btCalcularArea.Size = new System.Drawing.Size(397, 52);
            this.btCalcularArea.TabIndex = 5;
            this.btCalcularArea.Text = "CALCULAR ÁREAS GEOMÉTRICAS";
            this.btCalcularArea.UseVisualStyleBackColor = true;
            this.btCalcularArea.Click += new System.EventHandler(this.btCalcularArea_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 541);
            this.Controls.Add(this.btCalcularArea);
            this.Controls.Add(this.btFiguasGeometricas);
            this.Controls.Add(this.btIMC);
            this.Controls.Add(this.btAlcParaHec);
            this.Controls.Add(this.btHecParaAlq);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMenu";
            this.Text = "MENU INICIAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHecParaAlq;
        private System.Windows.Forms.Button btAlcParaHec;
        private System.Windows.Forms.Button btIMC;
        private System.Windows.Forms.Button btFiguasGeometricas;
        private System.Windows.Forms.Button btCalcularArea;
    }
}

