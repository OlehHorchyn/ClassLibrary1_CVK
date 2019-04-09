using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_CVK.Model
{
    public class TerretoryOkrug
    {
        public string Id { set; get; }
        public int Total { set; get; }
        public int Processed { set; get; }
        public string Description { set; get; }
        public List<Department> departments = new List<Department>();

        public TerretoryOkrug(string id, int total, int processed, string description)
        {
            Id = id;
            Total = total;
            Processed = processed;
            Description = description;
        }
    }
}
