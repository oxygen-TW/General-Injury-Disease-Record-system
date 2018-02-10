using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 傷病紀錄系統
{
    public partial class Main : Form
    {
        // Set a variable to the My Documents path.
        string FilePath = @"PatientData";

        public Main()
        {
            InitializeComponent();

            try
            {
                LoadData();
            }
            catch(IOException)
            {
                //Do Not Thing
            }

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

            //檢查是否有特殊需求
            string _PatientSpecialNeed = "";
            if (PatientSpecialNeed.Text == "")
                _PatientSpecialNeed = "-";
            else
                _PatientSpecialNeed = PatientSpecialNeed.Text;

            return Patient_Name.Text+","+Age.Text + "," + Sex.Text + "," + PatientSpecialNeed.Text + "," + Patient_Symptom.Text + "," + Treatment.Text;
        }

        private void B_Submit_Click(object sender, EventArgs e)
        {
            // Create a string array with the lines of text
            string Output_Text = ReadInputData();

            if (Output_Text == "")
                return;

            Console.Write(System.IO.File.Exists(FilePath));
            if(System.IO.File.Exists(FilePath))
            {
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(FilePath, true))
                    outputFile.WriteLine(Output_Text);
            }
            else
            {
                // Write the string array to a new file named "WriteLines.txt".
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(FilePath))
                    outputFile.WriteLine(Output_Text);
            }

            MessageBox.Show("已新增紀錄","成功", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            ClearAllTextBox();

            try
            {
                LoadData();
            }
            catch (IOException)
            {
                //Do Not Thing
            }
        }

        private List<string[]> ReadDataFile()
        {
            StreamReader FileStream = new StreamReader(FilePath);
            string RawData = "";
            List<string[]> Data = new List<string[]>();

            while ((RawData = FileStream.ReadLine()) != null)
            {
                string[] arr = RawData.Split(',');
                Data.Add(arr);
            }

            return Data;
        }
        private void LoadData()
        {
            DataGridViewRowCollection rows = dataGridView1.Rows;

            List<string[]> DataList = ReadDataFile();

            //取出所有值
            foreach (string[] DataString in DataList)
            {
                rows.Add(new Object[] { DataString[0], DataString[1], DataString[2], DataString[4], DataString[5], DataString[3] });
            }
            
        }
    }
}
