namespace FormCadastroArquivo.Formularios
{
    partial class FormListarPessoas
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
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            this.btCadastrarVeiculo = new System.Windows.Forms.Button();
            this.bsPessoa = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoa.Location = new System.Drawing.Point(12, 70);
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.RowHeadersWidth = 51;
            this.dgvPessoa.Size = new System.Drawing.Size(575, 276);
            this.dgvPessoa.TabIndex = 0;
            // 
            // btCadastrarVeiculo
            // 
            this.btCadastrarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVeiculo.Location = new System.Drawing.Point(366, 363);
            this.btCadastrarVeiculo.Name = "btCadastrarVeiculo";
            this.btCadastrarVeiculo.Size = new System.Drawing.Size(221, 42);
            this.btCadastrarVeiculo.TabIndex = 3;
            this.btCadastrarVeiculo.Text = "CADASTRAR";
            this.btCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btCadastrarVeiculo.Click += new System.EventHandler(this.btCadastrarVeiculo_Click);
            // 
            // FormListarPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 422);
            this.Controls.Add(this.btCadastrarVeiculo);
            this.Controls.Add(this.dgvPessoa);
            this.Name = "FormListarPessoas";
            this.Text = "$$$$ LISTAR PESSOAS $$$$";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsPessoa;
        private System.Windows.Forms.DataGridView dgvPessoa;
        private System.Windows.Forms.Button btCadastrarVeiculo;
    }
}