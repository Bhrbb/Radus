using Business.Abstract;
using Core.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdresBilgileriManager : IAdressBilgileriService
    {
        IAdressBilgileriDal _adresbilgi;
        public AdresBilgileriManager(IAdressBilgileriDal adressBilgileri)
        {
            _adresbilgi = adressBilgileri;
        }
        public IResult Add(AdresBilgileri adresbilgisi)
        {
            _adresbilgi.Add(adresbilgisi);
            return new SuccessResult("Adres başarıyla Eklendi");
        }

        public IResult Delete(AdresBilgileri adresbilgisi)
        {
            _adresbilgi.Delete(adresbilgisi);
            return new SuccessResult("Adres başarıyla Silindi");
        }

        public IDataResult<List<AdresBilgileri>> GetAll()
        {
            return new SuccessDataResult<List<AdresBilgileri>>(_adresbilgi.GetAll(), "Adres Bilgileri Basarıyla Görüntülendi");
        }

        public IDataResult<AdresBilgileri> GetById(int AdressId)
        {
            return new SuccessDataResult<AdresBilgileri>(_adresbilgi.Get(a=>a.AdresId==AdressId));
        }

        public IResult Update(AdresBilgileri adresbilgisi)
        {
            _adresbilgi.Update(adresbilgisi);
            return new SuccessResult("Adres başarıyla Güncellendi");
        }
    }
}
