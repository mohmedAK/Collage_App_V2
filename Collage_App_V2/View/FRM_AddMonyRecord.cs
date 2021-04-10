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
    public partial class FRM_AddMonyRecord : DevExpress.XtraEditors.XtraForm
    {
        CMD_Mony cmd_Mony = new CMD_Mony();
        int _id_Student;
        int _id_Money;
        string state;
         
        public FRM_AddMonyRecord(int id ,string state)
        {
            InitializeComponent();
            this.state = state;
            if (state == "Add")
            {
                _id_Student = id;
                groupControl1.Text = "أضافة دفعة";
                simpleButtonAddMoneyRecord.Text = "أضافة";
            }
            else if (state =="Edit")
            {
                _id_Money = id;
                groupControl1.Text = "تعديل دفعة";
                simpleButtonAddMoneyRecord.Text = "تعديل";
                GetMoneyRecordById();
            }
            
           
            

        }
        private void simpleButtonAddMoneyRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEditMony.Text) || string.IsNullOrWhiteSpace(textEditAge.Text))
            {
                XtraMessageBox.Show("يرجى ملئ جميع الحقول");
                return;
            }
            if (state == "Add")
            {
                AddMoneyRecord();
                this.Close();
            }
            else if (state =="Edit")
            {
                EditMoneyRecord();
                this.Close();
            }
                
            
        }
        void AddMoneyRecord()
        {
            
                if (cmd_Mony.InsertMoneyRecord(_id_Student, int.Parse(textEditMony.Text), textEditAge.DateTime))
                {
                    XtraMessageBox.Show("تمت الاضافة بنجاح", "أضافة دفعة");
                }
                else
                {
                    XtraMessageBox.Show("حصل خطا", "أضافة دفعة");
                }
            
            
        }

        void EditMoneyRecord()
        {
            if (cmd_Mony.EditMoneyRecord(_id_Money, double.Parse(textEditMony.Text), textEditAge.DateTime))
            {
                XtraMessageBox.Show("تم التعديل بنجاح", "تعديل دفعة");
            }
            else
            {
                XtraMessageBox.Show("حصل خطا", "تعديل دفعة");
            }
            
        }

        void GetMoneyRecordById()
        {
            List<CLS_Mony> monies = cmd_Mony.GetMoneyRecords().Where(c=> c.id_Mony == _id_Money).ToList();

            monies.ForEach(c =>
            {
                textEditMony.Text = c.batch.ToString();
                textEditAge.Text = c.dateRecord.ToString();
            });
        }


    }
}