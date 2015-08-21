@echo off
set "D=C:\Users\%USERNAME%\Documents\Visual Studio 2012\Templates\ProjectTemplates"
set "F=%TEMP%\Revit2016AddinWizardCs2.zip"
echo Creating C# wizard archive %F%...
cd cs
zip -r "%F%" *
cd ..
echo Copying C# wizard archive to %D%\Visual C#...
copy "%F%" "%D%\Visual C#"
set "F=%TEMP%\Revit2016AddinWizardVb2.zip"
echo Creating VB wizard archive %F%...
cd vb
zip -r "%F%" *
cd ..
echo Copying VB wizard archive to %D%\Visual Basic...
copy "%F%" "%D%\Visual Basic"
