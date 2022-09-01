using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstract.Repositories
{
    public interface IGenericRepository<Target> where Target : class
    {
        public List<Target> getAll(bool load = false);
        public Target add(Target record);
        public bool remove(int id);
        public Target getById(int id);
        public bool update(Target record);
    }
}
