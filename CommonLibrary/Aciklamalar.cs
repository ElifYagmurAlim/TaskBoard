using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Aciklamalar
    {
        //veritabanına gidecek verilerin tutulacağı değişkenler
        private DateTime _tarih;
        private string _durum, _yapilacakIs, _aciklama;
        private int _kartNo, _isId;

        //metodlar
        public DateTime _Tarih { get { return _tarih; } set { _tarih = value; } }
        public string _Durum { get { return _durum; } set { _durum = value; } }
        public string _YapilacakIs { get { return _yapilacakIs; } set { _yapilacakIs = value; } }
        public string _Aciklama { get { return _aciklama; } set { _aciklama = value; } }
        public int _KartNo { get { return _kartNo; } set { _kartNo = value; } }
        public int _IsId { get { return _isId; } set { _isId = value; } }

        //verileri çekecek kurucu metodu
        //public Aciklamalar(DateTime _tarih, string _durum, string _yapilacakIs, string _aciklama, int _kartNo)
        //{
        //    this._tarih = _tarih;
        //    this._durum = _durum;
        //    this._yapilacakIs = _yapilacakIs;
        //    this._aciklama = _aciklama;
        //    this._kartNo = _kartNo;
        //}
    }
}
