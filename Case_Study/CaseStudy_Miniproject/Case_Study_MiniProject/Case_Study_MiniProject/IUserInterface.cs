using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_MiniProject
{
    interface IUserInterface
    {
        void showFirstScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentScreen();
        void StudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCourseScreen();

    }
}
