using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanicilar:IEntity
    {
        public int KullaniciId { get; set; }
        public string  Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string KimlikNo { get; set; }
        public string Uyruk { get; set; }
        public string Cinsiyet { get; set; }
        public int YetkiId { get; set; }
       
    }
}
