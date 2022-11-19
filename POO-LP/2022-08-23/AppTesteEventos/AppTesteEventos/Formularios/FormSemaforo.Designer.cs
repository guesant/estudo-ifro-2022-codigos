namespace AppTesteEventos.Formularios
{
    partial class FormSemaforo
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
            this.btVerde = new System.Windows.Forms.Button();
            this.btAmarelo = new System.Windows.Forms.Button();
            this.btVermelho = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btParar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVerde
            // 
            this.btVerde.BackColor = System.Drawing.Color.Gray;
            this.btVerde.Location = new System.Drawing.Point(51, 98);
            this.btVerde.Name = "btVerde";
            this.btVerde.Size = new System.Drawing.Size(159, 216);
            this.btVerde.TabIndex = 0;
            this.btVerde.UseVisualStyleBackColor = false;
            // 
            // btAmarelo
            // 
            this.btAmarelo.BackColor = System.Drawing.Color.Gray;
            this.btAmarelo.Location = new System.Drawing.Point(270, 98);
            this.btAmarelo.Name = "btAmarelo";
            this.btAmarelo.Size = new System.Drawing.Size(159, 216);
            this.btAmarelo.TabIndex = 1;
            this.btAmarelo.UseVisualStyleBackColor = false;
            // 
            // btVermelho
            // 
            this.btVermelho.BackColor = System.Drawing.Color.Gray;
            this.btVermelho.Location = new System.Drawing.Point(510, 98);
            this.btVermelho.Name = "btVermelho";
            this.btVermelho.Size = new System.Drawing.Size(159, 216);
            this.btVermelho.TabIndex = 2;
            this.btVermelho.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(51, 384);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(0, 13);
            this.lblSegundos.TabIndex = 3;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(51, 26);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(302, 47);
            this.btIniciar.TabIndex = 4;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btParar
            // 
            this.btParar.Location = new System.Drawing.Point(367, 26);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(302, 47);
            this.btParar.TabIndex = 5;
            this.btParar.Text = "Parar";
            this.btParar.UseVisualStyleBackColor = true;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // FormSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.btVermelho);
            this.Controls.Add(this.btAmarelo);
            this.Controls.Add(this.btVerde);
            this.Name = "FormSemaforo";
            this.Text = "FormSemaforo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVerde;
        private System.Windows.Forms.Button btAmarelo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btVermelho;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btParar;
    }
}