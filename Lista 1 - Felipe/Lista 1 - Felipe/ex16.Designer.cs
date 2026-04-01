namespace Lista_1___Felipe
{
    partial class ex16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ex16));
            this.ex_Title = new System.Windows.Forms.Label();
            this.ex_Descriptor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fireBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ex_Title
            // 
            this.ex_Title.AutoSize = true;
            this.ex_Title.BackColor = System.Drawing.Color.Transparent;
            this.ex_Title.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_Title.Location = new System.Drawing.Point(293, 25);
            this.ex_Title.Name = "ex_Title";
            this.ex_Title.Size = new System.Drawing.Size(389, 40);
            this.ex_Title.TabIndex = 47;
            this.ex_Title.Text = "Conversor de Velocidade";
            // 
            // ex_Descriptor
            // 
            this.ex_Descriptor.AutoSize = true;
            this.ex_Descriptor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_Descriptor.Location = new System.Drawing.Point(305, 75);
            this.ex_Descriptor.Name = "ex_Descriptor";
            this.ex_Descriptor.Size = new System.Drawing.Size(365, 22);
            this.ex_Descriptor.TabIndex = 48;
            this.ex_Descriptor.Text = "Converte uma velocidade de Km/h para m/s";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(935, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_textBox
            // 
            this.result_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_textBox.Location = new System.Drawing.Point(28, 316);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(935, 119);
            this.result_textBox.TabIndex = 10;
            this.result_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = global::Lista_1___Felipe.Properties.Resources._4115235_exit_logout_sign_out_1140301;
            this.exitBtn.Location = new System.Drawing.Point(516, 546);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(447, 66);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Image = global::Lista_1___Felipe.Properties.Resources.iconfinder_broom_clean_service_labor_website_4622511_122412;
            this.clearBtn.Location = new System.Drawing.Point(28, 546);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(443, 66);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Digite a velocidade (Km/h)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Resultado";
            // 
            // fireBtn
            // 
            this.fireBtn.BackColor = System.Drawing.Color.Transparent;
            this.fireBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fireBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireBtn.Image = global::Lista_1___Felipe.Properties.Resources.calculation_count_finance_calculator_calc_math_icon_256453__1_;
            this.fireBtn.Location = new System.Drawing.Point(28, 457);
            this.fireBtn.Name = "fireBtn";
            this.fireBtn.Size = new System.Drawing.Size(935, 66);
            this.fireBtn.TabIndex = 2;
            this.fireBtn.UseVisualStyleBackColor = false;
            this.fireBtn.Click += new System.EventHandler(this.fireBtn_Click);
            // 
            // ex16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(986, 648);
            this.Controls.Add(this.fireBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ex_Descriptor);
            this.Controls.Add(this.ex_Title);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ex16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "16. Conversor de Velocidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label ex_Title;
        private System.Windows.Forms.Label ex_Descriptor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fireBtn;
    }
}