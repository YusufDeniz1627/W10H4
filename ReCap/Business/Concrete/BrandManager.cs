using Business.Abstarct;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        EfBrandDal _efBrandDal;

        public BrandManager(EfBrandDal efBrandDal)
        {
            _efBrandDal = efBrandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.Name.Length<2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            _efBrandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            _efBrandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_efBrandDal.GetAll(),Messages.BrandListed);
        }

        public IDataResult<Brand> GetbyId(int id)
        {
            return new SuccessDataResult<Brand>(_efBrandDal.Get(b => b.Id == id));
        }

        public IResult Update(Brand brand)
        {
            _efBrandDal.Update(brand);
            return new SuccessResult();
        }
    }
}
