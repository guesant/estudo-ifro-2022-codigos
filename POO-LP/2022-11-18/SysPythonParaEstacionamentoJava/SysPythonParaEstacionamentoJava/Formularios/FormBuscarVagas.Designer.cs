namespace SysPythonParaEstacionamentoJava.Formularios
{
    partial class FormBuscarVagas
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
            this.dgvVagas = new System.Windows.Forms.DataGridView();
            this.bsVagas = new System.Windows.Forms.BindingSource(this.components);
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bsSituacoes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSituacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVagas
            // 
            this.dgvVagas.AllowUserToAddRows = false;
            this.dgvVagas.AllowUserToDeleteRows = false;
            this.dgvVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVagas.Location = new System.Drawing.Point(12, 109);
            this.dgvVagas.Name = "dgvVagas";
            this.dgvVagas.ReadOnly = true;
            this.dgvVagas.RowHeadersWidth = 51;
            this.dgvVagas.RowTemplate.Height = 24;
            this.dgvVagas.Size = new System.Drawing.Size(776, 352);
            this.dgvVagas.TabIndex = 0;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(563, 24);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(225, 62);
            this.btLimpar.TabIndex = 39;
            this.btLimpar.Text = "Limpar Formulário";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // cbSituacao
            // 
            this.cbSituacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSituacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(13, 58);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(4);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(163, 28);
            this.cbSituacao.TabIndex = 38;
            this.cbSituacao.SelectedIndexChanged += new System.EventHandler(this.cbSituacao_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Situação:";
            // 
            // FormBuscarVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvVagas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarVagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Vagas | SysPython";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSituacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVagas;
        private System.Windows.Forms.BindingSource bsVagas;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bsSituacoes;
    }
}