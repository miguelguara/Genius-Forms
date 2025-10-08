namespace Jogo_Genius
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btVerde = new System.Windows.Forms.Button();
            this.btAmarelo = new System.Windows.Forms.Button();
            this.btVermelho = new System.Windows.Forms.Button();
            this.btAzul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNivel = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btVerde
            // 
            this.btVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerde.Location = new System.Drawing.Point(61, 49);
            this.btVerde.Name = "btVerde";
            this.btVerde.Size = new System.Drawing.Size(97, 97);
            this.btVerde.TabIndex = 0;
            this.btVerde.UseVisualStyleBackColor = true;
            this.btVerde.Click += new System.EventHandler(this.bt_Click);
            // 
            // btAmarelo
            // 
            this.btAmarelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAmarelo.Location = new System.Drawing.Point(181, 49);
            this.btAmarelo.Name = "btAmarelo";
            this.btAmarelo.Size = new System.Drawing.Size(97, 97);
            this.btAmarelo.TabIndex = 1;
            this.btAmarelo.UseVisualStyleBackColor = true;
            this.btAmarelo.Click += new System.EventHandler(this.bt_Click);
            // 
            // btVermelho
            // 
            this.btVermelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVermelho.Location = new System.Drawing.Point(61, 162);
            this.btVermelho.Name = "btVermelho";
            this.btVermelho.Size = new System.Drawing.Size(97, 97);
            this.btVermelho.TabIndex = 2;
            this.btVermelho.UseVisualStyleBackColor = true;
            this.btVermelho.Click += new System.EventHandler(this.bt_Click);
            // 
            // btAzul
            // 
            this.btAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAzul.Location = new System.Drawing.Point(181, 162);
            this.btAzul.Name = "btAzul";
            this.btAzul.Size = new System.Drawing.Size(97, 97);
            this.btAzul.TabIndex = 3;
            this.btAzul.UseVisualStyleBackColor = true;
            this.btAzul.Click += new System.EventHandler(this.bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nível:";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivel.Location = new System.Drawing.Point(139, 282);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(0, 17);
            this.lbNivel.TabIndex = 5;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(116, 319);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(97, 60);
            this.btIniciar.TabIndex = 6;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 409);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAzul);
            this.Controls.Add(this.btVermelho);
            this.Controls.Add(this.btAmarelo);
            this.Controls.Add(this.btVerde);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVerde;
        private System.Windows.Forms.Button btAmarelo;
        private System.Windows.Forms.Button btVermelho;
        private System.Windows.Forms.Button btAzul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Timer timer1;
    }
}

