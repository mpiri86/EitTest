using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//change on github
namespace CentralInsuranceCargoPolicyTest
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CargoTestForm());
        }
    }
}
// change 1
//fromEitclient
//fromEitclientwithoutanyauthorize
