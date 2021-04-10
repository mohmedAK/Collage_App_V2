using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collage_App_V2.Controller;
using Collage_App_V2.Factory;
using Collage_App_V2.Model;
namespace Collage_App_V2.Controller
{
    class CMD_Scores
    {
        Repository<CLS_Score> cmdScores = new Repository<CLS_Score>();

        public List<CLS_Score> GetAllScoresForOneStudent(int id_Student)
        {

           return cmdScores.GetByParam("SP_GetAllScoreForOneStudent @id_Student", new CLS_Score() {id_Student=id_Student}).ToList();
        }

        public void InsertScoreAndBook(int id_Student, string subjectName, int t1, int t2, int t3)
        {
            List<CLS_Score> scores = new List<CLS_Score>()
            {
               new CLS_Score()
               {
                    id_Student = id_Student,
                    subject_name = subjectName,
                    term1=t1,
                    term2=t2,
                    final =t3
               }
            };

            cmdScores.ExcParam("SP_InsertScore @id_Student,@subject_name, @term1,@term2,@final", scores);
        }

        public void EditScoreAndBook(int id_Score,  int t1, int t2, int t3)
        {
            List<CLS_Score> scores = new List<CLS_Score>()
            {
               new CLS_Score()
               {
                    id_Score = id_Score,
                    
                    term1=t1,
                    term2=t2,
                    final =t3
               }
            };

            cmdScores.ExcParam("SP_EditScore @id_Score , @term1,@term2,@final", scores);
        }

        public List<CLS_Score> GetAllSubjectScores()
        {
            return cmdScores.GetAll("SP_GetAllSubjectScore ").ToList();
        }

        public bool DeleteOneScoreFromStudent(int id_Score)
        {
            try
            {
                cmdScores.ExcParam("SP_DeleteOneScoreFromStudent @id_Score", new CLS_Score() { id_Score = id_Score });
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
