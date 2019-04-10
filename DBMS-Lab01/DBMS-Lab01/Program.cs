using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Lab01
{
    static class Program
    {
        /// <summary>
        /**
         * Create a C# Windows Forms application that uses ADO.NET to interact with the database you developed in the 1st semester. 
         * The application must contain a form allowing the user to manipulate data in 2 tables that are in a 1:n relationship (parent table and child table). 
         * The application must provide the following functionalities:
            display all the records in the parent table;
            when selecting a record in the parent table:
                display all the corresponding records in the child table;
                add new child records in the child table;
                remove / update child records in the child table.

        You must use the DataSet and SqlDataAdapter classes. 
        You are free to use any controls on the form. 
         */
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
