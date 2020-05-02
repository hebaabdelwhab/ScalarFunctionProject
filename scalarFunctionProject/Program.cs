using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scalarFunctionProject
{
    
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string[] arr = { "int" };
            function f = new function("sum", 3, arr);
            f.writeFunction();
            string[] s = { "Double"};
            function f1 = new function("minimum", 1, s);
            globals.fnList.Add(f1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
