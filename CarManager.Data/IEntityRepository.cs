using CarManager.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CarManager.Data
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //T Get(int id);

        //List<T> GetList()

        T Add(T obj);

        T Update(T obj);

        void Delete(int objId);
    }
}
