using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collage_App_V2.Model
{
    class CLS_Absence
    {
        public int id_Absence { get; set; }
        public int absence_count { get; set; }
        public DateTime date_Absence { get; set; }
        public int id_Student { get; set; }
    }
}
