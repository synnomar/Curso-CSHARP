namespace MyApplication
{
    partial class Login
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
            this.Lb1 = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Lb3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.Btt01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(156, 81);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(153, 25);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "Pagina de Login";
            this.Lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.Location = new System.Drawing.Point(104, 129);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(57, 17);
            this.Lb2.TabIndex = 1;
            this.Lb2.Text = "Usuario";
            this.Lb2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(161, 126);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 25);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lb3
            // 
            this.Lb3.AutoSize = true;
            this.Lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb3.Location = new System.Drawing.Point(104, 160);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(49, 17);
            this.Lb3.TabIndex = 3;
            this.Lb3.Text = "Senha";
            this.Lb3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(161, 160);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(148, 23);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // Btt01
            // 
            this.Btt01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btt01.Location = new System.Drawing.Point(196, 207);
            this.Btt01.Name = "Btt01";
            this.Btt01.Size = new System.Drawing.Size(75, 23);
            this.Btt01.TabIndex = 5;
            this.Btt01.Text = "Entrar";
            this.Btt01.UseVisualStyleBackColor = true;
            this.Btt01.Click += new System.EventHandler(this.Btt01_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 309);
            this.Controls.Add(this.Btt01);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.Lb3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Lb2);
            this.Controls.Add(this.Lb1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button Btt01;
    }
}

