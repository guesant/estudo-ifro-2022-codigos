namespace Avaliacao_3Etapa.Formularios
{
    partial class FormExibirRelatorio
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
            this.dtRelatorio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bsRelatorios = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRelatorio
            // 
            this.dtRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRelatorio.Location = new System.Drawing.Point(21, 62);
            this.dtRelatorio.Name = "dtRelatorio";
            this.dtRelatorio.Size = new System.Drawing.Size(767, 433);
            this.dtRelatorio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "RELATÓRIO DE INFRAÇÕES DO CONDOMÍNIO DELTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormExibirRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtRelatorio);
            this.Name = "FormExibirRelatorio";
            this.Text = "FormExibirRelatorio";
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRelatorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsRelatorios;
    }
}