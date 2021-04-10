using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collage_App_V2.Controller;
using Collage_App_V2.Model;
namespace Collage_App_V2.View
{
    public partial class FRM_Score : DevExpress.XtraEditors.XtraForm
    {
        CMD_Scores cmd_scores = new CMD_Scores();
        public FRM_Score()
        {
            InitializeComponent();
       
        }

      public  void loadScoresForOneStudent(int id_student)
        {
           List<CLS_Score> scores= cmd_scores.GetAllScoresForOneStudent(id_student);
            gcScores.DataSource = scores;        
        }

        private void simpleButtonAddStudyBook_Click(object sender, EventArgs e)
        {
            AddSubjectNameAndScore();
        }

        void AddSubjectNameAndScore()
        {
            int id_Student = int.Parse(labelControlIdStudent.Text);
            FRM_Add_EditStudyBook frm = new FRM_Add_EditStudyBook(id_Student, "Add");
            frm.ShowDialog();
            loadScoresForOneStudent(id_Student);
        }

        private void repositoryEditScore_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id_Score = int.Parse(gvScores.GetFocusedRowCellValue("id_Score").ToString());
            FRM_Add_EditStudyBook frm = new FRM_Add_EditStudyBook(id_Score, "Edit");
            frm.ShowDialog();
            loadScoresForOneStudent(int.Parse(labelControlIdStudent.Text));
        }

        private void repositoryDeleteSubject_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id_Score = int.Parse(gvScores.GetFocusedRowCellValue("id_Score").ToString());
            if (XtraMessageBox.Show("هل انت متاكد من حذف المادة لايمكن استعادة الدرجات بعد الحذف","حذف مادة",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cmd_scores.DeleteOneScoreFromStudent(id_Score))
                {
                    loadScoresForOneStudent(int.Parse(labelControlIdStudent.Text));
                    XtraMessageBox.Show("تم الحذف بنجاح", "الحذف");
                }
                else
                {
                    XtraMessageBox.Show("هناك مشكلة راجع المبرمج المسئول", "الحذف");
                }
            }
        }
    }
}