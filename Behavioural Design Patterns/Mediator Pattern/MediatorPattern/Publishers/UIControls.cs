using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Subscriber;

namespace MediatorPattern.UIControls
{
    abstract class UIControls
    {
        List<Observer> observers = new List<Observer>();

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        protected void notifyObservers()
        {
            foreach (Observer obs in observers)
                obs.update();
        }
    }
}
