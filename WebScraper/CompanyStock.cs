using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public class CompanyStock
    {
        public string Symbol { get; set; }
        public string Company { get; set; }
        public string Last { get; set; }
        public string Change { get; set; }
        public string PercentChange { get; set; }
        public string Volume { get; set; }
        public string Traded { get; set; }

        public CompanyStock(string symbol, string company, string last, string change, string perChange, string volume, string traded)
        {
            Symbol = symbol;
            Company = company;
            Last = last;
            Change = change;
            PercentChange = perChange;
            Volume = volume;
            Traded = traded;
        }

        override
        public string ToString()
        {
            return Symbol + " " + Company + " " + Last + " " + Change + " " + PercentChange + " " + Volume + " " + Traded;
        }
    }
}
