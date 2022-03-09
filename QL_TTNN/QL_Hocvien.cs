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
    public partial class QL_Hocvien : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_TrungTamNN");
        static IMongoCollection<hocvien> hv = db.GetCollection<hocvien>("HOCVIEN");

        public QL_Hocvien()
        {
            InitializeComponent();
            ReadAllDocuments();
        }
        public void ReadAllDocuments()
        {

            try
            {
                List<hocvien> list = hv.AsQueryable().ToList<hocvien>();
                dataGridView1.DataSource = list;
                txtID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtmahv.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txttenhv.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                txtmalop.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();

               
            }
            catch { Exception s; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtmahv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttenhv.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtmalop.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { Exception s; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hocvien h = new hocvien(txtmahv.Text, txttenhv.Text, dtNsinh.Text,txtsdt.Text, txtdiachi.Text, txtmalop.Text);
            hv.InsertOne(h);
            ReadAllDocuments();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hv.DeleteOne(h => h.Id == ObjectId.Parse(txtID.Text));
            ReadAllDocuments();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var update = Builders<hocvien>.Update.Set("id_HV", txtmahv.Text).Set("TenHV", txttenhv.Text).Set("Ngaysinh", dtNsinh.Text).Set("SDT", txtsdt.Text).Set("Diachi", txtdiachi.Text).Set("id_Lop", txtmalop.Text);
            hv.UpdateOne(h => h.Id == ObjectId.Parse(txtID.Text), update);
            ReadAllDocuments();
        }

    }
}
