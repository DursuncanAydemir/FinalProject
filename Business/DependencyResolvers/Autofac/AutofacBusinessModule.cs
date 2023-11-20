using Autofac;
using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
        builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
    }
}
