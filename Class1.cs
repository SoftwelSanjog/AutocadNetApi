using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime; 
using System;

namespace AutocadNetApi
{
    public static class MyAutocad
    {
        [CommandMethod("tm")]
        public static void TestMessage()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            ed.WriteMessage("Hello, AutoCAD!");
        }
    }
}

