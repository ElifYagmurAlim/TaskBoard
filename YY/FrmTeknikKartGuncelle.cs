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
using BusinessLibrary;
using CommonLibrary;
using DevExpress.XtraEditors.Controls;

namespace YY
{
    public partial class FrmTeknikKartGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public FrmTeknikKartGuncelle()
        {
            InitializeComponent();
        }

        List<int> isId = new List<int>();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(KartNoTextEdit.Text))//kart numarası olmadığı durumda tool'lara veri işlemek kapalıdır.
            {
                return;
            }
            else
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

                contextKartlar.UpdateKartlar(kart);

                if (isId.Count - 1 >= 0)
                    CheckIsAciklama(TarihDateEdit1, DurumAdiTextEdit1, IsAdiTextEdit1, AciklamaTextEdit1, KartNoTextEdit, isId[0]);
                else
                    CheckIsAciklama(TarihDateEdit1, DurumAdiTextEdit1, IsAdiTextEdit1, AciklamaTextEdit1, KartNoTextEdit, 0);
                if (isId.Count - 1 >= 1)
                    CheckIsAciklama(TarihDateEdit2, DurumAdiTextEdit2, IsAdiTextEdit2, AciklamaTextEdit2, KartNoTextEdit, isId[1]);
                else
                    CheckIsAciklama(TarihDateEdit2, DurumAdiTextEdit2, IsAdiTextEdit2, AciklamaTextEdit2, KartNoTextEdit, 0);
                if (isId.Count - 1 >= 2)
                    CheckIsAciklama(TarihDateEdit3, DurumAdiTextEdit3, IsAdiTextEdit3, AciklamaTextEdit3, KartNoTextEdit, isId[2]);
                else
                    CheckIsAciklama(TarihDateEdit3, DurumAdiTextEdit3, IsAdiTextEdit3, AciklamaTextEdit3, KartNoTextEdit, 0);
                if (isId.Count - 1 >= 3)
                    CheckIsAciklama(TarihDateEdit4, DurumAdiTextEdit4, IsAdiTextEdit4, AciklamaTextEdit4, KartNoTextEdit, isId[3]);
                else
                    CheckIsAciklama(TarihDateEdit4, DurumAdiTextEdit4, IsAdiTextEdit4, AciklamaTextEdit4, KartNoTextEdit, 0);
                if (isId.Count - 1 >= 4)
                    CheckIsAciklama(TarihDateEdit5, DurumAdiTextEdit5, IsAdiTextEdit5, AciklamaTextEdit5, KartNoTextEdit, isId[4]);
                else
                    CheckIsAciklama(TarihDateEdit5, DurumAdiTextEdit5, IsAdiTextEdit5, AciklamaTextEdit5, KartNoTextEdit, 0);
                if (isId.Count - 1 >= 5)
                    CheckIsAciklama(TarihDateEdit6, DurumAdiTextEdit6, IsAdiTextEdit6, AciklamaTextEdit6, KartNoTextEdit, isId[5]);
                else
                    CheckIsAciklama(TarihDateEdit6, DurumAdiTextEdit6, IsAdiTextEdit6, AciklamaTextEdit6, KartNoTextEdit, 0);

                ToolBoxEdits(true);
                CheckKart();
            }
        }
        private void CheckIsAciklama(DateEdit _tarih, TextEdit _durum, TextEdit _yapilacakIs, TextEdit _aciklama, TextEdit _kartNo, int id)
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
                aciklama._IsId = id;

                if (id == 0)
                    contextAciklamalar.InsertAciklama(aciklama);
                else
                    contextAciklamalar.UpdateAciklamalar(aciklama);
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(KartNoTextEdit.Text))//kart numarası olmadığı durumda tool'lara veri işlemek kapalıdır.
            {
                return;
            }
            else
            {
                int kartNo = Convert.ToInt32(KartNoTextEdit.SelectedItem.ToString());
                KartlarContext contextKartlar = new KartlarContext();
                AciklamalarContext aciklamalarContext = new AciklamalarContext();
                contextKartlar.DeleteKart(kartNo);
                //aciklamalarContext.DeleteAciklamalar(kartNo);
                ToolBoxEdits(true);
                CheckKart();
            }
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmTeknikKartGuncelle_Load(object sender, EventArgs e)
        {
            CheckKart();//Kart işlemleri.
        }
        private void CheckKart()//Kart numarasının olması durumunda numaraya göre kart sınıfının verilerini çeker.
        {
            KartlarContext contextKartlar = new KartlarContext();
            List<Kartlar> kartlar = contextKartlar.GetAllCards();

            ComboBoxItemCollection coll = KartNoTextEdit.Properties.Items;
            coll.Clear();
            coll.BeginUpdate();
            try
            {
                foreach (Kartlar item in kartlar)
                {
                    coll.Add(item._KartNo.ToString());
                }
            }
            finally
            {
                coll.EndUpdate();
            }
            KartNoTextEdit.SelectedIndex = -1;

            if (string.IsNullOrEmpty(KartNoTextEdit.Text))//kart numarası olmadığı durumda tool'lara veri işlemek kapalıdır.
            {
                ToolBoxEdits(false);
            }
        }
        private void KartNoTextEdit_SelectedIndexChanged(object sender, EventArgs e)//kart numarası girilmesi durumunda tool'ları işlenebilir forma getirir.
        {
            KartlarContext kartlarContext = new KartlarContext();
            List<Kartlar> kartlar = kartlarContext.GetAllCards();

            if (string.IsNullOrEmpty(KartNoTextEdit.Text))
            {
                return;
            }

            foreach (Kartlar item in kartlar)
            {
                if (item._KartNo == Convert.ToInt32(KartNoTextEdit.SelectedItem.ToString()))
                {
                    AciklamalarContext aciklamalarContext = new AciklamalarContext();
                    List<Aciklamalar> aciklama = aciklamalarContext.KartAcilklama(item._KartNo);                   
                    ToolBoxEdits(true);
                    isId.Clear();

                    GuncelTarihDateEdit.Text = item._Tarih.ToShortDateString();
                    ProjeAdiTextEdit.Text = item._ProjeAd.ToString();
                    TeknikUzmanTextEdit.Text = item._TeknikUzman.ToString();
                    TahminiSureDateEdit.Text = item._TahminiSure.ToShortDateString();
                    GerceklesenSureDateEdit.Text = item._GerceklesenSure.ToShortDateString();
                    IsAciklamaTextEdit.Text = item._IsAciklama.ToString();
                    IsNotTextEdit.Text = item._IsNot.ToString();

                    if (aciklama.Count - 1 >= 0)
                    {
                        TarihDateEdit1.Text = aciklama[0]._Tarih.ToShortDateString();
                        DurumAdiTextEdit1.Text = aciklama[0]._Durum;
                        IsAdiTextEdit1.Text = aciklama[0]._YapilacakIs;
                        AciklamaTextEdit1.Text = aciklama[0]._Aciklama;
                        isId.Add(aciklama[0]._IsId);
                    }
                    if (aciklama.Count - 1 >= 1)
                    {
                        TarihDateEdit2.Text = aciklama[1]._Tarih.ToShortDateString();
                        DurumAdiTextEdit2.Text = aciklama[1]._Durum;
                        IsAdiTextEdit2.Text = aciklama[1]._YapilacakIs;
                        AciklamaTextEdit2.Text = aciklama[1]._Aciklama;
                        isId.Add(aciklama[1]._IsId);
                    }
                    if (aciklama.Count - 1 >= 2)
                    {
                        TarihDateEdit3.Text = aciklama[2]._Tarih.ToShortDateString();
                        DurumAdiTextEdit3.Text = aciklama[2]._Durum;
                        IsAdiTextEdit3.Text = aciklama[2]._YapilacakIs;
                        AciklamaTextEdit3.Text = aciklama[2]._Aciklama;
                        isId.Add(aciklama[2]._IsId);
                    }
                    if (aciklama.Count - 1 >= 3)
                    {
                        TarihDateEdit4.Text = aciklama[3]._Tarih.ToShortDateString();
                        DurumAdiTextEdit4.Text = aciklama[3]._Durum;
                        IsAdiTextEdit4.Text = aciklama[3]._YapilacakIs;
                        AciklamaTextEdit4.Text = aciklama[3]._Aciklama;
                        isId.Add(aciklama[3]._IsId);
                    }
                    if (aciklama.Count - 1 >= 4)
                    {
                        TarihDateEdit5.Text = aciklama[4]._Tarih.ToShortDateString();
                        DurumAdiTextEdit5.Text = aciklama[4]._Durum;
                        IsAdiTextEdit5.Text = aciklama[4]._YapilacakIs;
                        AciklamaTextEdit5.Text = aciklama[4]._Aciklama;
                        isId.Add(aciklama[4]._IsId);
                    }
                    if (aciklama.Count - 1 >= 5)
                    {
                        TarihDateEdit6.Text = aciklama[5]._Tarih.ToShortDateString();
                        DurumAdiTextEdit6.Text = aciklama[5]._Durum;
                        IsAdiTextEdit6.Text = aciklama[5]._YapilacakIs;
                        AciklamaTextEdit6.Text = aciklama[5]._Aciklama;
                        isId.Add(aciklama[5]._IsId);
                    }
                }
            }
        }
        private void ToolBoxEdits(bool isOpen)
        {
            if (isOpen)
            {
                GuncelTarihDateEdit.Enabled = true;
                ProjeAdiTextEdit.Enabled = true;
                TeknikUzmanTextEdit.Enabled = true;
                IsAciklamaTextEdit.Enabled = true;
                IsNotTextEdit.Enabled = true;
                TarihDateEdit1.Enabled = true;
                DurumAdiTextEdit1.Enabled = true;
                IsAdiTextEdit1.Enabled = true;
                AciklamaTextEdit1.Enabled = true;
                TarihDateEdit2.Enabled = true;
                DurumAdiTextEdit2.Enabled = true;
                IsAdiTextEdit2.Enabled = true;
                AciklamaTextEdit2.Enabled = true;
                TarihDateEdit3.Enabled = true;
                DurumAdiTextEdit3.Enabled = true;
                IsAdiTextEdit3.Enabled = true;
                AciklamaTextEdit3.Enabled = true;
                TarihDateEdit4.Enabled = true;
                DurumAdiTextEdit4.Enabled = true;
                IsAdiTextEdit4.Enabled = true;
                AciklamaTextEdit4.Enabled = true;
                TarihDateEdit5.Enabled = true;
                DurumAdiTextEdit5.Enabled = true;
                IsAdiTextEdit5.Enabled = true;
                AciklamaTextEdit5.Enabled = true;
                TarihDateEdit6.Enabled = true;
                DurumAdiTextEdit6.Enabled = true;
                IsAdiTextEdit6.Enabled = true;
                AciklamaTextEdit6.Enabled = true;

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
            else
            {
                GuncelTarihDateEdit.Enabled = false;
                ProjeAdiTextEdit.Enabled = false;
                TeknikUzmanTextEdit.Enabled = false;
                TahminiSureDateEdit.Enabled = false;
                GerceklesenSureDateEdit.Enabled = false;
                IsAciklamaTextEdit.Enabled = false;
                IsNotTextEdit.Enabled = false;
                TarihDateEdit1.Enabled = false;
                DurumAdiTextEdit1.Enabled = false;
                IsAdiTextEdit1.Enabled = false;
                AciklamaTextEdit1.Enabled = false;
                TarihDateEdit2.Enabled = false;
                DurumAdiTextEdit2.Enabled = false;
                IsAdiTextEdit2.Enabled = false;
                AciklamaTextEdit2.Enabled = false;
                TarihDateEdit3.Enabled = false;
                DurumAdiTextEdit3.Enabled = false;
                IsAdiTextEdit3.Enabled = false;
                AciklamaTextEdit3.Enabled = false;
                TarihDateEdit4.Enabled = false;
                DurumAdiTextEdit4.Enabled = false;
                IsAdiTextEdit4.Enabled = false;
                AciklamaTextEdit4.Enabled = false;
                TarihDateEdit5.Enabled = false;
                DurumAdiTextEdit5.Enabled = false;
                IsAdiTextEdit5.Enabled = false;
                AciklamaTextEdit5.Enabled = false;
                TarihDateEdit6.Enabled = false;
                DurumAdiTextEdit6.Enabled = false;
                IsAdiTextEdit6.Enabled = false;
                AciklamaTextEdit6.Enabled = false;
            }
        }
    }
}