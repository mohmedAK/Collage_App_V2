using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collage_App_V2.Model
{
    class CLS_Score
    {
        public int id_Score { get; set; }

        public int id_Student { get; set; }
        public string subject_name { get; set; }

        public double term1 { get; set; }
        public double term2 { get; set; }
        public double final { get; set; }


    }
}
