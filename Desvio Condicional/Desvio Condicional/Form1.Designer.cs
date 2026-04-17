namespace Desvio_Condicional
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desvioCondicionalSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desvioCondicionalCompostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desvioCondicionalEncadeadoifElseifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desvioCondicionalSimplesToolStripMenuItem,
            this.desvioCondicionalCompostoToolStripMenuItem,
            this.desvioCondicionalEncadeadoifElseifToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desvioCondicionalSimplesToolStripMenuItem
            // 
            this.desvioCondicionalSimplesToolStripMenuItem.Name = "desvioCondicionalSimplesToolStripMenuItem";
            this.desvioCondicionalSimplesToolStripMenuItem.Size = new System.Drawing.Size(183, 20);
            this.desvioCondicionalSimplesToolStripMenuItem.Text = "Desvio Condicional Simples (if)";
            this.desvioCondicionalSimplesToolStripMenuItem.Click += new System.EventHandler(this.desvioCondicionalSimplesToolStripMenuItem_Click);
            // 
            // desvioCondicionalCompostoToolStripMenuItem
            // 
            this.desvioCondicionalCompostoToolStripMenuItem.Name = "desvioCondicionalCompostoToolStripMenuItem";
            this.desvioCondicionalCompostoToolStripMenuItem.Size = new System.Drawing.Size(221, 20);
            this.desvioCondicionalCompostoToolStripMenuItem.Text = "Desvio Condicional Composto (if else)";
            this.desvioCondicionalCompostoToolStripMenuItem.Click += new System.EventHandler(this.desvioCondicionalCompostoToolStripMenuItem_Click);
            // 
            // desvioCondicionalEncadeadoifElseifToolStripMenuItem
            // 
            this.desvioCondicionalEncadeadoifElseifToolStripMenuItem.Name = "desvioCondicionalEncadeadoifElseifToolStripMenuItem";
            this.desvioCondicionalEncadeadoifElseifToolStripMenuItem.Size = new System.Drawing.Size(230, 20);
            this.desvioCondicionalEncadeadoifElseifToolStripMenuItem.Text = "Desvio Condicional Encadeado (if elseif)";
            this.desvioCondicionalEncadeadoifElseifToolStripMenuItem.Click += new System.EventHandler(this.desvioCondicionalEncadeadoifElseifToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Desvio_Condicional.Properties.Resources._4115235_exit_logout_sign_out_1140301;
            this.button2.Location = new System.Drawing.Point(708, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 66);
            this.button2.TabIndex = 7;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalCompostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desvioCondicionalEncadeadoifElseifToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

