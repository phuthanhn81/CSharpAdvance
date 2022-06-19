using System;

namespace DI.Interface
{
    public interface IUser
    {
        Guid ID { get; set; }
        string Name { get; set; }

        Guid Create();
    }
}
