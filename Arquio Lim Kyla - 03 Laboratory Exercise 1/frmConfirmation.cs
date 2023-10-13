using System.Text.RegularExpressions;

namespace Arquio__Lim_Kyla___03_Laboratory_Exercise_1
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            studentNoLbl.Text = studentInformationClass.SetStudentNo.ToString(); 
            nameLbl.Text = studentInformationClass.SetFullName;
            programLbl.Text = studentInformationClass.SetProgram; 
            bdayLbl.Text = studentInformationClass.SetBirthday; 
            genderLbl.Text = studentInformationClass.SetGender; 
            contactNoLbl.Text = studentInformationClass.SetContactNo.ToString(); 
            ageLbl.Text = studentInformationClass.SetAge.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
