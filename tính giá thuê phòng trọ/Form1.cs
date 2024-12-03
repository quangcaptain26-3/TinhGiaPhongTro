using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tính_giá_thuê_phòng_trọ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ra không hả?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if(thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttontinhgiaphong_Click(object sender, EventArgs e)
        {
            double a, b;
            if(tboxgiaphong != null)
            {
                a=int.Parse(tboxgiaphong.Text);
            }
            else { a=0; };
            if(tboxloaiphong != null)
            {
                b = int.Parse(tboxloaiphong.Text);
            }
            else { b =0; };
            if (b == 1)
            {
                tboxtonggiaphong.Text =a.ToString();
            }
            if (b == 2)
            {
                tboxtonggiaphong.Text=(a*1.5).ToString();
            }
            if(b == 3)
            {
                tboxtonggiaphong.Text=(a*2).ToString();
            };
            
        }

        private void buttontinhgiadv_Click(object sender, EventArgs e)
        {
            double a, b,c;
            if (tboxgiaphong != null)
            {
                a = int.Parse(tboxgiaphong.Text);
            }
            else { a = 0; };
            if (tboxloaiphong != null)
            {
                b = int.Parse(tboxloaiphong.Text);
            }
            else { b = 0; };
            if (b == 1)
            {
                tboxtonggiaphong.Text = a.ToString();
            }
            if (b == 2)
            {
                tboxtonggiaphong.Text = (a * 1.5).ToString();
            }
            if (b == 3)
            {
                tboxtonggiaphong.Text = (a * 2).ToString();
            };
            c = int.Parse(tboxtonggiaphong.Text);
            tboxgiadichvu.Text = (c*0.1).ToString();
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            tboxsophong.ResetText();
            tboxgiaphong.ResetText();
            tboxloaiphong.ResetText();
            tboxgiadichvu.ResetText();
            tboxtonggiaphong.ResetText();
        }
    }
}
