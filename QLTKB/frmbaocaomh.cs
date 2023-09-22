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
    public partial class frmbaocaomh : Form
    {
        public frmbaocaomh()
        {
            InitializeComponent();
        }

        private void frmbaocaomh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTKBDataSet.tblMonHoc' table. You can move, or remove it, as needed.
            this.tblMonHocTableAdapter.Fill(this.QLTKB1.tblMonHoc);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
