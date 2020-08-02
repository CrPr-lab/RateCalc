using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc
{
    public class Period
    {
        public Cargo Cargo { get; set; }
        public DateTime BegCalc { get; set; }
        public DateTime EndCalc { get; set; }
    }
}
