using DevExpress.XtraEditors;
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
    public partial class FrmToDoList : DevExpress.XtraEditors.XtraForm
    {
        public FrmToDoList()
        {
            InitializeComponent();
        }

        private void FrmToDoList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cardsDataSet11.Kartlar' table. You can move, or remove it, as needed.
            this.kartlarTableAdapter.Fill(this.cardsDataSet11.Kartlar);

        }
    }
}