namespace QuanLyBanGiay
{
    partial class frm_main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xuatFile = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_tiemKiem = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsv_data = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btn_xuatFile);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_tiemKiem);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác Vụ";
            // 
            // btn_xuatFile
            // 
            this.btn_xuatFile.Location = new System.Drawing.Point(931, 30);
            this.btn_xuatFile.Name = "btn_xuatFile";
            this.btn_xuatFile.Size = new System.Drawing.Size(154, 41);
            this.btn_xuatFile.TabIndex = 0;
            this.btn_xuatFile.Text = "Xuất File";
            this.btn_xuatFile.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(416, 34);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(147, 39);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_tiemKiem
            // 
            this.btn_tiemKiem.Location = new System.Drawing.Point(217, 34);
            this.btn_tiemKiem.Name = "btn_tiemKiem";
            this.btn_tiemKiem.Size = new System.Drawing.Size(147, 39);
            this.btn_tiemKiem.TabIndex = 0;
            this.btn_tiemKiem.Text = "Tìm Kiếm";
            this.btn_tiemKiem.UseVisualStyleBackColor = true;
            this.btn_tiemKiem.Click += new System.EventHandler(this.btn_tiemKiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(21, 34);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(139, 40);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsv_data);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1094, 536);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu";
            // 
            // lsv_data
            // 
            this.lsv_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lsv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_data.FullRowSelect = true;
            this.lsv_data.GridLines = true;
            this.lsv_data.HideSelection = false;
            this.lsv_data.Location = new System.Drawing.Point(3, 16);
            this.lsv_data.Name = "lsv_data";
            this.lsv_data.Size = new System.Drawing.Size(1088, 517);
            this.lsv_data.TabIndex = 0;
            this.lsv_data.UseCompatibleStateImageBehavior = false;
            this.lsv_data.View = System.Windows.Forms.View.Details;
            this.lsv_data.DoubleClick += new System.EventHandler(this.lsv_data_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stt";
            this.columnHeader1.Width = 59;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hãng Giày";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Giày";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Màu Giày";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thể Loại";
            this.columnHeader6.Width = 128;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vị Trí";
            this.columnHeader7.Width = 76;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá Bán";
            this.columnHeader8.Width = 111;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày Bán";
            this.columnHeader9.Width = 113;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Người Bán";
            this.columnHeader10.Width = 179;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1118, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Giày";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.frm_main_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xuatFile;
        private System.Windows.Forms.Button btn_tiemKiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btn_xoa;
        public System.Windows.Forms.ListView lsv_data;
    }
}

