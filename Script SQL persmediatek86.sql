-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 24 mai 2022 à 13:23
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : persmediatek86
--
CREATE DATABASE IF NOT EXISTS persmediatek86 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE USER 'userDB'@'%' IDENTIFIED BY 'userDB';
GRANT USAGE ON *.* TO 'persmediatek86'@'%';
GRANT ALL PRIVILEGES ON `persmediatek86`.* TO 'persmediatek86'@'%';
USE persmediatek86;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE IF NOT EXISTS absence (
  IDPERSONNEL int(2) NOT NULL,
  DATEDEBUT datetime NOT NULL,
  IDMOTIF int(2) NOT NULL,
  DATEFIN datetime DEFAULT NULL,
  PRIMARY KEY (IDPERSONNEL,DATEDEBUT),
  KEY FK_ABSENCE_MOTIF (IDMOTIF)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (IDPERSONNEL, DATEDEBUT, IDMOTIF, DATEFIN) VALUES
(1, '2021-02-02 00:00:00', 1, '2021-02-02 00:00:00'),
(1, '2021-04-12 00:00:00', 1, '2021-04-16 00:00:00'),
(1, '2021-07-01 00:00:00', 1, '2020-07-20 00:00:00'),
(1, '2021-05-03 00:00:00', 2, '2021-05-05 00:00:00'),
(1, '2021-10-16 00:00:00', 2, '2021-10-22 00:00:00'),
(1, '2021-11-15 00:00:00', 3, '2021-11-15 00:00:00'),
(2, '2021-01-08 00:00:00', 2, '2021-01-10 00:00:00'),
(2, '2021-02-15 00:00:00', 3, '2021-02-15 00:00:00'),
(2, '2021-03-03 00:00:00', 3, '2021-03-03 00:00:00'),
(2, '2021-10-11 00:00:00', 3, '2021-10-12 00:00:00'),
(3, '2021-04-01 00:00:00', 1, '2021-04-03 00:00:00'),
(3, '2021-06-06 00:00:00', 1, '2021-06-10 00:00:00'),
(3, '2021-09-07 00:00:00', 1, '2021-09-12 00:00:00'),
(3, '2021-12-20 00:00:00', 1, '2021-12-27 00:00:00'),
(4, '2021-01-01 00:00:00', 4, '2021-06-30 00:00:00'),
(4, '2021-07-09 00:00:00', 1, '2021-07-24 00:00:00'),
(4, '2021-09-04 00:00:00', 3, '2021-09-04 00:00:00'),
(4, '2021-10-10 00:00:00', 3, '2021-10-12 00:00:00'),
(4, '2021-11-03 00:00:00', 3, '2021-11-03 00:00:00'),
(4, '2021-12-15 00:00:00', 3, '2021-12-17 00:00:00'),
(5, '2021-01-08 00:00:00', 3, '2021-01-09 00:00:00'),
(5, '2021-02-11 00:00:00', 3, '2021-02-11 00:00:00'),
(5, '2021-02-27 00:00:00', 3, '2021-02-27 00:00:00'),
(5, '2021-03-31 00:00:00', 3, '2021-03-31 00:00:00'),
(5, '2021-05-06 00:00:00', 3, '2021-05-06 00:00:00'),
(5, '2021-09-07 00:00:00', 3, '2021-09-07 00:00:00'),
(5, '2021-10-10 00:00:00', 3, '2021-10-10 00:00:00'),
(5, '2021-11-02 00:00:00', 2, '2021-11-05 00:00:00'),
(5, '2021-11-29 00:00:00', 2, '2021-11-30 00:00:00'),
(5, '2021-12-12 00:00:00', 2, '2021-12-15 00:00:00'),
(6, '2021-03-14 00:00:00', 2, '2021-03-20 00:00:00'),
(6, '2021-04-16 00:00:00', 3, '2021-04-16 00:00:00'),
(6, '2021-06-06 00:00:00', 2, '2021-06-10 00:00:00'),
(6, '2021-08-07 00:00:00', 1, '2021-08-28 00:00:00'),
(6, '2021-10-31 00:00:00', 2, '2021-10-31 00:00:00'),
(6, '2021-12-12 00:00:00', 3, '2021-12-12 00:00:00'),
(7, '2021-01-04 00:00:00', 3, '2021-01-04 00:00:00'),
(7, '2021-05-05 00:00:00', 3, '2021-05-05 00:00:00'),
(7, '2021-07-22 00:00:00', 1, '2021-08-13 00:00:00'),
(7, '2021-09-03 00:00:00', 2, '2021-09-12 00:00:00'),
(7, '2021-11-10 00:00:00', 3, '2021-11-10 00:00:00'),
(8, '2021-04-22 00:00:00', 1, '2021-04-29 00:00:00'),
(8, '2021-07-02 00:00:00', 1, '2021-07-29 00:00:00'),
(8, '2021-09-08 00:00:00', 2, '2021-09-12 00:00:00'),
(8, '2021-09-25 00:00:00', 2, '2021-09-27 00:00:00'),
(8, '2021-10-10 00:00:00', 2, '2021-10-15 00:00:00'),
(8, '2021-12-03 00:00:00', 3, '2021-12-03 00:00:00'),
(9, '2021-02-10 00:00:00', 1, '2021-02-17 00:00:00'),
(9, '2021-08-01 00:00:00', 1, '2021-08-22 00:00:00'),
(9, '2021-09-01 00:00:00', 4, '2021-12-31 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE IF NOT EXISTS motif (
  IDMOTIF int(2) NOT NULL AUTO_INCREMENT,
  LIBELLE varchar(128) DEFAULT NULL,
  PRIMARY KEY (IDMOTIF)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (IDMOTIF, LIBELLE) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE IF NOT EXISTS personnel (
  IDPERSONNEL int(2) NOT NULL AUTO_INCREMENT,
  IDSERVICE int(2) NOT NULL,
  NOM varchar(50) DEFAULT NULL,
  PRENOM varchar(50) DEFAULT NULL,
  TEL varchar(15) DEFAULT NULL,
  MAIL varchar(128) DEFAULT NULL,
  PRIMARY KEY (IDPERSONNEL),
  KEY FK_PERSONNEL_SERVICE (IDSERVICE)
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (IDPERSONNEL, IDSERVICE, NOM, PRENOM, TEL, MAIL) VALUES
(1, 1, 'BROOKS', 'Conan', '06.35.67.76.60', 'molestie.pharetra@protonmail.edu'),
(2, 2, 'CURRY', 'Basia', '04.61.70.71.32', 'pellentesque.habitant@icloud.couk'),
(3, 3, 'CARR', 'Shelly', '06.22.36.83.96', 'magna.lorem@aol.edu'),
(4, 1, 'LEBLANC', 'Dominique', '01.63.67.48.11', 'condimentum.donec@protonmail.net'),
(5, 2, 'BECKER', 'Emerson', '09.79.72.44.95', 'erat@google.com'),
(6, 3, 'ANDERSON', 'Urielle', '06.33.56.06.00', 'urna@yahoo.couk'),
(7, 1, 'FARMER', 'Reese', '06.81.23.33.70', 'curabitur@outlook.edu'),
(8, 2, 'ALVARADO', 'Patricia', '01.35.85.80.22', 'euismod.enim@hotmail.couk'),
(9, 3, 'GOODWIN', 'Eliana', '03.86.63.32.24', 'a.facilisis@hotmail.com'),
(10, 1, 'JENKINS', 'Cleo', '01.17.72.86.84', 'sem.vitae@icloud.net');

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE IF NOT EXISTS responsable (
  login varchar(64) NOT NULL,
  pwd varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('responsable1', '05067057bd01bdfb221f245bac40ae9088d8b086ddd4dfac9d8a1148203db834');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE IF NOT EXISTS service (
  IDSERVICE int(2) NOT NULL AUTO_INCREMENT,
  NOM varchar(50) DEFAULT NULL,
  PRIMARY KEY (IDSERVICE)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table service
--

INSERT INTO service (IDSERVICE, NOM) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
