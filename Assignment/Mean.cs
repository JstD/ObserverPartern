using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;
namespace Demo
{
    class Mean : IObserver
    {
        private float value;
        private IObservable subject;
        public Mean(IObservable subject)
        {
            value = 0;
            this.subject = subject;
        }
        public void update()
        {
            List<int> data = subject.getData();
            value = 0;
            foreach (int i in data) value += i;
            value = value / data.Count;
            Form1.lblAvg.Text = value.ToString();
        }
    }
}
