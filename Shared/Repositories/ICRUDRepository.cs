using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositories
{
    public interface ICRUDRepository<TEntity, TId> where TEntity : class
    {
        public IEnumerable<TEntity> Get();
        public TEntity Get(TId id);
        public TId Insert(TEntity data);
        public void Update(TEntity data);
        public void Delete(TId id);
    }
}
