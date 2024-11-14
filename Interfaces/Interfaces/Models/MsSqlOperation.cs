using System;

namespace Interfaces.Models
{
    public class MsSqlOperation :Test , ISqlOperation , ITestInterface
    {
        public void Connetction()
        {
            Console.WriteLine("MsSql için bağlantı sağlandı.");
        }

        public bool Insert(Products product)
        {
            return true;
        }
    }

    public class MySqlOperation : ISqlOperation
    {
        public void Connetction()
        {
            Console.WriteLine("MySql için bağlantı sağlandı.");
        }

        public bool Insert(Products product)
        {
            return true;
        }
    }


    public interface ISqlOperation: ITestInterface
    {
        void Connetction();
        bool Insert(Products product);
    }

    public class Test { 

    }

    public interface ITestInterface {

        
    }

}
