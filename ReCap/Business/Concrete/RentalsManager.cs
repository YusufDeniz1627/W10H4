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
    public class RentalsManager : IRentalsService
    {
        EfRentalsDal _efRentalsDal;

        public RentalsManager(EfRentalsDal efRentalsDal)
        {
            _efRentalsDal = efRentalsDal;
        }

        public IResult Add(Rental rentals)
        {
            var result = _efRentalsDal.Get(r => r.CarId == rentals.CarId && (r.ReturnDate == null || r.ReturnDate > rentals.RentDate));
            if (result == null )
            {
                _efRentalsDal.Add(rentals);
                return new SuccessResult(Messages.RentalsAdded);
            }
            else
            {
                return new ErrorResult(Messages.RentalsNotAdded);
            }
               
        }

        public IResult Deleted(Rental rentals)
        {
            _efRentalsDal.Delete(rentals);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_efRentalsDal.GetAll());
        }

        public IDataResult<Rental> GetById(int Id)
        {
            return new SuccessDataResult<Rental>(_efRentalsDal.Get(r=>r.Id==Id));
        }

        public IResult Updated(Rental rentals)
        {
            _efRentalsDal.Update(rentals);
            return new SuccessResult();
        }
    }
}
