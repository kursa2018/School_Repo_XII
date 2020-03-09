using ColaPodNaem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColaPodNaem.Business
{
    public class CarClientBusiness
    {
        private avtoparkColiClientyDbContext avtopark;
        public List<Car> GetAllCars()
        {
            using ( avtopark = new avtoparkColiClientyDbContext())
            {
                return avtopark.Cars.ToList();
            }
        }//end GetAllCars()
        public Car GetCar(string id)
        {
            using ( avtopark = new avtoparkColiClientyDbContext())
            {
                var item = avtopark.Cars.Find(id);
                return item;
            }
        }//end GetCar()
        public void AddCar(Car car)
        {
            using ( avtopark = new avtoparkColiClientyDbContext())
            {
                avtopark.Cars.Add(car);
                avtopark.SaveChanges();
            }
        }//end GetCar()
        public void UpdateCar(Car car)
        {
            using (avtopark = new avtoparkColiClientyDbContext())
            {
                var item = avtopark.Cars.Find(car.Id);
                if (item!=null)
                {
                    avtopark.Entry(item).CurrentValues.SetValues(car);
                    avtopark.SaveChanges();
                }
            }
        }//end UpdateCar()
        public void DeleteCar(string id)
        {
            using ( avtopark = new avtoparkColiClientyDbContext())
            {
                var item = avtopark.Cars.Find(id);
                if (item!=null)
                {
                    avtopark.Cars.Remove(item);
                    avtopark.SaveChanges();
                }
            }
        }//end UpdateCar()
    }
}
