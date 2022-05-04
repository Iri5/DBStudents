using System;
using System.Windows.Forms;

namespace SQLiteEF
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            label_About.Text = "Irina Bovchurova group 403 \n\nDatabase 'Students' \n\nYou can see the contents of the database in the SELECT tab \n" +
                "You can add data in the INSERT tab \nYou can change the data by finding the necessary record by id in the UPDATE tab \n" +
                "You can delete the data in the DELETE tab \nSettings - Show About: setting up the pop-up window display";
        }

        bool hideFormHello = false;
        private void About_Load(object sender, EventArgs e)
        {
            if (hideFormHello)
                Close();
        }
    }
}
