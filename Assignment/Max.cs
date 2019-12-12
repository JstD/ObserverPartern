using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;
namespace Demo
{
    class Max : IObserver
    {
        public int value;
        private IObservable subject;

        public Max(IObservable subject)
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
                if (i > value) value = i;
            }
            Form1.lblMax.Text = value.ToString();
        }
    }
}
