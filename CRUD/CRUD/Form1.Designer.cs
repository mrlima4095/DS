namespace CRUD
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
            this.id = new System.Windows.Forms.TextBox();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.newBtn = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtBtn = new System.Windows.Forms.Button();
            this.excBtn = new System.Windows.Forms.Button();
            this.cnsBtn = new System.Windows.Forms.Button();
            this.exiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(202, 27);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(713, 33);
            this.id.TabIndex = 0;
            // 
            // tabela
            // 
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(22, 254);
            this.tabela.Margin = new System.Windows.Forms.Padding(4);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(893, 281);
            this.tabela.TabIndex = 1;
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(22, 168);
            this.newBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(162, 56);
            this.newBtn.TabIndex = 2;
            this.newBtn.Text = "Novo";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(202, 71);
            this.nome.Margin = new System.Windows.Forms.Padding(4);
            this.nome.Multiline = true;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(713, 33);
            this.nome.TabIndex = 3;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(202, 114);
            this.numero.Margin = new System.Windows.Forms.Padding(4);
            this.numero.Multiline = true;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(713, 33);
            this.numero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtBtn
            // 
            this.edtBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.edtBtn.Location = new System.Drawing.Point(202, 168);
            this.edtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.edtBtn.Name = "edtBtn";
            this.edtBtn.Size = new System.Drawing.Size(162, 56);
            this.edtBtn.TabIndex = 8;
            this.edtBtn.Text = "Editar";
            this.edtBtn.UseVisualStyleBackColor = true;
            this.edtBtn.Click += new System.EventHandler(this.edtBtn_Click);
            // 
            // excBtn
            // 
            this.excBtn.Location = new System.Drawing.Point(388, 168);
            this.excBtn.Margin = new System.Windows.Forms.Padding(4);
            this.excBtn.Name = "excBtn";
            this.excBtn.Size = new System.Drawing.Size(162, 56);
            this.excBtn.TabIndex = 9;
            this.excBtn.Text = "Excluir";
            this.excBtn.UseVisualStyleBackColor = true;
            this.excBtn.Click += new System.EventHandler(this.excBtn_Click);
            // 
            // cnsBtn
            // 
            this.cnsBtn.Location = new System.Drawing.Point(570, 168);
            this.cnsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cnsBtn.Name = "cnsBtn";
            this.cnsBtn.Size = new System.Drawing.Size(162, 56);
            this.cnsBtn.TabIndex = 10;
            this.cnsBtn.Text = "Consultar";
            this.cnsBtn.UseVisualStyleBackColor = true;
            this.cnsBtn.Click += new System.EventHandler(this.cnsBtn_Click);
            // 
            // exiBtn
            // 
            this.exiBtn.Location = new System.Drawing.Point(753, 168);
            this.exiBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exiBtn.Name = "exiBtn";
            this.exiBtn.Size = new System.Drawing.Size(162, 56);
            this.exiBtn.TabIndex = 11;
            this.exiBtn.Text = "Exibir";
            this.exiBtn.UseVisualStyleBackColor = true;
            this.exiBtn.Click += new System.EventHandler(this.exiBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 552);
            this.Controls.Add(this.exiBtn);
            this.Controls.Add(this.cnsBtn);
            this.Controls.Add(this.excBtn);
            this.Controls.Add(this.edtBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.id);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button edtBtn;
        private System.Windows.Forms.Button excBtn;
        private System.Windows.Forms.Button cnsBtn;
        private System.Windows.Forms.Button exiBtn;
    }
}

