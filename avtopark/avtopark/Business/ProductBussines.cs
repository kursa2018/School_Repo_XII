using avtopark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace avtopark.Business
{
    public class ProductBussines
    {
        private AvtosalovDbContext avtosalovDbContext { get; set; }
        public List<Car>GetAll()
        {
            using (avtosalovDbContext = new AvtosalovDbContext())
            {
                return avtosalovDbContext.Cars.ToList();
            }
        }//end GetAll()
        public Car GetCar(string id)
        {
            using (avtosalovDbContext = new AvtosalovDbContext())
            {
                return avtosalovDbContext.Cars.Find(id);
            }
        }//end GetCar()
        public void AddCar(Car car)
        {
            using (avtosalovDbContext = new AvtosalovDbContext())
            {
                avtosalovDbContext.Cars.Add(car);
            }
        }//end GetCar()
        public void UpdateCar(Car car)
        {
            using (avtosalovDbContext = new AvtosalovDbContext())
            {
                var item = avtosalovDbContext.Cars.Find(car);
                if (item!=null)
                {
                    avtosalovDbContext.Entry(item).CurrentValues.SetValues(car);
                    avtosalovDbContext.SaveChanges();
                }
            }
        }//end UpdateCar
        public void DeleteCar(string id)
        {
            using (avtosalovDbContext = new AvtosalovDbContext())
            {
                var item = avtosalovDbContext.Cars.Find(id);
                if (item!=null)
                {
                    avtosalovDbContext.Cars.Remove(item);
                    avtosalovDbContext.SaveChanges();
                }
            }
        }//end delete
    }
}
