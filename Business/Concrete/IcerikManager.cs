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
    public class IcerikManager:IIcerikService
    {

        IIcerikDal _icerikdal;
        public IcerikManager(IIcerikDal ıcerikDal)
        {
            _icerikdal = ıcerikDal;
        }
        public IResult Add(İcerik icerik)
        {

           _icerikdal.Add(icerik);
            return new SuccessResult("İçerik başarıyla Eklendi");
        }

           
        public IResult Delete(İcerik icerik)
        {
            _icerikdal.Delete(icerik);
            return new SuccessResult("İçerik Silindi");
        }

        public IDataResult<List<İcerik>> GetAll()
        {
            return new SuccessDataResult<List<İcerik>>(_icerikdal.GetAll(),"İcerikler Basarıyla Görüntülendi");
        }

        public IDataResult<İcerik> GetById(int id)
        {
            return new SuccessDataResult<İcerik>(_icerikdal.Get(i => i.IcerikId == id));
        }

        public IResult Update(İcerik icerik)
        {
            _icerikdal.Update(icerik);
            return new SuccessResult("İcerik Guncellendi");
        }
    }
}
