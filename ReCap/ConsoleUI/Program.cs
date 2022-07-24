using Business.Concrete;
using System;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            //CarManagerTest();
            //CustomerManagerTest();
            //UsersManagerTest();
            //RentalTest();
        }

        private static void RentalTest()
        {
            RentalsManager rentM = new RentalsManager(new EfRentalsDal());
            Rental rental1 = new Rental { Id = 2, CarId = 2, CustomerId = 2, RentDate = new DateTime(2022, 01, 05), ReturnDate = new DateTime(2022, 01, 06) };
            Console.WriteLine(rentM.Add(rental1).Message);
            //var result = rentM.GetAll();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine(item.RentDate);
            //}
        }

        private static void UsersManagerTest()
        {
            UsersManager sM = new UsersManager(new EfUsersDal());
            User u1 = new User { Id = 3, FirstName = "FirstName User3", LastName = "LastName user3", Email = "user3@gmail.com", Passwords = "user3" };
            //sM.Add(u1);
            var result = sM.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerManagerTest()
        {
            CustomerManager cM = new CustomerManager(new EfCustomersDal());
            Customer c1 = new Customer { Id = 1, UserId = 1, CompanyName = "Customer1 company" };
            //cM.Add(c1);
            var result = cM.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CompanyName);
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var item in carManager.GetCarDetail())
            //{
            //    Console.WriteLine("isim :" + item.CarName + "\nmarka:" + item.BrandName + "\nrenk :" + item.ColorName + "\ngünlük fiyat :" + item.DailyPrice);
            //}
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //Color color = new Color { Id = 2, Name = "Beyaz" };
            //colorManager.Add(color);
            var result = colorManager.GetAll();
            foreach (var item in result.Data)
            {
               Console.WriteLine(item.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand = new Brand { Id = 2, Name = "BMW" };
            //brandManager.Delete(brand);
            var result = brandManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(brandManager.GetbyId(1).Data.Name);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Car newCar = new Car {Id=1,BrandId=1,ColorId=1,ModelYear=2023,DailyPrice=600,CarName="Togg",Detail="Yerli SUV TOGG" };
            //carManager.Add(newCar);
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
