namespace QuanLyNhanSu
{
    partial class FrmQuanLyTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNoiDungTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmCapDoTaiKhoan = new System.Windows.Forms.NumericUpDown();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvDSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCapDoTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSTaiKhoan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtNoiDungTimKiem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 295);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(362, 119);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(292, 81);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(45, 28);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(204, 81);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(82, 28);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNoiDungTimKiem
            // 
            this.txtNoiDungTimKiem.Location = new System.Drawing.Point(127, 49);
            this.txtNoiDungTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDungTimKiem.Name = "txtNoiDungTimKiem";
            this.txtNoiDungTimKiem.Size = new System.Drawing.Size(210, 20);
            this.txtNoiDungTimKiem.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nội Dung Tìm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmCapDoTaiKhoan);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTenHienThi);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(362, 228);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản";
            // 
            // nmCapDoTaiKhoan
            // 
            this.nmCapDoTaiKhoan.Location = new System.Drawing.Point(239, 168);
            this.nmCapDoTaiKhoan.Name = "nmCapDoTaiKhoan";
            this.nmCapDoTaiKhoan.Size = new System.Drawing.Size(120, 20);
            this.nmCapDoTaiKhoan.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(149, 123);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(210, 20);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(149, 77);
            this.txtTenHienThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(210, 20);
            this.txtTenHienThi.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(149, 12);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(210, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(149, 44);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(210, 20);
            this.txtTenTaiKhoan.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cấp độ Tài Khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hiển Thị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Tài Khoản:";
            // 
            // dtgvDSTaiKhoan
            // 
            this.dtgvDSTaiKhoan.AllowUserToAddRows = false;
            this.dtgvDSTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSTaiKhoan.Location = new System.Drawing.Point(381, 66);
            this.dtgvDSTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvDSTaiKhoan.MultiSelect = false;
            this.dtgvDSTaiKhoan.Name = "dtgvDSTaiKhoan";
            this.dtgvDSTaiKhoan.ReadOnly = true;
            this.dtgvDSTaiKhoan.Size = new System.Drawing.Size(561, 348);
            this.dtgvDSTaiKhoan.TabIndex = 35;
            // 
            // btnthem
            // 
            this.btnthem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(42, 22);
            this.btnthem.Text = "Thêm";
            this.btnthem.ToolTipText = "Thêm Mới (CTR + N)";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.toolStripSeparator1,
            this.btnCancel,
            this.toolStripSeparator2,
            this.btnRefresh,
            this.toolStripSeparator3,
            this.btnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(954, 25);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnsua
            // 
            this.btnsua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(30, 22);
            this.btnsua.Text = "Sửa";
            this.btnsua.ToolTipText = "Sửa (CTR + E)";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(34, 22);
            this.btnxoa.Text = " Xóa";
            this.btnxoa.ToolTipText = "Xóa (Delete)";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(33, 22);
            this.btnCancel.Text = "Hủy";
            this.btnCancel.ToolTipText = "Hủy (CTR + Q)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 22);
            this.btnRefresh.Text = "Cập Nhật";
            this.btnRefresh.ToolTipText = "Cập nhật lại (CTR + R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "In";
            this.btnPrint.ToolTipText = "In (CTR + P)";
            // 
            // FrmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvDSTaiKhoan);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmQuanLyTaiKhoan";
            this.Text = "FrmQuanLyTaiKhoan";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCapDoTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSTaiKhoan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNoiDungTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvDSTaiKhoan;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.NumericUpDown nmCapDoTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}