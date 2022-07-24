using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IRentalsService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int Id);

        IResult Add(Rental rentals);
        IResult Deleted(Rental rentals);
        IResult Updated(Rental rentals);

    }
}
