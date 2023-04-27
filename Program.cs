using System;

namespace Proxy
{
    class Program
    {
        static void Main(string []args)
        {
            Subject subject = RealSubject();

            Console.WriteLine("Owner work: ");
            TryAccess(new Proxy(subject, "AOwner"), "John");

            Console.WriteLine("Anministrator work: ");
            TryAccess(new Proxy(subject, "Anministrator"), "Mark");

            Console.WriteLine("Manager work: ");
            TryAccess(new Proxy(subject, "Manager"), "Lola");

            Console.WriteLine("User work: ");
            TryAccess(new Proxy(subject, "User"), "Gigi");
        }

        private static void TryAccess(Proxy proxy, string v)
        {
            try
            {

            }
        }
    }
}
