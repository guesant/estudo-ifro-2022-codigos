namespace AppRegistroVeiculo.Formularios
{
    partial class FormConsultarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.dtTabela = new System.Windows.Forms.DataGridView();
            this.btNovaConsulta = new System.Windows.Forms.Button();
            this.bsResultados = new System.Windows.Forms.BindingSource(this.components);
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECIONE O CLIENTE (CPF):";
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(12, 59);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(338, 28);
            this.cbCliente.TabIndex = 4;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // dtTabela
            // 
            this.dtTabela.AllowUserToAddRows = false;
            this.dtTabela.AllowUserToDeleteRows = false;
            this.dtTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTabela.Location = new System.Drawing.Point(12, 108);
            this.dtTabela.Name = "dtTabela";
            this.dtTabela.ReadOnly = true;
            this.dtTabela.Size = new System.Drawing.Size(582, 323);
            this.dtTabela.TabIndex = 3;
            // 
            // btNovaConsulta
            // 
            this.btNovaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaConsulta.Location = new System.Drawing.Point(412, 28);
            this.btNovaConsulta.Name = "btNovaConsulta";
            this.btNovaConsulta.Size = new System.Drawing.Size(182, 59);
            this.btNovaConsulta.TabIndex = 6;
            this.btNovaConsulta.Text = "NOVA CONSULTA";
            this.btNovaConsulta.UseVisualStyleBackColor = true;
            this.btNovaConsulta.Click += new System.EventHandler(this.btNovaConsulta_Click);
            // 
            // FormConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 443);
            this.Controls.Add(this.btNovaConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.dtTabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DataGridView dtTabela;
        private System.Windows.Forms.Button btNovaConsulta;
        private System.Windows.Forms.BindingSource bsResultados;
        private System.Windows.Forms.BindingSource bsClientes;
    }
}