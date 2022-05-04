using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace SQLiteEF
{
    internal class FileData
    {
        public void SaveResults(List<Student> list)
        {
            string id = "";
            string fname = "";
            string lname = "";
            string age = "";
            string course = "";
            string group = "";
            string[] strTable = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                id = (list[i].Id).ToString();
                fname = (list[i].FirstName).ToString();
                lname = (list[i].LastName).ToString();
                age = (list[i].Age).ToString();
                course = (list[i].Course).ToString();
                group = (list[i].Group).ToString();
                strTable[i] = id + " " + fname + " " + lname + " " + age + " " + course + " " + " " + group;
            }
            
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string fileName = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllLines(fileName, strTable);
            MessageBox.Show("Файл сохранен");
        }
    }
}
