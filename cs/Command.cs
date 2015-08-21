#region Namespaces
using System;
using System.Collections.Generic;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
#endregion

namespace $safeprojectname$
{
  [Transaction(TransactionMode.Manual)]
  public class Command : IExternalCommand
  {
    public Result Execute(
      ExternalCommandData commandData, 
      ref string message,
      ElementSet elements)
    {
      UIApplication uiapp = commandData.Application;
      UIDocument uidoc = uiapp.ActiveUIDocument;
      Application app = uiapp.Application;
      Document doc = uidoc.Document;

      return Result.Succeeded;
    }
  }
}
