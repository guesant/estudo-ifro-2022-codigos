namespace AppHotel.Formularios
{
    partial class FormListarQuartos
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
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.bsQuartos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartos.Location = new System.Drawing.Point(12, 12);
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.RowHeadersWidth = 51;
            this.dgvQuartos.RowTemplate.Height = 24;
            this.dgvQuartos.Size = new System.Drawing.Size(776, 331);
            this.dgvQuartos.TabIndex = 0;
            // 
            // FormListarQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.dgvQuartos);
            this.MaximizeBox = false;
            this.Name = "FormListarQuartos";
            this.Text = "Listar Quartos | App Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuartos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.BindingSource bsQuartos;
    }
}