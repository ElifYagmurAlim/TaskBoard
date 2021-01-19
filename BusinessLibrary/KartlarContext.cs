using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;

namespace BusinessLibrary
{
    public class KartlarContext
    {
        readonly KartlarProvider context = new KartlarProvider();
        public List<Kartlar> GetAllCards()
        {
            return context.GetAllCards();
        }
        public bool InsertKartlar(Kartlar kart)
        {
            return context.InsertKartlar(kart);
        }
        public bool UpdateKartlar(Kartlar kart)
        {
            return context.UpdateKartlar(kart);
        }
        public void DeleteKart(int KartNo)
        {
            context.DeleteKart(KartNo);
        }
    }
}
