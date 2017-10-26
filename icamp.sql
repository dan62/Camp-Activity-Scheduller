-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 26, 2017 at 09:09 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `icamp`
--

-- --------------------------------------------------------

--
-- Table structure for table `activities`
--

CREATE TABLE `activities` (
  `activity_name` text NOT NULL,
  `advisor_name` text NOT NULL,
  `seats_available` int(255) NOT NULL,
  `date` varchar(255) NOT NULL,
  `description` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `activities`
--

INSERT INTO `activities` (`activity_name`, `advisor_name`, `seats_available`, `date`, `description`) VALUES
('Cooking', 'cheff dan', 30, '30 October 2017', 'cooking thai food'),
('Fishing', 'Mr Daniel', 10, '05 November 2017', 'On a sunday we will be going fishing to a beutiful lake located on the outbounds of Bangkok'),
('Fun Land Visit', 'Dr Michael', 23, '29 October 2017', 'We shall be visiting an amazing amusement park filled with lots of activities and fun stuff.'),
('Swimming', 'Ms Earn', 25, '23 November 2017', 'We shall be swimming in the largest lake in Thailand, all swim suits will be provided.');

-- --------------------------------------------------------

--
-- Table structure for table `assigned_activities`
--

CREATE TABLE `assigned_activities` (
  `activity_name` text NOT NULL,
  `student_name` text NOT NULL,
  `parent_email` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assigned_activities`
--

INSERT INTO `assigned_activities` (`activity_name`, `student_name`, `parent_email`) VALUES
('Swimming', 'Students Name', 'Parent Email'),
('Fishing', 'Prosper', 'boba@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `students_name` text NOT NULL,
  `age` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `cellphone_number` int(255) NOT NULL,
  `school` text NOT NULL,
  `medical_aid` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `first_name` text NOT NULL,
  `surname` text NOT NULL,
  `email` varchar(255) NOT NULL,
  `passport_no` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `admin_user` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`first_name`, `surname`, `email`, `passport_no`, `password`, `admin_user`) VALUES
('Taf', 'Mugabe', 'taf@gmail.com', 'EN08745', 'pass', 1),
('test', 'haha', 'test@gmail.com', 'EN08745', 'pass', 0),
('Prosper', 'Gomo', 'pro@gmail.com', 'EN845382', 'password', 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
