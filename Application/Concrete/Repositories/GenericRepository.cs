using Application.Abstract.Context;
using Application.Abstract.Repositories;
using Application.Abstract.Services;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Concrete.Repositories
{
    public class GenericRepository<Target> : IGenericRepository<Target> where Target : class
    {
        ApplicationDbContext context;
        DbSet<Target> genericTable;

        public GenericRepository(ApplicationDbContext _db)
        {
            context = _db;
            genericTable = context.Set<Target>();
        }



        public Target add(Target record)
        {
            genericTable.Add(record);
            context.SaveChanges();
           
            return record;
        }

        public List<Target> getAll(bool load = false)
        {
            if (load)
            {
                var result = context.IncludeAll<Target>().ToList();
                return result;
            }
            return genericTable.ToList();
        }

        public Target getById(int id)
        {
            throw new NotImplementedException();
        }

        public bool remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(Target record)
        {
            throw new NotImplementedException();
        }
    }
}
