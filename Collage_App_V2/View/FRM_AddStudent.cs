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
    public partial class FRM_AddStudent : DevExpress.XtraEditors.XtraForm
    {
        
        CMD_Student cmd_Student = new CMD_Student();
        
        public FRM_AddStudent()
        {
            InitializeComponent();
            GetLastIdStudent();
            simpleButtonAddStudent.Text = "اضافة";
            groupControl1.Text = "أضافة معلومات طالب";
            this.Text = "أضافة معلومات طالب";
            comboBoxGender.SelectedIndex = 0;
            comboBoxStep.SelectedIndex = 0;
            comboBoxTypeOfStudy.SelectedIndex = 0;

        }

        public FRM_AddStudent( int id_student)
        {
            InitializeComponent();
              
            simpleButtonAddStudent.Text = "تعديل";
            groupControl1.Text = "تعديل معلومات طالب";
            this.Text = "تعديل معلومات طالب";          
            GetStudentById(id_student);

        }

        void GetLastIdStudent()
        {
            int maxId = cmd_Student.GetLastStudent().id_Student + 1;
            textEditIdStudent.Text = maxId.ToString();
            
        }

        void AddStudent()
        {
            if (string.IsNullOrWhiteSpace(textEditIdStudent.Text) || string.IsNullOrWhiteSpace(textEditStudentName.Text) ||
                 comboBoxGender.Text == "اختيار الجنس" || string.IsNullOrWhiteSpace(textEditDepartment.Text)||
                 comboBoxStep.Text == "اختيار مرحلة" || comboBoxTypeOfStudy.Text == "اختيار نوع الدراسة" ||
                string.IsNullOrWhiteSpace(textEditTotalAmount.Text) || string.IsNullOrWhiteSpace(textEditDiscount.Text))
            {
                XtraMessageBox.Show("يرجى ملئ جميع الحقول", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            cmd_Student.InsertStudent(int.Parse(textEditIdStudent.Text), textEditStudentName.Text, comboBoxGender.Text, txtAge.DateTime,
                textEditDepartment.Text, int.Parse(comboBoxStep.Text), comboBoxTypeOfStudy.Text, double.Parse(textEditTotalAmount.Text),
                double.Parse(textEditDiscount.Text));

            XtraMessageBox.Show("تمت الاضافه بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HelperClass.ClearValue(tableLayoutPanel1);
            comboBoxGender.SelectedIndex = 0;
            comboBoxStep.SelectedIndex = 0;
            comboBoxTypeOfStudy.SelectedIndex = 0;
        }

        void GetStudentById(int id_Student)
        {
           CLS_Student student= cmd_Student.GetStudentById(id_Student);
            textEditIdStudent.Text = student.id_Student.ToString();
            textEditStudentName.Text = student.name;
            comboBoxGender.Text = student.gender;
            txtAge.Text = student.age.ToString();
            textEditDepartment.Text = student.department;
            comboBoxStep.Text = student.step.ToString();
            comboBoxTypeOfStudy.Text = student.type_study;
            textEditTotalAmount.Text = student.total_amount.ToString();
            textEditDiscount.Text = student.discount.ToString();
        }

        void EditStudent()
        {
            if (string.IsNullOrWhiteSpace(textEditIdStudent.Text) || string.IsNullOrWhiteSpace(textEditStudentName.Text) ||
                comboBoxGender.Text == "اختيار الجنس" || string.IsNullOrWhiteSpace(textEditDepartment.Text) ||
                comboBoxStep.Text == "اختيار مرحلة" || comboBoxTypeOfStudy.Text == "اختيار نوع الدراسة" ||
               string.IsNullOrWhiteSpace(textEditTotalAmount.Text) || string.IsNullOrWhiteSpace(textEditDiscount.Text))
            {
                XtraMessageBox.Show("يرجى ملئ جميع الحقول", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            cmd_Student.EditStudent(int.Parse(textEditIdStudent.Text), textEditStudentName.Text, comboBoxGender.Text, txtAge.DateTime,
                textEditDepartment.Text, int.Parse(comboBoxStep.Text), comboBoxTypeOfStudy.Text, double.Parse(textEditTotalAmount.Text),
                double.Parse(textEditDiscount.Text));

            XtraMessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private void simpleButtonAddStudent_Click(object sender, EventArgs e)
        {

            if (simpleButtonAddStudent.Text == "اضافة")
            {
                AddStudent();
                
                GetLastIdStudent();
                
            }
            else if (simpleButtonAddStudent.Text == "تعديل")
            {
                EditStudent();
               
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}