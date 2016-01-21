namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    partial class frmThongKeBaoHanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.rbPTNBH = new System.Windows.Forms.RadioButton();
            this.panelRadio = new System.Windows.Forms.Panel();
            this.rbPTHBH = new System.Windows.Forms.RadioButton();
            this.panelFrm = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelRadio.SuspendLayout();
            this.panelFrm.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.lblDenNgay);
            this.panel1.Controls.Add(this.lblTuNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Location = new System.Drawing.Point(319, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 82);
            this.panel1.TabIndex = 0;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(101, 48);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 25);
            this.dtpDenNgay.TabIndex = 3;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(19, 50);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(77, 19);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(19, 11);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(67, 19);
            this.lblTuNgay.TabIndex = 1;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(101, 8);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 25);
            this.dtpTuNgay.TabIndex = 0;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // rbPTNBH
            // 
            this.rbPTNBH.AutoSize = true;
            this.rbPTNBH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPTNBH.Location = new System.Drawing.Point(11, 9);
            this.rbPTNBH.Name = "rbPTNBH";
            this.rbPTNBH.Size = new System.Drawing.Size(194, 23);
            this.rbPTNBH.TabIndex = 4;
            this.rbPTNBH.TabStop = true;
            this.rbPTNBH.Text = "Phiếu tiếp nhận bảo hành";
            this.rbPTNBH.UseVisualStyleBackColor = true;
            this.rbPTNBH.CheckedChanged += new System.EventHandler(this.rbPTNBH_CheckedChanged);
            // 
            // panelRadio
            // 
            this.panelRadio.Controls.Add(this.rbPTHBH);
            this.panelRadio.Controls.Add(this.rbPTNBH);
            this.panelRadio.Location = new System.Drawing.Point(51, 3);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Size = new System.Drawing.Size(224, 82);
            this.panelRadio.TabIndex = 4;
            // 
            // rbPTHBH
            // 
            this.rbPTHBH.AutoSize = true;
            this.rbPTHBH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPTHBH.Location = new System.Drawing.Point(11, 48);
            this.rbPTHBH.Name = "rbPTHBH";
            this.rbPTHBH.Size = new System.Drawing.Size(186, 23);
            this.rbPTHBH.TabIndex = 5;
            this.rbPTHBH.TabStop = true;
            this.rbPTHBH.Text = "Phiếu trả hàng bảo hành";
            this.rbPTHBH.UseVisualStyleBackColor = true;
            this.rbPTHBH.CheckedChanged += new System.EventHandler(this.rbPTHBH_CheckedChanged);
            // 
            // panelFrm
            // 
            this.panelFrm.Controls.Add(this.btnIn);
            this.panelFrm.Controls.Add(this.gbDanhSach);
            this.panelFrm.Controls.Add(this.panel1);
            this.panelFrm.Controls.Add(this.panelRadio);
            this.panelFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrm.Location = new System.Drawing.Point(0, 0);
            this.panelFrm.Name = "panelFrm";
            this.panelFrm.Size = new System.Drawing.Size(709, 446);
            this.panelFrm.TabIndex = 5;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(575, 404);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 36);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Controls.Add(this.dgvDanhSach);
            this.gbDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDanhSach.Location = new System.Drawing.Point(3, 102);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(703, 299);
            this.gbDanhSach.TabIndex = 5;
            this.gbDanhSach.TabStop = false;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSach.Name = "dgvDanhSach";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.Size = new System.Drawing.Size(697, 274);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // frmThongKeBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 446);
            this.ControlBox = false;
            this.Controls.Add(this.panelFrm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongKeBaoHanh";
            this.Load += new System.EventHandler(this.frmThongKeBaoHanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRadio.ResumeLayout(false);
            this.panelRadio.PerformLayout();
            this.panelFrm.ResumeLayout(false);
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.RadioButton rbPTNBH;
        private System.Windows.Forms.Panel panelRadio;
        private System.Windows.Forms.Panel panelFrm;
        private System.Windows.Forms.RadioButton rbPTHBH;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnIn;
    }
}