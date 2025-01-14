using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

namespace AutocadNetApi
{
    public static class MyAutocad
    {
        [CommandMethod("xox")]
        public static void TestMessage()
        {
            //frmMain objMain = new frmMain();
            //objMain.ShowDialog();
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            ed.WriteMessage("Hello, AutoCAD!");
        }
    }
}

