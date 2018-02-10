using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 傷病紀錄系統
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearAllTextBox()
        {
            Patient_Name.Text = "";
            Age.Text = "";
            Sex.Text = "";
            PatientSpecialNeed.Text = "";
            Patient_Symptom.Text = "";
            Treatment.Text = "";
        }

        private string ReadInputData()
        {
            if(Patient_Name.Text == "" || Patient_Symptom.Text == "" || Age.Text == ""  || Sex.Text == "" || Treatment.Text=="")
            {
                MessageBox.Show("紀錄資料不完整", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            return Patient_Name.Text+","+Age.Text + "," + Sex.Text + "," + PatientSpecialNeed.Text + "," + Patient_Symptom.Text + "," + Treatment.Text;
        }

        private void B_Submit_Click(object sender, EventArgs e)
        {
            // Create a string array with the lines of text
            string Output_Text = ReadInputData();

            if (Output_Text == "")
                return;

            // Set a variable to the My Documents path.
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string FileName =
                "PatientData";

            Console.Write(System.IO.File.Exists(mydocpath));
            if(System.IO.File.Exists(mydocpath + @"\" + FileName))
            {
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\" + FileName, true))
                    outputFile.WriteLine(Output_Text);
            }
            else
            {
                // Write the string array to a new file named "WriteLines.txt".
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\" + FileName))
                    outputFile.WriteLine(Output_Text);
            }

            MessageBox.Show("已新增紀錄","成功", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            ClearAllTextBox();
        }

        private void ShowData()
        {

        }
    }
}
