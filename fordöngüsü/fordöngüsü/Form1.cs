using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fordöngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            int baslangic=Convert.ToInt32(txtBaslangic.Text);
            int Bitis=Convert.ToInt32(txtBitis.Text);   

            for(int i = baslangic; i <= Bitis; i++)
            {
                lst1.Items.Add(i);
            }
        }
    }
}
