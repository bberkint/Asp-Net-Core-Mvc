using IocContainer.Services.Interfaces;
using System;

namespace IocContainer.Services
{
    public class ConsoleLogger: ILog
    {
        public void Info(string message) {
            Console.WriteLine(message);
        }
    }
}
