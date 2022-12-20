namespace SysPythonParaEstacionamentoJava.Formularios
{
    partial class FormConsultarEstacionamento
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
            this.cbVaga = new System.Windows.Forms.ComboBox();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDeletar = new System.Windows.Forms.Button();
            this.edTotalMinutos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edValorTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bsVeiculos = new System.Windows.Forms.BindingSource(this.components);
            this.bsVagas = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataDeSaidaTempo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDeSaidaDia = new System.Windows.Forms.DateTimePicker();
            this.cbDataDeSaida = new System.Windows.Forms.CheckBox();
            this.dtpDataDeEntradaTempo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataDeEntradaDia = new System.Windows.Forms.DateTimePicker();
            this.edValorMinuto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVaga
            // 
            this.cbVaga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVaga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVaga.Enabled = false;
            this.cbVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaga.FormattingEnabled = true;
            this.cbVaga.Location = new System.Drawing.Point(32, 196);
            this.cbVaga.Name = "cbVaga";
            this.cbVaga.Size = new System.Drawing.Size(355, 28);
            this.cbVaga.TabIndex = 41;
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVeiculo.Enabled = false;
            this.cbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(32, 121);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(355, 28);
            this.cbVeiculo.TabIndex = 40;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(304, 457);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(81, 46);
            this.btSalvar.TabIndex = 39;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(208, 457);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 46);
            this.btCancelar.TabIndex = 38;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(119, 457);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(81, 46);
            this.btAdd.TabIndex = 37;
            this.btAdd.Text = "Editar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Vaga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Veículo:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Consultar Estacionamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDeletar
            // 
            this.btDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.Location = new System.Drawing.Point(31, 457);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(81, 46);
            this.btDeletar.TabIndex = 43;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // edTotalHoras
            // 
            this.edTotalMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edTotalMinutos.Location = new System.Drawing.Point(401, 122);
            this.edTotalMinutos.Name = "edTotalHoras";
            this.edTotalMinutos.ReadOnly = true;
            this.edTotalMinutos.Size = new System.Drawing.Size(223, 26);
            this.edTotalMinutos.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Total de minutos:";
            // 
            // edValorTotal
            // 
            this.edValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edValorTotal.Location = new System.Drawing.Point(401, 187);
            this.edValorTotal.Name = "edValorTotal";
            this.edValorTotal.ReadOnly = true;
            this.edValorTotal.Size = new System.Drawing.Size(223, 26);
            this.edValorTotal.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(401, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "R$ Total:";
            // 
            // dtpDataDeSaidaTempo
            // 
            this.dtpDataDeSaidaTempo.CustomFormat = "";
            this.dtpDataDeSaidaTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeSaidaTempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDataDeSaidaTempo.Location = new System.Drawing.Point(256, 410);
            this.dtpDataDeSaidaTempo.Name = "dtpDataDeSaidaTempo";
            this.dtpDataDeSaidaTempo.ShowUpDown = true;
            this.dtpDataDeSaidaTempo.Size = new System.Drawing.Size(113, 26);
            this.dtpDataDeSaidaTempo.TabIndex = 60;
            // 
            // dtpDataDeSaidaDia
            // 
            this.dtpDataDeSaidaDia.CustomFormat = "";
            this.dtpDataDeSaidaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeSaidaDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeSaidaDia.Location = new System.Drawing.Point(54, 410);
            this.dtpDataDeSaidaDia.Name = "dtpDataDeSaidaDia";
            this.dtpDataDeSaidaDia.Size = new System.Drawing.Size(196, 26);
            this.dtpDataDeSaidaDia.TabIndex = 59;
            // 
            // cbDataDeSaida
            // 
            this.cbDataDeSaida.AutoSize = true;
            this.cbDataDeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataDeSaida.Location = new System.Drawing.Point(33, 416);
            this.cbDataDeSaida.Name = "cbDataDeSaida";
            this.cbDataDeSaida.Size = new System.Drawing.Size(15, 14);
            this.cbDataDeSaida.TabIndex = 58;
            this.cbDataDeSaida.UseVisualStyleBackColor = true;
            this.cbDataDeSaida.CheckedChanged += new System.EventHandler(this.cbDataDeSaida_CheckedChanged);
            // 
            // dtpDataDeEntradaTempo
            // 
            this.dtpDataDeEntradaTempo.CustomFormat = "";
            this.dtpDataDeEntradaTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeEntradaTempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDataDeEntradaTempo.Location = new System.Drawing.Point(256, 273);
            this.dtpDataDeEntradaTempo.Name = "dtpDataDeEntradaTempo";
            this.dtpDataDeEntradaTempo.ShowUpDown = true;
            this.dtpDataDeEntradaTempo.Size = new System.Drawing.Size(113, 26);
            this.dtpDataDeEntradaTempo.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Momento de Saída:";
            // 
            // dtpDataDeEntradaDia
            // 
            this.dtpDataDeEntradaDia.CustomFormat = "";
            this.dtpDataDeEntradaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeEntradaDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeEntradaDia.Location = new System.Drawing.Point(33, 273);
            this.dtpDataDeEntradaDia.Name = "dtpDataDeEntradaDia";
            this.dtpDataDeEntradaDia.Size = new System.Drawing.Size(216, 26);
            this.dtpDataDeEntradaDia.TabIndex = 55;
            // 
            // edValorHora
            // 
            this.edValorMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edValorMinuto.Location = new System.Drawing.Point(33, 336);
            this.edValorMinuto.Name = "edValorHora";
            this.edValorMinuto.Size = new System.Drawing.Size(336, 26);
            this.edValorMinuto.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "R$ / Minuto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Momento de Entrada:";
            // 
            // FormConsultarEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 531);
            this.Controls.Add(this.dtpDataDeSaidaTempo);
            this.Controls.Add(this.dtpDataDeSaidaDia);
            this.Controls.Add(this.cbDataDeSaida);
            this.Controls.Add(this.dtpDataDeEntradaTempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataDeEntradaDia);
            this.Controls.Add(this.edValorMinuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edValorTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.edTotalMinutos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.cbVaga);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultarEstacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Estacionamento | SysPython";
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbVaga;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.TextBox edTotalMinutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edValorTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bsVeiculos;
        private System.Windows.Forms.BindingSource bsVagas;
        private System.Windows.Forms.DateTimePicker dtpDataDeSaidaTempo;
        private System.Windows.Forms.DateTimePicker dtpDataDeSaidaDia;
        private System.Windows.Forms.CheckBox cbDataDeSaida;
        private System.Windows.Forms.DateTimePicker dtpDataDeEntradaTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataDeEntradaDia;
        private System.Windows.Forms.TextBox edValorMinuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}