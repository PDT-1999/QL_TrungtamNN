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
    public partial class QL_Giangvien : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_TrungTamNN");
        static IMongoCollection<giangvien> gv = db.GetCollection<giangvien>("GIANGVIEN");

        public void ReadAllDocuments()
        {

            try
            {
                List<giangvien> list = gv.AsQueryable().ToList<giangvien>();
                dataGridView1.DataSource = list;
                txtID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtmagv.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txttengv.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                txtLuong.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();

            }
            catch { Exception s; }
        }

        public QL_Giangvien()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtmagv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttengv.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLuong.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { Exception s; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            giangvien g = new giangvien(txtmagv.Text, txttengv.Text, dtNgaysinh.Text, txtdiachi.Text, txtsdt.Text, Double.Parse(txtLuong.Text));
            gv.InsertOne(g);
            ReadAllDocuments();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            gv.DeleteOne(g => g.Id == ObjectId.Parse(txtID.Text));
            ReadAllDocuments();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var update = Builders<giangvien>.Update.Set("id_GV", txtmagv.Text).Set("TenGV", txttengv.Text).Set("Ngaysinh", dtNgaysinh.Text).Set("Diachi", txtdiachi.Text).Set("SDT",txtsdt.Text).Set("Luongcb",txtLuong.Text);
            gv.UpdateOne(g => g.Id == ObjectId.Parse(txtID.Text), update);
            ReadAllDocuments();
        }

      

    }
}
