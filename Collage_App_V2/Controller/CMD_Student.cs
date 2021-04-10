 using Collage_App_V2.Factory;
using Collage_App_V2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collage_App_V2.Controller
{
    class CMD_Student
    {
        Repository<CLS_Student> cmd = new Repository<CLS_Student>();

        public CLS_Student GetLastStudent()
        {
            return cmd.GetSingle("SP_GetLastIDStudent");
        }
        public void InsertStudent(int id_Student,string name, string gender, DateTime age, string department, int step, string type_study, double total_amount, double discount)
        {
            List<CLS_Student> students = new List<CLS_Student>()
            {
                new CLS_Student
                {
                    id_Student = id_Student,
                    name =name,
                    gender =gender,
                    age=age,
                    department = department,
                    step = step,
                    type_study = type_study,
                    total_amount = total_amount,
                    discount = discount
                }
            };

            cmd.ExcParam("SP_InsertStudent @id_Student,@name,@gender, @age,@department,@step,@type_study,@total_amount,@discount", students);

        }

        public  void EditStudent(int id_Student, string name, string gender, DateTime age, string department, int step, string type_study, double total_amount, double discount)
        {
            List<CLS_Student> students = new List<CLS_Student>()
            {
                new CLS_Student
                {
                    id_Student = id_Student,
                    name =name,
                    gender =gender,
                    age=age,
                    department = department,
                    step = step,
                    type_study = type_study,
                    total_amount = total_amount,
                    discount = discount
                }
            };

             cmd.ExcParam("SP_UpdateStudent @id_Student,@name,@gender, @age,@department,@step,@type_study,@total_amount,@discount", students);
        }

        public CLS_Student GetStudentById(int id_Student)
        {
            return cmd.GetSingle("SP_GetSingleStudent @id_Student", new CLS_Student { id_Student = id_Student });
        }

        public List<CLS_Student> GetStudentsByStep(int step)
        {
           return cmd.GetByParam("SP_GetStudentsByStep @step", new CLS_Student() { step = step }).ToList();
        }

        public bool DeleteStudent(int id_Student)
        {
            try
            {
                cmd.ExcParam("SP_DeleteStudent @id_Student", new CLS_Student() { id_Student = id_Student });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
