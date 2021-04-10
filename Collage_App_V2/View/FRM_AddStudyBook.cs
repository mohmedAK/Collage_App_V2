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
    public partial class FRM_Add_EditStudyBook : DevExpress.XtraEditors.XtraForm
    {
        int _id_Student;
        int id_Score;
      
        string state;
        CMD_Scores cmdAddScoreAndBook = new CMD_Scores();
        public FRM_Add_EditStudyBook(int id ,string state)
        {
            InitializeComponent();
            if (state == "Add")
            {
                this._id_Student = id;
                this.state = "Add";
                textEditStudyBook.Enabled = true;
                groupControl1.Text = "اضافة مادة";
            }
            else if(state == "Edit")
            {
                this.id_Score = id;
                this.state = "Edit";

                textEditStudyBook.Enabled = false;
                simpleButtonAddStudyBook.Text = "تحديث";
                groupControl1.Text = "تحديث الدرجات";

                DisplaySubjectScore(id_Score);
            }
            

        }

        public FRM_Add_EditStudyBook(int id_Score )
        {
            InitializeComponent();
            
        }


        void DisplaySubjectScore(int id_Score)
        {
            List<CLS_Score> scores = cmdAddScoreAndBook.GetAllSubjectScores().Where(c => c.id_Score == id_Score).ToList();
            scores.ForEach(c => {
                textEditStudyBook.Text = c.subject_name;
                textEditF1.Text = c.term1.ToString();
                textEditF2.Text = c.term2.ToString();
                textEditF3.Text = c.final.ToString();
            }
            ); 
          
        }

        void InsertBook()
        {
            if (string.IsNullOrWhiteSpace(textEditStudyBook.Text)){
                XtraMessageBox.Show("يرجى ادخال اسم المادة", "أضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<CLS_Score> scores = cmdAddScoreAndBook.GetAllSubjectScores().ToList();
            if (scores.Exists(c=> c.id_Student == _id_Student && c.subject_name == textEditStudyBook.Text ))
            {
                XtraMessageBox.Show(" اسم المادة موجودة مسبقا", "أضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(textEditF1.Text))
            {
                textEditF1.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(textEditF2.Text) )
            {
                textEditF2.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(textEditF3.Text) )
            {
                textEditF3.Text = "0";
            }
            cmdAddScoreAndBook.InsertScoreAndBook(_id_Student, textEditStudyBook.Text, int.Parse(textEditF1.Text), int.Parse(textEditF2.Text), int.Parse(textEditF3.Text));
            XtraMessageBox.Show("تمت اضافة مادة جديدة", "أضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        void EditScore()
        {
            if (string.IsNullOrWhiteSpace(textEditF1.Text))
            {
                textEditF1.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(textEditF2.Text))
            {
                textEditF2.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(textEditF3.Text))
            {
                textEditF3.Text = "0";
            }
            cmdAddScoreAndBook.EditScoreAndBook(id_Score, int.Parse(textEditF1.Text), int.Parse(textEditF2.Text), int.Parse(textEditF3.Text));
            XtraMessageBox.Show("تمت تحديث الدرجات", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            
        }
        private void simpleButtonAddStudyBook_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                InsertBook();
                HelperClass.ClearValue(tableLayoutPanel1);
            }
            else if (state == "Edit")
            {
                EditScore();
                this.Close();
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}