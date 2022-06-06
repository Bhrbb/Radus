using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class AdresBilgileri:IEntity
    {
        public int AdresId { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
        public string İlce { get; set; }
        public string TelefonNo { get; set; }
        public string Mail { get; set; }
        public string Adres1 { get; set; }
        public string Adres2 { get; set; }
    }
}
