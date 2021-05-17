using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btnEvent
{
    public partial class Form1 : Form
    {

        Button btn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 50; i++)
            {
                btn = new Button();
                btn.Text = "ปุ่มที่ " + i;
                btn.Width = 100;
                btn.Height = 50;

                btn.Click += new EventHandler(btnclick);

                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void btnclick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text, "Message");
        }
    }
}
