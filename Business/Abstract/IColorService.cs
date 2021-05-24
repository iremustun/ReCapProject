using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;


namespace Business.Abstract
{
    public interface IColorService
    {
       public IResult Add(Color color);
       public IResult Update(Color color);
        public IResult Delete(Color color);
        IDataResult<List<Color>> GetAll();
        public IDataResult<Color> GetById(int colorId);

    }
}
