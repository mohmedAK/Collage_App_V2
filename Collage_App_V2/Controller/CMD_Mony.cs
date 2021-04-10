using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collage_App_V2.Model;
using Collage_App_V2.Factory;
namespace Collage_App_V2.Controller
{
    
    class CMD_Mony
    {
        Repository<CLS_Mony> cmd = new Repository<CLS_Mony>();

      public  List<CLS_Mony> GetMonyRecordForStudent(int id_Student)
        {
            return cmd.GetByParam("SP_GetMonyRecordForStudent @id_Student", new CLS_Mony() { id_Student = id_Student }).ToList();
        }

        public bool InsertMoneyRecord(int id_Student,double batch , DateTime date)
        {
            try
            {
                cmd.ExcParam("SP_InsertMoneyRecord @id_Student,@batch,@dateRecord ", new CLS_Mony() { id_Student = id_Student, batch = batch, dateRecord = date });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool EditMoneyRecord(int id_Money, double batch, DateTime date)
        {
            try
            {
                cmd.ExcParam("SP_EditMoneyRecord @id_Mony,@batch,@dateRecord ", new CLS_Mony() { id_Mony = id_Money, batch = batch, dateRecord = date });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

      public  List<CLS_Mony> GetMoneyRecords()
        {
            return cmd.GetAll("SP_GetMoneyRecords ").ToList();
        }
    }
}
