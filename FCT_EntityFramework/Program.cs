using GestionDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCT_EntityFramework
{
    static class Program
    {
        public static Gestion gestion;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            gestion = new Gestion(out string msg);
            if (!msg.Equals(""))
            {
                MessageBox.Show(msg);
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
