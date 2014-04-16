using Ninject;

namespace NinjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<IWeapon>().To<Suriken>();
            //kernel.Bind<IWeapon>().To<Sword>();

            var samurai1 = kernel.Get<Samurai>();
            samurai1.Attack("lord");
        }
    }
}
