using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Observable : IObservable
    {
        private List<IObserver> observers;
        private List<int> data;
        public Observable()
        {
            observers = new List<IObserver>();
            data = new List<int>();
        }
        public void attach(IObserver ob) { observers.Add(ob); }
        public void detach(IObserver ob) { observers.Remove(ob); }
        public void setData(List<int> data) { this.data = data; }
        public List<int> getData() { return data; }
        public void notify()
        {
            foreach (IObserver ob in observers)
            {
                ob.update();
            }
        }
    }
}
