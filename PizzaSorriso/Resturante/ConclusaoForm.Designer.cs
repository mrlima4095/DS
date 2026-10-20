namespace Resturante
{
    partial class ConclusaoForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(456, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pedido concluído! Obrigado pela preferência!";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRecibo
            // 
            this.txtRecibo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtRecibo.Location = new System.Drawing.Point(12, 50);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.ReadOnly = true;
            this.txtRecibo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecibo.Size = new System.Drawing.Size(456, 403);
            this.txtRecibo.TabIndex = 1;
            // 
            // lblPergunta
            // 
            this.lblPergunta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPergunta.Location = new System.Drawing.Point(13, 470);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(215, 24);
            this.lblPergunta.TabIndex = 2;
            this.lblPergunta.Text = "Deseja fazer um novo pedido?";
            // 
            // btnSim
            // 
            this.btnSim.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSim.Location = new System.Drawing.Point(248, 470);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(100, 32);
            this.btnSim.TabIndex = 3;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            // 
            // btnNao
            // 
            this.btnNao.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNao.Location = new System.Drawing.Point(368, 470);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(100, 32);
            this.btnNao.TabIndex = 4;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            // 
            // ConclusaoForm
            // 
            this.AcceptButton = this.btnSim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNao;
            this.ClientSize = new System.Drawing.Size(480, 520);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Resturante.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConclusaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedido concluído";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
    }
}
