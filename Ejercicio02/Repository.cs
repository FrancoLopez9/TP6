using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    abstract class Repository<TEntity, TDbContext> : IRepository<TEntity>   where TEntity : class
                                                                            where TDbContext : DbContext
    {
        protected TDbContext iDbContext;
        public Repository(TDbContext pContext)
        {
            this.iDbContext = pContext;
        }
        public void Add(TEntity pEntity) { }
        public TEntity Get(int pld)
        {
            return;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return;
        }
        public void Remove (TEntity pEntity)
        {
        }
    }
}
