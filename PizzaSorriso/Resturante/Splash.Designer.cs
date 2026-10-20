namespace Resturante
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.faixaTopo = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.descicao = new System.Windows.Forms.Label();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.loading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // faixaTopo
            // 
            this.faixaTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.faixaTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.faixaTopo.Location = new System.Drawing.Point(0, 0);
            this.faixaTopo.Name = "faixaTopo";
            this.faixaTopo.Size = new System.Drawing.Size(520, 8);
            this.faixaTopo.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Segoe Script", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(0, 58);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(520, 72);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Pizzaria Sorriso";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titulo.Click += new System.EventHandler(this.Splash_Click);
            // 
            // descicao
            // 
            this.descicao.BackColor = System.Drawing.Color.Transparent;
            this.descicao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.descicao.Location = new System.Drawing.Point(0, 132);
            this.descicao.Name = "descicao";
            this.descicao.Size = new System.Drawing.Size(520, 30);
            this.descicao.TabIndex = 2;
            this.descicao.Text = "Sistema de Pedidos";
            this.descicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descicao.Click += new System.EventHandler(this.Splash_Click);
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(60, 200);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(400, 18);
            this.progresso.TabIndex = 3;
            this.progresso.Click += new System.EventHandler(this.Splash_Click);
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.loading.Location = new System.Drawing.Point(0, 226);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(520, 20);
            this.loading.TabIndex = 4;
            this.loading.Text = "Carregando...";
            this.loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loading.Click += new System.EventHandler(this.Splash_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(0, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "v1.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Splash_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.descicao);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.faixaTopo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::Resturante.Properties.Resources.logo;
            this.Name = "Splash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Click += new System.EventHandler(this.Splash_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel faixaTopo;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label descicao;
        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}
