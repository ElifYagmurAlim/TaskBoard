using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Kartlar
    {
        //veritabanına gidecek verilerin tutulacağı değişkenler
        private DateTime _tarih, _tahminiSure, _gerceklesenSure;
        private string _projeAd, _teknikUzman, _isAciklama, _isNot;
        private int _kartNo;

        //metodlar
        public DateTime _Tarih { get { return _tarih; } set { _tarih = value; } }
        public DateTime _TahminiSure { get { return _tahminiSure; } set { _tahminiSure = value; } }
        public DateTime _GerceklesenSure { get { return _gerceklesenSure; } set { _gerceklesenSure = value; } }
        public string _ProjeAd { get { return _projeAd; } set { _projeAd = value; } }
        public string _TeknikUzman { get { return _teknikUzman; } set { _teknikUzman = value; } }
        public string _IsAciklama { get { return _isAciklama; } set { _isAciklama = value; } }
        public string _IsNot { get { return _isNot; } set { _isNot = value; } }
        public int _KartNo { get { return _kartNo; } set { _kartNo = value; } }
    }
}
