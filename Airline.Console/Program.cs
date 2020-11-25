using Airline.Domain;
using System;

namespace Airline.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Country c = new Country { Name="Serbia" };
            AirlineContext context = new AirlineContext();
            context.SaveChanges();
            context.Dispose();
        }
    }
}
