using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Inventor;
using InventorConnect.Core;

namespace InventorConnect.Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventor.Application InvApp = (Inventor.Application)Marshal.GetActiveObject("Inventor.Application");
            Inventor.PartDocument InvPartDoc = (Inventor.PartDocument)InvApp.ActiveDocument;
            
            InventorConnect.Core.InventorApp.InventorPart InvPart = new InventorConnect.Core.InventorApp.InventorPart(InvApp, InvPartDoc);

            Inventor.Parameters InvParams = InvPart.GetParameters();

            foreach (Inventor.Parameter InvParam in InvParams)
            {
                Console.WriteLine(InvParam.Name + " | " + InvParam.Type + " | " + InvParam.get_Units() + " | " + InvParam.Value);
            }
            Console.ReadLine();
        }
    }
}
