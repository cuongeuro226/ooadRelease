using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BLL;
using System.Threading;

namespace QuanLyCuaHangLinhKienMayTinh
{
    public partial class frmLogin : Form
    {
        public int _exit = 0;
        LoginBLL d = new LoginBLL();
        public frmLogin()
        {
            InitializeComponent();
        }


        public void showForm()
        {
            // Do some work here.
            //frmMainForm form = new frmMainForm(txtID.Text);
            //form.Show();
            //// Do some more work here
            //Application.Run();
 
        }


        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessLogin();
            }
        }


        public void ProcessLogin()
        {
            if (txtID.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0)
            {
                DisplayNotify( "Lỗi ! Nhập sai mã nhân viên hoặc sai mật khẩu...",-1);
            }
            else
            {
                try
                {
                    if (d.CheckDangNhap(txtID.Text, txtPassword.Text))
                    {
                        
                        DisplayNotify("Đăng nhập thành công.!", 1); 
                        //new Thread(new ThreadStart(showForm)).Start();
                        List<string>arr = d.GetFuntionByEmployeeID(txtID.Text);

                        frmMainForm form = new frmMainForm(txtID.Text, arr);
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                        txtID.Clear();
                        txtPassword.Clear();
                    }
                    else
                    {
                        DisplayNotify("Lỗi ! Nhập sai mã nhân viên hoặc sai mật khẩu...", -1);
                    }
                }
                catch(Exception ex) { DisplayNotify("Lỗi !Không thể đọc dữ liệu từ CSDL, mã lỗi:" + ex.Message, -1); }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _exit = 1;
            this.Close();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            DisplayNotify("Liên hệ trực tiếp với quản lý để được cấp tài khoản",1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProcessLogin();
        }



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
