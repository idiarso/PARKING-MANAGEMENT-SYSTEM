@echo off
echo Starting Parking Management System Installation...
echo.

:: Check for administrator privileges
net session >nul 2>&1
if %errorLevel% neq 0 (
    echo Please run this script as Administrator!
    echo Right-click the script and select "Run as administrator"
    pause
    exit /b 1
)

:: Create installation log
set "LOGFILE=%~dp0install_log.txt"
echo Installation started at: %date% %time% > "%LOGFILE%"

:: Check for .NET Framework 4.8
reg query "HKLM\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" /v Version >nul 2>&1
if %errorLevel% neq 0 (
    echo .NET Framework 4.8 is not installed.
    echo Downloading .NET Framework 4.8...
    powershell -Command "& {Invoke-WebRequest -Uri 'https://go.microsoft.com/fwlink/?LinkId=2085155' -OutFile 'ndp48-web.exe'}"
    echo Installing .NET Framework 4.8...
    start /wait ndp48-web.exe /q /norestart
    del ndp48-web.exe
)

:: Check for Visual Studio Build Tools
if not exist "%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" (
    echo Visual Studio Build Tools are not installed.
    echo Downloading Visual Studio Build Tools...
    powershell -Command "& {Invoke-WebRequest -Uri 'https://aka.ms/vs/17/release/vs_buildtools.exe' -OutFile 'vs_buildtools.exe'}"
    echo Installing Visual Studio Build Tools...
    start /wait vs_buildtools.exe --quiet --wait --norestart --nocache ^
        --installPath "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\BuildTools" ^
        --add Microsoft.VisualStudio.Workload.MSBuildTools ^
        --add Microsoft.VisualStudio.Workload.NetFrameworkBuildTools
    del vs_buildtools.exe
)

:: Check for MySQL
sc query MySQL >nul 2>&1
if %errorLevel% neq 0 (
    echo MySQL is not installed.
    echo Please download and install MySQL Server from:
    echo https://dev.mysql.com/downloads/installer/
    echo.
    echo After installation, press any key to continue...
    pause >nul
)

:: Create database and import schema
echo Setting up database...
echo.
set /p MYSQL_ROOT_PASS=Enter MySQL root password: 
echo.

mysql -u root -p%MYSQL_ROOT_PASS% -e "CREATE DATABASE IF NOT EXISTS db_parkir;" 2>>"%LOGFILE%"
if %errorLevel% neq 0 (
    echo Failed to create database. Please check MySQL installation and password.
    echo See install_log.txt for details.
    pause
    exit /b 1
)

:: Import database schema
if exist "Database\transactions_table.sql" (
    mysql -u root -p%MYSQL_ROOT_PASS% db_parkir < "Database\transactions_table.sql" 2>>"%LOGFILE%"
    if %errorLevel% neq 0 (
        echo Failed to import database schema.
        echo See install_log.txt for details.
        pause
        exit /b 1
    )
)

:: Run setup script to download dependencies
echo Installing dependencies...
powershell -ExecutionPolicy Bypass -File setup.ps1

:: Build the application
echo Building application...
call build.bat

echo.
echo Installation completed!
echo.
echo Next steps:
echo 1. The application executable is located in bin\Debug\parkir.exe
echo 2. Make sure MySQL Server is running
echo 3. Use the following default credentials to log in:
echo    Username: admin
echo    Password: admin
echo.
echo For troubleshooting, check install_log.txt
echo.

set /p RUNAPP="Do you want to run the application now? (Y/N): "
if /i "%RUNAPP%"=="Y" (
    start "" "bin\Debug\parkir.exe"
)

pause 