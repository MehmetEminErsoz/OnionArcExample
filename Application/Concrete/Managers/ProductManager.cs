using Application.Abstract.Repositories;
using Application.Abstract.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        IGenericRepository<Product> repository;
        public ProductManager(IGenericRepository<Product> _repository)
        {
            repository = _repository;
        }
        public Product add(Product product)
        {
            Product record = new Product();
            record.Id = product.Id;
            record.Name = product.Name;
            record.Description = product.Description;
            record.CreatedTime = DateTime.Now;
            record.IsActive = true;
            repository.add(record);
            return record;
           
        }

        public List<Product> getAll()
        {
            var result =repository.getAll();
            return result;
        }
    }
}
