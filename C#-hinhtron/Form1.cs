using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__hinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double TinhDT (double bk)
        { return bk * bk * Math.PI; }
        double TinhCV(double bk)
        { return bk * 2 * Math.PI; }


        private void btndientich_Click(object sender, EventArgs e)
        {
            Double r, p;
            r = Convert.ToDouble(txt1.Text);

            p = Math.PI * r * r;
            txtkq.Text = p.ToString();
        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            Double r,p;
            r = Convert.ToDouble(txt1.Text);
            
            p = Math.PI*r*2;
            txtkq.Text = p.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntinh1_Click(object sender, EventArgs e)
        {
            double r=Convert.ToDouble(txt1.Text);
            if (rdbdt1.Checked)
            {
                double dientich=r*r*Math.PI;
                string thongbao = "-diện tích" + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (rdbcv1.Checked)
            {
                double chuvi = r * 2* Math.PI;
                string thongbao = "-chu vi" + Convert.ToString(chuvi);
                MessageBox.Show(thongbao, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btntinh2_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txt1.Text);
            string thongbao = "";
            if (chkdt2.Checked)
            {
                double dientich=bankinh*bankinh*Math.PI;
                thongbao = thongbao + "-Diện tích" + Convert.ToString(dientich) + Environment.NewLine;

            }
            if (chkcv2.Checked)
            {
                double chuvi= bankinh * 2 * Math.PI;
                thongbao = thongbao + "-Chu vi" + Convert.ToString(chuvi) + Environment.NewLine;

            }
            if(thongbao.Length > 0)
            {
               MessageBox.Show(thongbao,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tính năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
