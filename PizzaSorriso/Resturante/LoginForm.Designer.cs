namespace Resturante
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpSobre = new System.Windows.Forms.GroupBox();
            this.lblSobre = new System.Windows.Forms.Label();
            this.grpEntrar = new System.Windows.Forms.GroupBox();
            this.btnConvidado = new System.Windows.Forms.Button();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRodape = new System.Windows.Forms.Label();
            this.grpSobre.SuspendLayout();
            this.grpEntrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 17);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pizzaria Sorriso";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 71);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(800, 27);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Sistema de Pedidos";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSobre
            // 
            this.grpSobre.Controls.Add(this.lblSobre);
            this.grpSobre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSobre.Location = new System.Drawing.Point(32, 111);
            this.grpSobre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSobre.Name = "grpSobre";
            this.grpSobre.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSobre.Size = new System.Drawing.Size(736, 192);
            this.grpSobre.TabIndex = 2;
            this.grpSobre.TabStop = false;
            this.grpSobre.Text = "Sobre a pizzaria";
            // 
            // lblSobre
            // 
            this.lblSobre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(21, 32);
            this.lblSobre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(693, 145);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = resources.GetString("lblSobre.Text");
            // 
            // grpEntrar
            // 
            this.grpEntrar.Controls.Add(this.btnConvidado);
            this.grpEntrar.Controls.Add(this.btnCriarConta);
            this.grpEntrar.Controls.Add(this.btnEntrar);
            this.grpEntrar.Controls.Add(this.txtCpf);
            this.grpEntrar.Controls.Add(this.lblCpf);
            this.grpEntrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrar.Location = new System.Drawing.Point(32, 318);
            this.grpEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEntrar.Name = "grpEntrar";
            this.grpEntrar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEntrar.Size = new System.Drawing.Size(736, 175);
            this.grpEntrar.TabIndex = 3;
            this.grpEntrar.TabStop = false;
            this.grpEntrar.Text = "Entrar ou criar conta";
            // 
            // btnConvidado
            // 
            this.btnConvidado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvidado.Location = new System.Drawing.Point(379, 103);
            this.btnConvidado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvidado.Name = "btnConvidado";
            this.btnConvidado.Size = new System.Drawing.Size(320, 42);
            this.btnConvidado.TabIndex = 4;
            this.btnConvidado.Text = "Entrar como convidado";
            this.btnConvidado.UseVisualStyleBackColor = true;
            this.btnConvidado.Click += new System.EventHandler(this.btnConvidado_Click);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(27, 103);
            this.btnCriarConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(320, 42);
            this.btnCriarConta.TabIndex = 3;
            this.btnCriarConta.Text = "Criar conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(539, 40);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(160, 37);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(91, 44);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCpf.MaxLength = 14;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(426, 29);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(27, 48);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(43, 23);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF:";
            // 
            // lblRodape
            // 
            this.lblRodape.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblRodape.Location = new System.Drawing.Point(32, 502);
            this.lblRodape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(736, 54);
            this.lblRodape.TabIndex = 4;
            this.lblRodape.Text = "Para entrar, informe o CPF usado no cadastro. Se preferir não se cadastrar, entre" +
    " como convidado e informe o nome na hora de fechar o pedido.";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.grpEntrar);
            this.Controls.Add(this.grpSobre);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Resturante.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzaria Sorriso - Entrar";
            this.grpSobre.ResumeLayout(false);
            this.grpEntrar.ResumeLayout(false);
            this.grpEntrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpSobre;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.GroupBox grpEntrar;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnConvidado;
        private System.Windows.Forms.Label lblRodape;
    }
}
