using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace qlBanHang
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        CThdBLL CThdBLL =new CThdBLL();
        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            List<DOANHSO> time = CThdBLL.time();
            cmbNam.DataSource=time;
            cmbThang.DataSource=time;
            cmbNam.ValueMember = "year";
            cmbThang.ValueMember = "NgayLapHD";

            List<DOANHSO> list = CThdBLL.money();
            chartmoney.DataSource = list;
            for (int i = 0; i < list.Count; i++)
            {
                chartmoney.Series["Series1"].Points.Add(list[i].tien);
                chartmoney.Series["Series1"].Points[i].AxisLabel = list[i].NgayLapHD.ToString() ;
             

                //chartSP.Series["Series1"].Points.Add(list[i].SoLuong);
                //chartSP.Series["Series1"].Points[i].AxisLabel = list[i].NgayLapHD.ToString();

            }

            chartmoney.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chartmoney.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            //chartSP.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            //chartSP.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;


            List<DOANHSO> sp = CThdBLL.sp();
         
            for (int i = 0; i < sp.Count; i++)
            {

                chartSP.Series["Series1"].Points.Add(sp[i].SoLuong);
                //chartSP.Series["Series1"].Points[i].LabelAngle = sp[i].SoLuong;
                chartSP.Series["Series1"].Points[i].AxisLabel = sp[i].TenSP;

            }

        }

        private void chartSP_Click(object sender, EventArgs e)
        {

        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
