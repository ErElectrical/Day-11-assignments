using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.IO;
namespace InventoryManager
{
    public class input
    {
        public string item { get; set; }
        public int weight { get; set; }
        public int priceperkg { get; set; }
    }
    public class InventoryManager
    {
        
        public static List<input> listcreation()
        {
            Console.WriteLine("list of items creation ----------> ");
            List<input> item = new List<input>
            {
                new input { item = "rice", weight = 50, priceperkg = 78 },
                new input { item = "wheat", weight = 60, priceperkg = 89 },
                new input { item = "pulses", weight = 78, priceperkg = 120 }



            };
            return item;
        }
        public static void Deserializaer()
        {
            string result = JsonConvert.SerializeObject(InventoryManager.listcreation);

            Console.WriteLine(result);
            Console.WriteLine("\t Deserialization of object ");
            List<input> newitem = JsonConvert.DeserializeObject<List<input>>(result);
            foreach(var d in newitem)
            {
                Console.WriteLine("item is ---- " + d.item );
                Console.WriteLine("weight is ---- " + d.weight);
                Console.WriteLine("value is ---- " + d.weight*d.priceperkg);



            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("amount of your purchase ----------");
            InventoryManager.Deserializaer();
            
        }


    }
    
        



}

