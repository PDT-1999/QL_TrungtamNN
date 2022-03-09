using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson;
namespace QL_TTNN
{
    public partial class Dangnhap : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_TrungTamNN");
        static IMongoCollection<taikhoan> tk = db.GetCollection<taikhoan>("TAIKHOAN");
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tendn = textBox1.Text;
            var matk = textBox2.Text;
            if(String.IsNullOrEmpty(tendn))
            {
                MessageBox.Show("Mời nhập tên đăng nhập");
            }
            else if (String .IsNullOrEmpty(matk))
            {
                MessageBox.Show("Mời nhập mật khẩu");
            }
            else 
            {
                List<taikhoan> t = tk.AsQueryable().ToList<taikhoan>();
                taikhoan k = t.SingleOrDefault(p => p.Tk == tendn && p.Mk == matk);
                if (k != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Menu m = new Menu();
                    m.Show();
                   
                }
                else
                    MessageBox.Show("Đăng nhập thất bại! Mời nhập lại tài khoản và mật khẩu!");
            }
        }
    }
}
