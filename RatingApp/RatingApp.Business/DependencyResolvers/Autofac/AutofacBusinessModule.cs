using Autofac;
using RatingApp.Business.Abstract;
using RatingApp.Business.Concrete;
using RatingApp.DataAccess.Abstract;
using RatingApp.DataAccess.Concrete.EntityFramework;

namespace RatingApp.Business.DependencyResolvers.Autofac{
    public class AutofacBusinessModule:Module{
        protected override void Load(ContainerBuilder builder){
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();
        }
    }
}