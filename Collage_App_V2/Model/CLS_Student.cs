using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collage_App_V2.Model
{
    class CLS_Student
    {
        public int id_Student { get; set; }

        public string name { get; set; }

        public string gender { get; set; }

        public DateTime age { get; set; }

        public string department { get; set; }

        public int step { get; set; }
    
        public string type_study { get; set; }

        public double total_amount { get; set; }

        public double discount { get; set; }
    }
}
