-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2022 at 08:23 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `retailbankdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_handles`
--

CREATE TABLE `admin_handles` (
  `Id` int(60) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `current_handles`
--

CREATE TABLE `current_handles` (
  `Id` int(60) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Balance` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `current_handles`
--

INSERT INTO `current_handles` (`Id`, `Username`, `Password`, `Balance`) VALUES
(1, ' ben', '123', '0.00'),
(2, ' ben', '1234', '0.00'),
(3, 'ben', '', '80500.90'),
(4, 'ben', '123', '80500.90'),
(5, ' ben', '123', '0.00'),
(6, ' russell', '1234', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `history_current`
--

CREATE TABLE `history_current` (
  `Id` int(60) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Type` varchar(50) NOT NULL,
  `Date` date NOT NULL DEFAULT current_timestamp(),
  `Amount` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `history_savings`
--

CREATE TABLE `history_savings` (
  `Id` int(60) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Type` varchar(50) NOT NULL,
  `Date` date DEFAULT current_timestamp(),
  `Amount` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `history_savings`
--

INSERT INTO `history_savings` (`Id`, `Username`, `Type`, `Date`, `Amount`) VALUES
(1, ' ken', 'deposit', '2022-06-22', '2000.00'),
(2, ' ken', 'Withdraw', '2022-06-22', '900.00'),
(3, ' ken', 'deposit', '2022-06-22', '4000.00'),
(4, ' ken', 'deposit', '2022-06-22', '600.00'),
(5, ' ken', 'deposit', '2022-06-22', '566.89'),
(6, ' Russell', 'deposit', '2022-06-29', '12000.00');

-- --------------------------------------------------------

--
-- Table structure for table `payee`
--

CREATE TABLE `payee` (
  `Id` int(11) NOT NULL,
  `Firstname` varchar(60) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `savings_handles`
--

CREATE TABLE `savings_handles` (
  `Id` int(60) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Balance` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `savings_handles`
--

INSERT INTO `savings_handles` (`Id`, `Username`, `Password`, `Balance`) VALUES
(1, ' ken', '123', '7700.27'),
(2, ' ben', '123', '10500.90'),
(3, 'ben', '123', '10500.90'),
(4, ' ', '', '0.00'),
(5, ' young', '123', '0.00'),
(6, 'young', '123', '0.00'),
(7, ' Russell', '1234', '14400.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_handles`
--
ALTER TABLE `admin_handles`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `current_handles`
--
ALTER TABLE `current_handles`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `history_current`
--
ALTER TABLE `history_current`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `history_savings`
--
ALTER TABLE `history_savings`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `payee`
--
ALTER TABLE `payee`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `savings_handles`
--
ALTER TABLE `savings_handles`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_handles`
--
ALTER TABLE `admin_handles`
  MODIFY `Id` int(60) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `current_handles`
--
ALTER TABLE `current_handles`
  MODIFY `Id` int(60) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `history_current`
--
ALTER TABLE `history_current`
  MODIFY `Id` int(60) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `history_savings`
--
ALTER TABLE `history_savings`
  MODIFY `Id` int(60) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `payee`
--
ALTER TABLE `payee`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `savings_handles`
--
ALTER TABLE `savings_handles`
  MODIFY `Id` int(60) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
