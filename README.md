# PARKING MANAGEMENT SYSTEM

A comprehensive parking management solution with advanced features for vehicle entry/exit management, photo verification, and transaction tracking.

## Features

1. **Gate Entry/Exit System**
   - Camera integration for vehicle photos
   - Barcode/ticket scanning
   - Automatic fee calculation
   - Photo verification system
   - Gate barrier control

2. **Transaction Management**
   - Real-time transaction logging
   - Advanced filtering and search
   - Batch operations support
   - Export capabilities
   - Photo verification tracking

3. **Security Features**
   - Entry/exit photo comparison
   - Lost ticket handling
   - Operator activity logging
   - Access control management

4. **Reporting System**
   - Daily transaction summaries
   - Revenue reports
   - Operator performance tracking
   - Custom date range reports

## System Requirements

- Windows 7 or later
- .NET Framework 4.8
- MySQL Server 5.7 or later
- Webcam for photo capture
- Printer for receipts
- Minimum 4GB RAM
- 500MB free disk space

## Installation

1. **Prerequisites**
   ```bash
   # Run the installation script
   install.bat
   ```

2. **Database Setup**
   - MySQL Server must be installed
   - Run the database scripts in the Database folder
   - Default credentials in App.config

3. **Hardware Setup**
   - Connect and configure webcam
   - Set up receipt printer
   - Configure gate barrier (if applicable)

## Usage

1. **Starting the Application**
   - Run parkir.exe
   - Login with provided credentials
   - Select operation mode (Entry/Exit)

2. **Vehicle Entry**
   - Capture entry photo
   - Generate ticket
   - Record vehicle details

3. **Vehicle Exit**
   - Scan ticket
   - Verify entry/exit photos
   - Process payment
   - Open gate

## Configuration

- Edit App.config for database settings
- Modify settings table for system parameters
- Adjust camera and printer settings in UI

## Development

- Built with Visual Studio 2022
- Uses .NET Framework 4.8
- MySQL for database
- AForge.NET for camera integration
- ZXing.NET for barcode processing

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct and the process for submitting pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

For support and queries, please create an issue in the repository.
