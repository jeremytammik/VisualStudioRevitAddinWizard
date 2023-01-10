@echo off
pushd "%~dp0"
if exist cs (goto okcs) else (echo "No cs folder found." && goto exit)
:okcs
if exist vb (goto okvb) else (echo "No vb folder found." && goto exit)
:okvb

if [%1]==[] (
  echo Please specify Visual Studio version, e.g., 2017
  goto exit
) else (
  echo Using version %1
  rem set "D=%userprofile%\Documents\Visual Studio %1\Templates\ProjectTemplates"
  set "D=Y:\Documents\Visual Studio %1\Templates\ProjectTemplates"
)

set "F=%TEMP%\Revit2023AddinWizardCs0.zip"
echo Creating C# wizard archive %F%...
cd cs
..\zip\zip.exe -r "%F%" *
cd ..
echo Copying C# wizard archive to %D%\Visual C#...
xcopy "%F%" "%D%\Visual C#\"
xcopy "%F%" "%D3%\CSharp\"
set "F=%TEMP%\Revit2023AddinWizardVb0.zip"
echo Creating VB wizard archive %F%...
cd vb
..\zip\zip.exe -r "%F%" *
cd ..
echo Copying VB wizard archive to %D%\Visual Basic...
xcopy "%F%" "%D%\Visual Basic\"
:exit
