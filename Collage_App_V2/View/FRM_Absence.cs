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
    public partial class FRM_Absence : DevExpress.XtraEditors.XtraForm
    {
        CMD_Absence cmd_absence = new CMD_Absence();
        public FRM_Absence()
        {
            InitializeComponent();
        }

       public void loadAbsence( int id_Student)
        {
            List<CLS_Absence> absences = cmd_absence.GetAllAbsences().Where(c => c.id_Student == id_Student).ToList();
            gcAbsence.DataSource = absences;
            labelControlTotalAbsence.Text = absences.Count.ToString();
        }

        private void simpleButtonAddAbsence_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAge.Text)){
                XtraMessageBox.Show("يرجى ملئ جميع الحقول");
            }
            else
            {
                InsertAbsence();
                loadAbsence(int.Parse(labelControlIdStudent.Text));
            }
        }

        void InsertAbsence()
        {
            int id_Student = int.Parse(labelControlIdStudent.Text);
            int totalAbsence =int.Parse( labelControlTotalAbsence.Text);
            if (cmd_absence.InsertAbsenceForStudent(id_Student, totalAbsence, txtAge.DateTime))
            {
                XtraMessageBox.Show("تمت الاضافة بنجاح");
            }
        }

        private void repositoryDeleteAbsence_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("هل انت متاكد من حذف تاريخ الغياب", "حذف غياب", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_Student = int.Parse(gvAbsence.GetFocusedRowCellValue("id_Student").ToString());
                if (cmd_absence.DeleteAbsenceDate(id_Student))
                {
                    loadAbsence(int.Parse(labelControlIdStudent.Text));
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