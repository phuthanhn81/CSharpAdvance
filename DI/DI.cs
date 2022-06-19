using DI.Interface;
using System;

namespace DI
{
    public class DI
    {
        private readonly IUser _user1;
        private readonly IUser _user2;

        public DI(IUser user1, IUser user2)
        {
            _user1 = user1;
            _user2 = user2;
        }

        public void RunDI()
        {
            Console.WriteLine(_user1.Create());
            Console.WriteLine(_user2.Create());
        }
    }
}
