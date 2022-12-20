namespace AppEventosTempo.Formularios
{
    partial class FormEstacionamento
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
            this.btEntrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edTempo = new System.Windows.Forms.TextBox();
            this.edValorTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btEntrar
            // 
            this.btEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.Location = new System.Drawing.Point(109, 101);
            this.btEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btEntrar.Size = new System.Drawing.Size(391, 59);
            this.btEntrar.TabIndex = 1;
            this.btEntrar.Text = "ENTRAR";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(109, 336);
            this.btSair.Margin = new System.Windows.Forms.Padding(4);
            this.btSair.Name = "btSair";
            this.btSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSair.Size = new System.Drawing.Size(391, 59);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEMPO ESTACIONADO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTempo
            // 
            this.edTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edTempo.Location = new System.Drawing.Point(608, 192);
            this.edTempo.Name = "edTempo";
            this.edTempo.ReadOnly = true;
            this.edTempo.Size = new System.Drawing.Size(280, 38);
            this.edTempo.TabIndex = 4;
            this.edTempo.Text = "0s";
            this.edTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edValorTotal
            // 
            this.edValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edValorTotal.Location = new System.Drawing.Point(608, 312);
            this.edValorTotal.Name = "edValorTotal";
            this.edValorTotal.ReadOnly = true;
            this.edValorTotal.Size = new System.Drawing.Size(280, 38);
            this.edValorTotal.TabIndex = 6;
            this.edValorTotal.Text = "R$ 0,00";
            this.edValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "VALOR A PAGAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // FormEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.edValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEntrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEstacionamento";
            this.Text = "FormEstacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edTempo;
        private System.Windows.Forms.TextBox edValorTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer clock;
    }
}