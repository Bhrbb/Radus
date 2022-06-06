using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        IDataResult<List<Kullanicilar>> GetAll();
        IDataResult<Kullanicilar> GetById(int kullaniciId);
        IResult Add(Kullanicilar kullanici);
        IResult Update(Kullanicilar kullanici);
        IResult Delete(Kullanicilar kullanici);

    }
}
