using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstract.Services
{
    public static class EntityFrameworkQueryableExtensions
    {
        public static IQueryable<TEntity> IncludeAll<TEntity>(this ApplicationDbContext source) where TEntity : class
        {
            var query = source.Set<TEntity>().AsQueryable();

            foreach (var property in source.Model.FindEntityType(typeof(TEntity)).GetNavigations())
                query = query.Include(property.Name);

            return query;
        }
    }
    public interface IProductService
    {
        public Product add(Product product);
        public List<Product> getAll();
    }
}
