using DI.Interface;
using System;

namespace DI.Entities
{
    public class User : IUser
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public User()
        {
            ID = Guid.NewGuid();
        }

        public Guid Create()
        {
            return ID;
        }
    }
}
