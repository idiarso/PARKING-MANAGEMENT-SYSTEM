# PARKING MANAGEMENT SYSTEM

## Description
This system manages parking operations and records for a parking facility. It provides a comprehensive solution for tracking vehicles, managing spaces, and handling parking fee calculations with advanced monitoring and management features.

[Previous sections remain unchanged until Features...]

## System Menu Structure

1. Dashboard (Menu Utama)
   - Real-time Statistics
   - Total Parked Vehicles
   - Available Slots
   - Today's Revenue
   - Occupancy Graph
   - Gate Status (Entry/Exit)

2. Entry Gate (Gate Masuk)
   - Vehicle Entry
     * Manual Gate Control
     * License Plate Input
     * Vehicle Type Selection
     * Photo Capture
     * Ticket Printing
     * CCTV Preview
   - Gate Status
     * Gate Indicator (Open/Closed)
     * Printer Status
     * Camera Status

3. Cashier (Kasir)
   - Payment Processing
     * Ticket Scanning
     * Manual Ticket Entry
     * Vehicle Information Display
     * Fee Calculation
     * Payment Processing
     * Receipt Printing
     * Exit Gate Control
   - Active Transactions
     * Today's Transaction List
     * Payment Status
     * Filter & Search

4. Reports (Laporan)
   - Daily Reports
     * Total Vehicles
     * Total Revenue
     * Type Breakdown
     * PDF/Excel Export
   - Financial Reports
     * Period Revenue
     * Trend Graphics
     * Revenue Analysis
     * Data Export
   - Activity Logs
     * Gate Logs
     * Operator Logs
     * System Logs

5. Settings (Pengaturan)
   - User Management
     * Add/Edit Users
     * Role & Access Rights
     * Password Reset
   - System Configuration
     * Printer Settings
     * Camera Settings
     * Gate Settings
     * Parking Rates
     * Operating Hours
   - Database
     * Backup Database
     * Restore Database
     * Clear Old Data

6. Help (Bantuan)
   - Guide
     * User Manual
     * Troubleshooting
     * FAQ
   - Information
     * About Application
     * Support Contact
     * License

7. Monitoring
   - CCTV
     * Entry Gate Live View
     * Exit Gate Live View
     * Image Capture
     * Recording Playback
   - Device Status
     * Printer Status
     * Camera Status
     * Gate Status
     * Server Status

8. Shift & Operator
   - Shift Management
     * Shift Schedule
     * Operator Rotation
     * Attendance
   - Operator Reports
     * Operator Performance
     * Activity Logs
     * Shift Summary

9. Member Management
   - Member Control
     * Member List
     * Member Cards
     * Renewal
     * Member History
   - Special Rates
     * Member Rates
     * Discounts & Promos
     * Vouchers

10. Utilities
    - Tools
      * Printer Test
      * Gate Test
      * Camera Test
      * Scanner Calibration
    - Maintenance
      * Database Cleanup
      * Counter Reset
      * System Update
      * Settings Backup

[Previous technical sections remain unchanged...]

## System Requirements
[Previous content remains unchanged, with addition of:]
- CCTV cameras and DVR system
- Thermal printer for tickets
- Gate barrier system
- Barcode scanner
- HD cameras for license plate capture

## Hardware Integration
- Automatic barrier gates
- Ticket printers
- CCTV cameras
- License plate cameras
- Barcode scanners
- Receipt printers
- Network infrastructure

[Previous sections remain unchanged...]

## Version
Current Version: 2.0.0
Release Date: March 2024
Previous Version: 1.0.0 (December 2017)

Last Updated: March 15, 2024

flowchart TD
    %% Entry Process
    Start([Start]) -->|Vehicle Arrives| GateIn[Entry Gate Computer]
    GateIn --> DetectCar[IP Camera Detects Vehicle]
    DetectCar -->|No| GateIn
    DetectCar -->|Yes| CheckCap{Check Parking Capacity}
    
    CheckCap -->|Full| ShowFull[Display: Parking Full]
    ShowFull --> GateIn
    
    CheckCap -->|Available| Process1[Capture Vehicle Photo]
    Process1 --> Process2[Input License Plate]
    Process2 --> Process3[Generate Unique Barcode]
    Process3 --> Process4[Record Entry Time]
    
    Process4 --> SaveEntry[Save to Database:<br>Plate No, Photo,<br>Entry Time, Barcode]
    SaveEntry --> PrintTicket[Print Ticket:<br>Plate No, Entry Time, Barcode]
    PrintTicket --> OpenGateIn[Open Entry Gate]
    OpenGateIn --> VehicleParked[Vehicle Parked]

    %% Exit Process
    VehicleParked --> ExitPoint{Exit Point Computer}
    ExitPoint --> ScanTicket[Scan Ticket Barcode]
    
    ScanTicket --> ValidateData{Validate Data}
    ValidateData -->|Invalid| ShowError[Display: Invalid Data]
    ShowError --> ExitPoint
    
    ValidateData -->|Valid| ExitProcess1[Capture Exit Photo]
    ExitProcess1 --> ExitProcess2[Verify Vehicle Photos]
    ExitProcess2 --> ExitProcess3[Calculate Duration]
    ExitProcess3 --> ExitProcess4[Calculate Parking Fee]
    
    ExitProcess4 --> Payment[Process Payment]
    Payment --> SaveExit[Save Transaction:<br>Exit Time, Fee, Exit Photo]
    SaveExit --> PrintReceipt[Print Receipt]
    PrintReceipt --> OpenGateOut[Open Exit Gate]
    OpenGateOut --> VehicleExit[Vehicle Exits]

    %% Admin System
    AdminPC{Admin Computer} --> CentralDB[(Central Database)]
    CentralDB -->|Store| SaveEntry
    CentralDB -->|Store| SaveExit
    CentralDB -->|Retrieve| ValidateData
    
    AdminPC --> Dashboard[Monitoring Dashboard]
    Dashboard --> Reports[Generate Reports:<br>Daily/Weekly/Monthly]
    Reports --> PrintReport[Print Reports]

    %% Database Connections
    subgraph Database Operations
        CentralDB
    end

    VehicleExit --> End([End])

    %% Styling
    classDef process fill:#e1f5fe,stroke:#01579b
    classDef decision fill:#fff3e0,stroke:#ff6f00
    classDef database fill:#e8f5e9,stroke:#2e7d32
    
    class Process1,Process2,Process3,Process4,ExitProcess1,ExitProcess2,ExitProcess3,ExitProcess4 process
    class CheckCap,ValidateData decision
    class CentralDB database