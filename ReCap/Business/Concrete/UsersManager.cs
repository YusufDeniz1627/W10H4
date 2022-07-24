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
    public class UsersManager : IUsersService
    {
        EfUsersDal _efUsersDal;

        public UsersManager(EfUsersDal efUsersDal)
        {
            _efUsersDal = efUsersDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length < 2 || user.LastName.Length < 2)
            {
                return new ErrorResult(Messages.UsersNotAdded);
            }
            else
            {
                _efUsersDal.Add(user);
                return new SuccessResult(Messages.UserAdded);
            }
        }

        public IResult Delete(User user)
        {
            _efUsersDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_efUsersDal.GetAll(),Messages.UsersListed);
        }

        public IDataResult<User> GetById(int Id)
        {
            return new SuccessDataResult<User>(_efUsersDal.Get(s => s.Id == Id));
        }

        public IResult Update(User user)
        {
            _efUsersDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
