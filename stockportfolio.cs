using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StockAccountManagemen
{ 
    // poco means plain old clr object it is a class which does not depend upon 
    // any framework specific base class.
    //this poco class is used as a datamodel for our input file.
    // class field and varibles should be same as fields and varible we want in our 
    // input file.
    public  class StockPortfolio
    {
        public  class poco
        {
            public string stockname { get; set; }
            public int Noofshares { get; set; }
            public int shareprice { get; set; }

        }

        List<poco> stock=new List<poco> 
        { 
            new poco{stockname="walmart",Noofshares=231,shareprice=2300},
            new poco{stockname="jio",Noofshares=22,shareprice=230},
            new poco{stockname="Tata",Noofshares=67,shareprice=786}
        };
        
        public static int Method()
        {
            int totalvalue = 0;
            StockPortfolio sw = new StockPortfolio();
            string stockresult = JsonConvert.SerializeObject(sw.stock);
            Console.WriteLine("stock Portfoilio --- " + stockresult);
            List<poco> newitem = JsonConvert.DeserializeObject<List<poco>>(stockresult);
            foreach(var d in newitem)
            {
                  Console.WriteLine( "company name is --- " + d.stockname + "share value is ----- " + d.Noofshares * d.shareprice);
                totalvalue += d.shareprice * d.Noofshares;
            }
            return totalvalue;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to stock Management system");
            
            Console.WriteLine("value of individual shares");
            int value = Method();
            Console.WriteLine("value of total share is " + value);
        }
        





    }
}


