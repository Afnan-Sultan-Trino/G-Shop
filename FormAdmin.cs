using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace G_Shop
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            SetupSalesChart();
            SetupCategoryChart();

        }
        private void SetupSalesChart()
        {
            chart1.Series["Sales(By Time)"].Points.AddXY("9 AM", 1200);
            chart1.Series["Sales(By Time)"].Points.AddXY("10 AM", 1800);
            chart1.Series["Sales(By Time)"].Points.AddXY("11 AM", 1500);
            chart1.Series["Sales(By Time)"].Points.AddXY("12 PM", 2200);
            chart1.Series["Sales(By Time)"].Points.AddXY("1 PM", 5000);
            chart1.Series["Sales(By Time)"].Points.AddXY("2 PM", 890);
            chart1.Series["Sales(By Time)"].Points.AddXY("3 PM", 3000);
        }
        private void SetupCategoryChart()
        {
            chart2.Series["Sales(By Categories)"].Points.AddXY("Smartphones", 4500);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Laptop", 56000);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Smart-Watch", 2500);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Tablet", 18500);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Mouse", 3400);
            chart2.Series["Sales(By Categories)"].Points.AddXY("Others", 500);

        }

        private void lblDashBoard_MouseEnter(object sender, EventArgs e)
        {
            lblDashBoard.BackColor = Color.Red;
            lblDashBoard.Cursor = Cursors.Hand;
        }

        private void lblDashBoard_MouseLeave(object sender, EventArgs e)
        {
            lblDashBoard.BackColor = Color.Transparent;

        }

        private void lblProduct_MouseEnter(object sender, EventArgs e)
        {
            lblProduct.BackColor = Color.Red;
            lblProduct.Cursor = Cursors.Hand;
        }

        private void lblProduct_MouseLeave(object sender, EventArgs e)
        {
            lblProduct.BackColor = Color.Transparent;
        }

        private void lblCatagory_MouseEnter(object sender, EventArgs e)
        {
            lblCatagory.BackColor = Color.Red;
            lblCatagory.Cursor = Cursors.Hand;
        }

        private void lblCatagory_MouseLeave(object sender, EventArgs e)
        {
            lblCatagory.BackColor= Color.Transparent;
        }

        private void lblSalesReport_MouseEnter(object sender, EventArgs e)
        {
            lblSalesReport.BackColor = Color.Red;
            lblSalesReport.Cursor = Cursors.Hand;
        }

        private void lblSalesReport_MouseLeave(object sender, EventArgs e)
        {
            lblSalesReport.BackColor = Color.Transparent;
        }

        private void lblUser_MouseEnter(object sender, EventArgs e)
        {
            lblUser.BackColor = Color.Red;
            lblUser.Cursor = Cursors.Hand;
        }

        private void lblUser_MouseLeave(object sender, EventArgs e)
        {
            lblUser.BackColor = Color.Transparent;
        }

        private void lblSetting_MouseEnter(object sender, EventArgs e)
        {
            lblSetting.BackColor = Color.Red;
            lblSetting.Cursor = Cursors.Hand;
        }

        private void lblSetting_MouseLeave(object sender, EventArgs e)
        {
            lblSetting.BackColor = Color.Transparent;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
