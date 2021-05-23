using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventor;

namespace CTestProject
{
    public partial class ThisCRule
    {
        public void Main()
        {
            var doc = (DrawingDocument)ThisDoc.Document;
            Sheet sheet = doc.ActiveSheet;
            DrawingView view = sheet.DrawingViews[1];


        }


    }
}
