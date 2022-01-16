using General.Core.Entities;
using System.Linq.Expressions;

namespace General.Core.DataAccess{
    public interface IGenericRepository<T> where T : class,IEntity,new(){
        T Get(Expression<Func<T,bool>> filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}