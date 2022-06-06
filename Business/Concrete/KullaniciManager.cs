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
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }
        public IResult Add(Kullanicilar kullanici)
        {
            _kullaniciDal.Add(kullanici);
            return new SuccessResult("Kullanici başarıyla Eklendi");
        }

        public IResult Delete(Kullanicilar kullanici)
        {
            _kullaniciDal.Delete(kullanici);
            return new SuccessResult("Kullanici başarıyla Silindi");
        }

        public IDataResult<List<Kullanicilar>> GetAll()
        {
            return new SuccessDataResult<List<Kullanicilar>>(_kullaniciDal.GetAll(), "Kullanicilar Basarıyla Listelendi");
        }

        public IDataResult<Kullanicilar> GetById(int kullaniciId)
        {
            return new SuccessDataResult<Kullanicilar>(_kullaniciDal.Get(i => i.KullaniciId == kullaniciId));
        }

        public IResult Update(Kullanicilar kullanici)
        {
            _kullaniciDal.Update(kullanici);
            return new SuccessResult("Kullanici başarıyla Güncellendi");
        }
    }
}
