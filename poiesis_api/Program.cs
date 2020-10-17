using System;

namespace poiesis_api
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Models.PoiesisDBContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            Console.WriteLine("Hello World!");
        }
    }
}
