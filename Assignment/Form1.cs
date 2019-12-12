using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo;
namespace Assignment
{
    public partial class Form1 : Form
    {
        static IObservable ob = new Observable();
        static void Register()
        {
            IObserver max = new Demo.Max(ob);
            IObserver min = new Demo.Min(ob);
            IObserver mean = new Demo.Mean(ob);
            ob.attach(max);
            ob.attach(min);
            ob.attach(mean);
        }
        List<int> L = new List<int>();
        public Form1()
        {
            InitializeComponent();
            lblList.Text = lblMax.Text = lblAvg.Text = lblMin.Text = lblReport.Text= "";
            Register();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int temp=0;
            bool report = true;
            try
            {
                temp = Int32.Parse(txtInput.Text);
            }
            catch (Exception)
            {
                report = false;
            }
            if (report)
            {
                lblReport.Text = "Thành công";
                L.Add(temp);
                string aux ="";
                foreach (int i in L)
                {
                    aux = aux + i.ToString() + ' ';
                }
                lblList.Text = aux;
                ob.setData(L);
                ob.notify();
            }
            else
                lblReport.Text = "Thất bại";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int temp = 0;
            bool report = true;
            try
            {
                temp = Int32.Parse(txtInput.Text);
            }
            catch (Exception)
            {
                report = false;
            }
            if (report)
            {
                lblReport.Text = "Thành công";
                L.Remove(temp);
                string aux = "";
                foreach (int i in L)
                {
                    aux = aux + i.ToString() + ' ';
                }
                lblList.Text = aux;
                lblList.Text = aux;
                ob.setData(L);
                ob.notify();
            }
            else
                lblReport.Text = "Thất bại";
        }
    }
}
    