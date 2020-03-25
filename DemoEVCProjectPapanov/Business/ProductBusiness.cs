using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductBusiness
    {
        private ProductContext context;
        //Извлича всички продукти
        public List<Product>GetAll()
        {
            using (context = new ProductContext())
            {
                return context.Products.ToList();
            }
        }
        //Процедура Get()
        public Product Get(int Id)
        {
            using (context = new ProductContext())
            {
                return context.Products.Find(Id);
            }
        }
        //Добавяне на продукт Add()
        public void Add(Product product)
        {
            using (context = new ProductContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        //Презаписване на продукт
        public void Update(Product product)
        {
            using (context = new ProductContext())
            {
                var item = context.Products.Find(product.Id);
                if (item!=null)
                {
                    context.Entry(item).CurrentValues.SetValues(product);
                    context.SaveChanges();
                }
            }
        }
        //Процедура изтриване Delete()
        public void Delete(int Id)
        {
            using (context = new ProductContext())
            {
                var item = context.Products.Find(Id);
                if (item!=null)
                {
                    context.Products.Remove(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
