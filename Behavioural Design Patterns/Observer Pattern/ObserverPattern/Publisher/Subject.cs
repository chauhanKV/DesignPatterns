using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Subscriber;

namespace ObserverPattern.Publisher
{
    class Subject
    {

        List<Observer> lst = new List<Observer>();
     
        public virtual void addObserver(Observer obs)
        {
            lst.Add(obs);
        }

        public virtual void removeObserver(Observer obs)
        {
            lst.Remove(obs);
        }

        public virtual void notifyObserver()
        {
            foreach (Observer obs in lst)
            {
                obs.update();
            }
        }
        
    }
}
