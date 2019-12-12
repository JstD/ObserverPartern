using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;
namespace Demo
{
    class Min : IObserver
    {
        private int value;
        private IObservable subject;
        public Min(IObservable subject)
        {
            value = 0;
            this.subject = subject;
        }
        public void update()
        {
            List<int> data = subject.getData();
            value = data.ElementAt(0);
            foreach (int i in data)
            {
                if (i < value) value = i;
            }
            Form1.lblMin.Text = value.ToString();
        }
        public int getMin() { return value; }
    }
}
