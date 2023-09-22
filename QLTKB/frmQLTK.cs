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
    public partial class frmQLTK : Form
    {
        public frmQLTK()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;

        public void setnull()
        {
            txttk.Text = "";
            txtmk.Text = "";
            cbq.Text = "";
        }
        public void Locktext()
        {
            txttk.Enabled = false;
            txtmk.Enabled = false;
            cbq.Enabled = false;
            txttim.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btntim.Enabled = true;
        }
        public void Un_locktex()
        {
            txttk.Enabled = true;
            txtmk.Enabled = true;
            cbq.Enabled = true;

            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btntim.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Tài khoản";
            msds.Columns[0].Width = 150;
            msds.Columns[0].Frozen = true;

            msds.Columns[1].HeaderText = "Mật khẩu";
            msds.Columns[1].Width = 150;

            msds.Columns[2].HeaderText = "Quyền";
            msds.Columns[2].Width = 150;
        }
        public void hienthi()
        {
            string sql = "Select * from tblLogin";
            msds.DataSource = cn.taobang(sql);
        }
        public void hienthitimkiem()
        {
            string sql = "Select * from tblLogin where Id like '%" + txttim.Text + "%'";
            msds.DataSource = cn.taobang(sql);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            setnull();
            Un_locktex();
            themmoi = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                if (txttk.Text.Trim().Length == 0)
                {
                    if (MessageBox.Show("Bạn chưa nhập tên tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
                        hienthi();
                        MessageBox.Show("Lưu Thành Công");
                    }
                    catch
                    {
                        MessageBox.Show("Lưu Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản này đã có");
                    txttk.Focus();
                }
            }
            else
            {
                cn.ExcuteNonQuery("update tblLogin set Pass=N'" + txtmk.Text + "',Quyen=N'" + cbq.Text + "' where Id=N'" + txttk.Text + "'");
                try
                {
                    hienthi();
                    MessageBox.Show("Sửa Thành Công");
                }
                catch
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            txttk.Enabled = false;
            Un_locktex();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cn.ExcuteNonQuery("delete tblLogin where Id=N'" + txttk.Text + "'");
            try
            {
                hienthi();
                MessageBox.Show("Xóa Thành Công");
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
            Locktext();
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

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Locktext();
            dong = e.RowIndex;
            txttk.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtmk.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbq.Text = msds.Rows[dong].Cells[2].Value.ToString();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            txttim.Enabled = true;
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            if (txttim.Text.Trim().Length == 0)
            {
                hienthi();
            }
            else
            {
                hienthitimkiem();
            }
        }
    }
}
