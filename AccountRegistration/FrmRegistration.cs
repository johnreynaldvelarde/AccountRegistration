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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = txtFirstName.Text.ToString();
            StudentInfoClass.LastName = txtLastName.Text.ToString();
            StudentInfoClass.MiddleName = txtMiddleName.Text.ToString();
            StudentInfoClass.Address = txtAddress.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(txtAge.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text.ToString());
            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNo.Text.ToString());
        }
    }
}
