# Parking Management System

## Gate Exit System

The Gate Exit System is a comprehensive solution for managing vehicle exits in a parking facility. It provides features for ticket scanning, fee calculation, receipt printing, and gate barrier control.

### Features

1. **Barcode Scanning**
   - Scan ticket barcodes using a camera
   - Auto-scan option for hands-free operation
   - Manual ticket number entry

2. **Lost Ticket Handling**
   - Special process for lost tickets
   - Search by plate number
   - Configurable lost ticket fee

3. **Fee Calculation**
   - Automatic calculation based on duration
   - Different rates for different vehicle types
   - Progressive hourly rates

4. **Receipt Printing**
   - Detailed receipts with all transaction information
   - Customizable receipt format
   - Print preview functionality

5. **Gate Barrier Control**
   - Automatic gate opening after payment
   - Serial port communication with gate hardware
   - Configurable gate open time

6. **Reporting**
   - Daily transaction summary
   - Revenue reports
   - Transaction history

### Installation

1. Set up the database:
   - Run the SQL scripts in the `Database` folder
   - Configure the connection string in the application

2. Install required packages:
   - AForge.Video
   - AForge.Video.DirectShow
   - ZXing.Net

3. Configure hardware:
   - Connect a webcam for barcode scanning
   - Set up the gate barrier on the appropriate COM port

### Usage

1. **Normal Exit Process**
   - Scan the ticket barcode
   - Verify vehicle information
   - Process payment
   - Print receipt
   - Gate opens automatically

2. **Lost Ticket Process**
   - Click "Lost Ticket" button
   - Enter vehicle plate number
   - Process payment (includes lost ticket fee)
   - Print receipt
   - Gate opens automatically

3. **Reporting**
   - Click "Daily Report" to view transaction summary
   - Export reports as needed

### Configuration

The system can be configured through the `settings` table in the database:

- `LostTicketFee`: Fee for lost tickets
- `GateOpenTime`: Time to keep the gate open
- `EnableAutoScan`: Enable/disable automatic scanning
- `CompanyName`: Company name for receipts
- `CompanyAddress`: Company address for receipts
- `ReceiptFooter`: Footer text for receipts

### Troubleshooting

1. **Camera Issues**
   - Ensure the webcam is properly connected
   - Check if other applications are using the camera

2. **Gate Barrier Issues**
   - Verify the correct COM port is configured
   - Check physical connections to the gate hardware

3. **Database Issues**
   - Ensure the MySQL server is running
   - Verify connection string parameters

### System Requirements

- Windows 7 or later
- .NET Framework 4.6.1 or later
- MySQL 5.7 or later
- Webcam for barcode scanning
- Receipt printer
- Gate barrier hardware (optional) 