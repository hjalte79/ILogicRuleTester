using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorInterop = Inventor;

namespace ILogicRuleTesterC_Core
{
    public partial class ThisCRule
    {
        public void Main()
        {
            var _application = ThisApplication;
            var path = @"D:\forum\2023\marked.ipt";


            var oPositionMatrix = _application.TransientGeometry.CreateMatrix();
            // Now create the component occurrence by calling the Add method of the ComponentOccurrences collection, referencing the part file previously created manually in Autodesk Inventor.
            var assemblyDocument = (InventorInterop.AssemblyDocument)_application.ActiveDocument;
            var invAssDocDef = assemblyDocument.ComponentDefinition;
            var invAssOcc = invAssDocDef.Occurrences;
            var debug1 = assemblyDocument.DisplayName;
            var debug2 = invAssDocDef.ActivePositionalState;
            var debug3 = invAssOcc.Count;
            var translation = _application.TransientGeometry.CreateVector(2.0, 0.0, -1.0);
            oPositionMatrix.SetTranslation(translation);
            var debug4 = oPositionMatrix.Translation.Length;
            invAssOcc.Add(path, oPositionMatrix);
        }
    }
}
