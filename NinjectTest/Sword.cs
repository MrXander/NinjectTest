using System;

namespace NinjectTest
{
    class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.Write("{0} attacked with sword", target);
        }
    }
}
