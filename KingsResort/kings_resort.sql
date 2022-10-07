-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.11-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for kings_resort
CREATE DATABASE IF NOT EXISTS `kings_resort` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `kings_resort`;

-- Dumping structure for table kings_resort.customer
CREATE TABLE IF NOT EXISTS `customer` (
  `customer_id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `email` varchar(150) NOT NULL,
  `no` varchar(50) NOT NULL DEFAULT '',
  `street` varchar(100) NOT NULL,
  `city` varchar(50) NOT NULL,
  `country` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table kings_resort.customer: ~4 rows (approximately)
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` (`customer_id`, `first_name`, `last_name`, `sex`, `email`, `no`, `street`, `city`, `country`, `phone`) VALUES
	(8, 'Thahir', 'Mohamed', 'Male', 'fzmhd@gmail.com', '21', 'Raithalawela Ukuwela', 'Matale', 'Sri Lanka', '076212424'),
	(12, 'Fazlan ', 'Mohamed', 'Male', 'fzlanhipster@gmail.com', '21', 'Main Street', 'Gampola', 'Sri Lanka', '12454654656'),
	(13, 'Zain ', 'Ahamed', 'Male', 'zain.ahamed@gmail.com', '21', 'Peta ', 'Colombo', 'Sri Lanka', '0752402323'),
	(14, 'Sara ', 'Murshide', 'Female', 'sramushid@gmail.com', '21', 'Aveunue Street', 'Gampola', 'Sri Lanka', '243553535326');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;

-- Dumping structure for table kings_resort.payment
CREATE TABLE IF NOT EXISTS `payment` (
  `payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `status` varchar(150) NOT NULL DEFAULT 'Pending',
  `amount` double NOT NULL DEFAULT 0,
  `payment_type_id` int(11) NOT NULL,
  `reservation_id` int(11) NOT NULL,
  PRIMARY KEY (`payment_id`,`payment_type_id`,`reservation_id`),
  KEY `FK__payment_type` (`payment_type_id`),
  KEY `FK__reservation` (`reservation_id`),
  CONSTRAINT `FK__payment_type` FOREIGN KEY (`payment_type_id`) REFERENCES `payment_type` (`type_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK__reservation` FOREIGN KEY (`reservation_id`) REFERENCES `reservation` (`reservation_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table kings_resort.payment: ~2 rows (approximately)
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` (`payment_id`, `first_name`, `last_name`, `status`, `amount`, `payment_type_id`, `reservation_id`) VALUES
	(1, 'Thahir', 'Mohamed', 'Paid', 2700, 6, 20),
	(2, 'Thahir', 'Mohamed', 'Paid', 5400, 1, 21),
	(3, 'Fazlan ', 'Mohamed', 'Paid', 4900, 4, 22);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;

-- Dumping structure for table kings_resort.payment_type
CREATE TABLE IF NOT EXISTS `payment_type` (
  `type_id` int(11) NOT NULL AUTO_INCREMENT,
  `payment_type` varchar(50) NOT NULL,
  `discount` double(22,0) NOT NULL,
  PRIMARY KEY (`type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table kings_resort.payment_type: ~3 rows (approximately)
/*!40000 ALTER TABLE `payment_type` DISABLE KEYS */;
INSERT INTO `payment_type` (`type_id`, `payment_type`, `discount`) VALUES
	(1, 'Cash', 0),
	(4, 'Travelers Cheque ', 2),
	(5, 'Credit Card', 3),
	(6, 'Company', 10);
/*!40000 ALTER TABLE `payment_type` ENABLE KEYS */;

-- Dumping structure for table kings_resort.reservation
CREATE TABLE IF NOT EXISTS `reservation` (
  `reservation_id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL DEFAULT curdate(),
  `time` time NOT NULL DEFAULT curtime(),
  `check_in` date NOT NULL,
  `check_out` date NOT NULL,
  `customer_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  PRIMARY KEY (`reservation_id`,`customer_id`,`room_id`),
  KEY `FK_cusomerRes` (`customer_id`),
  KEY `FK__roomRes` (`room_id`),
  CONSTRAINT `FK__roomRes` FOREIGN KEY (`room_id`) REFERENCES `room` (`room_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_cusomerRes` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table kings_resort.reservation: ~5 rows (approximately)
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
INSERT INTO `reservation` (`reservation_id`, `date`, `time`, `check_in`, `check_out`, `customer_id`, `room_id`) VALUES
	(20, '2022-04-26', '11:01:49', '2022-04-27', '2022-04-30', 8, 1),
	(21, '2022-04-26', '11:23:38', '2022-04-27', '2022-04-30', 8, 5),
	(22, '2022-04-26', '10:35:21', '2022-04-27', '2022-05-02', 12, 8),
	(24, '2022-04-27', '03:59:02', '2022-04-28', '2022-04-30', 13, 9),
	(25, '2022-04-27', '06:19:40', '2022-04-28', '2022-04-30', 14, 11);
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;

-- Dumping structure for table kings_resort.room
CREATE TABLE IF NOT EXISTS `room` (
  `room_id` int(11) NOT NULL AUTO_INCREMENT,
  `room_no` varchar(50) NOT NULL,
  `floor` int(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `amount` double NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Free',
  PRIMARY KEY (`room_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table kings_resort.room: ~7 rows (approximately)
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` (`room_id`, `room_no`, `floor`, `type`, `amount`, `status`) VALUES
	(1, 'S1', 1, 'Single', 1000, 'Busy'),
	(5, 'D1', 2, 'Double', 1800, 'Busy'),
	(8, 'S2', 1, 'Single', 1000, 'Busy'),
	(9, 'S3', 1, 'Single', 1000, 'Busy'),
	(11, 'SU1', 2, 'Suite', 5000, 'Busy'),
	(12, 'SU2', 3, 'Suite', 5000, 'Free');
/*!40000 ALTER TABLE `room` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
