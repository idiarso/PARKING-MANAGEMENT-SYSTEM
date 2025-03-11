-- Create discounts table
CREATE TABLE IF NOT EXISTS discounts (
    discount_id INT PRIMARY KEY AUTO_INCREMENT,
    discount_name VARCHAR(50) NOT NULL UNIQUE,
    discount_percentage DECIMAL(5,2) NOT NULL,
    description TEXT,
    is_active BOOLEAN DEFAULT TRUE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Insert default discount types
INSERT INTO discounts (discount_name, discount_percentage, description) VALUES
('Member', 10.00, 'Regular member discount'),
('VIP', 20.00, 'VIP member discount'),
('Special', 15.00, 'Special event discount')
ON DUPLICATE KEY UPDATE
discount_percentage = VALUES(discount_percentage),
description = VALUES(description);

-- Modify transactions table to include payment and discount information
ALTER TABLE transactions
ADD COLUMN IF NOT EXISTS discount_amount DECIMAL(10,2) DEFAULT 0.00,
ADD COLUMN IF NOT EXISTS final_amount DECIMAL(10,2),
ADD COLUMN IF NOT EXISTS payment_reference VARCHAR(100),
ADD COLUMN IF NOT EXISTS payment_status ENUM('pending', 'completed', 'failed') DEFAULT 'completed',
ADD COLUMN IF NOT EXISTS discount_id INT,
ADD FOREIGN KEY (discount_id) REFERENCES discounts(discount_id);

-- Add photo verification columns to transactions table
ALTER TABLE transactions 
ADD COLUMN photo_verified BIT DEFAULT 0,
    photo_verified_by VARCHAR(50),
    photo_verified_at DATETIME,
    photo_verification_notes TEXT;

-- Add exit photo column to parkir_masuk if not exists
IF NOT EXISTS (
    SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
    WHERE TABLE_NAME = 'parkir_masuk' 
    AND COLUMN_NAME = 'exit_photo'
)
BEGIN
    ALTER TABLE parkir_masuk
    ADD exit_photo VARCHAR(255);
END

-- Create index on photo verification status
CREATE INDEX idx_photo_verification 
ON transactions(photo_verified, photo_verified_at);

-- Create payment_methods table for future extensibility
CREATE TABLE IF NOT EXISTS payment_methods (
    method_id INT PRIMARY KEY AUTO_INCREMENT,
    method_name VARCHAR(50) NOT NULL UNIQUE,
    requires_reference BOOLEAN DEFAULT FALSE,
    is_active BOOLEAN DEFAULT TRUE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Insert default payment methods
INSERT INTO payment_methods (method_name, requires_reference) VALUES
('Cash', FALSE),
('Credit Card', TRUE),
('Debit Card', TRUE),
('E-Wallet', TRUE)
ON DUPLICATE KEY UPDATE
requires_reference = VALUES(requires_reference); 