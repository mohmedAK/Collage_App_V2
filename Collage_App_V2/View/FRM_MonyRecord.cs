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
    public partial class FRM_MonyRecord : DevExpress.XtraEditors.XtraForm
    {
        CMD_Mony cmd_Mony = new CMD_Mony();
        public FRM_MonyRecord()
        {
            InitializeComponent();
            
        }

     public void loadRecordMony(int id_Student)
        {
            //int id_Student =int.Parse( labelControlIdStudent.Text);
          List<CLS_Mony> monies =   cmd_Mony.GetMonyRecordForStudent(id_Student);
            gcMony.DataSource = monies;
            CountTotalMoney();
        }

        private void simpleButtonAddRecordMony_Click(object sender, EventArgs e)
        {
            FRM_AddMonyRecord frm = new FRM_AddMonyRecord(int.Parse(labelControlIdStudent.Text), "Add");
            frm.ShowDialog();
            loadRecordMony(int.Parse(labelControlIdStudent.Text));
        }

        private void repositoryEditRecordMony_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = int.Parse(gvMony.GetFocusedRowCellValue("id_Mony").ToString());
            FRM_AddMonyRecord frm = new FRM_AddMonyRecord(id, "Edit");
             
            frm.ShowDialog();
            loadRecordMony(int.Parse(labelControlIdStudent.Text));
        }

        void CountTotalMoney()
        {
            List<CLS_Mony> monies = cmd_Mony.GetMoneyRecords().Where(c => c.id_Student == int.Parse(labelControlIdStudent.Text)).ToList(); ;
            double total=0;

            monies.ForEach(c =>
            {
                total += c.batch;
            });
            labelControlMainMoney.Text = total.ToString();
            labelControlRemaining.Text = Math.Abs(total - double.Parse(labelControlPureMony.Text)).ToString();
        }
    }
}