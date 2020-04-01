using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDiamond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            for (int i = 1; i<=a; i++)
            {
                for (int j = a; j >=i ; j--)
                {
                    label2.Text += (" ").ToString() ;
                }
                for (int k = 1; k <= 2*i-1; k++)
                {
                    label2.Text += ("*").ToString() ;
                }
                label2.Text += "\n";
            }

        }
    }
}
