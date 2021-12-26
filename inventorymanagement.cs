using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inventorymanagementsystem
{
    public class Movie
    {
        public string item { get; set; }
        public int weight { get; set; }
        public int priceperkg { get; set; }
    }
    class program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("serialization --------------------------------------------------------------------");
            List<Movie> item = new List<Movie>
            {
                new Movie { item = "rice", weight = 50, priceperkg = 78 },
            new Movie { item = "wheat", weight = 60, priceperkg = 89 },
            new Movie { item = "pulses", weight = 78, priceperkg = 120 }



            };
            string result = JsonConvert.SerializeObject(item);

            Console.WriteLine(result);
            Console.WriteLine("\t Deserialization of object ");
            List<Movie> newitem=JsonConvert.DeserializeObject<List<Movie>>(result);
            foreach (var d in newitem)
            {
                Console.WriteLine("item : " + d.item + "  value is   " + d.weight * d.priceperkg);
            }













        }
    }
}


