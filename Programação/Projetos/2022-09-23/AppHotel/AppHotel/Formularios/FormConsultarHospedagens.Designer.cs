namespace AppHotel.Formularios
{
    partial class FormConsultarHospedagens
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
            this.dgvHospedagens = new System.Windows.Forms.DataGridView();
            this.bsHospedagens = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospedagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHospedagens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHospedagens
            // 
            this.dgvHospedagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospedagens.Location = new System.Drawing.Point(12, 12);
            this.dgvHospedagens.Name = "dgvHospedagens";
            this.dgvHospedagens.RowHeadersWidth = 51;
            this.dgvHospedagens.RowTemplate.Height = 24;
            this.dgvHospedagens.Size = new System.Drawing.Size(776, 426);
            this.dgvHospedagens.TabIndex = 0;
            // 
            // FormConsultarHospedagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHospedagens);
            this.Name = "FormConsultarHospedagens";
            this.Text = "Consultar Hospedagens | App Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospedagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHospedagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHospedagens;
        private System.Windows.Forms.BindingSource bsHospedagens;
    }
}