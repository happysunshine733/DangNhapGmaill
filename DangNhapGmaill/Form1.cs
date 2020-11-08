using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using OpenQA.Selenium.Firefox;

namespace DangNhapGmaill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            
            for (int j = 1; j <= Convert.ToInt32(textBox1.Text); j++)
            {

                string filePath = "data.xml";

                #region motrinhduyet

                FirefoxOptions co = new FirefoxOptions();
                FirefoxDriverService firefoxDirverService = FirefoxDriverService.CreateDefaultService();
                firefoxDirverService.HideCommandPromptWindow = true;
                co.AddArgument("--disable-notifications");
                FirefoxDriver driver = new FirefoxDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
                driver.Url = " https://accounts.google.com/signup/v2/webcreateaccount?flowName=GlifWebSignIn&flowEntry=SignUp";
                driver.Navigate();
                #endregion

                #region hoten
                //hoten
                string[] mang_ten = { "Lê", "Bách gia tính", "Đào", "Doãn", "Phạm", "Bùi", "Hoàng", "Trương", "Khương", "Lương", "Nguyễn", "Đặng", "Phùng", " Ninh", "Uông", "Lại", " Phí", "Diệp", " Lỗ", " Thiều", "Đoàn", "Lý", " Đinh", "Chu", " Ngô", "Lâm", "Thân", " Tống", " Phó", "Mạc", "Kim", " Vương", "Dương", "Hồ", "Tạ", " Cao", " Trịnh", " Bạch", " Phan", "Lưu", "Đỗ", " Thái", "Triệu", "Mai", " Tiêu", " Trình", "Hà", " Thôi", " Từ", "Hồng", "Văn", "Tôn", " Liễu", "Ngụy", "Long", " Quách", "Tăng", "Lữ", "Đới", "Mã", "Đàm", "Hàn", "Trang", "Hứa", "Chung", "Hình", "Khổng", " Cung", "Viên", "Kha", "Lục", "La", " Quan", "Hướng", "Thẩm", "Diêu", "Tào", "Tiết", "Sử", "Khúc", "Bành", "Nhâm", "Thạch", "Khâu", "Điền", "Đường" };
                Random randten = new Random();
                int selectname = randten.Next(0, 50);
                int selectsurname = randten.Next(0, 50);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
                string ten = mang_ten[selectname];
                string ho = mang_ten[selectsurname];
                var nhapho = driver.FindElementByXPath("//*[@id=\"lastName\"]");
                nhapho.SendKeys(ho);
                var nhapten = driver.FindElementByXPath("//*[@id=\"firstName\"]");
                nhapten.SendKeys(ten);
                #endregion

                #region dangnhap

                string[] mang_tendn = { "Laura.", "Linda.", "Rebecca.", "Maria.", " Sarah." };
                Random randmang_tendn = new Random();
                int selecttendn = randmang_tendn.Next(0, 4);
                string[] mang_hodn = { "David.", "Daniel.", "Brian.", "Christopher.", "John.", "Kevin.", "Mark.", "Michael.", "Matthew.", "Robert.", "William.", " James." };
                Random randmang_hodn = new Random();
                int selecthodn = randmang_hodn.Next(0, 10);
                string[] mangktdn = { "aa", "bb", "cc", "dd", "ee", "ff", "gg", "hh", "jj", "kk", "ll", "qq", "ww", "ee", "rr", "tt", "yy", "uu", "ii", "oo", "pp", "zz", "xx", "bb", "vv", "nn", "mm" };
                Random randmangktdn = new Random();
                int selectktdn = randmangktdn.Next(0, 26);
                string[] mangsodn = { "12", "23", "34", "56", "67", "78", "89", "90", "01", "11", "22", "33", "44", "55", "66", "77", "88", "99", "00" };
                Random randmangsodn = new Random();
                int selectsodn = randmangsodn.Next(0, 18);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
                string taikhoan = mang_tendn[selecttendn] + mang_hodn[selecthodn] + mangktdn[selectktdn] + mangsodn[selectsodn];
                var account = driver.FindElementByXPath("//*[@id=\"username\"]");
                account.SendKeys(taikhoan);
                #endregion

                #region matkhau
                string[] mang_mktendn = { "Laura", "Linda", "Rebecca", "Maria", "Sarah " };
                Random randmang_mktendn = new Random();
                int selectmktendn = randmang_mktendn.Next(0, 4);
                string[] mang_mkhodn = { "David", "Daniel", "Brian", "Christopher", "John", "Kevin", "Mark", "Michael", "Matthew", "Robert", "William", "James" };
                Random randmang_mkhodn = new Random();
                int selectmkhodn = randmang_mkhodn.Next(0, 10);
                string[] mangmkktdn = { "aa", "bb", "cc", "dd", "ee", "ff", "gg", "hh", "jj", "kk", "ll", "qq", "ww", "ee", "rr", "tt", "yy", "uu", "ii", "oo", "pp", "zz", "xx", "bb", "vv", "nn", "mm" };
                Random randmangmkktdn = new Random();
                int selectmkktdn = randmangmkktdn.Next(0, 26);
                string[] mangmksodn = { "12", "23", "34", "56", "67", "78", "89", "90", "01", "11", "22", "33", "44", "55", "66", "77", "88", "99", "00" };
                Random randmangmksodn = new Random();
                int selectmksodn = randmangmksodn.Next(0, 18);
                string[] mangmkbm = { "..", ",,", "--", "++", "**", "//", "''", "[[", "]]" };
                Random randmangmkbm = new Random();
                int selectmkbm = randmangmkbm.Next(0, 8);
                string matkhau = mang_mktendn[selectmktendn] + mang_mkhodn[selectmkhodn] + mangmkktdn[selectmkktdn] + mangmksodn[selectmksodn] + mangmkbm[selectmkbm];
                var passwords = driver.FindElementByXPath("//*[@id=\"passwd\"]/div[1]/div/div[1]/input");
                passwords.SendKeys(matkhau);
                var repass = driver.FindElementByXPath("//*[@id=\"confirm-passwd\"]/div[1]/div/div[1]/input");
                repass.SendKeys(matkhau);
                #endregion
                #region luutru
                GmailData Gd = new GmailData();                             
                Gd.Account = taikhoan;
                Gd.Password = matkhau;
                Gd.ID = j;
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer sr = new XmlSerializer(typeof(GmailData));
                StreamWriter st = new StreamWriter(fs);
                sr.Serialize(st, Gd);
                st.Close();
              
                #endregion

            }



        }
        [Serializable]
        public class GmailData
        {
            private int id;

            public int ID
            {
                get { return id; }
                set { id = value; }
            }


            private string account;

            public string Account
            {
                get { return account; }
                set { account = value; }
            }

            private string password;

            public string Password
            {
                get { return password; }
                set { password = value; }
            }


        }
        
        //public class GmailItem
        //{
        //    private List<GmailData> items;

        //    public List<GmailData> Items
        //    {
        //        get { return items; }
        //        set { items = value; }
        //    }
        //}
        //public class GmailManager
        //{

        //    private string filePath = "data.xml";

        //    private GmailItem items;

        //    public GmailItem Items
        //    {
        //        get { return items; }
        //        set { items = value; }
        //    }

        //    public GmailManager()
        //    {
        //        items = (GmailItem)DeserializeFromXML(filePath);
        //    }
        //    public void Serialize()
        //    {
        //        SerializeToXML(Items, filePath);
        //    }

        //    private void SerializeToXML(object data, string filePath)
        //    {
        //        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

        //        XmlSerializer sr = new XmlSerializer(typeof(GmailItem));

        //        sr.Serialize(fs, data);

        //        fs.Close();
        //    }
        //    public object DeserializeFromXML(string filePath)
        //    {
        //        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

        //        XmlSerializer sr = new XmlSerializer(typeof(GmailItem));

        //        object obj = sr.Deserialize(fs);

        //        fs.Close();

        //        return obj;
        //    }



        //}
    }
}



    

        
   
    








