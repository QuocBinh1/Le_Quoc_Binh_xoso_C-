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
    public partial class HistoryForm : Form
    {
        public DateTime SelectedDate { get; set; }
        public HistoryForm()
        {
            InitializeComponent();
            SelectedDate = SelectedDate;

        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            //LoadLotteryResults(SelectedDate);
            
        }
    }
}
