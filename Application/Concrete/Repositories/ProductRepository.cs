using Application.Abstract.Context;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Concrete.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        private readonly ApplicationDbContext context;
        public ProductRepository(ApplicationDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
