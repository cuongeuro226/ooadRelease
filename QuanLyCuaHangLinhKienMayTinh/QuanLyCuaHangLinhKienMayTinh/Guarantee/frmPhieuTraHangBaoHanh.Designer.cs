namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    partial class frmPhieuTraHangBaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuTraHangBaoHanh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNotify = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPTHBH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAbout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanlity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckbDateTimeSystem = new System.Windows.Forms.CheckBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbPTNBH = new System.Windows.Forms.ComboBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblTenNhanVien = new DevComponents.DotNetBar.LabelX();
            this.lblNgayTra = new DevComponents.DotNetBar.LabelX();
            this.lblMaPTNBH = new DevComponents.DotNetBar.LabelX();
            this.txtMaPTHBH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblMaPTHBH = new DevComponents.DotNetBar.LabelX();
            this.lblPTHBH = new System.Windows.Forms.Label();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTHBH)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblPTHBH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 449);
            this.panel1.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(108, 407);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 32);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 45;
            this.btnIn.Text = "In";
            this.btnIn.TextColor = System.Drawing.Color.Black;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(485, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 32);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.Black;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(290, 407);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 32);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnLuu.TextColor = System.Drawing.Color.Black;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNotify);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 449);
            this.panel2.TabIndex = 1;
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.Location = new System.Drawing.Point(14, 9);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(0, 25);
            this.lblNotify.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvPTHBH);
            this.panel4.Location = new System.Drawing.Point(12, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(661, 224);
            this.panel4.TabIndex = 4;
            // 
            // dgvPTHBH
            // 
            this.dgvPTHBH.AllowUserToAddRows = false;
            this.dgvPTHBH.AllowUserToDeleteRows = false;
            this.dgvPTHBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPTHBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTHBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ProductID,
            this.ErrorAbout,
            this.Quanlity,
            this.Note});
            this.dgvPTHBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPTHBH.Location = new System.Drawing.Point(0, 0);
            this.dgvPTHBH.MultiSelect = false;
            this.dgvPTHBH.Name = "dgvPTHBH";
            this.dgvPTHBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPTHBH.Size = new System.Drawing.Size(661, 224);
            this.dgvPTHBH.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "MaSanPham";
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ErrorAbout
            // 
            this.ErrorAbout.DataPropertyName = "MoTaLoi";
            this.ErrorAbout.HeaderText = "Mô tả lỗi";
            this.ErrorAbout.Name = "ErrorAbout";
            this.ErrorAbout.ReadOnly = true;
            // 
            // Quanlity
            // 
            this.Quanlity.DataPropertyName = "SoLuong";
            this.Quanlity.HeaderText = "Số lượng";
            this.Quanlity.Name = "Quanlity";
            this.Quanlity.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi chú";
            this.Note.Name = "Note";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckbDateTimeSystem);
            this.panel3.Controls.Add(this.lblThongBao);
            this.panel3.Controls.Add(this.txtMaNV);
            this.panel3.Controls.Add(this.cbPTNBH);
            this.panel3.Controls.Add(this.dtpNgayTra);
            this.panel3.Controls.Add(this.lblTenNhanVien);
            this.panel3.Controls.Add(this.lblNgayTra);
            this.panel3.Controls.Add(this.lblMaPTNBH);
            this.panel3.Controls.Add(this.txtMaPTHBH);
            this.panel3.Controls.Add(this.lblMaPTHBH);
            this.panel3.Location = new System.Drawing.Point(3, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 135);
            this.panel3.TabIndex = 2;
            // 
            // ckbDateTimeSystem
            // 
            this.ckbDateTimeSystem.AutoSize = true;
            this.ckbDateTimeSystem.Checked = true;
            this.ckbDateTimeSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDateTimeSystem.Location = new System.Drawing.Point(453, 101);
            this.ckbDateTimeSystem.Name = "ckbDateTimeSystem";
            this.ckbDateTimeSystem.Size = new System.Drawing.Size(131, 17);
            this.ckbDateTimeSystem.TabIndex = 62;
            this.ckbDateTimeSystem.Text = "Lấy ngày giờ hệ thống";
            this.ckbDateTimeSystem.UseVisualStyleBackColor = true;
            this.ckbDateTimeSystem.CheckedChanged += new System.EventHandler(this.ckbDateTimeSystem_CheckedChanged);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AllowDrop = true;
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(482, 9);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(150, 100);
            this.lblThongBao.TabIndex = 61;
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.Location = new System.Drawing.Point(189, 39);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(258, 26);
            this.txtMaNV.TabIndex = 60;
            // 
            // cbPTNBH
            // 
            this.cbPTNBH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPTNBH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPTNBH.DisplayMember = "MaPTNBH";
            this.cbPTNBH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTNBH.FormattingEnabled = true;
            this.cbPTNBH.Location = new System.Drawing.Point(189, 70);
            this.cbPTNBH.Name = "cbPTNBH";
            this.cbPTNBH.Size = new System.Drawing.Size(258, 25);
            this.cbPTNBH.TabIndex = 59;
            this.cbPTNBH.ValueMember = "MaPTNBH";
            this.cbPTNBH.TextChanged += new System.EventHandler(this.cbPTNBH_TextChanged);
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Enabled = false;
            this.dtpNgayTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Location = new System.Drawing.Point(189, 100);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(258, 26);
            this.dtpNgayTra.TabIndex = 58;
            // 
            // lblTenNhanVien
            // 
            // 
            // 
            // 
            this.lblTenNhanVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblTenNhanVien.Location = new System.Drawing.Point(11, 39);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(153, 27);
            this.lblTenNhanVien.TabIndex = 56;
            this.lblTenNhanVien.Text = "Người lập phiếu :";
            // 
            // lblNgayTra
            // 
            // 
            // 
            // 
            this.lblNgayTra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNgayTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.ForeColor = System.Drawing.Color.Black;
            this.lblNgayTra.Location = new System.Drawing.Point(11, 101);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(153, 27);
            this.lblNgayTra.TabIndex = 54;
            this.lblNgayTra.Text = "Ngày trả :";
            // 
            // lblMaPTNBH
            // 
            // 
            // 
            // 
            this.lblMaPTNBH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaPTNBH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPTNBH.ForeColor = System.Drawing.Color.Black;
            this.lblMaPTNBH.Location = new System.Drawing.Point(11, 69);
            this.lblMaPTNBH.Name = "lblMaPTNBH";
            this.lblMaPTNBH.Size = new System.Drawing.Size(153, 27);
            this.lblMaPTNBH.TabIndex = 50;
            this.lblMaPTNBH.Text = "Mã PTNBH :";
            // 
            // txtMaPTHBH
            // 
            // 
            // 
            // 
            this.txtMaPTHBH.Border.Class = "TextBoxBorder";
            this.txtMaPTHBH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaPTHBH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPTHBH.ForeColor = System.Drawing.Color.Black;
            this.txtMaPTHBH.Location = new System.Drawing.Point(189, 9);
            this.txtMaPTHBH.Name = "txtMaPTHBH";
            this.txtMaPTHBH.ReadOnly = true;
            this.txtMaPTHBH.Size = new System.Drawing.Size(258, 26);
            this.txtMaPTHBH.TabIndex = 47;
            // 
            // lblMaPTHBH
            // 
            // 
            // 
            // 
            this.lblMaPTHBH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaPTHBH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPTHBH.ForeColor = System.Drawing.Color.Black;
            this.lblMaPTHBH.Location = new System.Drawing.Point(11, 9);
            this.lblMaPTHBH.Name = "lblMaPTHBH";
            this.lblMaPTHBH.Size = new System.Drawing.Size(153, 27);
            this.lblMaPTHBH.TabIndex = 46;
            this.lblMaPTHBH.Text = "Mã phiếu trả hàng :";
            // 
            // lblPTHBH
            // 
            this.lblPTHBH.AutoSize = true;
            this.lblPTHBH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTHBH.Location = new System.Drawing.Point(222, 9);
            this.lblPTHBH.Name = "lblPTHBH";
            this.lblPTHBH.Size = new System.Drawing.Size(246, 24);
            this.lblPTHBH.TabIndex = 0;
            this.lblPTHBH.Text = "Phiếu Trả Hàng Bảo Hành";
            // 
            // timerNotify
            // 
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // frmPhieuTraHangBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 449);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhieuTraHangBaoHanh";
            this.Text = "frmPhieuTraHangBaoHanh";
            this.Load += new System.EventHandler(this.frmPhieuTraHangBaoHanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTHBH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPTHBH;
        private DevComponents.DotNetBar.LabelX lblNgayTra;
        private DevComponents.DotNetBar.LabelX lblMaPTNBH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPTHBH;
        private DevComponents.DotNetBar.LabelX lblMaPTHBH;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.LabelX lblTenNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.ComboBox cbPTNBH;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.CheckBox ckbDateTimeSystem;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Timer timerNotify;
        private System.Windows.Forms.DataGridView dgvPTHBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanlity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}