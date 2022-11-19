namespace SysPythonParaEstacionamentoJava.Formularios
{
    partial class ListarVeiculo
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
            this.dgvListaVeiculos = new System.Windows.Forms.DataGridView();
            this.bsVeiculos = new System.Windows.Forms.BindingSource(this.components);
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bsResultados = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVeiculos
            // 
            this.dgvListaVeiculos.AllowUserToAddRows = false;
            this.dgvListaVeiculos.AllowUserToDeleteRows = false;
            this.dgvListaVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVeiculos.Location = new System.Drawing.Point(19, 122);
            this.dgvListaVeiculos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaVeiculos.Name = "dgvListaVeiculos";
            this.dgvListaVeiculos.ReadOnly = true;
            this.dgvListaVeiculos.RowHeadersWidth = 51;
            this.dgvListaVeiculos.Size = new System.Drawing.Size(765, 313);
            this.dgvListaVeiculos.TabIndex = 0;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(559, 22);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(225, 64);
            this.btLimpar.TabIndex = 41;
            this.btLimpar.Text = "Limpar Formulário";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // cbPlaca
            // 
            this.cbPlaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPlaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(19, 56);
            this.cbPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(272, 28);
            this.cbPlaca.TabIndex = 39;
            this.cbPlaca.SelectedIndexChanged += new System.EventHandler(this.cbPlaca_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Placa:";
            // 
            // ListarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 456);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.cbPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListaVeiculos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Veículos | SysPython";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVeiculos;
        private System.Windows.Forms.BindingSource bsVeiculos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsResultados;
    }
}