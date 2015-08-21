#Region "Imported Namespaces"
Imports Autodesk.Revit.ApplicationServices
Imports Autodesk.Revit.Attributes
Imports Autodesk.Revit.DB
Imports Autodesk.Revit.UI
#End Region

Class AdskApplication
  Implements IExternalApplication
  ''' <summary>
  ''' This method is called when Revit starts up before a 
  ''' document or default template is actually loaded.
  ''' </summary>
  ''' <param name="app">An object passed to the external 
  ''' application which contains the controlled application.</param>
  ''' <returns>Return the status of the external application. 
  ''' A result of Succeeded means that the external application started successfully. 
  ''' Cancelled can be used to signify a problem. If so, Revit informs the user that 
  ''' the external application failed to load and releases the internal reference.
  ''' </returns>
  Public Function OnStartup(
    ByVal app As UIControlledApplication) _
  As Result Implements IExternalApplication.OnStartup

    'TODO: Add your code here

    'Must return some code
    Return Result.Succeeded
  End Function

  ''' <summary>
  ''' This method is called when Revit is about to exit.
  ''' All documents are closed before this method is called.
  ''' </summary>
  ''' <param name="app">An object passed to the external 
  ''' application which contains the controlled application.</param>
  ''' <returns>Return the status of the external application. 
  ''' A result of Succeeded means that the external application successfully shutdown. 
  ''' Cancelled can be used to signify that the user cancelled the external operation 
  ''' at some point. If false is returned then the Revit user should be warned of the 
  ''' failure of the external application to shut down correctly.</returns>
  Public Function OnShutdown(
    ByVal app As UIControlledApplication) _
  As Result Implements IExternalApplication.OnShutdown

    'TODO: Add your code here

    'Must return some code
    Return Result.Succeeded
  End Function
End Class
