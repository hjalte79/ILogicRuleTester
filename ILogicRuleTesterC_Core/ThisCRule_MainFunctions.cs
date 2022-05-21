using Autodesk.iLogic.Interfaces;
using Autodesk.iLogic.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILogicRuleTesterC_Core
{
    public partial class ThisCRule
    {
        private ICadDoc ThisDoc;
        private Inventor.Application ThisApplication;

        public ThisCRule()
        {
            this.ThisApplication = (Inventor.Application)Marshal2.GetActiveObject("Inventor.Application");
            this.ThisDoc = new CadDoc(ThisApplication.ActiveDocument);
        }

    }
}
