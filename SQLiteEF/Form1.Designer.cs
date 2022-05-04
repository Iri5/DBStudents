namespace SQLiteEF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.table = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Insert = new System.Windows.Forms.Button();
            this.textBox_insertGroup = new System.Windows.Forms.TextBox();
            this.textBox_insertCourse = new System.Windows.Forms.TextBox();
            this.textBox_insertAge = new System.Windows.Forms.TextBox();
            this.textBox_insertLName = new System.Windows.Forms.TextBox();
            this.textBox_insertFname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_Find = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_updateId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_updateGroup = new System.Windows.Forms.TextBox();
            this.textBox_updateCourse = new System.Windows.Forms.TextBox();
            this.textBox_updateAge = new System.Windows.Forms.TextBox();
            this.textBox_updateLName = new System.Windows.Forms.TextBox();
            this.textBox_updateFName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_FindDelete = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_deleteGroup = new System.Windows.Forms.TextBox();
            this.textBox_deleteCourse = new System.Windows.Forms.TextBox();
            this.textBox_deleteAge = new System.Windows.Forms.TextBox();
            this.textBox_deleteLName = new System.Windows.Forms.TextBox();
            this.textBox_deleteFName = new System.Windows.Forms.TextBox();
            this.label_Group = new System.Windows.Forms.Label();
            this.label_FName = new System.Windows.Forms.Label();
            this.label_Course = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_LName = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_deleteId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.showAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to file";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 286);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.table);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SELECT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(34, 28);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(598, 203);
            this.table.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Insert);
            this.tabPage2.Controls.Add(this.textBox_insertGroup);
            this.tabPage2.Controls.Add(this.textBox_insertCourse);
            this.tabPage2.Controls.Add(this.textBox_insertAge);
            this.tabPage2.Controls.Add(this.textBox_insertLName);
            this.tabPage2.Controls.Add(this.textBox_insertFname);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INSERT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(395, 98);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(152, 23);
            this.button_Insert.TabIndex = 10;
            this.button_Insert.Text = "INSERT";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // textBox_insertGroup
            // 
            this.textBox_insertGroup.Location = new System.Drawing.Point(82, 182);
            this.textBox_insertGroup.Name = "textBox_insertGroup";
            this.textBox_insertGroup.Size = new System.Drawing.Size(100, 20);
            this.textBox_insertGroup.TabIndex = 9;
            this.textBox_insertGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_insertGroup_KeyPress);
            // 
            // textBox_insertCourse
            // 
            this.textBox_insertCourse.Location = new System.Drawing.Point(82, 145);
            this.textBox_insertCourse.Name = "textBox_insertCourse";
            this.textBox_insertCourse.Size = new System.Drawing.Size(100, 20);
            this.textBox_insertCourse.TabIndex = 8;
            this.textBox_insertCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_insertCourse_KeyPress);
            // 
            // textBox_insertAge
            // 
            this.textBox_insertAge.Location = new System.Drawing.Point(82, 105);
            this.textBox_insertAge.Name = "textBox_insertAge";
            this.textBox_insertAge.Size = new System.Drawing.Size(100, 20);
            this.textBox_insertAge.TabIndex = 7;
            this.textBox_insertAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_insertAge_KeyPress);
            // 
            // textBox_insertLName
            // 
            this.textBox_insertLName.Location = new System.Drawing.Point(82, 63);
            this.textBox_insertLName.Name = "textBox_insertLName";
            this.textBox_insertLName.Size = new System.Drawing.Size(100, 20);
            this.textBox_insertLName.TabIndex = 6;
            this.textBox_insertLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_insertLName_KeyPress);
            // 
            // textBox_insertFname
            // 
            this.textBox_insertFname.Location = new System.Drawing.Point(82, 24);
            this.textBox_insertFname.Name = "textBox_insertFname";
            this.textBox_insertFname.Size = new System.Drawing.Size(100, 20);
            this.textBox_insertFname.TabIndex = 5;
            this.textBox_insertFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_insertFname_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_Find);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBox_updateId);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button_update);
            this.tabPage3.Controls.Add(this.textBox_updateGroup);
            this.tabPage3.Controls.Add(this.textBox_updateCourse);
            this.tabPage3.Controls.Add(this.textBox_updateAge);
            this.tabPage3.Controls.Add(this.textBox_updateLName);
            this.tabPage3.Controls.Add(this.textBox_updateFName);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(664, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UPDATE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(32, 152);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 23);
            this.button_Find.TabIndex = 25;
            this.button_Find.Text = "TO FIND";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 23;
            // 
            // textBox_updateId
            // 
            this.textBox_updateId.Location = new System.Drawing.Point(32, 105);
            this.textBox_updateId.Name = "textBox_updateId";
            this.textBox_updateId.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateId.TabIndex = 22;
            this.textBox_updateId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_updateId_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Id:";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(383, 109);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(189, 23);
            this.button_update.TabIndex = 20;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_updateGroup
            // 
            this.textBox_updateGroup.Location = new System.Drawing.Point(233, 186);
            this.textBox_updateGroup.Name = "textBox_updateGroup";
            this.textBox_updateGroup.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateGroup.TabIndex = 19;
            this.textBox_updateGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_updateGroup_KeyPress);
            // 
            // textBox_updateCourse
            // 
            this.textBox_updateCourse.Location = new System.Drawing.Point(233, 149);
            this.textBox_updateCourse.Name = "textBox_updateCourse";
            this.textBox_updateCourse.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateCourse.TabIndex = 18;
            this.textBox_updateCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_updateCourse_KeyPress);
            // 
            // textBox_updateAge
            // 
            this.textBox_updateAge.Location = new System.Drawing.Point(233, 109);
            this.textBox_updateAge.Name = "textBox_updateAge";
            this.textBox_updateAge.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateAge.TabIndex = 17;
            this.textBox_updateAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_updateAge_KeyPress);
            // 
            // textBox_updateLName
            // 
            this.textBox_updateLName.Location = new System.Drawing.Point(233, 67);
            this.textBox_updateLName.Name = "textBox_updateLName";
            this.textBox_updateLName.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateLName.TabIndex = 16;
            this.textBox_updateLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_updateLName_KeyPress);
            // 
            // textBox_updateFName
            // 
            this.textBox_updateFName.Location = new System.Drawing.Point(233, 28);
            this.textBox_updateFName.Name = "textBox_updateFName";
            this.textBox_updateFName.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateFName.TabIndex = 15;
            this.textBox_updateFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_updateFName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Course";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Age";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Last Name";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_FindDelete);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.textBox_deleteGroup);
            this.tabPage4.Controls.Add(this.textBox_deleteCourse);
            this.tabPage4.Controls.Add(this.textBox_deleteAge);
            this.tabPage4.Controls.Add(this.textBox_deleteLName);
            this.tabPage4.Controls.Add(this.textBox_deleteFName);
            this.tabPage4.Controls.Add(this.label_Group);
            this.tabPage4.Controls.Add(this.label_FName);
            this.tabPage4.Controls.Add(this.label_Course);
            this.tabPage4.Controls.Add(this.label_Age);
            this.tabPage4.Controls.Add(this.label_LName);
            this.tabPage4.Controls.Add(this.button_delete);
            this.tabPage4.Controls.Add(this.textBox_deleteId);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(664, 260);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DELETE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_FindDelete
            // 
            this.button_FindDelete.Location = new System.Drawing.Point(46, 146);
            this.button_FindDelete.Name = "button_FindDelete";
            this.button_FindDelete.Size = new System.Drawing.Size(75, 23);
            this.button_FindDelete.TabIndex = 37;
            this.button_FindDelete.Text = "TO FIND";
            this.button_FindDelete.UseVisualStyleBackColor = true;
            this.button_FindDelete.Click += new System.EventHandler(this.button_FindDelete_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "label20";
            // 
            // textBox_deleteGroup
            // 
            this.textBox_deleteGroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_deleteGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_deleteGroup.Location = new System.Drawing.Point(230, 190);
            this.textBox_deleteGroup.Name = "textBox_deleteGroup";
            this.textBox_deleteGroup.ReadOnly = true;
            this.textBox_deleteGroup.Size = new System.Drawing.Size(100, 13);
            this.textBox_deleteGroup.TabIndex = 35;
            // 
            // textBox_deleteCourse
            // 
            this.textBox_deleteCourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_deleteCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_deleteCourse.Location = new System.Drawing.Point(230, 153);
            this.textBox_deleteCourse.Name = "textBox_deleteCourse";
            this.textBox_deleteCourse.ReadOnly = true;
            this.textBox_deleteCourse.Size = new System.Drawing.Size(100, 13);
            this.textBox_deleteCourse.TabIndex = 34;
            // 
            // textBox_deleteAge
            // 
            this.textBox_deleteAge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_deleteAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_deleteAge.Location = new System.Drawing.Point(230, 113);
            this.textBox_deleteAge.Name = "textBox_deleteAge";
            this.textBox_deleteAge.ReadOnly = true;
            this.textBox_deleteAge.Size = new System.Drawing.Size(100, 13);
            this.textBox_deleteAge.TabIndex = 33;
            // 
            // textBox_deleteLName
            // 
            this.textBox_deleteLName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_deleteLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_deleteLName.Location = new System.Drawing.Point(230, 71);
            this.textBox_deleteLName.Name = "textBox_deleteLName";
            this.textBox_deleteLName.ReadOnly = true;
            this.textBox_deleteLName.Size = new System.Drawing.Size(100, 13);
            this.textBox_deleteLName.TabIndex = 32;
            // 
            // textBox_deleteFName
            // 
            this.textBox_deleteFName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_deleteFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_deleteFName.Location = new System.Drawing.Point(230, 32);
            this.textBox_deleteFName.Name = "textBox_deleteFName";
            this.textBox_deleteFName.ReadOnly = true;
            this.textBox_deleteFName.Size = new System.Drawing.Size(100, 13);
            this.textBox_deleteFName.TabIndex = 31;
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Location = new System.Drawing.Point(166, 193);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(0, 13);
            this.label_Group.TabIndex = 30;
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.Location = new System.Drawing.Point(167, 32);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(0, 13);
            this.label_FName.TabIndex = 26;
            // 
            // label_Course
            // 
            this.label_Course.AutoSize = true;
            this.label_Course.Location = new System.Drawing.Point(166, 156);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(0, 13);
            this.label_Course.TabIndex = 29;
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(166, 116);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(0, 13);
            this.label_Age.TabIndex = 28;
            // 
            // label_LName
            // 
            this.label_LName.AutoSize = true;
            this.label_LName.Location = new System.Drawing.Point(166, 74);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(0, 13);
            this.label_LName.TabIndex = 27;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(349, 93);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(163, 23);
            this.button_delete.TabIndex = 25;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_deleteId
            // 
            this.textBox_deleteId.Location = new System.Drawing.Point(35, 96);
            this.textBox_deleteId.Name = "textBox_deleteId";
            this.textBox_deleteId.Size = new System.Drawing.Size(100, 20);
            this.textBox_deleteId.TabIndex = 24;
            this.textBox_deleteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_deleteId_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Id";
            // 
            // showAboutToolStripMenuItem
            // 
            this.showAboutToolStripMenuItem.Name = "showAboutToolStripMenuItem";
            this.showAboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAboutToolStripMenuItem.Text = "Show About";
            this.showAboutToolStripMenuItem.Click += new System.EventHandler(this.showAboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 310);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.TextBox textBox_insertGroup;
        private System.Windows.Forms.TextBox textBox_insertCourse;
        private System.Windows.Forms.TextBox textBox_insertAge;
        private System.Windows.Forms.TextBox textBox_insertLName;
        private System.Windows.Forms.TextBox textBox_insertFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_updateId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_updateGroup;
        private System.Windows.Forms.TextBox textBox_updateCourse;
        private System.Windows.Forms.TextBox textBox_updateAge;
        private System.Windows.Forms.TextBox textBox_updateLName;
        private System.Windows.Forms.TextBox textBox_updateFName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_deleteId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_deleteGroup;
        private System.Windows.Forms.TextBox textBox_deleteCourse;
        private System.Windows.Forms.TextBox textBox_deleteAge;
        private System.Windows.Forms.TextBox textBox_deleteLName;
        private System.Windows.Forms.TextBox textBox_deleteFName;
        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.Label label_Course;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_LName;
        private System.Windows.Forms.Button button_FindDelete;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAboutToolStripMenuItem;
    }
}

