using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTKB
{
    public partial class frmbaocaotkb : Form
    {
        public frmbaocaotkb()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();

        private void frmbaocaotkb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTKBDataSet.tblTKB' table. You can move, or remove it, as needed.
            //this.tblTKBTableAdapter.Fill(this.QLTKBDataSet.tblTKB);

            //this.reportViewer1.RefreshReport();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-PKNFDUT;Initial Catalog=QLTKB;User ID=sa;Password=123");
            //string sql = "Select * from tblTKB where Ngay BETWEEN '" + txttn.Text + "' and  '" + txtdn.Text + "'";
            
            //SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);

            
            ////Đường dẫn báo cáo
            
            ////Nếu có dữ liệu
            
            //    //Tạo nguồn dữ liệu cho báo cáo
            //    ReportDataSource rds = new ReportDataSource("QLTKB1", dt);
                
               
            //    //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            //    reportViewer1.LocalReport.DataSources.Clear();
            //    //Add dữ liệu vào báo cáo
            //    reportViewer1.LocalReport.DataSources.Add(rds);
            //    //Refresh lại báo cáo
            //    reportViewer1.RefreshReport();
            this.tblTKBTableAdapter.Fill(this.QLTKBDataSet.tblTKB, txttn.Value, txtdn.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
