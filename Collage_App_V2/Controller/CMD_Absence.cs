using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collage_App_V2.Factory;
using Collage_App_V2.Model;

namespace Collage_App_V2.Controller
{
    
    class CMD_Absence
    {
        Repository<CLS_Absence> cmd = new Repository<CLS_Absence>();

        public List<CLS_Absence> GetAllAbsences()
        {
            return cmd.GetAll("SP_GetAllAbsence").ToList();
        }

        public bool InsertAbsenceForStudent(int id_Student, int absence_count, DateTime date_Absence)
        {
            try
            {
                cmd.ExcParam("Sp_InsertAbsence @absence_count,@date_absence,@id_Student", new CLS_Absence() { absence_count = absence_count, date_Absence = date_Absence, id_Student = id_Student });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteAbsenceDate(int id_Absence)
        {
            try
            {
                cmd.ExcParam("SP_DeleteAbsence @id_Absence", new CLS_Absence() { id_Absence = id_Absence });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
