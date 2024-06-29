using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventor;

namespace ApprenticeTester
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // If you get the following exception:
            // -----------------------------------------------
            // System.Runtime.InteropServices.COMException:
            // 'Retrieving the COM class factory for component with CLSID {C343ED84-A129-11D3-B799-0060B0F159EF}
            // failed due to the following error: 80040154 Class not registered
            // (Exception from HRESULT: 0x80040154 (REGDB_E_CLASSNOTREG)).'
            // -----------------------------------------------
            // Then make sure that you have the "Platform target" to x64 

            var apprentice = new ApprenticeServerComponent();
            
            string fullFileName = GetFileName();

            ApprenticeServerDocument doc = apprentice.Open(fullFileName);

            PropertySet propertySet = doc.PropertySets["Design Tracking Properties"];

            Console.WriteLine($"Part Number: {propertySet["Part Number"].Value}");

            Console.WriteLine("");
            Console.WriteLine("Press the any key to continue...");
            Console.ReadKey();
        }
        
        public static string GetFileName()
        {
            string filename = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "ipt files (*.ipt)|*.ipt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filename = openFileDialog.FileName;
                }
            }
            return filename;
        }
    }
}
