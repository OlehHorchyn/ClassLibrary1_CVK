using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1_CVK.Model;
using Newtonsoft.Json;

namespace ClassLibrary1_CVK
{
    public class JsonStorage : DAOSetting
    {

        public CVK retrieveFromFile(){
            CVK existCVK = null;

            string stringJson = "";

            using (StreamReader sr = new StreamReader(@"D:\C# Projects\cvk.json"))
            {
                stringJson = sr.ReadToEnd();
            }

            existCVK = JsonConvert.DeserializeObject<CVK>(stringJson);

            return existCVK;
        }

        public void upsert(CVK cvk)
        {
            CVK existCVK = retrieveFromFile();
        }
    }
}
