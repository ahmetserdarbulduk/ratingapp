using General.Core.DataAccess.EntityFramework;
using RatingApp.DataAccess.Abstract;
using RatingApp.Entities.Concrete;

namespace RatingApp.DataAccess.Concrete.EntityFramework{
    public class EfCommentDal:EfGenericRepository<Comment,RatingAppContext>,ICommentDal{
    
    }
}