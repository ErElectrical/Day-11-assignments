using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class Stock
    {
        public String StockName;
        public long NumberOfShare;
        public long SharePrice;
        public long TotalStockPrice;
        public override string ToString()
        {
            string st = $"StockName: {StockName}\nNumberOfShare: {NumberOfShare}\nSharePrice: {SharePrice}\nTotalStockPrice: {TotalStockPrice}";
            return st;
        }
    }
    public class StockPortFolio
    {
        
        
            public List<Stock> Stocks;
            public long GrandTotalStockPrice;
        
    }
}
