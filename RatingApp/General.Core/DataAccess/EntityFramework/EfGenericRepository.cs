using General.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace General.Core.DataAccess.EntityFramework{
    public class EfGenericRepository<Tentity, Tcontext> : IGenericRepository<Tentity>
        where Tentity : class, IEntity, new()
        where Tcontext : DbContext,new(){
        public void Add(Tentity entity){
            using(Tcontext context=new Tcontext()){
                var addedEntity=context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity){
            using (Tcontext context = new Tcontext()){
                var deletedEntity=context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter = null){
            using (Tcontext context = new Tcontext()){
                return context.Set<Tentity>().SingleOrDefault(filter);
            }
        }

        public List<Tentity> GetList(Expression<Func<Tentity, bool>> filter = null){
            using (Tcontext context = new Tcontext()){
                return filter==null
                    ? context.Set<Tentity>().ToList()
                    : context.Set<Tentity>().Where(filter).ToList();
            }
        }

        public void Update(Tentity entity){
            using (Tcontext context = new Tcontext()){
                var updatedEntity=context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
