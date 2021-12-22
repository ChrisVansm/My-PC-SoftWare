namespace RSA
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_Ciphertext = new System.Windows.Forms.RichTextBox();
            this.txb_P = new System.Windows.Forms.TextBox();
            this.txb_Q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Encryption = new System.Windows.Forms.Button();
            this.txb_L = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_E = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.txb_D = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_Rule = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_GetParameter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lab_States = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lab_Public_Key = new System.Windows.Forms.Label();
            this.lab_Private_Key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_Ciphertext
            // 
            this.rtb_Ciphertext.Location = new System.Drawing.Point(38, 66);
            this.rtb_Ciphertext.Name = "rtb_Ciphertext";
            this.rtb_Ciphertext.Size = new System.Drawing.Size(183, 188);
            this.rtb_Ciphertext.TabIndex = 0;
            this.rtb_Ciphertext.Text = "";
            // 
            // txb_P
            // 
            this.txb_P.Location = new System.Drawing.Point(299, 146);
            this.txb_P.Name = "txb_P";
            this.txb_P.Size = new System.Drawing.Size(255, 21);
            this.txb_P.TabIndex = 1;
            // 
            // txb_Q
            // 
            this.txb_Q.Location = new System.Drawing.Point(299, 191);
            this.txb_Q.Name = "txb_Q";
            this.txb_Q.Size = new System.Drawing.Size(255, 21);
            this.txb_Q.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "参数 P：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "参数 Q：";
            // 
            // txb_N
            // 
            this.txb_N.Location = new System.Drawing.Point(299, 239);
            this.txb_N.Name = "txb_N";
            this.txb_N.Size = new System.Drawing.Size(255, 21);
            this.txb_N.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "参数 N:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "参数 L：";
            // 
            // btn_Encryption
            // 
            this.btn_Encryption.Location = new System.Drawing.Point(390, 66);
            this.btn_Encryption.Name = "btn_Encryption";
            this.btn_Encryption.Size = new System.Drawing.Size(75, 23);
            this.btn_Encryption.TabIndex = 8;
            this.btn_Encryption.Text = "加密";
            this.btn_Encryption.UseVisualStyleBackColor = true;
            this.btn_Encryption.Click += new System.EventHandler(this.btn_Encryption_Click);
            // 
            // txb_L
            // 
            this.txb_L.Location = new System.Drawing.Point(299, 292);
            this.txb_L.Name = "txb_L";
            this.txb_L.Size = new System.Drawing.Size(255, 21);
            this.txb_L.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "参数 E：";
            // 
            // txb_E
            // 
            this.txb_E.Location = new System.Drawing.Point(299, 340);
            this.txb_E.Name = "txb_E";
            this.txb_E.Size = new System.Drawing.Size(255, 21);
            this.txb_E.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "参数 D：";
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(601, 104);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.Size = new System.Drawing.Size(183, 282);
            this.rtb_result.TabIndex = 13;
            this.rtb_result.Text = "";
            // 
            // txb_D
            // 
            this.txb_D.Location = new System.Drawing.Point(299, 380);
            this.txb_D.Name = "txb_D";
            this.txb_D.Size = new System.Drawing.Size(255, 21);
            this.txb_D.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "密文";
            // 
            // rtb_Rule
            // 
            this.rtb_Rule.Location = new System.Drawing.Point(38, 281);
            this.rtb_Rule.Name = "rtb_Rule";
            this.rtb_Rule.Size = new System.Drawing.Size(183, 211);
            this.rtb_Rule.TabIndex = 16;
            this.rtb_Rule.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "明文";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(599, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "解密后文件";
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(479, 66);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 19;
            this.btn_Decrypt.Text = "解密";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_GetParameter
            // 
            this.btn_GetParameter.Location = new System.Drawing.Point(479, 104);
            this.btn_GetParameter.Name = "btn_GetParameter";
            this.btn_GetParameter.Size = new System.Drawing.Size(75, 23);
            this.btn_GetParameter.TabIndex = 20;
            this.btn_GetParameter.Text = "计算相关参数";
            this.btn_GetParameter.UseVisualStyleBackColor = true;
            this.btn_GetParameter.Click += new System.EventHandler(this.btn_GetParameter_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(669, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "状态：";
            // 
            // lab_States
            // 
            this.lab_States.AutoSize = true;
            this.lab_States.Location = new System.Drawing.Point(719, 20);
            this.lab_States.Name = "lab_States";
            this.lab_States.Size = new System.Drawing.Size(65, 12);
            this.lab_States.TabIndex = 22;
            this.lab_States.Text = "初始化完成";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "公钥：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(297, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "私钥：";
            // 
            // lab_Public_Key
            // 
            this.lab_Public_Key.AutoSize = true;
            this.lab_Public_Key.Location = new System.Drawing.Point(344, 451);
            this.lab_Public_Key.Name = "lab_Public_Key";
            this.lab_Public_Key.Size = new System.Drawing.Size(17, 12);
            this.lab_Public_Key.TabIndex = 25;
            this.lab_Public_Key.Text = "xx";
            // 
            // lab_Private_Key
            // 
            this.lab_Private_Key.AutoSize = true;
            this.lab_Private_Key.Location = new System.Drawing.Point(344, 480);
            this.lab_Private_Key.Name = "lab_Private_Key";
            this.lab_Private_Key.Size = new System.Drawing.Size(17, 12);
            this.lab_Private_Key.TabIndex = 26;
            this.lab_Private_Key.Text = "xx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 523);
            this.Controls.Add(this.lab_Private_Key);
            this.Controls.Add(this.lab_Public_Key);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lab_States);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_GetParameter);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtb_Rule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_D);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_E);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_L);
            this.Controls.Add(this.btn_Encryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_N);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Q);
            this.Controls.Add(this.txb_P);
            this.Controls.Add(this.rtb_Ciphertext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Ciphertext;
        private System.Windows.Forms.TextBox txb_P;
        private System.Windows.Forms.TextBox txb_Q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Encryption;
        private System.Windows.Forms.TextBox txb_L;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_E;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.Windows.Forms.TextBox txb_D;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_Rule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_GetParameter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_States;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lab_Public_Key;
        private System.Windows.Forms.Label lab_Private_Key;
    }
}

