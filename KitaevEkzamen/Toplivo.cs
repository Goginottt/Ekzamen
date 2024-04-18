using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KitaevEkzamen
{
    internal class Toplivo
    {
        public void TP(double ob1, double ob2)
        {
            double ob3;
            ob3 = ob1 * ob2;
            MessageBox.Show("Масса топлива" + $"{ob3}"); 


        }
    }
}
