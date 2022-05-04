using System;
using System.Linq;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
namespace SQLiteEF
{
    public partial class Form1 : Form
    {
        StudentContext context = new StudentContext();
        public Form1()
        {
            InitializeComponent();
        }
        private bool KeyPressDigit(ref KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9'))|| (e.KeyChar == 8))
            {
                return true;
            }
            else return false;
            
        }
        private bool KeyPressLetter(ref KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'A') && (e.KeyChar <= 'Z'))|| ((e.KeyChar >= 'a') && (e.KeyChar <= 'z')) || (e.KeyChar == 8))
            {
                return true;
            }
            else return false;
        }
        private void textBox_insertFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressLetter(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_insertGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressDigit(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_insertCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressDigit(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_insertAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressDigit(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true; 
        }
        private void textBox_insertLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressLetter(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_updateFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressLetter(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_updateGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressDigit(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_updateCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressDigit(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_updateAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressDigit(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_updateLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressLetter(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_deleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressDigit(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void textBox_updateId_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = KeyPressDigit(ref e);
            if (right == true)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private bool RightAge(int age)
        {
            if (age > 100) 
            {
                DialogResult result = MessageBox.Show("We didn't know that vampires were studying here, it's time to stock up on garlic and holy water! Continue?", "Attention! Vampire!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) return true;
                else return false;
            }
            if (age < 15)
            {
                DialogResult result = MessageBox.Show("Are you sure? I want to shake the hand of a young prodigy! Continue?", "Attention! Prodigy!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) return true;
                else return false;
            }
            return true;
        }
        private bool RightCours(int course)
        {
            if (course > 6)
            {
                MessageBox.Show("Fortunately, we are not at a medical university, the maximum course is 6", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (course == 0)
            {
                MessageBox.Show("The minimum course is 1", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            return true;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label14.Text = "Enter the id of the student \nwhose data you want to edit";
            label20.Text = "Enter the id of the student \nwhose data you want to delete";
            var data = context.Students.ToList();
            table.DataSource = data;
            ShowHello(sender, e);
        }
        private void ShowHello(object sender, EventArgs e)
        {
            if (bool.Parse(ConfigurationManager.AppSettings["showHello"]))
            {
                About about = new About();
                about.ShowDialog();
            }
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGreetingForm();
        }
       
        private void showAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            bool show = !bool.Parse(ConfigurationManager.AppSettings["showHello"]);
            config.AppSettings.Settings["showHello"].Value = (show).ToString();
            config.Save();
            showAboutToolStripMenuItem.Checked = show;
            ConfigurationManager.RefreshSection("appSettings");
        }
        
        private void ShowGreetingForm()
        {
            new SQLiteEF.About().ShowDialog();
        }
        private void button_Insert_Click(object sender, EventArgs e)
        {
            if ((textBox_insertAge.Text == "") || (textBox_insertCourse.Text == "") || (textBox_insertFname.Text == "") ||
                (textBox_insertGroup.Text == "") || (textBox_insertLName.Text == ""))
            {
                MessageBox.Show("All fields must be filled in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int age = int.Parse(textBox_insertAge.Text);
                bool rightAge = RightAge(age);
                int course = int.Parse(textBox_insertCourse.Text);
                bool rightCourse = RightCours(course);
                if ((rightCourse == false) || (rightAge == false)) 
                { 
                    return; 
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = textBox_insertFname.Text,
                        LastName = textBox_insertLName.Text,
                        Age = age,
                        Course = course,
                        Group = int.Parse(textBox_insertGroup.Text)
                    };
                    context.Students.Add(student);
                    context.SaveChanges();
                    MessageBox.Show("The entry was successfully added", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_insertFname.Text = "";
                    textBox_insertLName.Text = "";
                    textBox_insertAge.Text = "";
                    textBox_insertCourse.Text = "";
                    textBox_insertGroup.Text = "";
                    var data = context.Students.ToList();
                    table.DataSource = data;
                }
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            if (textBox_updateId.Text == "") 
            {
                MessageBox.Show("Enter the id!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(textBox_updateId.Text);
                var item = context.Students.Find(id);
                if (item == null)
                {
                    MessageBox.Show("Record not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox_updateFName.Text = item.FirstName;
                    textBox_updateLName.Text = item.LastName;
                    textBox_updateAge.Text = Convert.ToString(item.Age);
                    textBox_updateCourse.Text = Convert.ToString(item.Course);
                    textBox_updateGroup.Text = Convert.ToString(item.Group);
                }
            }
                
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if ((textBox_updateAge.Text == "") || (textBox_updateCourse.Text == "") || (textBox_updateFName.Text == "") ||
                (textBox_updateGroup.Text == "") || (textBox_updateLName.Text == "") || (textBox_updateId.Text == ""))
            {
                MessageBox.Show("All fields must be filled in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int age = int.Parse(textBox_updateAge.Text);
                bool rightAge = RightAge(age);
                int course = int.Parse(textBox_updateCourse.Text);
                bool rightCourse = RightCours(course);
                if ((rightCourse == false) || (rightAge == false))
                {
                    return;
                }
                else
                {
                    int id = int.Parse(textBox_updateId.Text);
                    var item = context.Students.Find(id);
                    if (item == null)
                    {
                        MessageBox.Show("Record not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        item.FirstName = textBox_updateFName.Text;
                        item.LastName = textBox_updateLName.Text;
                        item.Age = age;
                        item.Course = course;
                        item.Group = int.Parse(textBox_updateGroup.Text);
                        context.SaveChanges();
                        MessageBox.Show("The entry was successfully modified", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_updateFName.Text = "";
                        textBox_updateLName.Text = "";
                        textBox_updateAge.Text = "";
                        textBox_updateCourse.Text = "";
                        textBox_updateGroup.Text = "";
                        textBox_updateId.Text = "";
                        var data = context.Students.ToList();
                        table.DataSource = data;
                    }
                }
            }
        }

        private void button_FindDelete_Click(object sender, EventArgs e)
        {
            if (textBox_deleteId.Text == "")
            {
                label_FName.Text = "";
                label_LName.Text = "";
                label_Age.Text = "";
                label_Course.Text = "";
                label_Group.Text = "";
                textBox_deleteFName.Text = "";
                textBox_deleteLName.Text = "";
                textBox_deleteAge.Text = "";
                textBox_deleteCourse.Text = "";
                textBox_deleteGroup.Text = "";
                MessageBox.Show("Enter the id!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(textBox_deleteId.Text);
                var item = context.Students.Find(id);
                if (item == null)
                {
                    MessageBox.Show("Record not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label_FName.Text = "";
                    label_LName.Text = "";
                    label_Age.Text = "";
                    label_Course.Text = "";
                    label_Group.Text = "";
                    textBox_deleteFName.Text = "";
                    textBox_deleteLName.Text = "";
                    textBox_deleteAge.Text = "";
                    textBox_deleteCourse.Text = "";
                    textBox_deleteGroup.Text = "";
                }
                else
                {
                    label_FName.Text = "First Name:";
                    label_LName.Text = "Last Name:";
                    label_Age.Text = "Age:";
                    label_Course.Text = "Course:";
                    label_Group.Text = "Group:";
                    textBox_deleteFName.Text = item.FirstName;
                    textBox_deleteLName.Text = item.LastName;
                    textBox_deleteAge.Text = Convert.ToString(item.Age);
                    textBox_deleteCourse.Text = Convert.ToString(item.Course);
                    textBox_deleteGroup.Text = Convert.ToString(item.Group);
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_deleteId.Text == "")
            {
                MessageBox.Show("Enter the id!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(textBox_deleteId.Text);
                var item = context.Students.Find(id);
                if (item == null)
                {
                    MessageBox.Show("Record not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    context.Students.Remove(item);
                    context.SaveChanges();
                    MessageBox.Show("The entry was successfully deleted", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_FName.Text = "";
                    label_LName.Text = "";
                    label_Age.Text = "";
                    label_Course.Text = "";
                    label_Group.Text = "";
                    textBox_deleteFName.Text = "";
                    textBox_deleteLName.Text = "";
                    textBox_deleteAge.Text = "";
                    textBox_deleteCourse.Text = "";
                    textBox_deleteGroup.Text = "";
                    textBox_deleteId.Text = "";
                    var data = context.Students.ToList();
                    table.DataSource = data;
                }
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = context.Students.ToList();
            FileData fileData = new FileData();
            fileData.SaveResults(data);
        }

        
    }
}
