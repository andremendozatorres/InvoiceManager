CREATE DATABASE examen;
USE examen;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `examen`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblcategories`
--

CREATE TABLE `tblcategories` (
  `ID` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `NAME` varchar(90) NOT NULL UNIQUE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategories`
--

INSERT INTO `tblcategories` (`ID`, `NAME`) VALUES
(1, 'PIPE'),
(2, 'MOTORS MACHINE'),
(3, 'BELT'),
(4, 'ACCESORIES'),
(5, 'BOLT');

-- --------------------------------------------------------

--
-- Table structure for table `tblunits`
--

CREATE TABLE `tblunits` (
  `ID` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `NAME` varchar(90) NOT NULL UNIQUE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsettings`
--

INSERT INTO `tblunits` (`ID`, `NAME`) VALUES
(1, 'pcs.'),
(2, 'box'),
(3, 'meter'),
(4, 'kilo');

-- --------------------------------------------------------

--
-- Table structure for table `tblitems`
--

CREATE TABLE `tblitems` (
  `ITEMID` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `NAME` varchar(90) NOT NULL,
  `DESCRIPTION` varchar(90) NOT NULL,
  `CATEGORY` int NOT NULL,
  `PRICE` double NOT NULL,
  `QTY` int NOT NULL,
  `UNIT` int NOT NULL,
  FOREIGN KEY (CATEGORY) REFERENCES tblcategories(ID),
  FOREIGN KEY (UNIT) REFERENCES tblunits(ID)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblitems`
--

INSERT INTO `tblitems` (`ITEMID`, `NAME`, `DESCRIPTION`, `CATEGORY`, `PRICE`, `QTY`, `UNIT`) VALUES
(1, 'Piston Ring \"Yamana\"', 'Motor Parts', 4, 350, 342, 2),
(2, 'Nut Lack', 'Motor Parts', 4, 45, 292, 1),
(3, 'Fly Wheel Nut', 'Motor Parts', 4, 100, 385, 1),
(4, 'Nut Lack Plus', 'Motor Parts', 4, 45, 195, 4),
(5, 'Tapelone', 'Motor Parts', 4, 150, 40, 2),
(6, 'Main Bering', 'Motor Parts', 4, 350, 200, 2),
(7, 'Con. Rod', 'Motor Parts', 4, 150, 250, 2),
(8, 'Bolt', 'Motor Bolt', 4, 50, 394, 4),
(9, 'Valve Spring', 'Motor Parts', 4, 250, 300, 2),
(10, 'Fuel Tank', 'Motor Tank', 4, 350, 30, 2),
(11, 'Nozzle Tip', 'Motor Tool', 4, 50, 50, 2),
(12, 'Oil Filter', 'Motor Tool', 4, 40, 50, 2),
(13, 'Fan Blade', 'Motor Fan', 4, 250, 15, 2),
(14, 'Nut', 'Motor parts', 4, 25, 400, 1),
(15, 'Fly Wheel Nut', 'Motor Part', 4, 50, 198, 1),
(16, 'Oil Dip Stick', 'Motor Tool ', 4, 40, 50, 2),
(17, 'Cylinder Head Gasket', 'Motor Parts', 4, 150, 100, 2),
(18, 'Fujibelt', 'Motor Belt', 3, 250, 55, 1),
(19, 'Bandbelt', 'Motor Belt ', 3, 300, 57, 1),
(20, 'Mitsubishibelt', 'Motor Belt', 3, 350, 65, 1),
(21, 'Power Spry', 'water spry', 2, 2000, 60, 1),
(22, 'Electric Motor', 'Machine', 2, 2000, 95, 1),
(23, 'Water Cool', 'water machine', 2, 2500, 109, 1),
(24, 'Air Cool', 'Air exit', 2, 3000, 45, 1),
(25, 'Electecal Water Pump', 'water spry', 2, 4500, 47, 1),
(26, 'Wilding Machine', '200AMPS OR 300 AMPS', 2, 10000, 40, 1),
(27, 'Gasoline Engine', 'Power Engine', 2, 10500, 40, 1),
(28, 'Water Pump', 'YAMMA MACHINE', 2, 10000, 40, 1),
(29, 'Grass Cutter', 'YAMAHA POWER', 2, 15000, 30, 1),
(30, 'P.U.T Bulb', 'FireFly ', 2, 5000, 30, 1),
(31, 'Piting Pipe', 'Long pipe', 1, 1200, 30, 3),
(32, 'Adapter Pipe', 'Short Pipe', 1, 100, 50, 1),
(33, 'T Pipe', 'Plastic Pipe', 1, 100, 50, 1),
(34, 'G.I Piting', 'Long Pipe', 1, 250, 30, 1),
(35, 'Power Back', 'Cool Electronics', 4, 250, 100, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblperson`
--

CREATE TABLE `tblperson` (
  `ID` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblperson`
--

INSERT INTO `tblperson` (`ID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`) VALUES
(1, 'Edzel', 'Magbato', 'Bayawan Negros Oriental', '444114', '09091122215', 'Customer'),
(2, 'Kim Dexter', 'Alimpuangon', 'National Highway', '4500024', '09483322547', 'Customer'),
(3, 'Cedrex', 'Caguales', 'Burgos St. kabankalan city', '499855', '09489752666', 'Customer'),
(4, 'Mark Joseph ', 'Porras', 'Guanzon st kab city', '4799878', '09485743184', 'Customer'),
(5, 'Alejandro', 'Suniga', 'Brgy Tapi', '471822', '09295596065', 'Customer'),
(6, 'Juanito', 'Tababa', 'Brgy Tabugon', '', '09085511125', 'Customer'),
(7, 'Ricardo', 'Casipsip', 'Malabong ilog', '', '0956775433', 'Customer'),
(8, 'jessa', 'matula', 'delicioso, ilog', '', '09123456675', 'Customer'),
(9, 'Angelie', 'Sitjar', 'Ilog negros occidental', '', '09095544124', 'Customer'),
(10, 'Joe', 'Morales', 'Road Oeste', '456684', '05648003648', 'Customer'),
(11, 'SpecialStockIn', 'SpecialStockIn', 'SpecialStockIn', '10101010', '10101010', 'SpecialStockIn');

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaction`
--

CREATE TABLE `tbltransaction` (
  `TRANSACTIONNUMBER` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `TRANSACTIONDATE` date NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `SUPLIERCUSTOMERID` int NOT NULL,
  `STATE` varchar(30) NOT NULL DEFAULT 'Activa',
  FOREIGN KEY (SUPLIERCUSTOMERID) REFERENCES tblperson(ID)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltransaction`
--

INSERT INTO `tbltransaction` (`TRANSACTIONNUMBER`, `TRANSACTIONDATE`, `TYPE`, `SUPLIERCUSTOMERID`) VALUES
(1, '2015-02-25', 'StockOut', 10),
(2, '2015-02-25', 'StockOut', 1),
(3, '2015-02-25', 'StockOut', 1),
(4, '2015-02-25', 'StockOut', 4),
(5, '2015-02-26', 'StockOut', 6),
(6, '2015-02-26', 'StockOut', 1),
(7, '2015-02-26', 'StockOut', 8),
(8, '2015-02-26', 'StockOut', 9),
(9, '2015-02-26', 'StockOut', 7),
(10, '2019-01-06', 'StockOut', 8),
(11, '2014-08-16', 'StockIn', 1),
(12, '2014-08-16', 'StockIn', 6),
(13, '2016-02-21', 'StockIn', 2),
(14, '2016-02-21', 'StockIn', 8),
(15, '2016-02-24', 'StockIn', 1),
(16, '2015-02-25', 'Returned', 1),
(17, '2015-02-25', 'Returned', 6),
(18, '2019-01-25', 'Returned', 2),
(19, '2019-01-26', 'Returned', 8),
(20, '2019-01-26', 'Returned', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_in_out`
--

CREATE TABLE `tblstock_in_out` (
  `STOCKOUTID` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `TRANSACTIONNUMBER` int NOT NULL,
  `ITEMID` int NOT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `QTY` int NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `SUPLIERCUSTOMERID` int,
  `REMARKS` varchar(30) NOT NULL,
  FOREIGN KEY (TRANSACTIONNUMBER) REFERENCES tbltransaction(TRANSACTIONNUMBER),
  FOREIGN KEY (SUPLIERCUSTOMERID) REFERENCES tblperson(ID),
  FOREIGN KEY (ITEMID) REFERENCES tblitems(ITEMID)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstock_in_out`
--

INSERT INTO `tblstock_in_out` (`STOCKOUTID`, `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`, `REMARKS`) VALUES
(1, 1, 11, '2015-02-25', 20, 1000, 10, 'StockOut'),
(2, 2, 25, '2015-02-25', 5, 22500, 1, 'StockOut'),
(3, 3, 2, '2015-02-25', 1, 45, 1, 'StockOut'),
(4, 4, 35, '2015-02-25', 2, 500, 4, 'StockOut'),
(5, 4, 3, '2015-02-25', 4, 400, 4, 'StockOut'),
(6, 4, 3, '2015-02-25', 6, 600, 4, 'StockOut'),
(7, 5, 2, '2015-02-26', 5, 225, 6, 'StockOut'),
(8, 5, 3, '2015-02-26', 4, 400, 6, 'StockOut'),
(9, 5, 4, '2015-02-26', 5, 225, 6, 'StockOut'),
(10, 6, 2, '2015-02-26', 1, 45, 1, 'StockOut'),
(11, 7, 1, '2015-02-25', 2, 700, 8, 'StockOut'),
(12, 8, 19, '2015-02-26', 3, 900, 9, 'StockOut'),
(13, 9, 8, '2015-02-26', 5, 250, 7, 'StockOut'),
(14, 10, 23, '2019-01-06', 1, 2500, 8, 'StockOut'),
(15, 10, 35, '2019-01-06', 1, 250, 8, 'StockOut'),
(16, 10, 22, '2019-01-06', 2, 4000, 8, 'StockOut'),
(17, 10, 15, '2019-01-06', 2, 100, 8, 'StockOut'),
(18, 10, 8, '2019-01-06', 1, 50, 8, 'StockOut'),
(19, 11, 11, '2014-08-16', 50, 550, 11, 'StockIn'),
(20, 12, 21, '2014-08-16', 10, 20000, 11, 'StockIn'),
(21, 13, 21, '2016-02-21', 5, 10000, 11, 'StockIn'),
(22, 13, 23, '2016-02-21', 3, 7500, 11, 'StockIn'),
(23, 14, 24, '2016-02-21', 1, 3000, 11, 'StockIn'),
(24, 14, 23, '2016-02-21', 6, 15000, 11, 'StockIn'),
(25, 15, 25, '2016-02-24', 3, 13500, 11, 'StockIn');

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_return`
--

CREATE TABLE `tblstock_return` (
  `STOCKRETURNID` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `STOCKRETURNNUMBER` int NOT NULL,
  `ITEMID` int NOT NULL,
  `RETURNDATE` date NOT NULL,
  `QTY` int NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `OWNER_CUS_ID` int NOT NULL,
  FOREIGN KEY (OWNER_CUS_ID) REFERENCES tblperson(ID),
  FOREIGN KEY (ITEMID) REFERENCES tblitems(ITEMID),
  FOREIGN KEY (STOCKRETURNNUMBER) REFERENCES tbltransaction(TRANSACTIONNUMBER)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstock_return`
--

INSERT INTO `tblstock_return` (`STOCKRETURNID`, `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `QTY`, `TOTALPRICE`, `OWNER_CUS_ID`) VALUES
(1, 16, 2, '2015-02-25', 2, 90, 1),
(2, 17, 23, '2015-02-25', 2, 5000, 6),
(3, 18, 15, '2019-01-25', 2, 100, 2),
(4, 18, 22, '2019-01-25', 5, 10000, 2),
(5, 19, 22, '2019-01-26', 2, 4000, 8),
(6, 20, 21, '2019-01-26', 5, 10000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblusertype`
--

CREATE TABLE `tblusertype` (
  `USERTYPEID` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `NAME` varchar(90) NOT NULL UNIQUE
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblusertype`
--

INSERT INTO `tblusertype` (`USERTYPEID`, `NAME`) VALUES
(1, 'Administrador'),
(2, 'Staff');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `USERID` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `NAME` varchar(90) DEFAULT NULL,
  `USER_NAME` varchar(90) DEFAULT NULL,
  `PASS` varchar(90) DEFAULT NULL,
  `TYPE` int NOT NULL,
  FOREIGN KEY (TYPE) REFERENCES tblusertype(USERTYPEID)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`USERID`, `NAME`, `USER_NAME`, `PASS`, `TYPE`) VALUES
(1, 'Gral Tohem', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 1),
(2, 'Paul Arroz', 'paul', 'd033e22ae348aeb5660fc2140aec35850c4da997', 1);


-- --------------------------------------------------------

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
