@echo off
pushd "%~dp0"
if exist cs (goto okcs) else (echo "No cs folder found." && goto exit)
:okcs
if exist vb (goto okvb) else (echo "No vb folder found." && goto exit)
:okvb

if [%1]==[] (
  echo Please specify Visual Studio version, e.g. 2022
  goto exit
) else (
  echo Using version %1
)

set "D=C:\Users\%USERNAME%\Documents\Visual Studio %1\Templates\ProjectTemplates"

set "F=%TEMP%\Revit2025AddinWizardCs0.zip"
echo Creating C# wizard archive %F%...
cd cs
..\zip\zip.exe -r "%F%" *
cd ..
echo Copying C# wizard archive to %D%\Visual C#...
xcopy "%F%" "%D%\Visual C#\"

set "F=%TEMP%\Revit2025AddinWizardVb0.zip"
echo Creating VB wizard archive %F%...
cd vb
..\zip\zip.exe -r "%F%" *
cd ..
echo Copying VB wizard archive to %D%\Visual Basic...
xcopy "%F%" "%D%\Visual Basic\"

:exit
