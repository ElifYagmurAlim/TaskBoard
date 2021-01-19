using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;
using BusinessLibrary;

namespace YY
{
    public partial class FrmTeknikKart : DevExpress.XtraEditors.XtraForm
    {
        public FrmTeknikKart()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            //Kart için gerekli verilerin girilmesi kontrol edilir koşul sağlanırsa veri tabanı için yapılacak işlemlerin olduğu fonksiyona yönlendirilir..
            if (String.IsNullOrEmpty(IsAciklamaTextEdit.Text) || String.IsNullOrEmpty(IsNotTextEdit.Text) || String.IsNullOrEmpty(GuncelTarihDateEdit.Text) || String.IsNullOrEmpty(ProjeAdiTextEdit.Text) || String.IsNullOrEmpty(TeknikUzmanTextEdit.Text))
                MessageBox.Show("Lütfen Zorunlu(*) Yerleri Doldurunuz");
            else
                DbConnection();
        }
        private void DbConnection()
        {
            //Kartları veritabanına yazmak için nesnesini oluşturup context üzerinden providerına ulaşması sağlanır.
            Kartlar kart = new Kartlar();
            KartlarContext contextKartlar = new KartlarContext();

            //Form sayfasından nesnesine aktarılacak objeler.
            kart._Tarih = Convert.ToDateTime(GuncelTarihDateEdit.Text);
            kart._TahminiSure = Convert.ToDateTime(TahminiSureDateEdit.Text);
            kart._GerceklesenSure = Convert.ToDateTime(GerceklesenSureDateEdit.Text);
            kart._ProjeAd = ProjeAdiTextEdit.Text;
            kart._TeknikUzman = TeknikUzmanTextEdit.Text;
            kart._IsAciklama = IsAciklamaTextEdit.Text;
            kart._IsNot = IsNotTextEdit.Text;
            kart._KartNo = Convert.ToInt32(KartNoTextEdit.Text);
           
            contextKartlar.InsertKartlar(kart);

            //Aciklamalar nesnesine aktarılacak verilerin nesneleri bu fonksioyna gönderilip işlem yapılır.
            CheckIsAciklama(TarihDateEdit1, DurumAdiTextEdit1, IsAdiTextEdit1, AciklamaTextEdit1, KartNoTextEdit);
            CheckIsAciklama(TarihDateEdit2, DurumAdiTextEdit2, IsAdiTextEdit2, AciklamaTextEdit2, KartNoTextEdit);
            CheckIsAciklama(TarihDateEdit3, DurumAdiTextEdit3, IsAdiTextEdit3, AciklamaTextEdit3, KartNoTextEdit);
            CheckIsAciklama(TarihDateEdit4, DurumAdiTextEdit4, IsAdiTextEdit4, AciklamaTextEdit4, KartNoTextEdit);
            CheckIsAciklama(TarihDateEdit5, DurumAdiTextEdit5, IsAdiTextEdit5, AciklamaTextEdit5, KartNoTextEdit);
            CheckIsAciklama(TarihDateEdit6, DurumAdiTextEdit6, IsAdiTextEdit6, AciklamaTextEdit6, KartNoTextEdit);

            //using (TaskBoard taskBoard = new TaskBoard())
            //{
            //    taskBoard.guncelle(context);
            //    taskBoard.ShowDialog();
            //}
        }
        private void CheckIsAciklama(DateEdit _tarih, TextEdit _durum, TextEdit _yapilacakIs, TextEdit _aciklama, TextEdit _kartNo)
        {
            //İş açıklama kısmında bir sütündaki bütün verilerin girilip girilmediği kontrol edilir.
            if (String.IsNullOrEmpty(_tarih.Text) || String.IsNullOrEmpty(_durum.Text) || String.IsNullOrEmpty(_yapilacakIs.Text) || String.IsNullOrEmpty(_aciklama.Text))
            {
                return;
            }
            else
            {
                //Açıklamaları veritabanına yazmak için nesnesini oluşturup context üzerinden providerına ulaşması sağlanır.
                AciklamalarContext contextAciklamalar = new AciklamalarContext();
                Aciklamalar aciklama = new Aciklamalar();

                //Form sayfasından nesnesine aktarılacak objeler.
                aciklama._Tarih = Convert.ToDateTime(_tarih.Text);
                aciklama._Durum = _durum.Text;
                aciklama._YapilacakIs = _yapilacakIs.Text;
                aciklama._Aciklama = _aciklama.Text;
                aciklama._KartNo = Convert.ToInt32(_kartNo.Text);

                contextAciklamalar.InsertAciklama(aciklama);
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            //bütün textler silinir.           
            GuncelTarihDateEdit.Text = "";
            ProjeAdiTextEdit.Text = "";
            TeknikUzmanTextEdit.Text = "";
            TahminiSureDateEdit.Text = "";
            GerceklesenSureDateEdit.Text = "";
            IsAciklamaTextEdit.Text = "";
            IsNotTextEdit.Text = "";
            TarihDateEdit1.Text = ""; 
            DurumAdiTextEdit1.Text = "";
            IsAdiTextEdit1.Text = ""; 
            AciklamaTextEdit1.Text = ""; 
            TarihDateEdit2.Text = "";
            DurumAdiTextEdit2.Text = "";
            IsAdiTextEdit2.Text = "";
            AciklamaTextEdit2.Text = "";
            TarihDateEdit3.Text = ""; 
            DurumAdiTextEdit3.Text = ""; 
            IsAdiTextEdit3.Text = ""; 
            AciklamaTextEdit3.Text = "";
            TarihDateEdit4.Text = ""; 
            DurumAdiTextEdit4.Text = ""; 
            IsAdiTextEdit4.Text = ""; 
            AciklamaTextEdit4.Text = "";
            TarihDateEdit5.Text = ""; 
            DurumAdiTextEdit5.Text = ""; 
            IsAdiTextEdit5.Text = ""; 
            AciklamaTextEdit5.Text = "";
            TarihDateEdit6.Text = ""; 
            DurumAdiTextEdit6.Text = ""; 
            IsAdiTextEdit6.Text = ""; 
            AciklamaTextEdit6.Text = "";
        }
        private void FrmTeknikKart_Load(object sender, EventArgs e)
        {

        }
        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ProjeAdiTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void TeknikUzmanTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}