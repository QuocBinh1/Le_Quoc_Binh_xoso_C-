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
using NAudio.Wave;
using System.IO;
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
        private bool isSpinningG41 = false;
        private bool isSpinningG42 = false;
        private bool isSpinningG43= false;
        private bool isSpinningG44 = false;
        private bool isSpinningG45 = false;
        private bool isSpinningG46 = false;
        private bool isSpinningG47 = false;
        private bool isSpinningG31 = false;
        private bool isSpinningG32 = false;
        private bool isSpinningG2 = false;
        private bool isSpinningG1 = false;
        private bool isSpinningGDB = false;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        int time = 1;
        public frmbinh()
        {
            InitializeComponent();
        }
        private async void btnplay_Click(object sender, EventArgs e)
        {
            // Phát âm thanh khi bắt đầu quay số
            PlayMp3(@"C:\Users\binhp\Downloads\nhacxoso.mp3");
            // chạy thời gian ngày giờ
            timer1.Start();
            //8
            isSpinningG8 = true; // Bắt đầu quay số cho Giải 8
            StartSpinning(kqg8);
            int G8 = randomnumber(10, 99);
            await Task.Delay(1000);
            isSpinningG8 = false; // Dừng quay số cho Giải 8
            kqg8.Text = G8.ToString(); // Hiển thị kết quả Giải 8
            //7
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
            await Task.Delay(5000);
            isSpinningG63 = false;
            kqg63.Text = G61.ToString();
            //5
            isSpinningG5 = true;
            StartSpinning(kqg5);
            int G5 = randomnumber(1000, 9999);
            await Task.Delay(5000);
            isSpinningG5 = false;
            kqg5.Text = G5.ToString();
            //g41
            isSpinningG41 = true;
            StartSpinning(kqg41);
            int G41 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG41 = false;
            kqg41.Text = G41.ToString();
            //g42
            isSpinningG42 = true;
            StartSpinning(kqg42);
            int G42 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG42 = false;
            kqg42.Text = G42.ToString();
            //g43
            isSpinningG43 = true;
            StartSpinning(kqg43);
            int G43 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG43 = false;
            kqg43.Text = G43.ToString();
            //44
            isSpinningG44 = true;
            StartSpinning(kqg44);
            int G44 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG44 = false;
            kqg44.Text = G44.ToString();
            //45
            isSpinningG45 = true;
            StartSpinning(kqg45);
            int G45 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG45 = false;
            kqg45.Text = G45.ToString();
            //46
            isSpinningG46 = true;
            StartSpinning(kqg46);
            int G46 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG46 = false;
            kqg46.Text = G46.ToString();
            //47
            isSpinningG47 = true;
            StartSpinning(kqg47);
            int G47 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG47 = false;
            kqg47.Text = G47.ToString();
            //31
            isSpinningG31 = true;
            StartSpinning(kqg31);
            int G31 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG31 = false;
            kqg31.Text = G31.ToString();
            //32
            isSpinningG32 = true;
            StartSpinning(kqg32);
            int G32 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG32 = false;
            kqg32.Text = G32.ToString();
            //2
            isSpinningG2 = true;
            StartSpinning(kqg2);
            int G2 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG2 = false;
            kqg2.Text = G2.ToString();
            //1
            isSpinningG1 = true;
            StartSpinning(kqg1);
            int G1 = randomnumber(10000, 99999);
            await Task.Delay(5000);
            isSpinningG1 = false;
            kqg1.Text = G1.ToString();
            // Quay số Giải Đặc Biệt
            isSpinningGDB = true; // Bắt đầu quay số cho Giải Đặc Biệt
            StartSpinning(kqgdb);
            int GDB = randomnumber(100000, 999999);
            await Task.Delay(7000); // Đợi 15 giây
            isSpinningGDB = false; // Dừng quay số cho Giải Đặc Biệt
            kqgdb.Text = GDB.ToString(); // Hiển thị kết quả Giải Đặc Biệt
            //dừng nhạc
            //StopMp3();

            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string filePath = $@"C:\C#xoso\{currentDateTime}.txt"; // Bạn có thể thay đổi đường dẫn theo ý muốn

            Directory.CreateDirectory(@"C:\C#xoso");
            using (StreamWriter sw = new StreamWriter(filePath, true)) // 'true' để ghi tiếp vào file nếu đã tồn tại
            {
                sw.WriteLine($"Ngày {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                sw.WriteLine($"Giải 8: {{{G8}}}");
                sw.WriteLine($"Giải 7: {{{G7}}}");
                sw.WriteLine($"Giải 6: {{{G61},{G62},{G63}}}");
                sw.WriteLine($"Giải 5: {{{G5}}}");
                sw.WriteLine($"Giải 4: {{{G41},{G42},{G43},{G44},{G45},{G46},{G47}}}");
                sw.WriteLine($"Giải 3: {{{G31},{G32}}}");
                sw.WriteLine($"Giải 2: {{{G2}}}");
                sw.WriteLine($"Giải 1: {{{G1}}}");
                sw.WriteLine($"Giải ĐB: {{{GDB}}}");
                sw.WriteLine("-----------------------------"); // Ngăn cách mỗi lần quay
            }
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
                || isSpinningG42 || isSpinningG43 || isSpinningG44 || isSpinningG45 || isSpinningG46 || isSpinningG47|| isSpinningG31 || isSpinningG32||isSpinningG2||isSpinningG1) // Quay nếu còn một trong hai giải đang quay
            {
                if (lb == kqg8 && isSpinningG8)
                {
                    lb.Text = randomnumber(10, 99).ToString();
                }
                else if (lb == kqgdb && isSpinningGDB)
                {
                    lb.Text = randomnumber(100000, 999999).ToString();
                }
                else if (lb == kqg7 && isSpinningG7)
                {
                    lb.Text = randomnumber(100, 999).ToString();
                }
                else if (lb == kqg61 && isSpinningG61)
                {
                    lb.Text = randomnumber(1000, 9999).ToString();
                }
                else if (lb == kqg62 && isSpinningG62)
                {
                    lb.Text = randomnumber(1000, 9999).ToString();
                }
                else if (lb == kqg63 && isSpinningG63)
                {
                    lb.Text = randomnumber(1000, 9999).ToString();
                }
                else if (lb == kqg5 && isSpinningG5)
                {
                    lb.Text = randomnumber(1000, 9999).ToString();
                }
                else if (lb == kqg41 && isSpinningG41)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg42 && isSpinningG42)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg43 && isSpinningG43)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg44 && isSpinningG44)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg45 && isSpinningG45)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg46 && isSpinningG46)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg47 && isSpinningG47)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg31 && isSpinningG31)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg32 && isSpinningG32)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg2 && isSpinningG2)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }
                else if (lb == kqg1 && isSpinningG1)
                {
                    lb.Text = randomnumber(10000, 99999).ToString();
                }

                await Task.Delay(200); // Thay đổi số mỗi 200ms
            }
        }

        private int randomnumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
        private void PlayMp3(string path)
        {
            if (outputDevice == null) outputDevice = new WaveOutEvent();
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(path);
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }
        private void StopMp3()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btndo_Click(object sender, EventArgs e)
        {
            string soCanDo = txtsearch.Text; // Số cần dò
            string ngayDo = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Lấy ngày dò dưới định dạng file
            string directoryPath = @"C:\C#xoso\"; // Đường dẫn thư mục
            string[] files = Directory.GetFiles(directoryPath, $"{ngayDo}_*.txt"); // Tìm file theo ngày, bỏ qua thời gian
            if (files.Length > 0)
            {
                // Đọc nội dung file đầu tiên tìm được
                string[] lines = File.ReadAllLines(files[0]);
                // Biến lưu lại giải trúng
                List<string> giaiTrung = new List<string>(); // Sử dụng List để lưu nhiều giải
                Dictionary<string, List<string>> soTrungTheoGiai = new Dictionary<string, List<string>>(); // Sử dụng Dictionary để lưu số trúng theo từng giải
                bool found = false; // Kiểm tra xem số có được tìm thấy hay không

                // Kiểm tra từng dòng xem có chứa số cần dò không
                foreach (string line in lines)
                {
                    // Kiểm tra nếu dòng có chứa giải
                    if (line.StartsWith("Giải"))
                    {
                        // Tìm kiếm số trong giải
                        string[] parts = line.Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length > 1)
                        {
                            string[] numbers = parts[1].Split(',').Select(num => num.Trim()).ToArray(); // Lấy các số trong giải
                            foreach (string number in numbers)
                            {
                                // Nếu số kết thúc với số cần dò, thêm vào danh sách trúng
                                if (number.EndsWith(soCanDo))
                                {
                                    if (!giaiTrung.Contains(line.Split(':')[0])) // Nếu giải chưa được thêm vào danh sách
                                    {
                                        giaiTrung.Add(line.Split(':')[0]); // Thêm tên giải vào danh sách
                                        soTrungTheoGiai[line.Split(':')[0]] = new List<string>(); // Khởi tạo danh sách cho số trúng theo giải
                                    }
                                    soTrungTheoGiai[line.Split(':')[0]].Add(number); // Thêm số vào danh sách theo giải
                                    found = true; // Đánh dấu là đã tìm thấy
                                }
                            }
                        }
                    }
                }

                // Hiển thị kết quả
                if (found)
                {
                    StringBuilder result = new StringBuilder($"Số {soCanDo} CÓ xuất hiện trong ngày {ngayDo}, trúng các giải:\n");
                    foreach (var giai in giaiTrung)
                    {
                        result.AppendLine($"{giai}: {string.Join(", ", soTrungTheoGiai[giai])}"); // Hiển thị tên giải và tất cả số trúng
                    }
                    MessageBox.Show(result.ToString());
                }
                else
                {
                    MessageBox.Show($"Số {soCanDo} KHÔNG CÓ trong ngày {ngayDo}.");
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy file kết quả cho ngày {ngayDo}. Vui lòng kiểm tra lại.");
            }
        }






        private void btnhistory_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value; // Lấy ngày từ DateTimePicker
            //HistoryForm historyForm = new HistoryForm(selectedDate); // Tạo instance của HistoryForm với ngày đã chọn
            //historyForm.Show(); // Hiển thị HistoryForm
            this.Hide(); // Ẩn form hiện tại (nếu cần)
        }
    }

}
