using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{

    public delegate long DelegateNumber(long number);
    public delegate string DelegateName(string name);

    class StudentInfoClass
    {
        string FirstName = "";
        string LastName = "";
        string MiddleName = "";
        string Address = "";
        string Program = "";

    }
}
