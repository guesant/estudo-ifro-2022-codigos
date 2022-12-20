namespace AppRegistroVeiculo.Formularios
{
    partial class FormConsultarVeiculo
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
            this.bsResultados = new System.Windows.Forms.BindingSource(this.components);
            this.bsVeiculo = new System.Windows.Forms.BindingSource(this.components);
            this.btNovaConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.dtTabela = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // btNovaConsulta
            // 
            this.btNovaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaConsulta.Location = new System.Drawing.Point(413, 18);
            this.btNovaConsulta.Name = "btNovaConsulta";
            this.btNovaConsulta.Size = new System.Drawing.Size(182, 59);
            this.btNovaConsulta.TabIndex = 10;
            this.btNovaConsulta.Text = "NOVA CONSULTA";
            this.btNovaConsulta.UseVisualStyleBackColor = true;
            this.btNovaConsulta.Click += new System.EventHandler(this.btNovaConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "SELECIONE O VEÍCULO (PLACA):";
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(13, 49);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(338, 28);
            this.cbVeiculo.TabIndex = 8;
            this.cbVeiculo.SelectedIndexChanged += new System.EventHandler(this.cbVeiculo_SelectedIndexChanged);
            // 
            // dtTabela
            // 
            this.dtTabela.AllowUserToAddRows = false;
            this.dtTabela.AllowUserToDeleteRows = false;
            this.dtTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTabela.Location = new System.Drawing.Point(13, 98);
            this.dtTabela.Name = "dtTabela";
            this.dtTabela.ReadOnly = true;
            this.dtTabela.Size = new System.Drawing.Size(582, 323);
            this.dtTabela.TabIndex = 7;
            // 
            // FormConsultarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 438);
            this.Controls.Add(this.btNovaConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.dtTabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.bsResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsResultados;
        private System.Windows.Forms.BindingSource bsVeiculo;
        private System.Windows.Forms.Button btNovaConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.DataGridView dtTabela;
    }
}