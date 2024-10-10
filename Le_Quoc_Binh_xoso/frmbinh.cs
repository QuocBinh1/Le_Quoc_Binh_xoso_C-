using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Le_Quoc_Binh_xoso
{
    public partial class frmbinh : Form
    {
        private bool isSpinningG8 = false;
        private bool isSpinningG7 = false;
        private bool isSpinningG61 = false;
        private bool isSpinningG62 = false;
        private bool isSpinningG63 = false;
        private bool isSpinningG5 = false;
        private bool isSpinningG4 = false;
        private bool isSpinningG3 = false;
        private bool isSpinningG2 = false;
        private bool isSpinningG1 = false;
        private bool isSpinningGDB = false; 

        public frmbinh()
        {
            InitializeComponent();
            
        }
        private int randomnumber(int min , int max )
        {
            Random random = new Random();
            return random.Next(min, max +1);
        }

        //giải 4 số : g6 , g5 
        //giải 5 số : g4 ,g3 ,g2,g1 
        
        private async void btnplay_Click(object sender, EventArgs e)
        {
            // chạy thời gian ngày giờ
            timer1.Start();
            //8888888888888888888888888888888888888888888888888888888888888888888888888
            isSpinningG8 = true; // Bắt đầu quay số cho Giải 8
            StartSpinning(kqg8);
            int G8 = randomnumber(10, 99);
            await Task.Delay(1000);
            isSpinningG8 = false; // Dừng quay số cho Giải 8
            kqg8.Text = G8.ToString(); // Hiển thị kết quả Giải 8
            //777777777777777777777777777777777777777777777777777777777777777777
            isSpinningG7 = true; // Bắt đầu quay số cho Giải 7
            StartSpinning(kqg7);
            int G7 = randomnumber(100, 999);
            await Task.Delay(2000);
            isSpinningG7 = false; // Dừng quay số cho Giải 7
            kqg7.Text = G7.ToString(); // Hiển thị kết quả Giải 7
            //61
            isSpinningG61 = true; 
            StartSpinning(kqg61);
            int G61 = randomnumber(1000  , 9999);
            await Task.Delay(3000);
            isSpinningG61 = false; 
            kqg61.Text = G61.ToString();
            //62
            isSpinningG62 = true;
            StartSpinning(kqg62);
            int G62 = randomnumber(1000, 9999);
            await Task.Delay(4000);
            isSpinningG62 = false;
            kqg62.Text = G62.ToString();
            //63
            isSpinningG63 = true;
            StartSpinning(kqg63);
            int G63 = randomnumber(1000, 9999);
            await Task.Delay(3000);
            isSpinningG63 = false;
            kqg63.Text = G61.ToString();


            //55555555555555555555555555555555555555555555555555555555555555555555555


            // Quay số Giải Đặc Biệt
            isSpinningGDB = true; // Bắt đầu quay số cho Giải Đặc Biệt
            StartSpinning(kqgdb);
            int GDB = randomnumber(100000, 999999);
            await Task.Delay(7000); // Đợi 15 giây
            isSpinningGDB = false; // Dừng quay số cho Giải Đặc Biệt
            kqgdb.Text = GDB.ToString(); // Hiển thị kết quả Giải Đặc Biệt

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbl_gio.Text = String.Format("{0:hh:mm:ss tt}", dt);
            lbl_ngaythang.Text = String.Format("{0:dd/MM/yyyy}", dt);

        }
        private async void StartSpinning(Label lb)
        {
            while (isSpinningG8 || isSpinningGDB || isSpinningG7 || isSpinningG61 ||isSpinningG62||isSpinningG63 || isSpinningG5 ||isSpinningG41
            {
                if (lb == kqg8 && isSpinningG8)
                {
                    lb.Text = randomnumber(10, 99).ToString(); // Quay số cho Giải 8
                }
                else if (lb == kqgdb && isSpinningGDB)
                {
                    lb.Text = randomnumber(100000, 999999).ToString(); // Quay số cho Giải Đặc Biệt
                }
                else if (lb == kqg7 && isSpinningG7)
                {
                    lb.Text = randomnumber(100, 999).ToString(); // Quay số cho Giải Đặc Biệt
                }
                else if (lb == kqg61 && isSpinningG61)
                {
                    lb.Text = randomnumber(1000, 9999).ToString(); // Quay số cho Giải Đặc Biệt
                }
                else if (lb == kqg62 && isSpinningG62)
                {
                    lb.Text = randomnumber(1000, 9999).ToString(); // Quay số cho Giải Đặc Biệt
                }
                else if (lb == kqg63 && isSpinningG63)
                {
                    lb.Text = randomnumber(1000, 9999).ToString(); // Quay số cho Giải Đặc Biệt
                }


                await Task.Delay(200); // Thay đổi số mỗi 200ms
            }
        }
        

        

    }

}
