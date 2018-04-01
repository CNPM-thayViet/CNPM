using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.GUI
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien FrmNV = new frmNhanvien();
            FrmNV.ShowDialog();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrUpdateAccount FrmUA = new FrUpdateAccount();
            FrmUA.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu FrmDoanhThu = new frmBaoCaoDoanhThu();
            FrmDoanhThu.ShowDialog();

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThucDon FrmThucDon = new frmThucDon();
            FrmThucDon.ShowDialog();
        }
    }
}
