using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_CVK.Model
{
    public class CVK
    {
        public int CVKHashCode { set; get; }
        public List<Region> regions = new List<Region>();

        public CVK()
        {
            CVKHashCode = GetHashCode();
        }

        public override int GetHashCode()
        {
            return -1557085286 + EqualityComparer<List<Region>>.Default.GetHashCode(regions);
        }
    }
}
