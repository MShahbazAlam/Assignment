using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();
            IUserInterface userInterface = new UserInterface(appEngine);

            userInterface.showFirstScreen();

            appEngine.CloseConnection();
        }
    }
}
