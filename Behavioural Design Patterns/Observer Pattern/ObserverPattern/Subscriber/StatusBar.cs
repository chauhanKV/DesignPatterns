using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Publisher;

namespace ObserverPattern.Subscriber
{
    class StatusBar : Observer
    {
        private List<Stock> stocks = new List<Stock>();

        public void addStocks(Stock stock)
        {
            stocks.Add(stock);
            stock.addObserver(this);
        }
        public void update()
        {
            StringBuilder str = new StringBuilder();
            str.Append("======= Status Bar =======");
            foreach (Stock stk in stocks)
            {
                str.Append("\n Symbol Name: " + stk.getSymbolName() + " " + "Price: " + stk.getStockPrice()+ "\n");
            }

            Console.WriteLine(str.ToString());
        }
    }
}
