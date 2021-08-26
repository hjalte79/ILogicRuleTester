using Autodesk.iLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.iLogic.Runtime;

namespace CTestProject
{
    public partial class ThisCRule
    {
        private ICadDoc ThisDoc;
        private Inventor.Application ThisApplication;

        public ThisCRule()
        {
            this.ThisApplication = (Inventor.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application");
            this.ThisDoc = new CadDoc(ThisApplication.ActiveDocument);
        }

    }
}
