using Business.Abstarct;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        EfColorDal _efColorDal;

        public ColorManager(EfColorDal efColorDal)
        {
            _efColorDal = efColorDal;
        }

        public IResult Add(Color color)
        {
            if (color.Name.Length<2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            else
            {
                _efColorDal.Add(color);
                return new SuccessResult();
            }
            
        }

        public IResult Delete(Color color)
        {
            _efColorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_efColorDal.GetAll(),Messages.ColorListed);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_efColorDal.Get(c=>c.Id == id),Messages.ColorListed);
        }

        public IResult Update(Color color)
        {
            _efColorDal.Update(color);
            return new SuccessResult();
        }
    }
}
