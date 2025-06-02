CREATE DATABASE  IF NOT EXISTS `book_heaven` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `book_heaven`;
-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: book_heaven
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `book`
--

DROP TABLE IF EXISTS `book`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `book` (
  `book_id` int(11) NOT NULL AUTO_INCREMENT,
  `isbn_number` varchar(45) NOT NULL,
  `book_title` varchar(255) NOT NULL,
  `book_author` varchar(255) NOT NULL,
  `genre` enum('Fictions','Non-Fictions','Collectibles','Education Materials') NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `stock_qty` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `added_by` int(11) NOT NULL,
  PRIMARY KEY (`book_id`),
  UNIQUE KEY `isbn_number` (`isbn_number`),
  KEY `book_supplier_relationship` (`supplier_id`),
  KEY `book_cashier_relationship` (`added_by`),
  CONSTRAINT `book_cashier_relationship` FOREIGN KEY (`added_by`) REFERENCES `user` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `book_supplier_relationship` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book`
--

LOCK TABLES `book` WRITE;
/*!40000 ALTER TABLE `book` DISABLE KEYS */;
INSERT INTO `book` VALUES (1,'123','sample 2','shehan 1','Non-Fictions',1250,12,6,'2025-04-20 21:26:13','2025-04-21 08:19:25',1);
/*!40000 ALTER TABLE `book` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `customer_id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `customer_phone` varchar(10) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`customer_id`),
  UNIQUE KEY `customer_phone` (`customer_phone`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (2,'shehan','maduranga','0713856191','2025-04-20 23:04:10');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory_record`
--

DROP TABLE IF EXISTS `inventory_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory_record` (
  `record_id` int(11) NOT NULL AUTO_INCREMENT,
  `book_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `bought_for` decimal(10,0) NOT NULL,
  `added_by` int(11) NOT NULL,
  PRIMARY KEY (`record_id`),
  KEY `inventory_record_book_relationship` (`book_id`),
  KEY `inventory_record_cashier_relationship` (`added_by`),
  CONSTRAINT `inventory_record_book_relationship` FOREIGN KEY (`book_id`) REFERENCES `book` (`book_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `inventory_record_cashier_relationship` FOREIGN KEY (`added_by`) REFERENCES `user` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory_record`
--

LOCK TABLES `inventory_record` WRITE;
/*!40000 ALTER TABLE `inventory_record` DISABLE KEYS */;
INSERT INTO `inventory_record` VALUES (1,1,1,'2025-04-20 23:53:11','2025-04-20 23:53:11',1,1),(2,1,10,'2025-04-21 07:48:59','2025-04-21 07:48:59',1000,1),(3,1,1,'2025-04-21 08:19:25','2025-04-21 08:19:25',1000,1);
/*!40000 ALTER TABLE `inventory_record` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order` (
  `order_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `total_price` decimal(10,0) NOT NULL,
  `order_status` enum('Pending','Processing','Sent','Fulfilled','Canceled') NOT NULL,
  `placed_by` int(11) NOT NULL,
  `order_type` enum('PICKUP','DELIVERY') NOT NULL,
  `delivery_cost` int(11) NOT NULL,
  `delivery_address` varchar(512) DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  KEY `order_customer_relationship` (`customer_id`),
  KEY `order_cashier_relationship` (`placed_by`),
  CONSTRAINT `order_cashier_relationship` FOREIGN KEY (`placed_by`) REFERENCES `user` (`user_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `order_customer_relationship` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,NULL,'2025-04-21 00:37:46','2025-04-21 00:42:38',1000,'Processing',1,'PICKUP',0,NULL),(3,NULL,'2025-04-21 07:03:21','2025-04-21 07:03:21',1250,'Pending',1,'PICKUP',0,NULL),(4,2,'2025-04-21 07:03:50','2025-04-21 07:56:06',1250,'Sent',1,'DELIVERY',1000,'sample'),(5,2,'2025-04-21 08:21:19','2025-04-21 08:21:19',13750,'Processing',1,'DELIVERY',800,'sample address');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_item`
--

DROP TABLE IF EXISTS `order_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_item` (
  `book_id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `bought_price` decimal(10,0) NOT NULL,
  `total` decimal(10,0) NOT NULL,
  PRIMARY KEY (`book_id`,`order_id`),
  KEY `order_item_order_relationship` (`order_id`),
  CONSTRAINT `order_item_book_relationship` FOREIGN KEY (`book_id`) REFERENCES `book` (`book_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `order_item_order_relationship` FOREIGN KEY (`order_id`) REFERENCES `order` (`order_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_item`
--

LOCK TABLES `order_item` WRITE;
/*!40000 ALTER TABLE `order_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `order_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `supplier` (
  `supplier_id` int(11) NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(128) NOT NULL,
  `supplier_phone` varchar(10) NOT NULL,
  `supplier_email` varchar(255) NOT NULL,
  `supplier_address` varchar(512) NOT NULL,
  PRIMARY KEY (`supplier_id`),
  UNIQUE KEY `supplier_phone` (`supplier_phone`),
  UNIQUE KEY `supplier_email` (`supplier_email`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (6,'sample','0713856191','sample@sample.com','bla'),(8,'harishanth','0734564561','bla@bla.com','adsgss');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `user_email` varchar(255) NOT NULL,
  `password_hash` varchar(512) NOT NULL,
  `user_phone` varchar(10) NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `user_type` enum('CASHIER','ADMIN') NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `user_email` (`user_email`),
  UNIQUE KEY `user_phone` (`user_phone`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Admin','User','admin@sample.com','$2a$11$023rHdvSZ0Fovu8IYJF/oetTtX4RPjmwbsD00./oKOMBEWzL3A44a','1234567890','2025-03-13 21:09:39','ADMIN'),(3,'Cashier','Cashier','cashier@sample.com','$2a$11$023rHdvSZ0Fovu8IYJF/oetTtX4RPjmwbsD00./oKOMBEWzL3A44a','1234567891','2025-04-21 07:13:55','CASHIER');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'book_heaven'
--

--
-- Dumping routines for database 'book_heaven'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-21 16:02:42
