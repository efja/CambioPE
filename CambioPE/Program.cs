using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioPE
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool aberta = false;

            using (Mutex mtex = new Mutex(true, "CambioPE", out aberta))
            {
                if (aberta)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new F_principal());
                    mtex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("Xa se está a executar o aplicativo, só se pode exutar unha única instacia do mesmo");
                }
            }
        }
    }
}
