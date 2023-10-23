using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSebze.Items.Count; i++)
            {
                if (lstSebze.Items[i].ToString() == "Brokoli" ||
                    lstSebze.Items[i].ToString() == "Havuç" ||
                    lstSebze.Items[i].ToString() == "Pırasa")
                {
                    lstMeyve.Items.Add(lstSebze.Items[i]);
                }
                else
                {
                    lstMahsul.Items.Add(lstSebze.Items[i]);
                }

            }
        }
    }
}
