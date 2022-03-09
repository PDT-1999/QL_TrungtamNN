using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTNN
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QL_Giangvien qlgv = new QL_Giangvien();
            qlgv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QL_Hocvien qlhv = new QL_Hocvien();
            qlhv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QL_Khoahoc qlkh = new QL_Khoahoc();
            qlkh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QL_LOP qll = new QL_LOP();
            qll.Show();
        }

        private void qLGiangVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Giangvien qlgv = new QL_Giangvien();
            qlgv.Show();
        }

        private void qLHocVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Hocvien qlhv = new QL_Hocvien();
            qlhv.Show();
        }

        private void qLPhongHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Khoahoc qlkh = new QL_Khoahoc();
            qlkh.Show();
        }

        private void qLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_LOP qll = new QL_LOP();
            qll.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
