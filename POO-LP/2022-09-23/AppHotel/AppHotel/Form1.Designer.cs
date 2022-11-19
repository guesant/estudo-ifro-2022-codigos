namespace AppHotel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConsultarQuartos = new System.Windows.Forms.Button();
            this.btCadastrarQuartos = new System.Windows.Forms.Button();
            this.btConsultarClientes = new System.Windows.Forms.Button();
            this.btCadastrarClientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btConsultarHospedagens = new System.Windows.Forms.Button();
            this.btRegistrarHospedagem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConsultarQuartos);
            this.groupBox1.Controls.Add(this.btCadastrarQuartos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quarto";
            // 
            // btConsultarQuartos
            // 
            this.btConsultarQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarQuartos.Location = new System.Drawing.Point(19, 85);
            this.btConsultarQuartos.Name = "btConsultarQuartos";
            this.btConsultarQuartos.Size = new System.Drawing.Size(309, 48);
            this.btConsultarQuartos.TabIndex = 2;
            this.btConsultarQuartos.Text = "Consultar Quartos";
            this.btConsultarQuartos.UseVisualStyleBackColor = true;
            this.btConsultarQuartos.Click += new System.EventHandler(this.btConsultarQuartos_Click);
            // 
            // btCadastrarQuartos
            // 
            this.btCadastrarQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarQuartos.Location = new System.Drawing.Point(19, 31);
            this.btCadastrarQuartos.Name = "btCadastrarQuartos";
            this.btCadastrarQuartos.Size = new System.Drawing.Size(309, 48);
            this.btCadastrarQuartos.TabIndex = 1;
            this.btCadastrarQuartos.Text = "Cadastrar Quartos";
            this.btCadastrarQuartos.UseVisualStyleBackColor = true;
            this.btCadastrarQuartos.Click += new System.EventHandler(this.btCadastrarQuartos_Click);
            // 
            // btConsultarClientes
            // 
            this.btConsultarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarClientes.Location = new System.Drawing.Point(19, 85);
            this.btConsultarClientes.Name = "btConsultarClientes";
            this.btConsultarClientes.Size = new System.Drawing.Size(309, 48);
            this.btConsultarClientes.TabIndex = 2;
            this.btConsultarClientes.Text = "Consultar Clientes";
            this.btConsultarClientes.UseVisualStyleBackColor = true;
            this.btConsultarClientes.Click += new System.EventHandler(this.btConsultarClientes_Click);
            // 
            // btCadastrarClientes
            // 
            this.btCadastrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarClientes.Location = new System.Drawing.Point(19, 31);
            this.btCadastrarClientes.Name = "btCadastrarClientes";
            this.btCadastrarClientes.Size = new System.Drawing.Size(309, 48);
            this.btCadastrarClientes.TabIndex = 1;
            this.btCadastrarClientes.Text = "Cadastrar Clientes";
            this.btCadastrarClientes.UseVisualStyleBackColor = true;
            this.btCadastrarClientes.Click += new System.EventHandler(this.btCadastrarClientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btConsultarClientes);
            this.groupBox2.Controls.Add(this.btCadastrarClientes);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btConsultarHospedagens);
            this.groupBox3.Controls.Add(this.btRegistrarHospedagem);
            this.groupBox3.Location = new System.Drawing.Point(12, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 150);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hospedagem";
            // 
            // btConsultarHospedagens
            // 
            this.btConsultarHospedagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarHospedagens.Location = new System.Drawing.Point(19, 85);
            this.btConsultarHospedagens.Name = "btConsultarHospedagens";
            this.btConsultarHospedagens.Size = new System.Drawing.Size(309, 48);
            this.btConsultarHospedagens.TabIndex = 2;
            this.btConsultarHospedagens.Text = "Consultar Hospedagens";
            this.btConsultarHospedagens.UseVisualStyleBackColor = true;
            this.btConsultarHospedagens.Click += new System.EventHandler(this.btConsultarHospedagens_Click);
            // 
            // btRegistrarHospedagem
            // 
            this.btRegistrarHospedagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarHospedagem.Location = new System.Drawing.Point(19, 31);
            this.btRegistrarHospedagem.Name = "btRegistrarHospedagem";
            this.btRegistrarHospedagem.Size = new System.Drawing.Size(309, 48);
            this.btRegistrarHospedagem.TabIndex = 1;
            this.btRegistrarHospedagem.Text = "Registrar Hospedagens";
            this.btRegistrarHospedagem.UseVisualStyleBackColor = true;
            this.btRegistrarHospedagem.Click += new System.EventHandler(this.btRegistrarHospedagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 491);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "App Hotel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCadastrarQuartos;
        private System.Windows.Forms.Button btConsultarQuartos;
        private System.Windows.Forms.Button btConsultarClientes;
        private System.Windows.Forms.Button btCadastrarClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btConsultarHospedagens;
        private System.Windows.Forms.Button btRegistrarHospedagem;
    }
}

