using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Collage_App_V2
{
    class HelperClass
    {
        public static byte[] saveImage(PictureEdit pictuerEdit)
        {
            MemoryStream ms = new MemoryStream();
            pictuerEdit.Image.Save(ms, pictuerEdit.Image.RawFormat);
            byte[] image = ms.ToArray();
            return image;
        }

        public static byte[] RetrieveImage(byte[] arrImage, PictureEdit pictuerEdit)
        {
            byte[] image = arrImage;

            MemoryStream ms = new MemoryStream(image);
            pictuerEdit.Image = Image.FromStream(ms);

            return image;
        }

        public static void ClearValue(TableLayoutPanel tp)
        {
            foreach (Control item in tp.Controls)
            {
                if (item is TextEdit) { item.Text = ""; }
                if (item is ComboBoxEdit) { item.Text = ""; }
                if (item is DateEdit) { item.Text = ""; }
                if (item is MemoEdit) { item.Text = ""; }
            }
        }

        public static void EnableControls(TableLayoutPanel tp)
        {
            foreach (Control item in tp.Controls)
            {
                if (item is TextEdit) { item.Enabled = true; }
                if (item is ComboBoxEdit) { item.Enabled = true; }
                if (item is DateEdit) { item.Enabled = true; }
                if (item is MemoEdit) { item.Enabled = true; }
            }
        }

        public static void StartOperation(Form frm)
        {
            frm.Cursor = Cursors.WaitCursor;
            frm.Enabled = false;
        }

        public static void EndOperation(Form frm)
        {
            frm.Cursor = Cursors.WaitCursor;
            frm.Enabled = true;
        }

        public static string EncryptPassword(string s)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(s));
            byte[] Result = md5.Hash;
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < Result.Length; i++)
            {
                str.Append(Result[i].ToString("x4"));
            }
            return str.ToString();
        }



    }
}
