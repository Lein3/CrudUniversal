using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudLibrary;

namespace CrudLibraryTests
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InnerConnection.db = new TestEntities();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new NoAutoIncCreateForm());
            //Application.Run(new TestUpdateForm(Connection.db.Test.Where(a => a.ID == 1).FirstOrDefault()));
            Application.Run(new TestReadForm());
        }
    }

    static public class Connection
    {
        static public TestEntities db = new TestEntities();
    }
}
