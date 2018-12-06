using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace Lesson8_Database
{
    static class Program
    {
        public static string basePath = Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData ) + "\\base.xml";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(Init()) Application.Run(new MainWindow());
        }

        static bool Init()
        {
            try
            {
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream( "Lesson8_Database.Resources.base.XML" ))
                using (StreamReader reader = new StreamReader( stream ))
                {
                    File.WriteAllText( basePath , reader.ReadToEnd() );
                }
            }
            catch (Exception e)
            {
                MessageBox.Show( $"Что-то пошло не так: {e.Message}" );
                return false;
            }

            return true;
        }
    }
}
