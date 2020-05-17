using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Subscriber;

namespace ObserverPattern.Publisher
{
    class Stock
    {
        private string symbolName;
        private int stockPrice;
        List<Observer> lst = new List<Observer>();

        public Stock(string symbolName, int stockPrice)
        {
            this.symbolName = symbolName;
            this.stockPrice = stockPrice;
        }

        public string getSymbolName() { return this.symbolName; }
        public int getStockPrice() { return this.stockPrice; }

        public void setStockPrice(int price)
        {
            this.stockPrice = price;
            notifyObserver();
        }

        public void addObserver(Observer obs)
        {
            lst.Add(obs);
        }

        public void removeObserver(Observer obs)
        {
            lst.Remove(obs);
        }

        private void notifyObserver()
        {
            foreach (Observer obs in lst)
            {
                obs.update();
            }
        }

    }
}
