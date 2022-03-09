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
    public partial class QL_Khoahoc : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_TrungTamNN");
        static IMongoCollection<khoahoc> k = db.GetCollection<khoahoc>("KHOAHOC");
        public QL_Khoahoc()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        public void ReadAllDocuments()
        {
            try
            {
                List<khoahoc> list = k.AsQueryable().ToList<khoahoc>();
                dataGridView1.DataSource = list;
                txtID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtmakhoa.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txtNgongu.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                txttrinhdo.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                txtthoiluong.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();

            }
            catch { Exception s; }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            khoahoc kh = new khoahoc(txtmakhoa.Text, txtNgongu.Text,txttrinhdo.Text, dtTgbd.Text, txtthoiluong.Text);
            k.InsertOne(kh);
            ReadAllDocuments();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            k.DeleteOne(kh => kh.Id == ObjectId.Parse(txtID.Text));
            ReadAllDocuments();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var update = Builders<khoahoc>.Update.Set("id_Khoa", txtmakhoa.Text).Set("Ngonngu", txtNgongu.Text).Set("Trinhdo", txttrinhdo.Text).Set("TGbatdau", dtTgbd.Text).Set("Thoiluong", txtthoiluong.Text);
            k.UpdateOne(kh => kh.Id == ObjectId.Parse(txtID.Text), update);
            ReadAllDocuments();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtmakhoa.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNgongu.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txttrinhdo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtthoiluong.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch { Exception s; }
        }

       
    }
}
