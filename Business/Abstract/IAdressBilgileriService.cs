using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdressBilgileriService
    {
        IDataResult<List<AdresBilgileri>> GetAll();
        IDataResult<AdresBilgileri> GetById(int AdressId);
        IResult Add(AdresBilgileri adresbilgisi);
        IResult Update(AdresBilgileri adresbilgisi);
        IResult Delete(AdresBilgileri adresbilgisi);
    }
}
