/*
SQLyog Ultimate v9.62 
MySQL - 5.5.54 : Database - softeng_grades
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`softeng_grades` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `softeng_grades`;

/*Table structure for table `examtype` */

DROP TABLE IF EXISTS `examtype`;

CREATE TABLE `examtype` (
  `examtype_id` int(100) DEFAULT NULL,
  `TypeName` char(7) DEFAULT NULL,
  `ExamScore` int(11) DEFAULT NULL,
  `ExamTerm` char(3) DEFAULT NULL,
  KEY `examtype_id` (`examtype_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `examtype` */

/*Table structure for table `grades` */

DROP TABLE IF EXISTS `grades`;

CREATE TABLE `grades` (
  `grades_id` int(11) DEFAULT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `prsn_id` int(11) DEFAULT NULL,
  `examtype_id` int(11) DEFAULT NULL,
  `Grade` float DEFAULT NULL,
  KEY `subject_id` (`subject_id`),
  KEY `prsn_id` (`prsn_id`),
  KEY `examtype_id` (`examtype_id`),
  CONSTRAINT `grades_ibfk_3` FOREIGN KEY (`examtype_id`) REFERENCES `examtype` (`examtype_id`),
  CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`subject_id`) REFERENCES `subject` (`subject_id`),
  CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`prsn_id`) REFERENCES `person` (`prsn_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `grades` */

/*Table structure for table `person` */

DROP TABLE IF EXISTS `person`;

CREATE TABLE `person` (
  `prsn_id` int(11) DEFAULT NULL,
  `PrsnFrstName` char(11) DEFAULT NULL,
  `PrsnMidName` char(11) DEFAULT NULL,
  `PrsnLastName` char(11) DEFAULT NULL,
  `PrsnExtName` char(11) DEFAULT NULL,
  `PrsnID` int(8) DEFAULT NULL,
  KEY `prsn_id` (`prsn_id`),
  CONSTRAINT `person_ibfk_1` FOREIGN KEY (`prsn_id`) REFERENCES `student` (`stdnt_id`),
  CONSTRAINT `person_ibfk_2` FOREIGN KEY (`prsn_id`) REFERENCES `teacher` (`tch_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `person` */

/*Table structure for table `section` */

DROP TABLE IF EXISTS `section`;

CREATE TABLE `section` (
  `section_id` int(11) DEFAULT NULL,
  `std_id` int(11) DEFAULT NULL,
  `tch_id` int(11) DEFAULT NULL,
  `SecName` char(6) DEFAULT NULL,
  `SecID` int(11) DEFAULT NULL,
  KEY `section_id` (`section_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `section` */

/*Table structure for table `sem` */

DROP TABLE IF EXISTS `sem`;

CREATE TABLE `sem` (
  `sem_id` int(11) DEFAULT NULL,
  `SemName` char(5) DEFAULT NULL,
  KEY `sem_id` (`sem_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sem` */

/*Table structure for table `student` */

DROP TABLE IF EXISTS `student`;

CREATE TABLE `student` (
  `stdnt_id` int(11) DEFAULT NULL,
  `StdntFirstName` char(11) DEFAULT NULL,
  `StdntMidName` char(11) DEFAULT NULL,
  `StdntLastName` char(11) DEFAULT NULL,
  `StdntExtName` char(11) DEFAULT NULL,
  `StdntID` int(11) DEFAULT NULL,
  KEY `stdnt_id` (`stdnt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `student` */

/*Table structure for table `subject` */

DROP TABLE IF EXISTS `subject`;

CREATE TABLE `subject` (
  `subject_id` int(11) DEFAULT NULL,
  `SubjCode` char(9) DEFAULT NULL,
  `SubjDesc` char(100) DEFAULT NULL,
  `sem_id` int(11) DEFAULT NULL,
  `section_id` int(11) DEFAULT NULL,
  KEY `subject_id` (`subject_id`),
  KEY `sem_id` (`sem_id`),
  KEY `section_id` (`section_id`),
  CONSTRAINT `subject_ibfk_1` FOREIGN KEY (`sem_id`) REFERENCES `sem` (`sem_id`),
  CONSTRAINT `subject_ibfk_2` FOREIGN KEY (`section_id`) REFERENCES `section` (`section_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `subject` */

/*Table structure for table `teacher` */

DROP TABLE IF EXISTS `teacher`;

CREATE TABLE `teacher` (
  `tch_id` int(11) DEFAULT NULL,
  `TchFirstName` char(11) DEFAULT NULL,
  `TchMidName` char(11) DEFAULT NULL,
  `TchLastName` char(11) DEFAULT NULL,
  `TchExtName` char(11) DEFAULT NULL,
  `TchID` int(11) DEFAULT NULL,
  KEY `tch_id` (`tch_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `teacher` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
