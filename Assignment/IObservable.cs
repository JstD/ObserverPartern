using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    interface IObservable
    {
        void notify();
        void attach(IObserver ob);
        void detach(IObserver ob);
        List<int> getData();
        void setData(List<int> data);
    }
}
