using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace StudentsManagement
{
    public partial class Form1 : Form
    {
        List<Student> students; //create list student
        Student temp_Student; // create temp student
        //set up variable to check requirement
        bool inADD = false; // true if in add method
        bool isOkPhone = false;
        bool isOkMail = false;
        bool isNullId = true;
        bool isNullName = true;
        bool isNullClass = true;
        // check mail
        Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // disable all text box in form
            disableTextBox();
            loadAreaCode();
            loadStudentList();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if(addBtn.Text == "ADD")
            {
                // reset all data
                resetDataTextBox();
                // enable all text box
                enableTextBox();
                // focus to Name Box
                nameTextBox.Focus();
                // change event of btn
                addBtn.Text = "Save";
                modifyBtn.Enabled = false;
                deleteBtn.Enabled = false;
                undoBtn.Visible = true;
                inADD = true;
                //change bg
                this.BackColor = Color.FromArgb(204, 255, 221);
            }
            else
                saveData("ADD"); //save data width method add
        } // handle event ADD button click
        private void undoBtn_Click(object sender, EventArgs e)
        {
            // undo actions
            undoChosing();
        }// handle event UNDO button click
        private void undoChosing()
        {
            // modify buttons
            addBtn.Text = "ADD";
            modifyBtn.Text = "MODIFY";
            deleteBtn.Text = "DELETE";
            addBtn.Enabled = true;
            modifyBtn.Enabled = true;
            deleteBtn.Enabled = true;
            undoBtn.Visible = false;
            inADD = false;
            //reset all data
            resetDataTextBox();
            //disable text box
            disableTextBox();
            //change bg
            this.BackColor = Color.Azure;
        } // undo actions
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (modifyBtn.Text == "MODIFY")
            {
                // enable all text box
                enableTextBox();
                // change event of btn
                modifyBtn.Text = "Save";
                addBtn.Enabled = false;
                deleteBtn.Enabled = false;
                undoBtn.Visible = true;
                idTextBox.Enabled = false; //not allow change id of student
                //change bg
                this.BackColor = Color.FromArgb(255, 255, 204);
            }
            else
                saveData("MODIFY"); //save data width method modify
        }// handle event MODIFY button click
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 179, 179);
            if (isReadyData()) // check that if data fill all textbox
            {
                // ask user to delete
                if (MessageBox.Show("Are you really want to remove " + temp_Student.Name + " ?", "Remove student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    removeData();
                    loadDataFromList();
                }
            }
            else
                MessageBox.Show("Please seclect student row to delete!"); //notify if err
            undoChosing();
        }// handle event DELETE button click
        private void removeData()
        {
            // check array to delete data
            for(int i = 0; i < students.Count; i++)
            {
                if(students[i].Id == temp_Student.Id) // if id selection compare id element in array
                {
                    students.Remove(students[i]); // detele element in array
                    break;
                }
            }
            saveStudentList();
        }
        private void enableTextBox()
        {
            // enable to fill data
            nameTextBox.Enabled = true;
            idTextBox.Enabled = true;
            classTextBox.Enabled = true;
            phoneTextBox.Enabled = true;
            mailTextBox.Enabled = true;
            maleRadio.Enabled = true;
            femaleRadio.Enabled = true;
            otherRadio.Enabled = true;
            codeBox.Enabled = true;
            birthDate.Enabled = true;
        }// enable all text box
        private void resetDataTextBox()
        {
            //reset all textbox in new activities
            nameTextBox.Text = "";
            idTextBox.Text = "";
            classTextBox.Text = "";
            phoneTextBox.Text = "";
            mailTextBox.Text = "";
            mailErrLabel.Visible = false;
            maleRadio.Checked = true;
            codeBox.SelectedIndex = 0;
            // set min max of age
            birthDate.MaxDate = new System.DateTime(DateTime.Now.Year - 17, 12, 31, 0, 0, 0, 0);
            birthDate.MinDate = new System.DateTime(DateTime.Now.Year - 35, 1, 1, 0, 0, 0, 0);
            birthDate.Value = birthDate.MaxDate;
        }
        private void disableTextBox()
        {
            // disable all activities
            nameTextBox.Enabled = false;
            idTextBox.Enabled = false;
            classTextBox.Enabled = false;
            phoneTextBox.Enabled = false;
            mailTextBox.Enabled = false;
            maleRadio.Enabled = false;
            femaleRadio.Enabled = false;
            otherRadio.Enabled = false;
            codeBox.Enabled = false;
            birthDate.Enabled = false;
        } // disable Text Box
        private void loadAreaCode() 
        {
            StreamReader reader = new StreamReader(Application.StartupPath + "\\..\\..\\Resources\\AreaCode.txt");
            string areaCode = reader.ReadLine();// read each line to add to combobox
            while (areaCode != null)
            {
                codeBox.Items.Add(areaCode.ToString());
                areaCode = reader.ReadLine();
            }
        }// load data of file to combobox
        private void loadStudentList()
        {
            students = new List<Student>(); // create list student
            // read and add data to each intance of student
            StreamReader reader = new StreamReader(Application.StartupPath + "\\..\\..\\Resources\\StudentList.txt");
            string infoStudent = reader.ReadLine();

            while (infoStudent != null)
            {
                string[] infos = infoStudent.ToString().Split('~');
                Student student = new Student(infos[0], infos[1], infos[2], infos[3], infos[4], infos[5], infos[6], infos[7]);
                students.Add(student);
                infoStudent = reader.ReadLine();
                sinhvienDataGrid.Rows.Add(student.Name, student.Id, student.Class, student.Birth, student.Gender, student.Phone, student.Code, student.Mail);
            }
            reader.Close();
        } // load data of students 
        private void refeshDataGrid(string method)
        {
            // reload datagridview
            DataGridViewRowCollection listStudent = sinhvienDataGrid.Rows;
            Student student = new Student(getStudentProperty());
            if(method == "MODIFY") // reload datagridview if method modify
                for (int i=0;i<listStudent.Count; i++)
                {
                    if(listStudent[i].Cells[1].Value.ToString() == temp_Student.Id)
                    {
                        sinhvienDataGrid.Rows[i].Cells[0].Value = student.Name;
                        sinhvienDataGrid.Rows[i].Cells[1].Value = student.Id;
                        sinhvienDataGrid.Rows[i].Cells[2].Value = student.Class;
                        sinhvienDataGrid.Rows[i].Cells[3].Value = student.Birth;
                        sinhvienDataGrid.Rows[i].Cells[4].Value = student.Gender;
                        sinhvienDataGrid.Rows[i].Cells[5].Value = student.Phone;
                        sinhvienDataGrid.Rows[i].Cells[6].Value = student.Code;
                        sinhvienDataGrid.Rows[i].Cells[7].Value = student.Mail;
                        break;
                    }
                }
            else if(method == "ADD")
            {
                // reload datagridview if method add
                sinhvienDataGrid.Rows.Add(student.Name, student.Id, student.Class, student.Birth, student.Gender, student.Phone, student.Code, student.Mail);
            }
            //sinhvienDataGrid.Rows.Clear();
            sinhvienDataGrid.Refresh();
            //loadStudentList();
        } // reload data
        private void loadDataFromList()
        {
            sinhvienDataGrid.Rows.Clear(); //clear datagridview for new data
            foreach(Student student in students)
            {
                sinhvienDataGrid.Rows.Add(student.Name, student.Id, student.Class, student.Birth, student.Gender, student.Phone, student.Code, student.Mail);
            }
            sinhvienDataGrid.Refresh(); //refresh datagridview
        } // fill datagridview with list student
        private void saveStudentList()
        {
            // save each student to file
            StreamWriter writer = new StreamWriter(Application.StartupPath + "\\..\\..\\Resources\\StudentList.txt", false, Encoding.UTF8);
            foreach(Student student in students)
            {
                string line = student.Name + "~" + student.Id + "~" + student.Class + "~" + student.Birth + "~" + student.Gender + "~" + student.Code + "~" + student.Phone + "~" + student.Mail;
                writer.WriteLine(line);
            }
            writer.Close();
        } //save list student to file
        private void sinhvienDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!inADD) // if not in add method
            {
                try
                {
                    //try to save property to file
                    DataGridViewCellCollection infos = sinhvienDataGrid.CurrentRow.Cells;
                    nameTextBox.Text = infos[0].Value.ToString();
                    idTextBox.Text = infos[1].Value.ToString();
                    classTextBox.Text = infos[2].Value.ToString();
                    birthDate.Value = Convert.ToDateTime(infos[3].Value.ToString());
                    loadGender(infos[4].Value.ToString());
                    phoneTextBox.Text = infos[5].Value.ToString();
                    codeBox.Text = infos[6].Value.ToString();
                    mailTextBox.Text = infos[7].Value.ToString();

                }
                catch(Exception) //catch err
                {
                    MessageBox.Show("Cant not select this row!!");
                }
                //get property of student has been selected
                temp_Student = new Student(getStudentProperty());
            }

        } //handle event when row header clicked
        private string getGender()
        {
            if (maleRadio.Checked)
                return "Male";
            else if (femaleRadio.Checked)
                return "Female";
            return "Other";
        } //get string gender of student form radio box
        private string getStudentProperty()
        {
            return nameTextBox.Text + "~" + idTextBox.Text + "~" + classTextBox.Text + "~" + birthDate.Value.ToShortDateString() + "~" + getGender() + "~" + codeBox.Text + "~" + phoneTextBox.Text + "~" + mailTextBox.Text;
        } // get students informations from text box
        private void loadGender(string gender)
        {
            if (gender == "Male")
                maleRadio.Checked = true;
            else if (gender == "Female")
                femaleRadio.Checked = true;
            else otherRadio.Checked = true;
        } //load gender of student to radio box
        private void saveData(string method)
        {
            if (isReadyData())
            {
                if (method == "ADD")
                {
                    // save data
                    saveData_methodADD();
                    // refesh data grid view
                    refeshDataGrid("ADD");
                    //clear text box
                    resetDataTextBox();
                }
                else if (method == "MODIFY")
                {
                    // save data
                    saveData_methodModify();
                    // refesh data grid view
                    refeshDataGrid("MODIFY");
                }
                undoChosing();
            }
            else
            {
                MessageBox.Show("LOOK BACK!! Your data missing some require");
                if (isNullName)
                {
                    nameErrLabel.Visible = true;
                    nameTextBox.Focus();
                }
                else if (isNullId)
                {
                    idErrLabel.Visible = true;
                    idTextBox.Focus();
                }
                else if (isNullClass)
                {
                    classErrLabel.Visible = true;
                    classTextBox.Focus();
                }
                else if (!isOkPhone)
                {
                    phoneErrLabel1.Visible = true;
                    phoneTextBox.Focus();
                }
                else if (!isOkMail)
                {
                    mailErrLabel.Visible = true;
                    mailTextBox.Focus();
                }

            }
                
        } // save data to file
        private void saveData_methodADD()
        {
            
                Student student = new Student(getStudentProperty());
                students.Add(student);
                saveStudentList();
        } // save data with method add
        private void saveData_methodModify()
        {
            Student student = new Student(getStudentProperty());
            for(int i = 0; i<students.Count; i++)
            {
                if (students[i].Id == temp_Student.Id)
                {
                    students[i] = student;
                    break;
                }
            }
            saveStudentList();
        } //// save data with method modify
        private bool isReadyData()
        {
            if (nameTextBox.Text == "")
            {
                isNullName = true;
                return false;
            }
            else
                isNullName = false;
            if (idTextBox.Text == "")
            {
                isNullId = true;
                return false;
            }
            else
                isNullId = false;
            if (classTextBox.Text == "")
            {
                isNullClass = true;
                return false;
            }
            else
                isNullClass = false;
            if (isOkMail && isOkPhone)
                return true;
            return false;
        } // check that if data is ready to use
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.nameTextBox.Text);
            nameTextBox.Select(nameTextBox.Text.Length, 0);
            nameErrLabel.Visible = false;
        } //handle event when text box name changed

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isAllow = true;
            string digits = phoneTextBox.Text;
            for(int i = 0; i< digits.Length; i++)
            {
                if(digits.Length < 9 || digits[0] == '0')
                {
                    isAllow = false;
                    break;
                }
            }
            if (isAllow)
            {
                phoneErrLabel1.Visible = false;
                isOkPhone = true;
            }
            else
            {
                phoneErrLabel1.Visible = true;
                isOkPhone = false;
            }
            if(digits.Length <= 0)
            {
                phoneErrLabel1.Visible = true;
                isOkPhone = false;
            }
        } //handle event when text box phone changed

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {
            string mail = mailTextBox.Text;
            if (reg.IsMatch(mail))
            {
                mailErrLabel.Visible = false;
                isOkMail = true;
            }
            else
            {
                mailErrLabel.Visible = true;
                isOkMail = false;
            }
        } //handle event when text box mail changed

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            idErrLabel.Visible = false;
        } //handle event when text box id changed

        private void classTextBox_TextChanged(object sender, EventArgs e)
        {
            classErrLabel.Visible = false;
        } //handle event when text box class changed

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        } //handle event when text box name changed -> use for deny alpha click
    }
}
