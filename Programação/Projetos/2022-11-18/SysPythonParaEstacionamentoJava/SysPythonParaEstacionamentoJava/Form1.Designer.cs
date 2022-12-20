namespace SysPythonParaEstacionamentoJava
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
            this.btCadastrarVeiculos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btListarVeiculos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btListarEstacionamentos = new System.Windows.Forms.Button();
            this.btRegistrarEstacionamento = new System.Windows.Forms.Button();
            this.btFerramentasAdministrativas = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btListarVagas = new System.Windows.Forms.Button();
            this.btCadastrarVagas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor: Reinaldo\r\n\r\nTurma: 2A - Informática - 2022\r\n\r\n  - Gabriel Rodrigues An" +
    "tunes\r\n  - Gabriel Soares Caldeira\r\n";
            // 
            // btCadastrarVeiculos
            // 
            this.btCadastrarVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVeiculos.Location = new System.Drawing.Point(12, 34);
            this.btCadastrarVeiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastrarVeiculos.Name = "btCadastrarVeiculos";
            this.btCadastrarVeiculos.Size = new System.Drawing.Size(302, 46);
            this.btCadastrarVeiculos.TabIndex = 3;
            this.btCadastrarVeiculos.Text = "Cadastrar Veículos";
            this.btCadastrarVeiculos.UseVisualStyleBackColor = true;
            this.btCadastrarVeiculos.Click += new System.EventHandler(this.btCadastrarVeiculos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btListarVeiculos);
            this.groupBox1.Controls.Add(this.btCadastrarVeiculos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(328, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veículos";
            // 
            // btListarVeiculos
            // 
            this.btListarVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarVeiculos.Location = new System.Drawing.Point(12, 87);
            this.btListarVeiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btListarVeiculos.Name = "btListarVeiculos";
            this.btListarVeiculos.Size = new System.Drawing.Size(302, 46);
            this.btListarVeiculos.TabIndex = 4;
            this.btListarVeiculos.Text = "Consultar Veículos";
            this.btListarVeiculos.UseVisualStyleBackColor = true;
            this.btListarVeiculos.Click += new System.EventHandler(this.btListarVeiculos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btListarEstacionamentos);
            this.groupBox2.Controls.Add(this.btRegistrarEstacionamento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(328, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estacionamentos";
            // 
            // btListarEstacionamentos
            // 
            this.btListarEstacionamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarEstacionamentos.Location = new System.Drawing.Point(12, 85);
            this.btListarEstacionamentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btListarEstacionamentos.Name = "btListarEstacionamentos";
            this.btListarEstacionamentos.Size = new System.Drawing.Size(302, 46);
            this.btListarEstacionamentos.TabIndex = 4;
            this.btListarEstacionamentos.Text = "Consultar Estacionamentos";
            this.btListarEstacionamentos.UseVisualStyleBackColor = true;
            this.btListarEstacionamentos.Click += new System.EventHandler(this.btListarEstacionamentos_Click);
            // 
            // btRegistrarEstacionamento
            // 
            this.btRegistrarEstacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarEstacionamento.Location = new System.Drawing.Point(12, 34);
            this.btRegistrarEstacionamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRegistrarEstacionamento.Name = "btRegistrarEstacionamento";
            this.btRegistrarEstacionamento.Size = new System.Drawing.Size(302, 46);
            this.btRegistrarEstacionamento.TabIndex = 3;
            this.btRegistrarEstacionamento.Text = "Registrar Estacionamentos";
            this.btRegistrarEstacionamento.UseVisualStyleBackColor = true;
            this.btRegistrarEstacionamento.Click += new System.EventHandler(this.btRegistrarEstacionamento_Click);
            // 
            // btFerramentasAdministrativas
            // 
            this.btFerramentasAdministrativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFerramentasAdministrativas.Location = new System.Drawing.Point(361, 340);
            this.btFerramentasAdministrativas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFerramentasAdministrativas.Name = "btFerramentasAdministrativas";
            this.btFerramentasAdministrativas.Size = new System.Drawing.Size(332, 40);
            this.btFerramentasAdministrativas.TabIndex = 5;
            this.btFerramentasAdministrativas.Text = "Ferramentas Administrativas";
            this.btFerramentasAdministrativas.UseVisualStyleBackColor = true;
            this.btFerramentasAdministrativas.Click += new System.EventHandler(this.btFerramentasAdministrativas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btListarVagas);
            this.groupBox3.Controls.Add(this.btCadastrarVagas);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(361, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(328, 179);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vagas";
            // 
            // btListarVagas
            // 
            this.btListarVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarVagas.Location = new System.Drawing.Point(12, 87);
            this.btListarVagas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btListarVagas.Name = "btListarVagas";
            this.btListarVagas.Size = new System.Drawing.Size(302, 46);
            this.btListarVagas.TabIndex = 4;
            this.btListarVagas.Text = "Consultar Vagas";
            this.btListarVagas.UseVisualStyleBackColor = true;
            this.btListarVagas.Click += new System.EventHandler(this.btListarVagas_Click);
            // 
            // btCadastrarVagas
            // 
            this.btCadastrarVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVagas.Location = new System.Drawing.Point(12, 34);
            this.btCadastrarVagas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastrarVagas.Name = "btCadastrarVagas";
            this.btCadastrarVagas.Size = new System.Drawing.Size(302, 46);
            this.btCadastrarVagas.TabIndex = 3;
            this.btCadastrarVagas.Text = "Cadastrar Vagas";
            this.btCadastrarVagas.UseVisualStyleBackColor = true;
            this.btCadastrarVagas.Click += new System.EventHandler(this.btCadastrarVagas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "A função de \"Registrar Saída\" também está disponível em:\r\nConsultar Estacionament" +
    "os >> Abrir o registro com dois cliques.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar Saída";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btRegistrarSaida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btFerramentasAdministrativas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysPython | Estacionamento JAVA | 2A INF - 2022";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarVeiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btListarVeiculos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btListarEstacionamentos;
        private System.Windows.Forms.Button btRegistrarEstacionamento;
        private System.Windows.Forms.Button btFerramentasAdministrativas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btListarVagas;
        private System.Windows.Forms.Button btCadastrarVagas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

