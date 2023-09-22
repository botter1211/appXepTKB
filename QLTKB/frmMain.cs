using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTKB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }       
        private string quyen;

        public string QUYEN
        {
            get
            {
                return quyen;
            }
            set
            {
                quyen = value;
            }
        }
        private Form kiemtratontai(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmKhoa));
            if (frm != null)
                frm.Activate();
            else
            {
                frmKhoa fr = new frmKhoa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void phòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmPhongHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmPhongHoc fr = new frmPhongHoc();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmGiaoVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frmGiaoVien fr = new frmGiaoVien();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLop fr = new frmLop();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmMonHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmMonHoc fr = new frmMonHoc();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void xếpTKBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmXepTKB));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXepTKB fr = new frmXepTKB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (quyen == "1")//quyền giáo viên xem tkb
            {
                mncn.Enabled = false;
                mnxtkb.Enabled = false;
                mndk.Enabled = false;
                mnuqltk.Enabled = false;
                mnbaocao.Enabled = true;
            }
            if (quyen == "2")//quyền sinh viên xem tkb
            {
                mncn.Enabled = false;
                mnxtkb.Enabled = false;
                mndk.Enabled = false;
                mnuqltk.Enabled = false;
                mnbaocao.Enabled = false;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap fr = new frmDangNhap();
            this.Hide();
            fr.Show();
        }

        private void mnxem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmXemTKB));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXemTKB fr = new frmXemTKB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mndk_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmDangKy));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDangKy fr = new frmDangKy();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuqltk_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmQLTK));
            if (frm != null)
                frm.Activate();
            else
            {
                frmQLTK fr = new frmQLTK();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void mnbcmh_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmbaocaomh));
            if (frm != null)
                frm.Activate();
            else
            {
                frmbaocaomh fr = new frmbaocaomh();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void mnbck_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmbaocaok));
            if (frm != null)
                frm.Activate();
            else
            {
                frmbaocaok fr = new frmbaocaok();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void mnubctkb_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(frmbaocaotkb));
            if (frm != null)
                frm.Activate();
            else
            {
                frmbaocaotkb fr = new frmbaocaotkb();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}
