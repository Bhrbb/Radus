using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYetkiService
    {
        IDataResult<List<Yetkiler>> GetAll();
        IDataResult<Yetkiler> GetById(int yetkiId);
        IResult Add(Yetkiler yetki);
        IResult Update(Yetkiler yetki);
        IResult Delete(Yetkiler yetki);
    }
}
