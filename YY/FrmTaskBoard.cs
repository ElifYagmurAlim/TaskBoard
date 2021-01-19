using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YY
{
    public partial class FrmTaskBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmTaskBoard()
        {
            InitializeComponent();
        }

        private void TaskBoard_Load(object sender, EventArgs e)
        {

        }

        private void kartEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTeknikKart frm = new FrmTeknikKart();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listeyiAc_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmToDoList frm = new FrmToDoList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kartGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTeknikKartGuncelle frm = new FrmTeknikKartGuncelle();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}