using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;

namespace CommonLibrary
{
    public class KartlarProvider
    {
        public bool InsertKartlar(Kartlar kartlar)
        {
            bool result = false;

            using (var connection = Database.GetConnection())
            {
                var sqlCommand = new SqlCommand("Insert Into Kartlar (kartNo,projeAd,teknikUzman,tarih,tahminiSure,gerceklesenSure,isAciklama,isNot) " +
                "Values(@kartNo,@projeAd,@teknikUzman,@tarih,@tahminiSure,@gerceklesenSure,@isAciklama,@isNot)", connection);
                sqlCommand.Parameters.Add(new SqlParameter("kartNo", kartlar._KartNo));
                sqlCommand.Parameters.Add(new SqlParameter("projeAd", kartlar._ProjeAd));
                sqlCommand.Parameters.Add(new SqlParameter("teknikUzman", kartlar._TeknikUzman));
                sqlCommand.Parameters.Add(new SqlParameter("tarih", kartlar._Tarih));
                sqlCommand.Parameters.Add(new SqlParameter("tahminiSure", kartlar._TahminiSure));
                sqlCommand.Parameters.Add(new SqlParameter("gerceklesenSure", kartlar._GerceklesenSure));
                sqlCommand.Parameters.Add(new SqlParameter("isAciklama", kartlar._IsAciklama));
                sqlCommand.Parameters.Add(new SqlParameter("isNot", kartlar._IsNot));
                connection.Open();
                if (sqlCommand.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }
        public bool UpdateKartlar(Kartlar kartlar)
        {
            bool result = false;

            using (var connection = Database.GetConnection())
            {
                var sqlCommand = new SqlCommand("Update Kartlar SET projeAd=@projeAd,teknikUzman=@teknikUzman,tarih=@tarih," +
                "tahminiSure=@tahminiSure,gerceklesenSure=@gerceklesenSure,isAciklama=@isAciklama,isNot=@isNot WHERE kartNo=@kartNo", connection);
                sqlCommand.Parameters.Add(new SqlParameter("kartNo", kartlar._KartNo));
                sqlCommand.Parameters.Add(new SqlParameter("projeAd", kartlar._ProjeAd));
                sqlCommand.Parameters.Add(new SqlParameter("teknikUzman", kartlar._TeknikUzman));
                sqlCommand.Parameters.Add(new SqlParameter("tarih", kartlar._Tarih));
                sqlCommand.Parameters.Add(new SqlParameter("tahminiSure", kartlar._TahminiSure));
                sqlCommand.Parameters.Add(new SqlParameter("gerceklesenSure", kartlar._GerceklesenSure));
                sqlCommand.Parameters.Add(new SqlParameter("isAciklama", kartlar._IsAciklama));
                sqlCommand.Parameters.Add(new SqlParameter("isNot", kartlar._IsNot));
                connection.Open();
                if (sqlCommand.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                connection.Close();
            }
            return result;
        }
        public List<Kartlar> GetAllCards()
        {
            List<Kartlar> kartlar = new List<Kartlar>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("Select * from Kartlar", connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var kart = new Kartlar();
                        kart._KartNo = Convert.ToInt32(reader["kartNo"]);
                        kart._ProjeAd = reader["projeAd"].ToString();
                        kart._TeknikUzman = reader["teknikUzman"].ToString();
                        kart._Tarih = Convert.ToDateTime(reader["tarih"]);
                        kart._TahminiSure = Convert.ToDateTime(reader["tahminiSure"]);
                        kart._GerceklesenSure = Convert.ToDateTime(reader["gerceklesenSure"]);
                        kart._IsAciklama = reader["isAciklama"].ToString();
                        kart._IsNot = reader["isNot"].ToString();
                        kartlar.Add(kart);
                    }
                }
                connection.Close();
            }
            return kartlar;
        }
        public void DeleteKart(int KartNo)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("Delete from Kartlar where kartNo=@_kartNo", connection);

                connection.Open();
                SqlParameter kartNo = new SqlParameter("_kartNo", KartNo);
                command.Parameters.Add(kartNo);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
