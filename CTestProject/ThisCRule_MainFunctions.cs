using Autodesk.iLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILogicRuleTester;

namespace CTestProject
{
    public partial class ThisCRule
    {
        private ICadDoc ThisDoc;
        private Inventor.Application ThisApplication;

        public ThisCRule()
        {
            this.ThisDoc = ILogicHelpers.ThisDoc;
            this.ThisApplication = ILogicHelpers.ThisApplication;
        }

    }
}
