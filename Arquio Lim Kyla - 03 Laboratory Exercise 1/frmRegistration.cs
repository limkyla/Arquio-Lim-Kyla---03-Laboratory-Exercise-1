using System.Text.RegularExpressions;


namespace Arquio__Lim_Kyla___03_Laboratory_Exercise_1
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                programCB.Items.Add(ListOfProgram[i].ToString());
            }
        }

        /////return methods 
        public long StudentNumber(string studNum)
        {
            if (Regex.IsMatch(studNum, @"^[0-9]{10,15}$"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new ArgumentNullException("Invalid input! Please enter a valid student number");
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid input! Please enter a valid contact number");
            } 

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new FormatException("Invalid input! Please complete your fullname");
            }
                

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new OverflowException("Invalid input! Please enter the correct age!");
            }

            return _Age;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                studentInformationClass.SetFullName = FullName(lNameTB.Text,
                    fNameTB.Text,
                    mNameTB.Text);
                studentInformationClass.SetProgram = programCB.Text;
                studentInformationClass.SetGender = genderCB.Text;
                studentInformationClass.SetContactNo = ContactNo(contactNoTB.Text);
                studentInformationClass.SetAge = Age(ageTB.Text);
                studentInformationClass.SetStudentNo = StudentNumber(studTB.Text);
                studentInformationClass.SetBirthday = dateTimePicker.Value.ToString("yyyyMM-dd");


                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (IndexOutOfRangeException i)
            {
                MessageBox.Show(i.Message);
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (OverflowException o)
            {
                MessageBox.Show(o.Message);
            }
            finally
            {
                Console.WriteLine("No error found");
            }
        }
    }
}