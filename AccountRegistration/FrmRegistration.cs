using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            listprogram();
        }

        public void listprogram()
        {
            ArrayList program = new ArrayList();
            program.Add("BS in Computer Science");
            program.Add("BS in Information Systems");
            program.Add("BS in Information Technology ");
            program.Add("BS in Computer Engineering");
            program.Add("BS in Bussines Administration");
            program.Add("BS in Accoutancy");
            program.Add("BS in Management Accounting");

            for (int i = 0; i< program.Count; i++) {
                cbProgram.Items.Add(program[i]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStudentNo.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtMiddleName.Text) || 
                String.IsNullOrEmpty(txtAge.Text) || String.IsNullOrEmpty(txtContactNo.Text) || String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please fill in the blank");
            }
            else if (cbProgram.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a program");
            }
            else
            {
                StudentInfoClass.FirstName = txtFirstName.Text.ToString();
                StudentInfoClass.LastName = txtLastName.Text.ToString();
                StudentInfoClass.MiddleName = txtMiddleName.Text.ToString();
                StudentInfoClass.Address = txtAddress.Text.ToString();
                StudentInfoClass.Program = cbProgram.Text.ToString();
                StudentInfoClass.Age = Convert.ToInt64(txtAge.Text.ToString());
                StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text.ToString());
                StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNo.Text.ToString());

                FrmConfrim frm = new FrmConfrim();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtMiddleName.Text = "";
                    txtAddress.Text = "";
                    cbProgram.SelectedIndex = -1;
                    txtAge.Text = "";
                    txtContactNo.Text = "";
                    txtStudentNo.Text = "";
                }
            }
        }
    }
}
