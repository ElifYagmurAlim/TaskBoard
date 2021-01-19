using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;

namespace BusinessLibrary
{
    public class AciklamalarContext
    {
        readonly AciklamalarProvider context = new AciklamalarProvider();
        public bool InsertAciklama(Aciklamalar aciklama)
        {
            return context.InsertAciklama(aciklama);
        }

        public List<Aciklamalar> KartAcilklama(int KartNo)
        {
            return context.KartAcilklama(KartNo);
        }

        public bool UpdateAciklamalar(Aciklamalar aciklama)
        {
            return context.UpdateAciklamalar(aciklama);
        }
    }
}
