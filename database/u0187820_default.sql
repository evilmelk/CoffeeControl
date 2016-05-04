-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Хост: localhost
-- Время создания: Май 04 2016 г., 19:41
-- Версия сервера: 5.5.35-33.0
-- Версия PHP: 5.3.28

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `u0187820_default`
--

-- --------------------------------------------------------

--
-- Структура таблицы `cheks`
--

CREATE TABLE IF NOT EXISTS `cheks` (
  `checkID` int(11) NOT NULL AUTO_INCREMENT,
  `date` datetime NOT NULL,
  `workerID` int(11) NOT NULL,
  `shopID` int(11) NOT NULL,
  PRIMARY KEY (`checkID`),
  KEY `workerID` (`workerID`,`shopID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `materials`
--

CREATE TABLE IF NOT EXISTS `materials` (
  `materials_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) COLLATE utf8_general_mysql500_ci NOT NULL,
  `pieces` double DEFAULT NULL,
  `unitName` varchar(30) COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `modifier` varchar(20) COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `type` varchar(20) COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  PRIMARY KEY (`materials_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci AUTO_INCREMENT=61 ;

--
-- Дамп данных таблицы `materials`
--

INSERT INTO `materials` (`materials_id`, `name`, `pieces`, `unitName`, `modifier`, `type`) VALUES
(44, 'Кофе', 2, 'Кг', '', 'Кофе'),
(45, 'Шоколад', 2, 'Кг', '', 'Шоколад'),
(46, 'Молоко', 20, 'Л', '', 'Молоко'),
(47, 'Сливки', 20, 'Л', '', 'Сливки'),
(48, 'Сахар', 3, 'Кг', '', 'Сахар'),
(49, 'Сироп: карамель', 2, 'Л', '', 'Сиропы'),
(50, 'Сироп: кокос', 2, 'Л', '', 'Сиропы'),
(51, 'Стакан 0.1', 100, 'Шт', '', 'Стаканы'),
(52, 'Стакан 0.2', 100, 'Шт', '', 'Стаканы'),
(53, 'Стакан 0.3', 100, 'Шт', '', 'Стаканы'),
(54, 'Стакан 0.4', 100, 'Шт', '', 'Стаканы'),
(55, 'Стакан 0.5', 100, 'Шт', '', 'Стаканы'),
(56, 'Крышка 70мм', 100, 'Шт', '', 'Крышки'),
(57, 'Крышка 80мм', 100, 'Шт', '', 'Крышки'),
(58, 'Крышка 90мм', 100, 'Шт', '', 'Крышки'),
(59, 'Ложки', 100, 'Шт', '', 'Ложки'),
(60, 'Салфетки', 3, 'Упак', '', 'Салфетки');

-- --------------------------------------------------------

--
-- Структура таблицы `positions`
--

CREATE TABLE IF NOT EXISTS `positions` (
  `positionsID` int(11) NOT NULL AUTO_INCREMENT,
  `price` int(10) NOT NULL,
  `checkID` int(11) NOT NULL,
  PRIMARY KEY (`positionsID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `shops`
--

CREATE TABLE IF NOT EXISTS `shops` (
  `shopID` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`shopID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Дамп данных таблицы `shops`
--

INSERT INTO `shops` (`shopID`, `title`) VALUES
(1, 'Барвиха'),
(2, 'Кремль');

-- --------------------------------------------------------

--
-- Структура таблицы `workers`
--

CREATE TABLE IF NOT EXISTS `workers` (
  `workerID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `workerTime` datetime NOT NULL,
  PRIMARY KEY (`workerID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Дамп данных таблицы `workers`
--

INSERT INTO `workers` (`workerID`, `name`, `workerTime`) VALUES
(1, 'ivanov', '2016-05-04 00:00:00'),
(2, 'козлов', '0000-00-00 00:00:00');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
