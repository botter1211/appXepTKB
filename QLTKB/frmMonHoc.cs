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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            cbn.Text = "";
        }
        public void Locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            cbn.Enabled = false;
            txttim.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnXem.Enabled = true;
            btntim.Enabled = true;
        }
        public void Un_locktex()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            cbn.Enabled = true;

            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnXem.Enabled = false;
            btntim.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Môn";
            msds.Columns[0].Width = 150;
            msds.Columns[0].Frozen = true;

            msds.Columns[1].HeaderText = "Tên Môn";
            msds.Columns[1].Width = 150;
            msds.Columns[2].HeaderText = "Mã Khoa";
            msds.Columns[2].Width = 150;
        }
        public void hienthi()
        {
            string sql = "Select * from tblMonHoc";
            msds.DataSource = cn.taobang(sql);
        }
        public void hienthitimkiem()
        {
            string sql = "Select * from tblMonHoc where MaMon like '%" + txttim.Text + "%'";
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
                if (txtma.Text.Trim().Length == 0)
                {
                    if (MessageBox.Show("Bạn chưa nhập mã môn học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        txtma.Focus();
                    return;
                }
                if (txtten.Text.Trim().Length == 0)
                {
                    if (MessageBox.Show("Bạn chưa nhập tên môn học !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        txtten.Focus();
                    return;
                }
                string sql = "Select count(*) from tblMonHoc where MaMon=N'" + txtma.Text + "'";
                if (cn.LoadLable(sql) == "0")
                {
                    cn.ExcuteNonQuery("insert into tblMonHoc values(N'" + txtma.Text + "',N'" + txtten.Text + "',N'" + cbn.Text + "')");
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
                    MessageBox.Show("Mã Này Đã Có");
                    txtma.Focus();
                }
            }
            else
            {
                cn.ExcuteNonQuery("update tblMonHoc set TenMon=N'" + txtten.Text + "',MaKhoa =N'" + cbn.Text + "' where MaMon=N'" + txtma.Text + "'");
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
            txtma.Enabled = false;
            Un_locktex();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            cn.ExcuteNonQuery("delete tblMonHoc where MaMon=N'" + txtma.Text + "'");
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

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Locktext();
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbn.Text = msds.Rows[dong].Cells[2].Value.ToString();
        }

        private void fr_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
            Locktext();
            cn.LoadLenCombobox(cbn, "Select MaKhoa from tblKhoa", 0);
        }

        private void cbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbten.Text = cn.LoadLable("Select TenKhoa from tblKhoa where MaKhoa=N'" + cbn.Text + "'");
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frmbaocaomh frm = new frmbaocaomh();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            //if (txttim.Text.Trim().Length == 0)
            //{
            //    hienthi();
            //}
            //else
            //{
            //    hienthitimkiem();
            //}
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
