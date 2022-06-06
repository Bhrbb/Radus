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
    public class YetkiManager : IYetkiService
    {
        IYetkilerDal _yetkidal;
        public YetkiManager(IYetkilerDal yetkidal)
        {
            _yetkidal = yetkidal;
        }
        public IResult Add(Yetkiler yetki)
        {
            _yetkidal.Add(yetki);
            return new SuccessResult("Yetki başarıyla Eklendi");
        }

        public IResult Delete(Yetkiler yetki)
        {
            _yetkidal.Delete(yetki);
            return new SuccessResult("Yetki başarıyla Silindi");
        }

        public IDataResult<List<Yetkiler>> GetAll()
        {
            return new SuccessDataResult<List<Yetkiler>>(_yetkidal.GetAll(), "Yetki listesi Basarıyla Görüntülendi");
        }

        public IDataResult<Yetkiler> GetById(int yetkiId)
        {
            return new SuccessDataResult<Yetkiler>(_yetkidal.Get(y=>y.YetkiID==yetkiId));
        }

        public IResult Update(Yetkiler yetki)
        {
            _yetkidal.Update(yetki);
            return new SuccessResult("Yetki başarıyla güncellendi");
        }
    }
}
