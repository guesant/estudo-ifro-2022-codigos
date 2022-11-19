namespace AppCalculadoraFuncional.Formularios
{
    partial class FormFiguraGeometricaAA
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbOpcao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbValor1 = new System.Windows.Forms.Label();
            this.lbValor2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.edValor1 = new System.Windows.Forms.TextBox();
            this.edValor2 = new System.Windows.Forms.TextBox();
            this.edResultado = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "CALCULAR ÁREA DE FIGURAS GEOMÉTRICAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOpcao
            // 
            this.cbOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcao.FormattingEnabled = true;
            this.cbOpcao.Items.AddRange(new object[] {
            "LOSÂNGULO",
            "RETÂNGULO",
            "TRIÂNGULO RETÂNGULO"});
            this.cbOpcao.Location = new System.Drawing.Point(93, 90);
            this.cbOpcao.Name = "cbOpcao";
            this.cbOpcao.Size = new System.Drawing.Size(297, 28);
            this.cbOpcao.TabIndex = 2;
            this.cbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbOpcao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESCOLHA A FIGURA PARA CALCULAR A ÁREA";
            // 
            // lbValor1
            // 
            this.lbValor1.AutoSize = true;
            this.lbValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor1.Location = new System.Drawing.Point(90, 136);
            this.lbValor1.Name = "lbValor1";
            this.lbValor1.Size = new System.Drawing.Size(67, 15);
            this.lbValor1.TabIndex = 4;
            this.lbValor1.Text = "VALOR 1:";
            // 
            // lbValor2
            // 
            this.lbValor2.AutoSize = true;
            this.lbValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor2.Location = new System.Drawing.Point(90, 198);
            this.lbValor2.Name = "lbValor2";
            this.lbValor2.Size = new System.Drawing.Size(67, 15);
            this.lbValor2.TabIndex = 5;
            this.lbValor2.Text = "VALOR 2:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(90, 331);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(93, 15);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "RESULTADO:";
            // 
            // edValor1
            // 
            this.edValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edValor1.Location = new System.Drawing.Point(93, 159);
            this.edValor1.Name = "edValor1";
            this.edValor1.ReadOnly = true;
            this.edValor1.Size = new System.Drawing.Size(297, 24);
            this.edValor1.TabIndex = 7;
            // 
            // edValor2
            // 
            this.edValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edValor2.Location = new System.Drawing.Point(93, 223);
            this.edValor2.Name = "edValor2";
            this.edValor2.ReadOnly = true;
            this.edValor2.Size = new System.Drawing.Size(297, 24);
            this.edValor2.TabIndex = 8;
            // 
            // edResultado
            // 
            this.edResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edResultado.Location = new System.Drawing.Point(93, 357);
            this.edResultado.Name = "edResultado";
            this.edResultado.ReadOnly = true;
            this.edResultado.Size = new System.Drawing.Size(297, 24);
            this.edResultado.TabIndex = 9;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(93, 268);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(147, 46);
            this.btCalcular.TabIndex = 10;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(246, 268);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(144, 46);
            this.btNovo.TabIndex = 11;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(93, 400);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(297, 46);
            this.btFechar.TabIndex = 12;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FormFiguraGeometricaAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 469);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.edResultado);
            this.Controls.Add(this.edValor2);
            this.Controls.Add(this.edValor1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbValor2);
            this.Controls.Add(this.lbValor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOpcao);
            this.Controls.Add(this.label2);
            this.Name = "FormFiguraGeometricaAA";
            this.Text = "FormFiguraGeometricaAA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOpcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbValor1;
        private System.Windows.Forms.Label lbValor2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox edValor1;
        private System.Windows.Forms.TextBox edValor2;
        private System.Windows.Forms.TextBox edResultado;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btFechar;
    }
}