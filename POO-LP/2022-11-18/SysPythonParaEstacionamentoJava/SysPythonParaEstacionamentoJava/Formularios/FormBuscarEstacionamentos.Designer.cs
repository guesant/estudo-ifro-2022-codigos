namespace SysPythonParaEstacionamentoJava.Formularios
{
    partial class FormBuscarEstacionamentos
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
            this.dgvEstacionamentos = new System.Windows.Forms.DataGridView();
            this.bsEstacionamentos = new System.Windows.Forms.BindingSource(this.components);
            this.cbVaga = new System.Windows.Forms.ComboBox();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.bsVeiculos = new System.Windows.Forms.BindingSource(this.components);
            this.bsVagas = new System.Windows.Forms.BindingSource(this.components);
            this.bsSituacao = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstacionamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSituacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstacionamentos
            // 
            this.dgvEstacionamentos.AllowUserToAddRows = false;
            this.dgvEstacionamentos.AllowUserToDeleteRows = false;
            this.dgvEstacionamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstacionamentos.Location = new System.Drawing.Point(12, 116);
            this.dgvEstacionamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEstacionamentos.Name = "dgvEstacionamentos";
            this.dgvEstacionamentos.ReadOnly = true;
            this.dgvEstacionamentos.RowHeadersWidth = 51;
            this.dgvEstacionamentos.RowTemplate.Height = 24;
            this.dgvEstacionamentos.Size = new System.Drawing.Size(957, 302);
            this.dgvEstacionamentos.TabIndex = 0;
            this.dgvEstacionamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstacionamentos_CellDoubleClick);
            // 
            // cbVaga
            // 
            this.cbVaga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVaga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaga.FormattingEnabled = true;
            this.cbVaga.Location = new System.Drawing.Point(293, 59);
            this.cbVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVaga.Name = "cbVaga";
            this.cbVaga.Size = new System.Drawing.Size(163, 28);
            this.cbVaga.TabIndex = 33;
            this.cbVaga.SelectedIndexChanged += new System.EventHandler(this.cbVaga_SelectedIndexChanged);
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(13, 59);
            this.cbVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(272, 28);
            this.cbVeiculo.TabIndex = 32;
            this.cbVeiculo.SelectedIndexChanged += new System.EventHandler(this.cbVeiculo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Vaga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Veículo:";
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(744, 25);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(225, 64);
            this.btLimpar.TabIndex = 36;
            this.btLimpar.Text = "Limpar Formulário";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FormBuscarEstacionamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 432);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.cbVaga);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEstacionamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarEstacionamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Estacionamentos | SysPython";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstacionamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSituacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstacionamentos;
        private System.Windows.Forms.BindingSource bsEstacionamentos;
        private System.Windows.Forms.ComboBox cbVaga;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.BindingSource bsVeiculos;
        private System.Windows.Forms.BindingSource bsVagas;
        private System.Windows.Forms.BindingSource bsSituacao;
    }
}