namespace Salary
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
            this.horasField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valorHoraField = new System.Windows.Forms.TextBox();
            this.descontoField = new System.Windows.Forms.TextBox();
            this.resultadoField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // horasField
            // 
            this.horasField.Location = new System.Drawing.Point(60, 168);
            this.horasField.Multiline = true;
            this.horasField.Name = "horasField";
            this.horasField.Size = new System.Drawing.Size(266, 44);
            this.horasField.TabIndex = 0;
            this.horasField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculadora de Salarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horas Trabalhadas";
            // 
            // valorHoraField
            // 
            this.valorHoraField.Location = new System.Drawing.Point(361, 168);
            this.valorHoraField.Multiline = true;
            this.valorHoraField.Name = "valorHoraField";
            this.valorHoraField.Size = new System.Drawing.Size(266, 44);
            this.valorHoraField.TabIndex = 5;
            this.valorHoraField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descontoField
            // 
            this.descontoField.Location = new System.Drawing.Point(654, 168);
            this.descontoField.Multiline = true;
            this.descontoField.Name = "descontoField";
            this.descontoField.Size = new System.Drawing.Size(266, 44);
            this.descontoField.TabIndex = 6;
            this.descontoField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultadoField
            // 
            this.resultadoField.Location = new System.Drawing.Point(60, 270);
            this.resultadoField.Multiline = true;
            this.resultadoField.Name = "resultadoField";
            this.resultadoField.ReadOnly = true;
            this.resultadoField.Size = new System.Drawing.Size(860, 189);
            this.resultadoField.TabIndex = 7;
            this.resultadoField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor da Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desconto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Resultados";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::Salary.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.exitBtn.Location = new System.Drawing.Point(654, 491);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(266, 76);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Image = global::Salary.Properties.Resources.iconfinder_broom_clean_service_labor_website_4622511_122412;
            this.clearBtn.Location = new System.Drawing.Point(361, 491);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(266, 76);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.Transparent;
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcBtn.Image = global::Salary.Properties.Resources.calculator_icon_icons_com_50442;
            this.calcBtn.Location = new System.Drawing.Point(60, 491);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(266, 76);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(950, 627);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.resultadoField);
            this.Controls.Add(this.descontoField);
            this.Controls.Add(this.valorHoraField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horasField);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox horasField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valorHoraField;
        private System.Windows.Forms.TextBox descontoField;
        private System.Windows.Forms.TextBox resultadoField;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

