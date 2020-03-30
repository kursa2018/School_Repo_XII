using StokiPoKatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokiPoKatalog.Business
{
    public class ProductBusiness
    {
        public CatalogDbContext catalogDbContext;
        public List<Client>GetAllClients()
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                return catalogDbContext.Clients.ToList();
            }
        }
        //Процедура GetAll() за Products
        public List<Distributor> GetAllDistributors()
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                return catalogDbContext.Distributors.ToList();
            }
        }
        //Процедура GetAll() за продуктите
        public List<Product> GetAllProducts()
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                return catalogDbContext.Products.ToList();
            }
        }
        //Процедури за добавяне на Клиенти->Дистрибутори->Продукти
        public void AddClient(Client client)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                catalogDbContext.Clients.Add(client);
                catalogDbContext.SaveChanges();
            }
        }
        //Процедура за добавяне на дистрибутори
        public void AddDistributor(Distributor distributor)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                catalogDbContext.Distributors.Add(distributor);
                catalogDbContext.SaveChanges();
            }
        }
        //Процедура за добавяне на клиенти
        public void AddProducts(Product product)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                catalogDbContext.Products.Add(product);
                catalogDbContext.SaveChanges();
            }
        }
        //Процедури за търсене-----
        public Client GetClient(string egn)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                return catalogDbContext.Clients.Find(egn);
            }
        }

        public Product GetProduct(int number)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                return catalogDbContext.Products.Find(number);
            }
        }

        public Distributor GetDistributor(int distId)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                return catalogDbContext.Distributors.Find(distId);
            }
        }
        //Край на сегмента търсене---
        public void UpdateClient(Client client)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                var item = catalogDbContext.Clients.Find(client.Egn);
                if (item!=null)
                {
                    catalogDbContext.Entry(item).CurrentValues.SetValues(client);
                    catalogDbContext.SaveChanges();
                }
            }
        }//end
        public void UpdateProduct(Product product)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                var item = catalogDbContext.Products.Find(product.Number);
                if (item != null)
                {
                    catalogDbContext.Entry(item).CurrentValues.SetValues(product);
                    catalogDbContext.SaveChanges();
                }
            }
        }//end
        public void UpdateDistributor(Distributor distributor)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                var item = catalogDbContext.Distributors.Find(distributor.DistrId);
                if (item!=null)
                {
                    catalogDbContext.Entry(item).CurrentValues.SetValues(distributor);
                    catalogDbContext.SaveChanges();
                }
            }
        }
        //Изтриване на Клиенти, Дистрибутори, Продукти
        public void DeleteClient(string egn)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                var client = catalogDbContext.Clients.Find(egn);
                if (client!=null)
                {
                    catalogDbContext.Clients.Remove(client);
                    catalogDbContext.SaveChanges();
                }
            }
        }//end
        public void DeleteProduct(int number)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                var product = catalogDbContext.Products.Find(number);
                if (product != null)
                {
                    catalogDbContext.Products.Remove(product);
                    catalogDbContext.SaveChanges();
                }
            }
        }//end
        public void DeleteDistributor(int distId)
        {
            using (catalogDbContext = new CatalogDbContext())
            {
                var distributor = catalogDbContext.Distributors.Find(distId);
                if (distributor!=null)
                {
                    catalogDbContext.Distributors.Remove(distributor);
                    catalogDbContext.SaveChanges();
                }
            }
        }
    }
}
