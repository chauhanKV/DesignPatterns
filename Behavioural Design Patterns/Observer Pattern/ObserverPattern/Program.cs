using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Publisher;
using ObserverPattern.Subscriber;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Stock stock1 = new Stock("TCS", 4512);
            Stock stock2 = new Stock("Reliance", 1200);
            Stock stock3 = new Stock("HUL", 4568);


            StatusBar objStatusBar = new StatusBar();
            StockListView objStockLstView = new StockListView();

            objStatusBar.addStocks(stock1);
            objStatusBar.addStocks(stock2);

            objStockLstView.addStocks(stock1);
            //objStockLstView.addStocks(stock2);
            //objStockLstView.addStocks(stock3);

            stock1.setStockPrice(5000);
            stock2.setStockPrice(10000);
            stock3.setStockPrice(20033);

            Console.ReadLine();
        }
    }
}
