using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final___Wingo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        //C:\Users\matia\OneDrive\Escritorio\d\bin\Debug
        static string[] partsPath = AppDomain.CurrentDomain.BaseDirectory.Split(System.IO.Path.DirectorySeparatorChar);
        static List<string> projectPath = new List<string>(partsPath);
        static public string pathConfig;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pathConfig = "";
            foreach (string folder in projectPath)
            {
                if (folder != "bin" && folder != "Debug")
                {
                    if (!string.IsNullOrEmpty(pathConfig))
                    {
                        pathConfig += System.IO.Path.DirectorySeparatorChar;
                    }

                    pathConfig += folder;
                }
            }
            pathConfig += "config.txt";
            Application.Run(new Pantalla_principal());
        }
    }
}
