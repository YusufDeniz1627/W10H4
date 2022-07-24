using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IUsersService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
