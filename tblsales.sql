-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 28, 2022 at 03:52 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `posresto`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblsales`
--

CREATE TABLE `tblsales` (
  `id` int(11) NOT NULL,
  `transno` varchar(50) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `sdate` date NOT NULL,
  `stime` varchar(20) NOT NULL,
  `cashier` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblsales`
--

INSERT INTO `tblsales` (`id`, `transno`, `total`, `sdate`, `stime`, `cashier`) VALUES
(1, '202210250001', '621.00', '2022-10-28', '08:16:48', 'cashier001'),
(2, '202210250001', '552.00', '2022-10-28', '08:33:58', 'cashier001'),
(3, '202210250001', '552.00', '2022-10-28', '08:34:10', 'cashier001'),
(4, '202210250001', '552.00', '2022-10-28', '08:34:13', 'cashier001'),
(5, '202210250001', '552.00', '2022-10-28', '08:34:47', 'cashier001'),
(6, '202210250001', '552.00', '2022-10-28', '08:36:13', 'cashier001'),
(7, '202210250001', '483.00', '2022-10-28', '08:46:16', 'cashier001'),
(8, '202210280001', '276.00', '2022-10-28', '09:09:06', 'cashier001'),
(9, '202210280001', '276.00', '2022-10-28', '09:37:09', 'cashier001'),
(10, '202210250001', '483.00', '2022-10-28', '09:37:22', 'cashier001'),
(11, '202210250001', '483.00', '2022-10-28', '09:38:15', 'cashier001'),
(12, '202210280002', '483.00', '2022-10-28', '09:39:59', 'cashier001');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblsales`
--
ALTER TABLE `tblsales`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblsales`
--
ALTER TABLE `tblsales`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
