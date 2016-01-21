namespace QuanLyCuaHangLinhKienMayTinh
{
    partial class frmPosition
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPositionID = new System.Windows.Forms.TextBox();
            this.txtPositionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvData = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColumnPositionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnControlID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.chkConfigEmployee = new System.Windows.Forms.CheckBox();
            this.chkReport = new System.Windows.Forms.CheckBox();
            this.chkguarentee = new System.Windows.Forms.CheckBox();
            this.chkHouseWare = new System.Windows.Forms.CheckBox();
            this.chkSale = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblNotify = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnCloseFind = new DevComponents.DotNetBar.ButtonX();
            this.btnFindnext = new DevComponents.DotNetBar.ButtonX();
            this.txtFindText = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grpControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chức vụ:";
            // 
            // txtPositionID
            // 
            this.txtPositionID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPositionID.Location = new System.Drawing.Point(100, 52);
            this.txtPositionID.Name = "txtPositionID";
            this.txtPositionID.ReadOnly = true;
            this.txtPositionID.Size = new System.Drawing.Size(147, 20);
            this.txtPositionID.TabIndex = 1;
            // 
            // txtPositionName
            // 
            this.txtPositionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPositionName.Location = new System.Drawing.Point(100, 92);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(147, 20);
            this.txtPositionName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chức vụ";
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSalary.Location = new System.Drawing.Point(100, 135);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(147, 20);
            this.txtSalary.TabIndex = 2;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lương";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPositionNumber,
            this.ColumnControlID,
            this.ColumnPositionName,
            this.ColumnSalary});
            this.dgvData.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvData.Location = new System.Drawing.Point(12, 35);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(619, 161);
            this.dgvData.TabIndex = 8;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // ColumnPositionNumber
            // 
            this.ColumnPositionNumber.DataPropertyName = "PositionNumber";
            this.ColumnPositionNumber.HeaderText = "Mã Chức vụ";
            this.ColumnPositionNumber.Name = "ColumnPositionNumber";
            this.ColumnPositionNumber.ReadOnly = true;
            // 
            // ColumnControlID
            // 
            this.ColumnControlID.DataPropertyName = "ControlID";
            this.ColumnControlID.HeaderText = "ControlID";
            this.ColumnControlID.Name = "ColumnControlID";
            this.ColumnControlID.ReadOnly = true;
            this.ColumnControlID.Visible = false;
            // 
            // ColumnPositionName
            // 
            this.ColumnPositionName.DataPropertyName = "PositionName";
            this.ColumnPositionName.HeaderText = "Tên Chức vụ";
            this.ColumnPositionName.Name = "ColumnPositionName";
            this.ColumnPositionName.ReadOnly = true;
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.DataPropertyName = "Salary";
            this.ColumnSalary.HeaderText = "Lương";
            this.ColumnSalary.Name = "ColumnSalary";
            this.ColumnSalary.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(646, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(646, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(646, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(646, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpControl
            // 
            this.grpControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpControl.Controls.Add(this.chkConfigEmployee);
            this.grpControl.Controls.Add(this.chkReport);
            this.grpControl.Controls.Add(this.chkguarentee);
            this.grpControl.Controls.Add(this.chkHouseWare);
            this.grpControl.Controls.Add(this.chkSale);
            this.grpControl.Location = new System.Drawing.Point(290, 38);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(423, 193);
            this.grpControl.TabIndex = 3;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Chức năng được phép sử dụng";
            // 
            // chkConfigEmployee
            // 
            this.chkConfigEmployee.AutoSize = true;
            this.chkConfigEmployee.Location = new System.Drawing.Point(24, 168);
            this.chkConfigEmployee.Name = "chkConfigEmployee";
            this.chkConfigEmployee.Size = new System.Drawing.Size(392, 17);
            this.chkConfigEmployee.TabIndex = 19;
            this.chkConfigEmployee.Text = "Chức năng quản lý nhân viên( thêm, xóa, sửa nhân viên, thêm xóa sửa vị trí , ";
            this.chkConfigEmployee.UseVisualStyleBackColor = true;
            // 
            // chkReport
            // 
            this.chkReport.AutoSize = true;
            this.chkReport.Location = new System.Drawing.Point(23, 132);
            this.chkReport.Name = "chkReport";
            this.chkReport.Size = new System.Drawing.Size(241, 17);
            this.chkReport.TabIndex = 18;
            this.chkReport.Text = "Chức năng xem tất cả các thống kê, báo cáo";
            this.chkReport.UseVisualStyleBackColor = true;
            // 
            // chkguarentee
            // 
            this.chkguarentee.AutoSize = true;
            this.chkguarentee.Location = new System.Drawing.Point(24, 98);
            this.chkguarentee.Name = "chkguarentee";
            this.chkguarentee.Size = new System.Drawing.Size(376, 17);
            this.chkguarentee.TabIndex = 17;
            this.chkguarentee.Text = "Chức năng quản lý bảo hành(Tiế nhận bảo hành, trả bảo hành, thống kê )";
            this.chkguarentee.UseVisualStyleBackColor = true;
            // 
            // chkHouseWare
            // 
            this.chkHouseWare.AutoSize = true;
            this.chkHouseWare.Location = new System.Drawing.Point(24, 65);
            this.chkHouseWare.Name = "chkHouseWare";
            this.chkHouseWare.Size = new System.Drawing.Size(374, 17);
            this.chkHouseWare.TabIndex = 16;
            this.chkHouseWare.Text = "Chức năng quản lý kho(Quảng lý sản phẩm, nhập kho, báo cá , thống kê)";
            this.chkHouseWare.UseVisualStyleBackColor = true;
            // 
            // chkSale
            // 
            this.chkSale.AutoSize = true;
            this.chkSale.Location = new System.Drawing.Point(24, 31);
            this.chkSale.Name = "chkSale";
            this.chkSale.Size = new System.Drawing.Size(345, 17);
            this.chkSale.TabIndex = 12;
            this.chkSale.Text = "Chức năng quản lý bán hàng( tạo hóa đơn, xem báo cáo, thống kê)";
            this.chkSale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.grpControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPositionID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPositionName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 250);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 25);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackgroundImage = global::QuanLyCuaHangLinhKienMayTinh.Properties.Resources.TieuDeChung;
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.lblNotify);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(729, 25);
            this.panel4.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRefresh.Location = new System.Drawing.Point(646, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "làm tươi";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblNotify
            // 
            this.lblNotify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotify.AutoSize = true;
            this.lblNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.lblNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.ForeColor = System.Drawing.Color.Black;
            this.lblNotify.Location = new System.Drawing.Point(364, 4);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(0, 16);
            this.lblNotify.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlFind);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.dgvData);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 206);
            this.panel2.TabIndex = 12;
            // 
            // pnlFind
            // 
            this.pnlFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFind.BackColor = System.Drawing.Color.Transparent;
            this.pnlFind.Controls.Add(this.btnCloseFind);
            this.pnlFind.Controls.Add(this.btnFindnext);
            this.pnlFind.Controls.Add(this.txtFindText);
            this.pnlFind.Location = new System.Drawing.Point(388, 113);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(243, 81);
            this.pnlFind.TabIndex = 38;
            this.pnlFind.Visible = false;
            // 
            // btnCloseFind
            // 
            this.btnCloseFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCloseFind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCloseFind.Location = new System.Drawing.Point(0, 0);
            this.btnCloseFind.Name = "btnCloseFind";
            this.btnCloseFind.Size = new System.Drawing.Size(20, 23);
            this.btnCloseFind.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCloseFind.TabIndex = 2;
            this.btnCloseFind.Text = "X";
            this.btnCloseFind.Click += new System.EventHandler(this.btnCloseFind_Click);
            // 
            // btnFindnext
            // 
            this.btnFindnext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFindnext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFindnext.Location = new System.Drawing.Point(79, 49);
            this.btnFindnext.Name = "btnFindnext";
            this.btnFindnext.Size = new System.Drawing.Size(89, 23);
            this.btnFindnext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFindnext.TabIndex = 1;
            this.btnFindnext.Text = "Tìm kế tiếp";
            this.btnFindnext.Click += new System.EventHandler(this.btnFindnext_Click_1);
            // 
            // txtFindText
            // 
            this.txtFindText.Location = new System.Drawing.Point(22, 19);
            this.txtFindText.Name = "txtFindText";
            this.txtFindText.Size = new System.Drawing.Size(202, 20);
            this.txtFindText.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::QuanLyCuaHangLinhKienMayTinh.Properties.Resources.TieuDeChung;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(726, 25);
            this.panel5.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(646, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timerNotify
            // 
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 456);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(742, 472);
            this.Name = "frmPosition";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPositionID;
        private System.Windows.Forms.TextBox txtPositionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvData;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPositionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnControlID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Timer timerNotify;
        private System.Windows.Forms.Panel pnlFind;
        private DevComponents.DotNetBar.ButtonX btnCloseFind;
        private DevComponents.DotNetBar.ButtonX btnFindnext;
        private System.Windows.Forms.TextBox txtFindText;
        private System.Windows.Forms.CheckBox chkConfigEmployee;
        private System.Windows.Forms.CheckBox chkReport;
        private System.Windows.Forms.CheckBox chkguarentee;
        private System.Windows.Forms.CheckBox chkHouseWare;
        private System.Windows.Forms.CheckBox chkSale;
        private System.Windows.Forms.Button btnRefresh;
    }
}