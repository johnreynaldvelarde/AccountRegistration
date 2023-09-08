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
        
        private event DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress ;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private event DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

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

    }
}
