#Region "Imported Namespaces"
Imports System
Imports System.Collections.Generic
Imports Autodesk.Revit.ApplicationServices
Imports Autodesk.Revit.Attributes
Imports Autodesk.Revit.DB
Imports Autodesk.Revit.UI
Imports Autodesk.Revit.UI.Selection
#End Region

<Transaction(TransactionMode.Manual)>
Public Class AdskCommand
  Implements IExternalCommand

  ''' <summary>
  ''' The one and only method required by the IExternalCommand interface, the main entry point for every external command.
  ''' </summary>
  ''' <param name="commandData">Input argument providing access to the Revit application, its documents and their properties.</param>
  ''' <param name="message">Return argument to display a message to the user in case of error if Result is not Succeeded.</param>
  ''' <param name="elements">Return argument to highlight elements on the graphics screen if Result is not Succeeded.</param>
  ''' <returns>Cancelled, Failed or Succeeded Result code.</returns>
  Public Function Execute(
    ByVal commandData As ExternalCommandData,
    ByRef message As String,
    ByVal elements As ElementSet) _
  As Result Implements IExternalCommand.Execute

    Dim uiapp As UIApplication = commandData.Application
    Dim uidoc As UIDocument = uiapp.ActiveUIDocument
    Dim app As Application = uiapp.Application
    Dim doc As Document = uidoc.Document

    Dim sel As Selection = uidoc.Selection

    'TODO: Add your code here

    Using tx As New Transaction(doc)
      tx.Start("$projectname$")
      tx.Commit()
    End Using

    'Must return some code
    Return Result.Succeeded
  End Function
End Class
