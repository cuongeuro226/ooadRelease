namespace QuanLyCuaHangLinhKienMayTinh.Warehouse
{
    partial class frmAddWarehouseBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtWarehouseBillID = new System.Windows.Forms.TextBox();
            this.txtNguoiLapPhieu = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.txtTotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dgvDetailWarehouseBill = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonGiaNhap = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.SoLuong = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.GhiChu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKiemTra = new DevComponents.DotNetBar.ButtonX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNotify = new System.Windows.Forms.Label();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailWarehouseBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(12, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(206, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tạo Mới Phiếu Nhập Kho";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 585);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1016, 543);
            this.panel5.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtWarehouseBillID);
            this.panel7.Controls.Add(this.txtNguoiLapPhieu);
            this.panel7.Controls.Add(this.txtGhiChu);
            this.panel7.Controls.Add(this.labelX6);
            this.panel7.Controls.Add(this.labelX1);
            this.panel7.Controls.Add(this.labelX5);
            this.panel7.Controls.Add(this.btnThem);
            this.panel7.Controls.Add(this.txtTotal);
            this.panel7.Controls.Add(this.labelX3);
            this.panel7.Controls.Add(this.dgvDetailWarehouseBill);
            this.panel7.Controls.Add(this.btnKiemTra);
            this.panel7.Controls.Add(this.btnIn);
            this.panel7.Controls.Add(this.btnThoat);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.MinimumSize = new System.Drawing.Size(1016, 543);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1016, 543);
            this.panel7.TabIndex = 5;
            // 
            // txtWarehouseBillID
            // 
            this.txtWarehouseBillID.Enabled = false;
            this.txtWarehouseBillID.Location = new System.Drawing.Point(118, 13);
            this.txtWarehouseBillID.Name = "txtWarehouseBillID";
            this.txtWarehouseBillID.Size = new System.Drawing.Size(198, 20);
            this.txtWarehouseBillID.TabIndex = 19;
            // 
            // txtNguoiLapPhieu
            // 
            this.txtNguoiLapPhieu.Enabled = false;
            this.txtNguoiLapPhieu.Location = new System.Drawing.Point(118, 48);
            this.txtNguoiLapPhieu.Name = "txtNguoiLapPhieu";
            this.txtNguoiLapPhieu.Size = new System.Drawing.Size(198, 20);
            this.txtNguoiLapPhieu.TabIndex = 18;
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(118, 85);
            this.txtGhiChu.MaxLength = 100;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(198, 91);
            this.txtGhiChu.TabIndex = 17;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(3, 84);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(110, 23);
            this.labelX6.TabIndex = 16;
            this.labelX6.Text = "Ghi Chú";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(110, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Mã Phiếu Nhập Kho";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(3, 46);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(110, 23);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "Người Lập Phiếu";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(933, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 28);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTotal.Border.Class = "TextBoxBorder";
            this.txtTotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(786, 413);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(141, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(726, 413);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(54, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Tổng";
            // 
            // dgvDetailWarehouseBill
            // 
            this.dgvDetailWarehouseBill.AllowUserToDeleteRows = false;
            this.dgvDetailWarehouseBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailWarehouseBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailWarehouseBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetailWarehouseBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailWarehouseBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSanPham,
            this.DonGiaNhap,
            this.SoLuong,
            this.GhiChu1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailWarehouseBill.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetailWarehouseBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDetailWarehouseBill.Location = new System.Drawing.Point(322, 6);
            this.dgvDetailWarehouseBill.MultiSelect = false;
            this.dgvDetailWarehouseBill.Name = "dgvDetailWarehouseBill";
            this.dgvDetailWarehouseBill.RowHeadersVisible = false;
            this.dgvDetailWarehouseBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDetailWarehouseBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetailWarehouseBill.Size = new System.Drawing.Size(605, 390);
            this.dgvDetailWarehouseBill.TabIndex = 5;
            this.dgvDetailWarehouseBill.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDetailWarehouseBill_CellBeginEdit);
            this.dgvDetailWarehouseBill.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailWarehouseBill_CellEndEdit);
            this.dgvDetailWarehouseBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailWarehouseBill_CellValueChanged);
            this.dgvDetailWarehouseBill.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetailWarehouseBill_RowsAdded_1);
            this.dgvDetailWarehouseBill.Sorted += new System.EventHandler(this.dgvDetailWarehouseBill_Sorted);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DonGiaNhap
            // 
            // 
            // 
            // 
            this.DonGiaNhap.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.DonGiaNhap.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.DonGiaNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonGiaNhap.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.Enabled = false;
            this.DonGiaNhap.HeaderText = "Đơn Giá";
            this.DonGiaNhap.Increment = 1D;
            this.DonGiaNhap.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SoLuong
            // 
            // 
            // 
            // 
            this.SoLuong.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.SoLuong.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.SoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SoLuong.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.SoLuong.MinValue = 1;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GhiChu1
            // 
            this.GhiChu1.DataPropertyName = "GhiChu";
            this.GhiChu1.HeaderText = "Ghi Chú";
            this.GhiChu1.Name = "GhiChu1";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKiemTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKiemTra.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKiemTra.Location = new System.Drawing.Point(933, 48);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(80, 28);
            this.btnKiemTra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Location = new System.Drawing.Point(933, 131);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(80, 28);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(933, 88);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 28);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.lblNotify);
            this.panel3.Controls.Add(this.labelX2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1016, 42);
            this.panel3.TabIndex = 5;
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.Location = new System.Drawing.Point(280, 13);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(0, 25);
            this.lblNotify.TabIndex = 1;
            // 
            // timerNotify
            // 
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRefresh.Location = new System.Drawing.Point(933, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "làm tươi";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmAddWarehouseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 585);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmAddWarehouseBill";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailWarehouseBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotal;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDetailWarehouseBill;
        private DevComponents.DotNetBar.ButtonX btnKiemTra;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.TextBox txtNguoiLapPhieu;
        private System.Windows.Forms.TextBox txtWarehouseBillID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Timer timerNotify;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSanPham;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn DonGiaNhap;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu1;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private System.Windows.Forms.Button btnRefresh;
    }
}