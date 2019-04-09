using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_CVK.Model
{
    public class Region
    {
        public string RegionName { set; get; }

        public int Count { set; get; }
        public List<TerretoryOkrug> okrugs = new List<TerretoryOkrug>();

        public Region(string regionName, int count)
        {
            RegionName = regionName;
            Count = count;
        }
    }
}
