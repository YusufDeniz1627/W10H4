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
    public class CustomerManager : ICustomerService
    {
        EfCustomersDal _efCustomerDal;

        public CustomerManager(EfCustomersDal efCustomerDal)
        {
            _efCustomerDal = efCustomerDal;
        }

        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length<2)
            {
                return new ErrorResult(Messages.CustomerNotAdded);
            }
            else
            {
                _efCustomerDal.Add(customer);
                return new SuccessResult(Messages.CustomerAdded);
            }
        }

        public IResult Deleted(Customer customer)
        {
            _efCustomerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_efCustomerDal.GetAll(),Messages.CustomerListed);
        }

        public IDataResult<Customer> GetById(int Id)
        {
            return new SuccessDataResult<Customer>(_efCustomerDal.Get(c=>c.UserId==Id));
        }

        public IResult Updated(Customer customer)
        {
            _efCustomerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
