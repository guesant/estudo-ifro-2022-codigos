namespace SysPythonParaEstacionamentoJava.Formularios
{
    partial class FormFerramentasAdministrativas
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btDebugLimparDados = new System.Windows.Forms.Button();
            this.btDebugAbrirPastaExecutavel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btDebugLimparDados);
            this.groupBox3.Controls.Add(this.btDebugAbrirPastaExecutavel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 194);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debug";
            // 
            // btDebugLimparDados
            // 
            this.btDebugLimparDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDebugLimparDados.Location = new System.Drawing.Point(13, 116);
            this.btDebugLimparDados.Name = "btDebugLimparDados";
            this.btDebugLimparDados.Size = new System.Drawing.Size(403, 60);
            this.btDebugLimparDados.TabIndex = 4;
            this.btDebugLimparDados.Text = "Limpar Dados - Tenha Cuidado!";
            this.btDebugLimparDados.UseVisualStyleBackColor = true;
            this.btDebugLimparDados.Click += new System.EventHandler(this.btDebugLimparDados_Click);
            // 
            // btDebugAbrirPastaExecutavel
            // 
            this.btDebugAbrirPastaExecutavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDebugAbrirPastaExecutavel.Location = new System.Drawing.Point(13, 42);
            this.btDebugAbrirPastaExecutavel.Name = "btDebugAbrirPastaExecutavel";
            this.btDebugAbrirPastaExecutavel.Size = new System.Drawing.Size(403, 60);
            this.btDebugAbrirPastaExecutavel.TabIndex = 3;
            this.btDebugAbrirPastaExecutavel.Text = "Abrir Pasta de Execução";
            this.btDebugAbrirPastaExecutavel.UseVisualStyleBackColor = true;
            this.btDebugAbrirPastaExecutavel.Click += new System.EventHandler(this.btDebugAbrirPastaExecutavel_Click);
            // 
            // FerramentasAdministrativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 218);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FerramentasAdministrativas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramentas Administrativas | SysPython";
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btDebugLimparDados;
        private System.Windows.Forms.Button btDebugAbrirPastaExecutavel;
    }
}