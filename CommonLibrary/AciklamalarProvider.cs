using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;

namespace CommonLibrary
{
    public class AciklamalarProvider
    {
        public bool InsertAciklama(Aciklamalar aciklama)
        {
            bool result = false;

            using (var connection = Database.GetConnection())
            {
                var sqlCommand = new SqlCommand("Insert Into Aciklamalar (tarih,durum,yapilacakIs,aciklama,kartNo) " +
            "Values(@tarih,@durum,@yapilacakIs,@aciklama,@kartNo)", connection);
                sqlCommand.Parameters.Add(new SqlParameter("tarih", aciklama._Tarih));
                sqlCommand.Parameters.Add(new SqlParameter("durum", aciklama._Durum));
                sqlCommand.Parameters.Add(new SqlParameter("yapilacakIs", aciklama._YapilacakIs));
                sqlCommand.Parameters.Add(new SqlParameter("aciklama", aciklama._Aciklama));
                sqlCommand.Parameters.Add(new SqlParameter("kartNo", aciklama._KartNo));
                connection.Open();
                if (sqlCommand.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }


        public List<Aciklamalar> KartAcilklama(int KartNo)
        {
            List<Aciklamalar> aciklamalar = new List<Aciklamalar>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("Select * from Aciklamalar Where kartNo=@_kartNo", connection);

                connection.Open();
                SqlParameter kartNo = new SqlParameter("_kartNo", KartNo);
                command.Parameters.Add(kartNo);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        aciklamalar.Add(new Aciklamalar()
                        {
                            _Tarih = Convert.ToDateTime(reader["tarih"]),
                            _Durum = reader["durum"].ToString(),
                            _YapilacakIs = reader["yapilacakIs"].ToString(),
                            _Aciklama = reader["aciklama"].ToString(),
                            _IsId = Convert.ToInt32(reader["isId"]),
                            _KartNo = KartNo,
                        });
                    }
                }
                connection.Close();
            }
            return aciklamalar;
        }
        public bool UpdateAciklamalar(Aciklamalar aciklama)
        {
            bool result = false;

            using (var connection = Database.GetConnection())
            {
                var sqlCommand = new SqlCommand("Update Aciklamalar SET tarih=@tarih,durum=@durum,yapilacakIs=@yapilacakIs," +
                "aciklama=@aciklama WHERE isId=@isId AND kartNo=@kartNo", connection);
                sqlCommand.Parameters.Add(new SqlParameter("kartNo", aciklama._KartNo));
                sqlCommand.Parameters.Add(new SqlParameter("tarih", aciklama._Tarih));
                sqlCommand.Parameters.Add(new SqlParameter("durum", aciklama._Durum));
                sqlCommand.Parameters.Add(new SqlParameter("yapilacakIs", aciklama._YapilacakIs));
                sqlCommand.Parameters.Add(new SqlParameter("aciklama", aciklama._Aciklama));
                sqlCommand.Parameters.Add(new SqlParameter("isId", aciklama._IsId));
                connection.Open();
                if (sqlCommand.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();

            }
            return result;
        }
    }
}
