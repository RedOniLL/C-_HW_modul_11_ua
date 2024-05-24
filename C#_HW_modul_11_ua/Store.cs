using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_11_ua
{
    public class Store : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public Store(string name, string address, string type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Store Name: {Name}, Address: {Address}, Type: {Type}");
        }

        ~Store()
        {
            Console.WriteLine("Destructor called for Store");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose called for Store");
            GC.SuppressFinalize(this);
        }
    }

}
