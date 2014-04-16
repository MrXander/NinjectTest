using System;

namespace NinjectTest
{
    class Suriken : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("{0} attacked with Suriken", target);
        }
    }
}
