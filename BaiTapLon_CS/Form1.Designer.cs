﻿namespace BaiTapLon_CS
{
    partial class Form1
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
               this.txtAccount = new System.Windows.Forms.TextBox();
               this.txtPassword = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
               this.radioBtnCashier = new System.Windows.Forms.RadioButton();
               this.btnExit = new System.Windows.Forms.Button();
               this.btnLogin = new System.Windows.Forms.Button();
               this.panel1 = new System.Windows.Forms.Panel();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // txtAccount
               // 
               this.txtAccount.Location = new System.Drawing.Point(133, 221);
               this.txtAccount.Name = "txtAccount";
               this.txtAccount.Size = new System.Drawing.Size(303, 22);
               this.txtAccount.TabIndex = 2;
               // 
               // txtPassword
               // 
               this.txtPassword.Location = new System.Drawing.Point(133, 313);
               this.txtPassword.Name = "txtPassword";
               this.txtPassword.Size = new System.Drawing.Size(303, 22);
               this.txtPassword.TabIndex = 3;
               this.txtPassword.UseSystemPasswordChar = true;
               this.txtPassword.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(101, 190);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(71, 17);
               this.label1.TabIndex = 4;
               this.label1.Text = "Tài khoản";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(101, 274);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(66, 17);
               this.label2.TabIndex = 5;
               this.label2.Text = "Mật khẩu";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label3.ForeColor = System.Drawing.Color.White;
               this.label3.Location = new System.Drawing.Point(147, 43);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(221, 39);
               this.label3.TabIndex = 7;
               this.label3.Text = "ĐĂNG NHẬP";
               // 
               // radioBtnAdmin
               // 
               this.radioBtnAdmin.AutoSize = true;
               this.radioBtnAdmin.Location = new System.Drawing.Point(288, 149);
               this.radioBtnAdmin.Name = "radioBtnAdmin";
               this.radioBtnAdmin.Size = new System.Drawing.Size(68, 21);
               this.radioBtnAdmin.TabIndex = 1;
               this.radioBtnAdmin.TabStop = true;
               this.radioBtnAdmin.Text = "Admin";
               this.radioBtnAdmin.UseVisualStyleBackColor = true;
               // 
               // radioBtnCashier
               // 
               this.radioBtnCashier.AutoSize = true;
               this.radioBtnCashier.Location = new System.Drawing.Point(166, 149);
               this.radioBtnCashier.Name = "radioBtnCashier";
               this.radioBtnCashier.Size = new System.Drawing.Size(77, 21);
               this.radioBtnCashier.TabIndex = 0;
               this.radioBtnCashier.TabStop = true;
               this.radioBtnCashier.Text = "Cashier";
               this.radioBtnCashier.UseVisualStyleBackColor = true;
               // 
               // btnExit
               // 
               this.btnExit.Image = global::BaiTapLon_CS.Properties.Resources.exit;
               this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnExit.Location = new System.Drawing.Point(299, 379);
               this.btnExit.Name = "btnExit";
               this.btnExit.Size = new System.Drawing.Size(137, 45);
               this.btnExit.TabIndex = 8;
               this.btnExit.Text = "Thoát";
               this.btnExit.UseVisualStyleBackColor = true;
               this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
               // 
               // btnLogin
               // 
               this.btnLogin.AutoSize = true;
               this.btnLogin.Image = global::BaiTapLon_CS.Properties.Resources.Login_in_icon;
               this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnLogin.Location = new System.Drawing.Point(133, 379);
               this.btnLogin.Name = "btnLogin";
               this.btnLogin.Size = new System.Drawing.Size(141, 45);
               this.btnLogin.TabIndex = 6;
               this.btnLogin.Text = "Đăng Nhập";
               this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnLogin.UseVisualStyleBackColor = true;
               this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
               this.panel1.Controls.Add(this.label3);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(548, 117);
               this.panel1.TabIndex = 9;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(548, 475);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.btnExit);
               this.Controls.Add(this.btnLogin);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.txtPassword);
               this.Controls.Add(this.txtAccount);
               this.Controls.Add(this.radioBtnAdmin);
               this.Controls.Add(this.radioBtnCashier);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Đăng nhập";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.RadioButton radioBtnCashier;
        private System.Windows.Forms.Panel panel1;
    }
}

