namespace AppRegistroVeiculo
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
            this.btCadastrarVeiculo = new System.Windows.Forms.Button();
            this.btCadastrarCliente = new System.Windows.Forms.Button();
            this.btRealizarVenda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btListarVeiculos = new System.Windows.Forms.Button();
            this.btConsultarVeiculos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btListarClientes = new System.Windows.Forms.Button();
            this.btConsultarCliente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btListarVendas = new System.Windows.Forms.Button();
            this.btConsultarVendas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadastrarVeiculo
            // 
            this.btCadastrarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVeiculo.Location = new System.Drawing.Point(6, 30);
            this.btCadastrarVeiculo.Name = "btCadastrarVeiculo";
            this.btCadastrarVeiculo.Size = new System.Drawing.Size(222, 45);
            this.btCadastrarVeiculo.TabIndex = 0;
            this.btCadastrarVeiculo.Text = "Cadastrar Veículo";
            this.btCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btCadastrarVeiculo.Click += new System.EventHandler(this.btCadastrarVeiculo_Click);
            // 
            // btCadastrarCliente
            // 
            this.btCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCliente.Location = new System.Drawing.Point(6, 30);
            this.btCadastrarCliente.Name = "btCadastrarCliente";
            this.btCadastrarCliente.Size = new System.Drawing.Size(222, 45);
            this.btCadastrarCliente.TabIndex = 1;
            this.btCadastrarCliente.Text = "Cadastrar Cliente";
            this.btCadastrarCliente.UseVisualStyleBackColor = true;
            this.btCadastrarCliente.Click += new System.EventHandler(this.btCadastrarCliente_Click);
            // 
            // btRealizarVenda
            // 
            this.btRealizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRealizarVenda.Location = new System.Drawing.Point(6, 30);
            this.btRealizarVenda.Name = "btRealizarVenda";
            this.btRealizarVenda.Size = new System.Drawing.Size(222, 45);
            this.btRealizarVenda.TabIndex = 2;
            this.btRealizarVenda.Text = "Realizar Venda";
            this.btRealizarVenda.UseVisualStyleBackColor = true;
            this.btRealizarVenda.Click += new System.EventHandler(this.btRealizarVenda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btListarVeiculos);
            this.groupBox1.Controls.Add(this.btConsultarVeiculos);
            this.groupBox1.Controls.Add(this.btCadastrarVeiculo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veículos";
            // 
            // btListarVeiculos
            // 
            this.btListarVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarVeiculos.Location = new System.Drawing.Point(462, 30);
            this.btListarVeiculos.Name = "btListarVeiculos";
            this.btListarVeiculos.Size = new System.Drawing.Size(222, 45);
            this.btListarVeiculos.TabIndex = 3;
            this.btListarVeiculos.Text = "Listar Veículos";
            this.btListarVeiculos.UseVisualStyleBackColor = true;
            this.btListarVeiculos.Click += new System.EventHandler(this.btListarVeiculos_Click);
            // 
            // btConsultarVeiculos
            // 
            this.btConsultarVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarVeiculos.Location = new System.Drawing.Point(234, 30);
            this.btConsultarVeiculos.Name = "btConsultarVeiculos";
            this.btConsultarVeiculos.Size = new System.Drawing.Size(222, 45);
            this.btConsultarVeiculos.TabIndex = 2;
            this.btConsultarVeiculos.Text = "Consultar Veículo";
            this.btConsultarVeiculos.UseVisualStyleBackColor = true;
            this.btConsultarVeiculos.Click += new System.EventHandler(this.btConsultarVeiculos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btListarClientes);
            this.groupBox2.Controls.Add(this.btConsultarCliente);
            this.groupBox2.Controls.Add(this.btCadastrarCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // btListarClientes
            // 
            this.btListarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarClientes.Location = new System.Drawing.Point(462, 30);
            this.btListarClientes.Name = "btListarClientes";
            this.btListarClientes.Size = new System.Drawing.Size(222, 45);
            this.btListarClientes.TabIndex = 2;
            this.btListarClientes.Text = "Listar Clientes";
            this.btListarClientes.UseVisualStyleBackColor = true;
            this.btListarClientes.Click += new System.EventHandler(this.btListarClientes_Click);
            // 
            // btConsultarCliente
            // 
            this.btConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarCliente.Location = new System.Drawing.Point(234, 30);
            this.btConsultarCliente.Name = "btConsultarCliente";
            this.btConsultarCliente.Size = new System.Drawing.Size(222, 45);
            this.btConsultarCliente.TabIndex = 1;
            this.btConsultarCliente.Text = "Consultar Cliente";
            this.btConsultarCliente.UseVisualStyleBackColor = true;
            this.btConsultarCliente.Click += new System.EventHandler(this.btConsultarCliente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btListarVendas);
            this.groupBox3.Controls.Add(this.btConsultarVendas);
            this.groupBox3.Controls.Add(this.btRealizarVenda);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 84);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas";
            // 
            // btListarVendas
            // 
            this.btListarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarVendas.Location = new System.Drawing.Point(462, 30);
            this.btListarVendas.Name = "btListarVendas";
            this.btListarVendas.Size = new System.Drawing.Size(222, 45);
            this.btListarVendas.TabIndex = 5;
            this.btListarVendas.Text = "Listar Vendas";
            this.btListarVendas.UseVisualStyleBackColor = true;
            this.btListarVendas.Click += new System.EventHandler(this.btListarVendas_Click);
            // 
            // btConsultarVendas
            // 
            this.btConsultarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarVendas.Location = new System.Drawing.Point(234, 30);
            this.btConsultarVendas.Name = "btConsultarVendas";
            this.btConsultarVendas.Size = new System.Drawing.Size(222, 45);
            this.btConsultarVendas.TabIndex = 3;
            this.btConsultarVendas.Text = "Consultar Vendas";
            this.btConsultarVendas.UseVisualStyleBackColor = true;
            this.btConsultarVendas.Click += new System.EventHandler(this.btConsultarVendas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 291);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Veículos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarVeiculo;
        private System.Windows.Forms.Button btCadastrarCliente;
        private System.Windows.Forms.Button btRealizarVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btConsultarCliente;
        private System.Windows.Forms.Button btConsultarVeiculos;
        private System.Windows.Forms.Button btConsultarVendas;
        private System.Windows.Forms.Button btListarVeiculos;
        private System.Windows.Forms.Button btListarClientes;
        private System.Windows.Forms.Button btListarVendas;
    }
}

