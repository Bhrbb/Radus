using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIcerikService
    {

        IDataResult<List<İcerik>> GetAll();
        IDataResult<İcerik> GetById(int icerikid);
        IResult Add(İcerik icerik);
        IResult Update(İcerik icerik);
        IResult Delete(İcerik icerik);







       

    }
}
