﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.IO;
using System.Drawing.Imaging;
using CommonLayer;

namespace QuanLyCuaHangLinhKienMayTinh
{
    public partial class frmEmployee : Form
    {
        EmployeeBLL employeeBLL = new EmployeeBLL();
        static int SearchIndex = 0;
        frmMainForm Main;
        public frmEmployee()
        {
            InitializeComponent();
        }
        public frmEmployee(frmMainForm main,string manv)
        {
            Main= new frmMainForm(manv);
            Main = main;
             
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {

            // get list position
            try
            {
                cboPosition.DataSource = employeeBLL.GetListPosition();
                cboPosition.DisplayMember = "PositionName";
                cboPosition.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                
                 DisplayNotify( "Lỗi đọc danh sách chức vụ!!, mã lỗi: "+ex.Message,-1);
                return;
            }
            //load dgview
            try
            {
                
                dgvData.DataSource =  employeeBLL.GetAllEmployee();
                //Console.WriteLine("asas"+ dgvData.DataBindings.ToString());
                dgvData.ClearSelection();
                ClearTextbox();

                

            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi đọc danh sách Nhân viên, mã lỗi: " + ex.Message, -1);
            }

        }

         
        #region Button event
        private void btnImage_Click(object sender, EventArgs e)
        {
            
            openFileDialogImage.Filter = "JPEG Files (*.jpeg)|*.jpg";
            openFileDialogImage.ShowDialog();
            txtImagelink.Text = openFileDialogImage.FileName;
            try
            {
                if (txtImagelink.Text.Length > 0)
                    picImage.BackgroundImage = Image.FromFile(txtImagelink.Text);
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi load ảnh lên , mã lỗi: " + ex.Message, -1);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            ClearTextbox();
            
        }
        private void btnCloseFind_Click(object sender, EventArgs e)
        {
            pnlFind.Visible = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlFind.Visible = true;
        }
        private void btnFindnext_Click(object sender, EventArgs e)
        {
            if (txtFindText.Text.Length == 0)
                MessageBox.Show("Nhập chuỗi để tìm kiếm!");
            else
            {
               
                SearchIndex = CommonFunction.Search(dgvData, txtFindText.Text, SearchIndex);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            //get position number
            DTO.position c = (DTO.position)cboPosition.SelectedItem;
            string macv = c.PositionNumber.ToString();
            //image
            MemoryStream mem = new MemoryStream();
            try
            {
                if (txtImagelink.Text.Length == 0)
                {
                    Image ima = picImage.BackgroundImage;
                    ima.Save(mem, ImageFormat.Jpeg);
                }
                else
                {
                    Image ima = Image.FromFile(txtImagelink.Text);
                    ima.Save(mem, ImageFormat.Jpeg);
                }
            }
            catch { };
            try
            {
                string KeyToSelect = txtEmployeeID.Text;
                employeeBLL.DeleteEmployee(txtEmployeeID.Text, txtEmployeeName.Text, cboSex.Text, txtNumberID.Text, txtPhone.Text, dtmBirthDay.Value.ToString(), txtAddress.Text,
                            txtPlaceBrith.Text, txtAge.Text, macv, txtSalary.Text, dtmDayWorking.Value.ToString(), mem, txtPassword.Text, cboStatus.Text);
                DisplayNotify("Xoa thành công", 1);
                dgvData.DataSource = employeeBLL.GetAllEmployee();
                SelectRow(dgvData, KeyToSelect);
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi xóa trong CSDL, mã lỗi: " + ex.Message, -1);
            }
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave(1) == true)
            {
                //get position number
                DTO.position c = (DTO.position)cboPosition.SelectedItem;
                string macv = c.PositionNumber.ToString();
                //images
                try {
                    Image ima = Image.FromFile(openFileDialogImage.FileName);
                    MemoryStream mem = new MemoryStream();
                    ima.Save(mem, ImageFormat.Jpeg);
                    try
                    {
                        string KeyToSelect = txtEmployeeID.Text;
                        employeeBLL.SaveEmployee(txtEmployeeID.Text, txtEmployeeName.Text, cboSex.Text, txtNumberID.Text, txtPhone.Text, dtmBirthDay.Value.ToString(), txtAddress.Text,
                                    txtPlaceBrith.Text, txtAge.Text, macv, txtSalary.Text, dtmDayWorking.Value.ToString(), mem, txtPassword.Text, cboStatus.Text,checkCheckbox());
                        DisplayNotify("Lưu thành công", 1);
                        dgvData.DataSource = employeeBLL.GetAllEmployee();
                        SelectRow(dgvData, KeyToSelect);

                    }
                    catch(Exception ex)
                    {
                        
                        DisplayNotify("Lỗi ghi dữ liệu xuống CSDL, mã lỗi: " + ex.Message, -1);
                        return;
                    }
                }
                catch(Exception ex)
                {
                    DisplayNotify("Lỗi load ảnh, mã lỗi: " + ex.Message, -1);
                }
                
            }
            else
            {
                DisplayNotify("Lỗi nhập dữ liệu, có thể bạn đã nhập sai hoặc thiếu các trường được đánh dấu đỏ", -1);


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave(0) == true)
            {
                string macv = "";
                //get position number
                try
                {
                    DTO.position c = (DTO.position)cboPosition.SelectedItem;
                     macv = c.PositionNumber.ToString();
                }
                catch(Exception ex)
                {

                    DisplayNotify("Lỗi không thể lấy dối tượng từ combobox để lưu dữ liệu, mã lỗi: " + ex.Message, -1);
                    return;
                }
                //image
                MemoryStream mem = new MemoryStream();
                if (txtImagelink.Text.Length == 0)
                {
                    Image ima = picImage.BackgroundImage;
                    ima.Save(mem, ImageFormat.Jpeg);
                }
                else
                {
                    try {
                        Image ima = Image.FromFile(txtImagelink.Text);
                        ima.Save(mem, ImageFormat.Jpeg);
                    }
                    catch(Exception ex)
                    {
                        Image ima = picImage.BackgroundImage;
                        ima.Save(mem, ImageFormat.Jpeg);
                        DisplayNotify("Lỗi khi lưu ảnh vào csdl, mã lỗi: " + ex.Message, -1);
                    }
                }
                try
                {
                    string KeyToSelect = txtEmployeeID.Text;
                    employeeBLL.UpdateEmployee(txtEmployeeID.Text, txtEmployeeName.Text, cboSex.Text, txtNumberID.Text, txtPhone.Text, dtmBirthDay.Value.ToString(), txtAddress.Text,
                                txtPlaceBrith.Text, txtAge.Text, macv, txtSalary.Text, dtmDayWorking.Value.ToString(), mem, txtPassword.Text, cboStatus.Text,checkCheckbox());
                    DisplayNotify("Cập nhật thành công", 1);
                    dgvData.DataSource = employeeBLL.GetAllEmployee();
                    SelectRow(dgvData, KeyToSelect);

                }
                catch(Exception ex)
                {
                    DisplayNotify("Lỗi ghi dữ liệu xuống CSDL, mã lỗi: " + ex.Message, -1);
                }
            }
            else
            {
                DisplayNotify("Lỗi nhập dữ liệu, có thể bạn đã nhập sai hoặc thiếu các trường được đánh dấu đỏ", -1);


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Check data
        public bool CheckBeforeSave(int index)
        {
            bool check = true;
            List<Control> textbox = new List<Control>();
            // textbox
            textbox.Add(txtEmployeeID);
            textbox.Add(txtEmployeeName);
            textbox.Add(cboSex);
            textbox.Add(txtNumberID);
            textbox.Add(txtPhone);
            textbox.Add(txtAddress);
            textbox.Add(txtPlaceBrith);
            textbox.Add(txtSalary);
            textbox.Add(txtImagelink);
            textbox.Add(txtPassword);
            textbox.Add(cboPosition);
            textbox.Add(cboStatus);
            foreach(Control c in textbox)
            {
                if(c.Text.Trim().Length==0)
                {
                    // imagelink
                    if (c.Name == "txtImagelink")
                    {
                        //luu
                        if(index==1)
                        {
                            this.Controls.Find(c.Tag.ToString(), true)[0].ForeColor = Color.Red;
                            check = false;
                        }
                    }
                    else
                    {
                        this.Controls.Find(c.Tag.ToString(), true)[0].ForeColor = Color.Red;
                        check = false;
                    }
                }
                else
                {
                    this.Controls.Find(c.Tag.ToString(), true)[0].ForeColor = Color.Green;
                    // field nuimber
                    bool checkflag = CheckFieldNumber(c);
                    if (checkflag == false)
                        check = false;
                }

            }
            //  ngay sinh
            if(dtmBirthDay.Value>= DateTime.Now)
            {
                check = false;
                lblBirthDay.ForeColor = Color.Red;
            }
            else
            {
                lblBirthDay.ForeColor =   Color.Green;
            }
            // ngay vao lam
            if ( dtmDayWorking.Value < dtmBirthDay.Value)
            {
                check = false;
                lblDayWorking.ForeColor = Color.Red;
            }
            else
            {
                lblDayWorking.ForeColor  = Color.Green;
            }
            
            return check;
        }

        public bool CheckFieldNumber(Control control)
        {
            bool check = true;
            // field number
            if (control.Name == "txtPhone" || control.Name == "txtNumberID" || control.Name == "txtSalary")
            {
                 
                if (control.Name == "txtPhone")
                {
                    if (rule.CheckPhone(control.Text) == false)
                    {
                        check = false;
                        this.Controls.Find(control.Tag.ToString(), true)[0].ForeColor = Color.Red;
                    }
                    else
                        this.Controls.Find(control.Tag.ToString(), true)[0].ForeColor = Color.Green;
                }
                else
                {
                    if (control.Name == "txtNumberID")
                    {
                        if (rule.CheckNumberID(control.Text) == false)
                        {
                            check = false;
                            this.Controls.Find(control.Tag.ToString(), true)[0].ForeColor = Color.Red;
                        }
                        else
                            this.Controls.Find(control.Tag.ToString(), true)[0].ForeColor = Color.Green;
                    }
                    else
                    {
                        if (rule.CheckNumber(control.Text) == false)
                        {
                            check = false;
                            this.Controls.Find(control.Tag.ToString(), true)[0].ForeColor = Color.Red;
                        }
                        else
                            this.Controls.Find(control.Tag.ToString(), true)[0].ForeColor = Color.Green;
                    }
                }
            }
            return check;
        }
        private void dtmBirthDay_ValueChanged(object sender, EventArgs e)
        {
            // ngay vao lam
            if (dtmDayWorking.Value < dtmBirthDay.Value)
            {
                lblDayWorking.ForeColor = Color.Red;
            }
            else
                lblDayWorking.ForeColor = Color.Black;
            //  ngay sinh
            if (dtmBirthDay.Value >= DateTime.Now)
            {
                lblBirthDay.ForeColor = Color.Red;
            }
            else
            {
                lblBirthDay.ForeColor = Color.Black;
                txtAge.Text = (DateTime.Now.Year - dtmBirthDay.Value.Year).ToString();
            }
        }

        private void Control_Layout(object sender, LayoutEventArgs e)
        {
            if (((Control)(sender)).Text.Trim().Length == 0)
            {
                this.Controls.Find(((Control)(sender)).Tag.ToString(), true)[0].ForeColor = Color.Red;
            }
            else
            {
                this.Controls.Find(((Control)(sender)).Tag.ToString(), true)[0].ForeColor = Color.Green;
            }
        }

        private void ControlTexxtbox_change(object sender, EventArgs e)
        {
            // all field
            if (((Control)(sender)).Text.Trim().Length == 0)
            {
                this.Controls.Find(((Control)(sender)).Tag.ToString(), true)[0].ForeColor = Color.Red;
            }
            else
            {
                this.Controls.Find(((Control)(sender)).Tag.ToString(), true)[0].ForeColor = Color.Green;
            }
            // field number
            CheckFieldNumber((Control)sender);
            
        }
        #endregion

        #region Notify
        public void ResetNotify()
        {
            lblNotify.Text = "";
            lblNotify.BackColor= Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
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

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.Controls.DataGridViewX g = (DevComponents.DotNetBar.Controls.DataGridViewX)sender;
            if (g.SelectedRows.Count == 1)
            {
                ClearTextboxToReload();
                DTO.Employee EmployeeSelected = (DTO.Employee)g.SelectedRows[0].DataBoundItem;
                
                txtEmployeeID.Text = EmployeeSelected.EmployeeID;
                txtEmployeeName.Text = EmployeeSelected.EmployeeName;
                cboSex.SelectedItem= EmployeeSelected.Sex;
                txtNumberID.Text = EmployeeSelected.NumberID;
                txtPhone.Text = EmployeeSelected.Phone;
                dtmBirthDay.Value =DateTime.Parse( EmployeeSelected.BirthDay);
                dtmDayWorking.Value = DateTime.Parse(EmployeeSelected.DayWorking);
                txtAddress.Text = EmployeeSelected.Address;
                txtPlaceBrith.Text = EmployeeSelected.PlaceBirth;
                txtAge.Text = EmployeeSelected.Age;
                
                //txtImagelink.Text = EmployeeSelected.ImageLink.ToString();
                txtPassword.Text = EmployeeSelected.PassWord;
                cboStatus.SelectedItem = EmployeeSelected.StatusName;
                SetSelectItemComboboxPosition(EmployeeSelected.PositionID);
                txtSalary.Text = EmployeeSelected.Salary;
                //image
                setChekbox(employeeBLL.GetFuntionByPositionID(EmployeeSelected.EmployeeID));
                try
                {
                    byte[] b = employeeBLL.GetImage(EmployeeSelected.EmployeeID);
                    MemoryStream mem = new MemoryStream(b);
                    Image ima = Image.FromStream(mem, true);
                    picImage.BackgroundImage = ima;
                }
                catch (Exception ex) { DisplayNotify("Lỗi không thể load dữ ảnh, mã lỗi: " + ex.Message,-1); };
                
                //btn
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                 

            }
            
        }
        public void setChekbox(List<string> arr)
        {
            if (arr[0] == "1")
                chkSale.Checked = true;
            else
                chkSale.Checked = false;

            if (arr[1] == "1")
                chkHouseWare.Checked = true;
            else
                chkHouseWare.Checked = false;

            if (arr[2] == "1")
                chkguarentee.Checked = true;
            else
                chkguarentee.Checked = false;

            if (arr[3] == "1")
                chkReport.Checked = true;
            else
                chkReport.Checked = false;

            if (arr[4] == "1")
                chkConfigEmployee.Checked = true;
            else
                chkConfigEmployee.Checked = false;
        }
        public List<string> checkCheckbox()
        {
            List<string> arr = new List<string>();

            if (chkSale.Checked == true)
                arr.Add("1");
            else
                arr.Add("0");

            if (chkHouseWare.Checked == true)
                arr.Add("1");
            else
                arr.Add("0");

            if (chkguarentee.Checked == true)
                arr.Add("1");
            else
                arr.Add("0");

            if (chkReport.Checked == true)
                arr.Add("1");
            else
                arr.Add("0");

            if (chkConfigEmployee.Checked == true)
                arr.Add("1");
            else
                arr.Add("0");
            return arr;
        }
        public void SetSelectItemComboboxPosition(string ID )
        {
            for(int i=0; i<cboPosition.Items.Count;i++)
            {
                DTO.position a = (DTO.position)(cboPosition.Items[i]);
                if (a.PositionNumber==ID)
                {
                    cboPosition.SelectedIndex = i;
                    break;
                }
            }
        }
       
        public void ClearTextbox()
        {
            try
            {
                txtEmployeeID.Text = employeeBLL.CreateEmployeeID();

            }
            catch (Exception ex)
            {
                DisplayNotify("Lỗi tạo mới nhân viên !", -1);
            }
            cboPosition.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboSex.SelectedIndex = -1;
            //textbox 
            txtEmployeeName.Text = null;
            cboSex.Text = null;
            txtNumberID.Text = null;
            txtPhone.Text = null;
            txtAddress.Text = null;
            txtPlaceBrith.Text = null;
            txtSalary.Text = null;
            txtImagelink.Text = null;
            txtPassword.Text = null;
            txtAge.Text = null;
            cboPosition.Text = null;
            cboStatus.Text = null;
            // date
            dtmBirthDay.Value = DateTime.Now;
            dtmDayWorking.Value = DateTime.Now;
            //notify
            lblNotify.Text = null;
            lblNotify.BackColor = Color.Green;
            //button
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            //dât
            dgvData.ClearSelection();
            //pic
            picImage.BackgroundImage = null;
        }
        public void ClearTextboxToReload()
        {
            cboPosition.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboSex.SelectedIndex = -1;
            //textbox 
            txtEmployeeName.Text = null;
            cboSex.Text = null;
            txtNumberID.Text = null;
            txtPhone.Text = null;
            txtAddress.Text = null;
            txtPlaceBrith.Text = null;
            txtSalary.Text = null;
            txtImagelink.Text = null;
            txtPassword.Text = null;
            txtAge.Text = null;
            cboPosition.Text = null;
            cboStatus.Text = null;
            // date
            dtmBirthDay.Value = DateTime.Now;
            dtmDayWorking.Value = DateTime.Now;
          
           //pic
            picImage.BackgroundImage = null;
        }

        public void SelectRow(DataGridView dgv, string key)
        {
            for(int i=0; i<dgv.RowCount; i++)
            {
                for(int j=0; j<dgv.Rows[i].Cells.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null && dgv.Rows[i].Cells[j].Value!="")
                    {
                        if (dgv.Rows[i].Cells[j].Value.ToString() == key)
                        {
                            dgv.Rows[i].Selected = true;
                            dgvData.FirstDisplayedScrollingRowIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            
                //frmPosition f = new frmPosition();
                //f.ShowDialog();
                Form s = new frmPosition();
                s.TopLevel = false;
                s.Visible = true;
                s.Location = new Point(0, 0);
                Main.AddForm(s, "Thêm vị trí");
           
        }

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                DTO.position c = (DTO.position)cboPosition.SelectedItem;
                if (c!=null)
                {
                    //DTO.position c = (DTO.position)cboPosition.SelectedItem;
                    string macv = c.PositionNumber.ToString();
                    setChekbox(employeeBLL.GetFuntionByPositionID(macv));
                    txtSalary.Text = c.Salary;
                }
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi đọc danh sách đề nghị cho mỗi vị trí, bạn có thể tự nhập "+ex.Message,-1);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // get list position
            try
            {
                cboPosition.DataSource = employeeBLL.GetListPosition();
                cboPosition.DisplayMember = "PositionName";
                cboPosition.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                DisplayNotify("Lỗi đọc danh sách chức vụ!!, mã lỗi: " + ex.Message, -1);
                return;
            }
            //load dgview
            try
            {

                dgvData.DataSource = employeeBLL.GetAllEmployee();
                //Console.WriteLine("asas"+ dgvData.DataBindings.ToString());
                dgvData.ClearSelection();
                ClearTextbox();



            }
            catch (Exception ex)
            {
                DisplayNotify("Lỗi đọc danh sách Nhân viên, mã lỗi: " + ex.Message, -1);
            }

        }

        private void txtDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
