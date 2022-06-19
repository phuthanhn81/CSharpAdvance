using Microsoft.Extensions.DependencyInjection;
using System;

namespace DI
{
    class Program
    {
        private readonly DI _di;

        public Program(DI di)
        {
            // dễ dàng thay đổi qua lại các class nếu các class cùng implement 1 interface
            _di = di;
        }

        static void Main(string[] args)
        {
            var host = Startup.CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();

            Console.ReadLine();
        }

        public void Run()
        {
            _di.RunDI();
        }
    }
}
