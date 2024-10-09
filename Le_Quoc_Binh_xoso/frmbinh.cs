using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Quoc_Binh_xoso
{
    public partial class frmbinh : Form
    {
        public frmbinh()
        {
            InitializeComponent();
        }
        private int randomnumber(int min = 01, int max = 99)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void btnplay_Click(object sender, EventArgs e)
        {
            int min = Properties.Settings.Default.numberMin;
            int max = Properties.Settings.Default.numberMax;
            int numresult = randomnumber(min,max);
            lbg8.Text = numresult.ToString();
             
        }
    }
}
