namespace FormCadastroArquivo.Formularios
{
    partial class FormListarVeiculos
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
            this.dgvVeiculo = new System.Windows.Forms.DataGridView();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.btCadastrarVeiculo = new System.Windows.Forms.Button();
            this.btConsultarPorPlaca = new System.Windows.Forms.Button();
            this.bsVeiculo = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVeiculo
            // 
            this.dgvVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculo.Location = new System.Drawing.Point(13, 95);
            this.dgvVeiculo.Name = "dgvVeiculo";
            this.dgvVeiculo.RowHeadersWidth = 51;
            this.dgvVeiculo.Size = new System.Drawing.Size(619, 287);
            this.dgvVeiculo.TabIndex = 0;
            // 
            // cbModelo
            // 
            this.cbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(13, 13);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(619, 33);
            this.cbModelo.TabIndex = 1;
            // 
            // btCadastrarVeiculo
            // 
            this.btCadastrarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVeiculo.Location = new System.Drawing.Point(443, 388);
            this.btCadastrarVeiculo.Name = "btCadastrarVeiculo";
            this.btCadastrarVeiculo.Size = new System.Drawing.Size(188, 42);
            this.btCadastrarVeiculo.TabIndex = 2;
            this.btCadastrarVeiculo.Text = "CADASTRAR";
            this.btCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btCadastrarVeiculo.Click += new System.EventHandler(this.btCadastrarVeiculo_Click);
            // 
            // btConsultarPorPlaca
            // 
            this.btConsultarPorPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarPorPlaca.Location = new System.Drawing.Point(152, 388);
            this.btConsultarPorPlaca.Name = "btConsultarPorPlaca";
            this.btConsultarPorPlaca.Size = new System.Drawing.Size(285, 42);
            this.btConsultarPorPlaca.TabIndex = 3;
            this.btConsultarPorPlaca.Text = "CONSULTA POR PLACA";
            this.btConsultarPorPlaca.UseVisualStyleBackColor = true;
            this.btConsultarPorPlaca.Click += new System.EventHandler(this.btConsultarPorPlaca_Click);
            // 
            // FormListarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 442);
            this.Controls.Add(this.btConsultarPorPlaca);
            this.Controls.Add(this.btCadastrarVeiculo);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.dgvVeiculo);
            this.Name = "FormListarVeiculos";
            this.Text = "$$$$ LISTA DE VEÍCULOS $$$$";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeiculo;
        private System.Windows.Forms.BindingSource bsVeiculo;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Button btCadastrarVeiculo;
        private System.Windows.Forms.Button btConsultarPorPlaca;
    }
}