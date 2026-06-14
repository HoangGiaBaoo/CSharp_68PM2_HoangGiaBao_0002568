namespace QLSV
{
    partial class frm_login
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
            this.lb_tieuDe = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tieuDe
            // 
            this.lb_tieuDe.AutoSize = true;
            this.lb_tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieuDe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_tieuDe.Location = new System.Drawing.Point(173, 77);
            this.lb_tieuDe.Name = "lb_tieuDe";
            this.lb_tieuDe.Size = new System.Drawing.Size(460, 37);
            this.lb_tieuDe.TabIndex = 0;
            this.lb_tieuDe.Text = "Hệ Thống Quản Lý Sinh Viên";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(196, 151);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(58, 20);
            this.lb_email.TabIndex = 1;
            this.lb_email.Text = "Email:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(196, 191);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(91, 20);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(330, 148);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(236, 26);
            this.txt_email.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(330, 188);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(236, 26);
            this.txt_password.TabIndex = 4;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Location = new System.Drawing.Point(330, 266);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(133, 54);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_tieuDe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tieuDe;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}

