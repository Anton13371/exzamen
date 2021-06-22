using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Model
{
    [Serializable]
    public class Buyer
    {
        public Buyer() { }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateBuy { get; set; }
        public double SumBuy { get; set; }

        public string Type { get; set; }

    }
}
