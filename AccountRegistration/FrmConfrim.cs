using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfrim : Form
    {
        
        private event DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private event DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void FrmConfrim_Load(object sender, EventArgs e)
        {
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblLastName.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
        }

        // 15. form closed event
        private void FrmConfrim_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

       

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public FrmConfrim()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

        }

        public void ShowOutput()
        {
            

            /*
            long Age = Convert.ToInt64(lblAge);
            Age = DelNumAge(StudentInfoClass.Age);

            long numcont = Convert.ToInt64(lblContact);
            numcont = DelNumAge(StudentInfoClass.ContactNo);

            long studno = Convert.ToInt64(lblAge);
            studno = DelNumAge(StudentInfoClass.StudentNo);
            */
        }

    }
}
