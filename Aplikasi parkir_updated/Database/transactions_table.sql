-- Create transactions table to store parking exit transactions
CREATE TABLE IF NOT EXISTS `transactions` (
  `transaction_id` int(11) NOT NULL AUTO_INCREMENT,
  `parking_id` int(11) NOT NULL,
  `exit_time` datetime NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `payment_method` varchar(50) NOT NULL DEFAULT 'Cash',
  `operator_name` varchar(100) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`transaction_id`),
  KEY `parking_id` (`parking_id`),
  CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`parking_id`) REFERENCES `parkir_masuk` (`no_masuk`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Create settings table for application configuration
CREATE TABLE IF NOT EXISTS `settings` (
  `setting_id` int(11) NOT NULL AUTO_INCREMENT,
  `setting_name` varchar(100) NOT NULL,
  `setting_value` varchar(255) NOT NULL,
  `description` text,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`setting_id`),
  UNIQUE KEY `setting_name` (`setting_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insert default settings
INSERT INTO `settings` (`setting_name`, `setting_value`, `description`) VALUES
('LostTicketFee', '50000', 'Default fee for lost tickets in IDR'),
('GateOpenTime', '5', 'Time in seconds to keep the gate open'),
('EnableAutoScan', 'true', 'Enable automatic barcode scanning'),
('CompanyName', 'Parking Management System', 'Company name for receipts'),
('CompanyAddress', 'Jl. Raya No. 123, Jakarta', 'Company address for receipts'),
('ReceiptFooter', 'Terima kasih telah menggunakan layanan kami', 'Footer text for receipts');

-- Add lost_ticket column to parkir_masuk table if it doesn't exist
ALTER TABLE `parkir_masuk` 
ADD COLUMN IF NOT EXISTS `is_lost_ticket` tinyint(1) NOT NULL DEFAULT 0 COMMENT 'Flag for lost tickets';

-- Add exit_photo column to parkir_masuk table if it doesn't exist
ALTER TABLE `parkir_masuk` 
ADD COLUMN IF NOT EXISTS `exit_photo` varchar(255) DEFAULT NULL COMMENT 'Path to exit photo';

-- Add operator_id column to parkir_masuk table if it doesn't exist
ALTER TABLE `parkir_masuk` 
ADD COLUMN IF NOT EXISTS `operator_id` int(11) DEFAULT NULL COMMENT 'ID of the operator who processed the exit'; 