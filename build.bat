@echo off
echo Building Parking Management System...

:: Check for Visual Studio installation
set "VSWHERE=%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe"
if not exist "%VSWHERE%" (
    echo Visual Studio is not installed.
    echo Please download and install Visual Studio 2019/2022 Community Edition from:
    echo https://visualstudio.microsoft.com/downloads/
    pause
    exit /b 1
)

:: Find MSBuild path
for /f "usebackq tokens=*" %%i in (`"%VSWHERE%" -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe`) do (
    set "MSBUILD=%%i"
)

if not defined MSBUILD (
    echo MSBuild not found. Please install Visual Studio with .NET desktop development workload.
    pause
    exit /b 1
)

:: Restore NuGet packages
echo Downloading and installing dependencies...
powershell -ExecutionPolicy Bypass -File setup.ps1

:: Build solution
echo Building solution...
"%MSBUILD%" parkir.csproj /p:Configuration=Debug /p:Platform="Any CPU"

if %ERRORLEVEL% NEQ 0 (
    echo Build failed!
    pause
    exit /b 1
)

:: Check if build was successful
if not exist "bin\Debug\parkir.exe" (
    echo Build output not found!
    pause
    exit /b 1
)

echo Build completed successfully!

:: Ask to run the application
set /p RUNAPP="Do you want to run the application now? (Y/N): "
if /i "%RUNAPP%"=="Y" (
    start "" "bin\Debug\parkir.exe"
)

pause 