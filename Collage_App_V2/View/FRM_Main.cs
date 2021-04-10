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
    public partial class FRM_Main : DevExpress.XtraEditors.XtraForm
    {
        CMD_Student cmdStudent = new CMD_Student();
        public FRM_Main()
        {
            InitializeComponent();
            loadStudent();
        }

      

        void loadStudent()
        {
            if (xtraTabControl1.SelectedTabPage == step1)
            {
                List<CLS_Student> students = cmdStudent.GetStudentsByStep(1);
                gcMain1.DataSource = students;
            }

            if (xtraTabControl1.SelectedTabPage == step2)
            {
                List<CLS_Student> students = cmdStudent.GetStudentsByStep(2);
                gcMain2.DataSource = students;
            }

            if (xtraTabControl1.SelectedTabPage == step3)
            {
                List<CLS_Student> students = cmdStudent.GetStudentsByStep(3);
                gcMain3.DataSource = students;
            }

            if (xtraTabControl1.SelectedTabPage == step4)
            {
                List<CLS_Student> students = cmdStudent.GetStudentsByStep(4);
                gcMain4.DataSource = students;
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            loadStudent();
        }
        private void simpleButtonAddStudent_Click(object sender, EventArgs e)
        {
            FRM_AddStudent fRM = new FRM_AddStudent();
            fRM.ShowDialog();

        }

        #region Stap 1 Grid View Buttons
        private void repositoryBtnScore_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_Score frm = new FRM_Score();
            int id = int.Parse(gvMain1.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = gvMain1.GetFocusedRowCellValue("id_Student").ToString();
            frm.labelControlStudentName.Text = gvMain1.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text= gvMain1.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain1.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain1.GetFocusedRowCellValue("type_study").ToString();
            frm.loadScoresForOneStudent(id);
            frm.ShowDialog();
        }
        private void repositoryBtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("هل انت متاكد من حذف المادة لايمكن استعادة الدرجات بعد الحذف", "حذف مادة", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_Student = int.Parse(gvMain1.GetFocusedRowCellValue("id_Student").ToString());
                if (cmdStudent.DeleteStudent(id_Student))
                {
                    loadStudent();
                    XtraMessageBox.Show("تم الحذف بنجاح", "الحذف");
                }
                else
                {
                    XtraMessageBox.Show("هناك مشكلة راجع المبرمج المسئول", "الحذف");
                }
            }
        }
        private void repositoryEditStudent_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id_Student = int.Parse(gvMain1.GetFocusedRowCellValue("id_Student").ToString());
            FRM_AddStudent frm = new FRM_AddStudent(id_Student);
            frm.ShowDialog();
            loadStudent();
        }

        private void repositoryBtnMonyEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_MonyRecord frm = new FRM_MonyRecord();
            int id_Student = int.Parse(gvMain1.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = id_Student.ToString() ;
            frm.labelControlStudentName.Text = gvMain1.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain1.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain1.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain1.GetFocusedRowCellValue("type_study").ToString();
            double totalMony = double.Parse(gvMain1.GetFocusedRowCellValue("total_amount").ToString());
            frm.labelControlTotalMony.Text = totalMony.ToString();
            double discount = double.Parse(gvMain1.GetFocusedRowCellValue("discount").ToString());
            frm.labelControlDiscount.Text = discount.ToString();
            frm.labelControlPureMony.Text = (totalMony - discount).ToString();
            frm.loadRecordMony(id_Student);
            frm.ShowDialog();
        }

        private void repositoryBtnAbsence_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_Absence frm = new FRM_Absence();
            int id_Student = int.Parse(gvMain1.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = id_Student.ToString();
            frm.labelControlStudentName.Text = gvMain1.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain1.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain1.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain1.GetFocusedRowCellValue("type_study").ToString();
            frm.loadAbsence(id_Student);
            frm.ShowDialog();
        }

       
        #endregion

        #region Stap 2 Grid View Buttons
        private void repositoryEditStudent2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id_Student = int.Parse(gvMain2.GetFocusedRowCellValue("id_Student").ToString());
            FRM_AddStudent frm = new FRM_AddStudent(id_Student);
            frm.ShowDialog();
            loadStudent();
        }

        private void repositoryMoney2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_MonyRecord frm = new FRM_MonyRecord();
            int id_Student = int.Parse(gvMain2.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = id_Student.ToString();
            frm.labelControlStudentName.Text = gvMain2.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain2.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain2.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain2.GetFocusedRowCellValue("type_study").ToString();
            double totalMony = double.Parse(gvMain2.GetFocusedRowCellValue("total_amount").ToString());
            frm.labelControlTotalMony.Text = totalMony.ToString();
            double discount = double.Parse(gvMain2.GetFocusedRowCellValue("discount").ToString());
            frm.labelControlDiscount.Text = discount.ToString();
            frm.labelControlPureMony.Text = (totalMony - discount).ToString();
            frm.loadRecordMony(id_Student);
            frm.ShowDialog();
        }

        private void repositoryAbsence2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_Absence frm = new FRM_Absence();
            int id_Student = int.Parse(gvMain2.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = id_Student.ToString();
            frm.labelControlStudentName.Text = gvMain2.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain2.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain2.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain2.GetFocusedRowCellValue("type_study").ToString();
            frm.loadAbsence(id_Student);
            frm.ShowDialog();
        }

        private void repositoryDeleteStudent2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("هل انت متاكد من حذف المادة لايمكن استعادة الدرجات بعد الحذف", "حذف مادة", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_Student = int.Parse(gvMain2.GetFocusedRowCellValue("id_Student").ToString());
                if (cmdStudent.DeleteStudent(id_Student))
                {
                    loadStudent();
                    XtraMessageBox.Show("تم الحذف بنجاح", "الحذف");
                }
                else
                {
                    XtraMessageBox.Show("هناك مشكلة راجع المبرمج المسئول", "الحذف");
                }
            }
        }

        private void repositoryScores2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_Score frm = new FRM_Score();
            int id = int.Parse(gvMain2.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = gvMain2.GetFocusedRowCellValue("id_Student").ToString();
            frm.labelControlStudentName.Text = gvMain2.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain2.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain2.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain2.GetFocusedRowCellValue("type_study").ToString();
            frm.loadScoresForOneStudent(id);
            frm.ShowDialog();
        }

        #endregion

        #region Stap 3 Grid View Buttons
        private void repositoryEditStudent3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id_Student = int.Parse(gvMain3.GetFocusedRowCellValue("id_Student").ToString());
            FRM_AddStudent frm = new FRM_AddStudent(id_Student);
            frm.ShowDialog();
            loadStudent();
        }

        private void repositoryMoney3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_MonyRecord frm = new FRM_MonyRecord();
            int id_Student = int.Parse(gvMain3.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = id_Student.ToString();
            frm.labelControlStudentName.Text = gvMain3.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain3.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain3.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain3.GetFocusedRowCellValue("type_study").ToString();
            double totalMony = double.Parse(gvMain3.GetFocusedRowCellValue("total_amount").ToString());
            frm.labelControlTotalMony.Text = totalMony.ToString();
            double discount = double.Parse(gvMain3.GetFocusedRowCellValue("discount").ToString());
            frm.labelControlDiscount.Text = discount.ToString();
            frm.labelControlPureMony.Text = (totalMony - discount).ToString();
            frm.loadRecordMony(id_Student);
            frm.ShowDialog();
        }

        private void repositoryAbsence_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_Absence frm = new FRM_Absence();
            int id_Student = int.Parse(gvMain3.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = id_Student.ToString();
            frm.labelControlStudentName.Text = gvMain3.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain3.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain3.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain3.GetFocusedRowCellValue("type_study").ToString();
            frm.loadAbsence(id_Student);
            frm.ShowDialog();
        }

        private void repositoryDeleteStudent3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("هل انت متاكد من حذف المادة لايمكن استعادة الدرجات بعد الحذف", "حذف مادة", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_Student = int.Parse(gvMain3.GetFocusedRowCellValue("id_Student").ToString());
                if (cmdStudent.DeleteStudent(id_Student))
                {
                    loadStudent();
                    XtraMessageBox.Show("تم الحذف بنجاح", "الحذف");
                }
                else
                {
                    XtraMessageBox.Show("هناك مشكلة راجع المبرمج المسئول", "الحذف");
                }
            }
        }

        private void repositoryScores3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_Score frm = new FRM_Score();
            int id = int.Parse(gvMain3.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = gvMain3.GetFocusedRowCellValue("id_Student").ToString();
            frm.labelControlStudentName.Text = gvMain3.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain3.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain3.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain3.GetFocusedRowCellValue("type_study").ToString();
            frm.loadScoresForOneStudent(id);
            frm.ShowDialog();
        }
        #endregion

        #region Stap 4 Grid View Buttons
        private void repositoryEditStudent4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id_Student = int.Parse(gvMain4.GetFocusedRowCellValue("id_Student").ToString());
            FRM_AddStudent frm = new FRM_AddStudent(id_Student);
            frm.ShowDialog();
            loadStudent();
        }

        private void repositoryMoney4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_MonyRecord frm = new FRM_MonyRecord();
            int id_Student = int.Parse(gvMain4.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = id_Student.ToString();
            frm.labelControlStudentName.Text = gvMain4.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain4.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain4.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain4.GetFocusedRowCellValue("type_study").ToString();
            double totalMony = double.Parse(gvMain4.GetFocusedRowCellValue("total_amount").ToString());
            frm.labelControlTotalMony.Text = totalMony.ToString();
            double discount = double.Parse(gvMain4.GetFocusedRowCellValue("discount").ToString());
            frm.labelControlDiscount.Text = discount.ToString();
            frm.labelControlPureMony.Text = (totalMony - discount).ToString();
            frm.loadRecordMony(id_Student);
            frm.ShowDialog();
        }

        private void repositoryAbsence4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_Absence frm = new FRM_Absence();
            int id_Student = int.Parse(gvMain4.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = id_Student.ToString();
            frm.labelControlStudentName.Text = gvMain4.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain4.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain4.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain4.GetFocusedRowCellValue("type_study").ToString();
            frm.loadAbsence(id_Student);
            frm.ShowDialog();
        }

        private void repositoryDeleteStudent4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("هل انت متاكد من حذف المادة لايمكن استعادة الدرجات بعد الحذف", "حذف مادة", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_Student = int.Parse(gvMain4.GetFocusedRowCellValue("id_Student").ToString());
                if (cmdStudent.DeleteStudent(id_Student))
                {
                    loadStudent();
                    XtraMessageBox.Show("تم الحذف بنجاح", "الحذف");
                }
                else
                {
                    XtraMessageBox.Show("هناك مشكلة راجع المبرمج المسئول", "الحذف");
                }
            }
        }

        private void repositoryScores4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FRM_Score frm = new FRM_Score();
            int id = int.Parse(gvMain4.GetFocusedRowCellValue("id_Student").ToString());
            frm.labelControlIdStudent.Text = gvMain4.GetFocusedRowCellValue("id_Student").ToString();
            frm.labelControlStudentName.Text = gvMain4.GetFocusedRowCellValue("name").ToString();
            frm.labelControlDepartment.Text = gvMain4.GetFocusedRowCellValue("department").ToString();
            frm.labelControlStep.Text = gvMain4.GetFocusedRowCellValue("step").ToString();
            frm.labelControlTypeOfStudy.Text = gvMain4.GetFocusedRowCellValue("type_study").ToString();
            frm.loadScoresForOneStudent(id);
            frm.ShowDialog();
        }
        #endregion
    }
}