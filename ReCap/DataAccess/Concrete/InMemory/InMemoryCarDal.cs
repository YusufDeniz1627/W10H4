using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=120,ModelYear=2015,CarName="Bmw 4.20",Detail="Sıfır" },
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=400,ModelYear=2022,CarName="Volvo S90",Detail="Sıfır" },
                new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=299,ModelYear=2006,CarName="Mercedes s350",Detail="Sıfır" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id==Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.CarName = car.CarName;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Detail = car.Detail;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
