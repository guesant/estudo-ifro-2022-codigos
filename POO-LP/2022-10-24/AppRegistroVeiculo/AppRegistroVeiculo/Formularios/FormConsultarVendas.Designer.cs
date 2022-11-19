namespace AppRegistroVeiculo.Formularios
{
    partial class FormConsultarVendas
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
            this.dtTabela = new System.Windows.Forms.DataGridView();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.btBuscarVeiculo = new System.Windows.Forms.Button();
            this.btBuscarClientePlaca = new System.Windows.Forms.Button();
            this.btNovaConsulta = new System.Windows.Forms.Button();
            this.bsResultados = new System.Windows.Forms.BindingSource(this.components);
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bsVeiculos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTabela
            // 
            this.dtTabela.AllowUserToAddRows = false;
            this.dtTabela.AllowUserToDeleteRows = false;
            this.dtTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTabela.Location = new System.Drawing.Point(13, 241);
            this.dtTabela.Name = "dtTabela";
            this.dtTabela.ReadOnly = true;
            this.dtTabela.Size = new System.Drawing.Size(775, 282);
            this.dtTabela.TabIndex = 0;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(203, 54);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(394, 28);
            this.cbCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECIONE O CLIENTE (CPF):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SELECIONE O VEÍCULO (PLACA):";
            // 
            // cbPlaca
            // 
            this.cbVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(203, 134);
            this.cbVeiculo.Name = "cbPlaca";
            this.cbVeiculo.Size = new System.Drawing.Size(394, 28);
            this.cbVeiculo.TabIndex = 3;
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarCliente.Location = new System.Drawing.Point(278, 193);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(243, 28);
            this.btBuscarCliente.TabIndex = 5;
            this.btBuscarCliente.Text = "BUSCAR POR CLIENTE";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
            this.btBuscarCliente.Click += new System.EventHandler(this.btBuscarCliente_Click);
            // 
            // btBuscarVeiculo
            // 
            this.btBuscarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarVeiculo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btBuscarVeiculo.Location = new System.Drawing.Point(12, 193);
            this.btBuscarVeiculo.Name = "btBuscarVeiculo";
            this.btBuscarVeiculo.Size = new System.Drawing.Size(243, 28);
            this.btBuscarVeiculo.TabIndex = 6;
            this.btBuscarVeiculo.Text = "BUSCAR POR VEÍCULO";
            this.btBuscarVeiculo.UseVisualStyleBackColor = true;
            this.btBuscarVeiculo.Click += new System.EventHandler(this.btBuscarVeiculo_Click);
            // 
            // btBuscarClientePlaca
            // 
            this.btBuscarClientePlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarClientePlaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btBuscarClientePlaca.Location = new System.Drawing.Point(544, 193);
            this.btBuscarClientePlaca.Name = "btBuscarClientePlaca";
            this.btBuscarClientePlaca.Size = new System.Drawing.Size(243, 28);
            this.btBuscarClientePlaca.TabIndex = 7;
            this.btBuscarClientePlaca.Text = "BUSCAR CLIENTE/VEÍCULO";
            this.btBuscarClientePlaca.UseVisualStyleBackColor = true;
            this.btBuscarClientePlaca.Click += new System.EventHandler(this.btBuscarClientePlaca_Click);
            // 
            // btNovaConsulta
            // 
            this.btNovaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNovaConsulta.Location = new System.Drawing.Point(575, 529);
            this.btNovaConsulta.Name = "btNovaConsulta";
            this.btNovaConsulta.Size = new System.Drawing.Size(212, 28);
            this.btNovaConsulta.TabIndex = 8;
            this.btNovaConsulta.Text = "NOVA CONSULTA";
            this.btNovaConsulta.UseVisualStyleBackColor = true;
            this.btNovaConsulta.Click += new System.EventHandler(this.btNovaConsulta_Click);
            // 
            // FormConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btNovaConsulta);
            this.Controls.Add(this.btBuscarClientePlaca);
            this.Controls.Add(this.btBuscarVeiculo);
            this.Controls.Add(this.btBuscarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.dtTabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dtTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtTabela;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.Button btBuscarCliente;
        private System.Windows.Forms.Button btBuscarVeiculo;
        private System.Windows.Forms.Button btBuscarClientePlaca;
        private System.Windows.Forms.Button btNovaConsulta;
        private System.Windows.Forms.BindingSource bsResultados;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.BindingSource bsVeiculos;
    }
}