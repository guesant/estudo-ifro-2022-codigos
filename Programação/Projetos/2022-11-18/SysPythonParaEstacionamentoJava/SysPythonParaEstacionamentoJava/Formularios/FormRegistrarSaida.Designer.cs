namespace SysPythonParaEstacionamentoJava.Formularios
{
    partial class FormRegistrarSaida
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
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataDeSaidaTempo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDeSaidaDia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.bsVeiculos = new System.Windows.Forms.BindingSource(this.components);
            this.bsEstacionamentos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstacionamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(23, 54);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(390, 28);
            this.cbVeiculo.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Veículo:";
            // 
            // dtpDataDeSaidaTempo
            // 
            this.dtpDataDeSaidaTempo.CustomFormat = "";
            this.dtpDataDeSaidaTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeSaidaTempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDataDeSaidaTempo.Location = new System.Drawing.Point(300, 136);
            this.dtpDataDeSaidaTempo.Name = "dtpDataDeSaidaTempo";
            this.dtpDataDeSaidaTempo.ShowUpDown = true;
            this.dtpDataDeSaidaTempo.Size = new System.Drawing.Size(113, 26);
            this.dtpDataDeSaidaTempo.TabIndex = 63;
            // 
            // dtpDataDeSaidaDia
            // 
            this.dtpDataDeSaidaDia.CustomFormat = "";
            this.dtpDataDeSaidaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeSaidaDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeSaidaDia.Location = new System.Drawing.Point(23, 136);
            this.dtpDataDeSaidaDia.Name = "dtpDataDeSaidaDia";
            this.dtpDataDeSaidaDia.Size = new System.Drawing.Size(271, 26);
            this.dtpDataDeSaidaDia.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Momento de Saída:";
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(313, 187);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(99, 46);
            this.btSalvar.TabIndex = 66;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(168, 187);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 46);
            this.btCancelar.TabIndex = 65;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(23, 187);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(99, 46);
            this.btAdd.TabIndex = 64;
            this.btAdd.Text = "Add+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // FormRegistrarSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtpDataDeSaidaTempo);
            this.Controls.Add(this.dtpDataDeSaidaDia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Saída | SysPython";
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstacionamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataDeSaidaTempo;
        private System.Windows.Forms.DateTimePicker dtpDataDeSaidaDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.BindingSource bsVeiculos;
        private System.Windows.Forms.BindingSource bsEstacionamentos;
    }
}