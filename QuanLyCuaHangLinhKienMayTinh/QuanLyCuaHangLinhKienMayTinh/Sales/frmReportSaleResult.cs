using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Sales;
using DevComponents.DotNetBar.Controls;
using DTO.Sales;
using CommonLayer;

namespace QuanLyCuaHangLinhKienMayTinh.Sales
{
    public partial class frmReportSaleResult : Form
    {

        #region process

        ReportSalesBLL bll = new ReportSalesBLL();
        public frmReportSaleResult()
        {
            InitializeComponent();
        }
        private void frmReportSaleResult_Load(object sender, EventArgs e)
        {
            try
            {
                dgvXListBill.DataSource = bll.GetBillByDate(dtpStartDate.Value, dtpEndDate.Value);
                DisplayNotify("Load thành công hóa đơn và doanh thu trong ngày hôm nay", 1);
                SetIncome();
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi load doanh thu trong ngày , mã lỗi:"+ex, 1);
                   
            }
           
        }
        private void dgvXListBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                string billId = dgvXListBill[1, e.RowIndex].Value.ToString();
                dgvXBillDetail.DataSource = bll.GetBillDetail(billId);
                DisplayNotify("Load thành công", 1);
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi load dữ liệu, mã lỗi:" + ex, -1);
            }

            for (int i =0; i < dgvXBillDetail.Rows.Count; i++)
            {
                dgvXBillDetail.Rows[i].Cells[0].Value = (i+1).ToString();
            }
        }

        public void loaddata()
        {
            try
            {
                // set data source bill
                dgvXListBill.DataSource = bll.GetBillByDate(dtpStartDate.Value, dtpEndDate.Value);
                // tinh doanh thu
                SetIncome();
                DisplayNotify("Load thành công", 1);
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi load dữ liệu, mã lỗi:" + ex, - 1);
            }
            for(int i=1; i< dgvXListBill.Rows.Count; i++)
            {
                dgvXListBill.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            
        }

        public void SetIncome()
        {
            int sum = 0;
            try
            {
                for (int i = 0; i < dgvXListBill.Rows.Count; i++)
                {
                    sum += int.Parse( dgvXListBill.Rows[i].Cells[5].Value.ToString());
                }
                lblFrom.Text = dtpStartDate.Value.Day + "/" + dtpStartDate.Value.Month + "/" + dtpStartDate.Value.Year;
                lblTo.Text = dtpEndDate.Value.Day + "/" + dtpEndDate.Value.Month + "/" + dtpEndDate.Value.Year;
                txtIncome.Text =rule.parrtToMonney(sum.ToString()); 
                 
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

         

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        #endregion

        #region Notify
        public void ResetNotify()
        {
            lblNotify.Text = "";
            lblNotify.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
        }
        public void DisplayNotify(string error, int codeError)
        {
            if (codeError == 1)
            {
                lblNotify.Text = error;
                lblNotify.BackColor = Color.Green;
            }
            else
            {
                if (codeError == -1)
                {
                    lblNotify.Text = error;
                    lblNotify.BackColor = Color.Red;
                }
            }
            // timer
            int TimeInterval = error.Length * 30;
            if (TimeInterval < 800)
                TimeInterval = 800;
            timerNotify.Interval = TimeInterval;
            timerNotify.Start();
        }
        private void timerNotify_Tick(object sender, EventArgs e)
        {
            ResetNotify();
            timerNotify.Stop();
        }

        #endregion
    }
}
