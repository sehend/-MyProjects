using Autofac;
using Core.Security.Jwt;
using Data.Abstract;
using Data.Concrete;
using Data.Concrete.EntityFramework;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();

            builder.RegisterType<EfProduct>().As<IProductDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();

            builder.RegisterType<EfCategory>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }


    }
}
