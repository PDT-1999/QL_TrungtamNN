using MongoDB.Driver;
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

namespace QL_TTNN {

    public partial class QL_LOP : Form
    {
        static MongoClient client= new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_TrungTamNN");
        static IMongoCollection<lop> collection = db.GetCollection<lop>("LOP");
        static IMongoCollection<giangvien> gv = db.GetCollection<giangvien>("GIANGVIEN");
        static IMongoCollection<khoahoc> kh = db.GetCollection<khoahoc>("KHOAHOC");

        public void ReadAllDocuments()
        {

            try
            {
                List<lop> list = collection.AsQueryable().ToList<lop>();
                dataGridView1.DataSource = list;
                txtID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtmalp.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txttenlp.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                txtmamon.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                txtgv.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();

               
            }
            catch { Exception s; }
        }

        public QL_LOP()
        {

            InitializeComponent();
            ReadAllDocuments();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            lop l = new lop(txtmalp.Text, txttenlp.Text, txtmamon.Text, txtgv.Text);
            collection.InsertOne(l);
            ReadAllDocuments();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(l => l.Id == ObjectId.Parse(txtID.Text));
            ReadAllDocuments();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var update = Builders<lop>.Update.Set("id_Lop", txtmalp.Text).Set("Tenlp", txttenlp.Text).Set("id_Khoa", txtmamon.Text).Set("id_GV", txtgv.Text);
            collection.UpdateOne(l => l.Id == ObjectId.Parse(txtID.Text),update);
            ReadAllDocuments();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtmalp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttenlp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtmamon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtgv.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch { Exception s; }
        }

      
    }
}
