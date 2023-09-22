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
    public partial class frmbaocaok : Form
    {
        public frmbaocaok()
        {
            InitializeComponent();
        }

        private void frmbaocaok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTKBDataSet.tblKhoa' table. You can move, or remove it, as needed.
            this.tblKhoaTableAdapter.Fill(this.QLTKBDataSet.tblKhoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
