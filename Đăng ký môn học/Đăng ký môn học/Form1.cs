using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đăng_ký_môn_học
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
            lop.SelectedIndex = 0;
            rdn1.Checked = true;
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtkq.Text = "Họ tên: " + txtten.Text + "\r\n" +
                "Ngày sinh: " + dateTimePicker1.Text + "\r\n" +
                "Lớp: " + lop.Text + "\r\n";
            foreach (Control c in grb_subject.Controls)
            {
      
                if (c is CheckBox )
                {
                    CheckBox cb = (CheckBox) c;
                    if (cb.Checked)
                    {
                        txtkq.Text += cb.Text + "\r\n";
                    }
                    
                }
            }
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox b = (CheckBox)c;
                    b.Checked = true;
                }
            }
        }

        private void cb_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach(Control c in grb_subject.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = cb_selectAll.Checked;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = (MessageBox.Show("Bạn có muốn thoát khỏi chương trình này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtten.ResetText();
            txtkq.ResetText();
            lop.ResetText();
            dateTimePicker1.ResetText();
            foreach (Control c in grb_subject.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                }
            }
        }
    }
}
