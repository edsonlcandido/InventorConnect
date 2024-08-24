using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;

namespace InventorConnect.Core
{
    public class InventorApp
    {
        Inventor.Application _InventorApp;
        Inventor.Document _InventorDoc;
        public InventorApp(Inventor.Application InvApplication)
        {
            _InventorApp = InvApplication;            
        }

        public class InventorPart
        {

            Inventor.Application _InventorApp;
            Inventor.PartDocument _InventorPartDoc;
            Inventor.Document _InventorDocument;
            public InventorPart(Inventor.Application InvApplication, Inventor.PartDocument InvPartDocument)
            {
                _InventorApp = InvApplication;
                _InventorPartDoc = InvPartDocument;
                _InventorDocument = InvPartDocument as Inventor.Document;
            }

            public Inventor.Parameters GetParameters()
            {
                return _InventorPartDoc.ComponentDefinition.Parameters;
            }

        }

    }
}
