using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Süreler
    {
        public int ID { get; set; }
        public string sanise { get; set; }
        public string saniye{ get; set; }
        public string dakika{ get; set; }
        public string saat{ get; set; }
        public string tür { get; set; }
        public DateTime time { get; set; }
    }
}
