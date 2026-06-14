namespace QLSV
{
    partial class frm_DSSV_TheoLop
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
            this.lbl_tieuDe = new System.Windows.Forms.Label();
            this.lbl_tongSo = new System.Windows.Forms.Label();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.btn_dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_tieuDe
            //
            this.lbl_tieuDe.AutoSize = true;
            this.lbl_tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieuDe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_tieuDe.Location = new System.Drawing.Point(16, 13);
            this.lbl_tieuDe.Name = "lbl_tieuDe";
            this.lbl_tieuDe.Size = new System.Drawing.Size(330, 29);
            this.lbl_tieuDe.TabIndex = 0;
            this.lbl_tieuDe.Text = "Danh sách sinh viên — Lớp:";
            //
            // lbl_tongSo
            //
            this.lbl_tongSo.AutoSize = true;
            this.lbl_tongSo.Location = new System.Drawing.Point(18, 52);
            this.lbl_tongSo.Name = "lbl_tongSo";
            this.lbl_tongSo.Size = new System.Drawing.Size(150, 20);
            this.lbl_tongSo.TabIndex = 1;
            this.lbl_tongSo.Text = "Tổng số 0 sinh viên";
            //
            // dgv_DSSV
            //
            this.dgv_DSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSSV.AllowUserToAddRows = false;
            this.dgv_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Location = new System.Drawing.Point(20, 85);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.ReadOnly = true;
            this.dgv_DSSV.RowHeadersVisible = false;
            this.dgv_DSSV.RowHeadersWidth = 62;
            this.dgv_DSSV.RowTemplate.Height = 28;
            this.dgv_DSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSSV.Size = new System.Drawing.Size(844, 380);
            this.dgv_DSSV.TabIndex = 2;
            //
            // btn_dong
            //
            this.btn_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dong.Location = new System.Drawing.Point(762, 480);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(102, 40);
            this.btn_dong.TabIndex = 3;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            //
            // frm_DSSV_TheoLop
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.dgv_DSSV);
            this.Controls.Add(this.lbl_tongSo);
            this.Controls.Add(this.lbl_tieuDe);
            this.Name = "frm_DSSV_TheoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sinh viên theo lớp";
            this.Load += new System.EventHandler(this.frm_DSSV_TheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tieuDe;
        private System.Windows.Forms.Label lbl_tongSo;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Button btn_dong;
    }
}
