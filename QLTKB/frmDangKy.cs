using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTKB
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            cbq.Items.Add("0");
            cbq.Items.Add("1");
            cbq.Items.Add("2");
        }

        private void cbq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbq.Text == "0")
                lbten.Text = "admin";
            else if (cbq.Text == "1")
                lbten.Text = "Giáo viên";
            else if (cbq.Text == "2")
                lbten.Text = "Sinh viên";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttk.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Bạn chưa nhập tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    txttk.Focus();
                return;
            }
            if (txtmk.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Bạn chưa nhập mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    txtmk.Focus();
                return;
            }
            string sql = "Select count(*) from tblLogin where Id=N'" + txttk.Text + "'";
            if (cn.LoadLable(sql) == "0")
            {
                cn.ExcuteNonQuery("insert into tblLogin values(N'" + txttk.Text + "',N'" + txtmk.Text + "',N'" + cbq.Text + "')");
                try
                {
                    MessageBox.Show("Đăng ký Thành Công");
                }
                catch
                {
                    MessageBox.Show("Đăng ký Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã có !! Vui lòng chọn tên khác");
                txttk.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmk_CheckedChanged(object sender, EventArgs e)
        {
            txtmk.PasswordChar = cbmk.Checked ? '\0' : '*';
        }
        
    }
}
