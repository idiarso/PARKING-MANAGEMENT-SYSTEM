# Ensure running as administrator
if (-NOT ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator")) {
    Write-Warning "Please run this script as Administrator!"
    Break
}

Write-Host "Starting setup for Parking Management System..." -ForegroundColor Green

# Create packages directory if it doesn't exist
$packagesDir = ".\packages"
if (-not (Test-Path $packagesDir)) {
    New-Item -ItemType Directory -Path $packagesDir
}

# Function to download file
function Download-File {
    param (
        [string]$Url,
        [string]$OutputPath
    )
    try {
        $webClient = New-Object System.Net.WebClient
        $webClient.DownloadFile($Url, $OutputPath)
        return $true
    }
    catch {
        Write-Host "Failed to download: $Url" -ForegroundColor Red
        Write-Host $_.Exception.Message
        return $false
    }
}

# Download NuGet packages
$packages = @{
    "AForge" = "https://www.nuget.org/api/v2/package/AForge/2.2.5"
    "AForge.Video" = "https://www.nuget.org/api/v2/package/AForge.Video/2.2.5"
    "AForge.Video.DirectShow" = "https://www.nuget.org/api/v2/package/AForge.Video.DirectShow/2.2.5"
    "ZXing.Net" = "https://www.nuget.org/api/v2/package/ZXing.Net/0.16.8"
    "MySql.Data" = "https://www.nuget.org/api/v2/package/MySql.Data/8.0.33"
    "Microsoft.Office.Interop.Excel" = "https://www.nuget.org/api/v2/package/Microsoft.Office.Interop.Excel/15.0.4795.1001"
}

Write-Host "Downloading NuGet packages..." -ForegroundColor Yellow
foreach ($package in $packages.GetEnumerator()) {
    $packageDir = Join-Path $packagesDir $package.Key
    $packageZip = "$packageDir.zip"
    
    Write-Host "Downloading $($package.Key)..."
    if (Download-File -Url $package.Value -OutputPath $packageZip) {
        # Extract package
        if (-not (Test-Path $packageDir)) {
            New-Item -ItemType Directory -Path $packageDir
        }
        Expand-Archive -Path $packageZip -DestinationPath $packageDir -Force
        Remove-Item $packageZip
    }
}

# Check MySQL
$mysqlService = Get-Service -Name "MySQL*" -ErrorAction SilentlyContinue
if ($null -eq $mysqlService) {
    Write-Host "MySQL is not installed. Please install MySQL Server." -ForegroundColor Red
    Write-Host "You can download it from: https://dev.mysql.com/downloads/installer/" -ForegroundColor Yellow
}
else {
    Write-Host "MySQL is installed." -ForegroundColor Green
    if ($mysqlService.Status -ne "Running") {
        Write-Host "Starting MySQL service..."
        Start-Service $mysqlService.Name
    }
}

# Create database and import schema
$mysqlCmd = "mysql"
$dbScript = ".\Database\transactions_table.sql"
if (Test-Path $dbScript) {
    Write-Host "Importing database schema..."
    try {
        $mysqlProcess = Start-Process -FilePath $mysqlCmd -ArgumentList "-u root -p < `"$dbScript`"" -NoNewWindow -Wait -PassThru
        if ($mysqlProcess.ExitCode -eq 0) {
            Write-Host "Database schema imported successfully." -ForegroundColor Green
        }
        else {
            Write-Host "Failed to import database schema." -ForegroundColor Red
        }
    }
    catch {
        Write-Host "Error running MySQL command. Please run the script manually:" -ForegroundColor Red
        Write-Host "mysql -u root -p < `"$dbScript`"" -ForegroundColor Yellow
    }
}

# Check .NET Framework
$netVersion = Get-ItemProperty "HKLM:\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" -ErrorAction SilentlyContinue
if ($null -eq $netVersion -or $netVersion.Version -lt "4.8") {
    Write-Host ".NET Framework 4.8 is not installed. Please install it." -ForegroundColor Red
    Write-Host "Download from: https://dotnet.microsoft.com/download/dotnet-framework/net48" -ForegroundColor Yellow
}
else {
    Write-Host ".NET Framework 4.8 is installed." -ForegroundColor Green
}

Write-Host "`nSetup completed!" -ForegroundColor Green
Write-Host "`nNext steps:"
Write-Host "1. Ensure MySQL Server is installed and running"
Write-Host "2. Make sure .NET Framework 4.8 is installed"
Write-Host "3. Build the project using Visual Studio or MSBuild"
Write-Host "4. Run the application from bin/Debug/parkir.exe" 