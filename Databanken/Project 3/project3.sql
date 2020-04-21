create database project3;

CREATE TABLE `project3`.`brood` (
  `idbrood` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
  PRIMARY KEY (`idbrood`));

INSERT INTO `project3`.`brood` (`naam`) VALUES ('Bus limburgs terf');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('bus melkwit');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('bus fijn volkoren');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('bus grof volkoren');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('boeren tarwe');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('bus wit');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('bus tarwe');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('boeren donker meergranen');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('bus gogh meergranen');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('bus spelt (half)');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('boeren tijger tarwe');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('boeren tijger wit');
INSERT INTO `project3`.`brood` (`naam`) VALUES ('boeren mout');



CREATE TABLE `project3`.`klant` (
  `idklant` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
  `voornaam` VARCHAR(45) NULL,
  `code` VARCHAR(45) NULL,
  `saldo` VARCHAR(45) NULL,
  PRIMARY KEY (`idklant`));

INSERT INTO `project3`.`klant` (`naam`, `voornaam`, `code`, `saldo`) VALUES ('pieters', 'pieter', '0123456789', '5');
INSERT INTO `project3`.`klant` (`naam`, `voornaam`, `code`, `saldo`) VALUES ('samson', 'sam', '9876543210', '7');

CREATE TABLE `project3`.`automaat` (
  `plaats` VARCHAR(2) NOT NULL,
  `broodid` VARCHAR(45) NULL,
  `prijs` VARCHAR(45) NULL,
  PRIMARY KEY (`plaats`));
  
  ALTER TABLE `project3`.`automaat` 
CHANGE COLUMN `broodid` `broodid` INT NULL DEFAULT NULL ;

INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('1A', '1', '2.10');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('2A', '2', '2.20');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('3A', '3', '2.30');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('4A', '4', '2.40');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('1B', '5', '2.50');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('2B', '6', '2.60');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('3B', '7', '2.70');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('4B', '8', '2.80');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('1C', '9', '2.90');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('2C', '10', '2.95');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('3C', '11', '3.00');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('4C', '12', '2.25');
INSERT INTO `project3`.`automaat` (`plaats`, `broodid`, `prijs`) VALUES ('1D', '13', '2.35');


CREATE TABLE `project3`.`transactie` (
  `idtransactie` INT NOT NULL AUTO_INCREMENT,
  `code` VARCHAR(45) NULL,
  `idbrood` VARCHAR(45) NULL,
  PRIMARY KEY (`idtransactie`));
  
  ALTER TABLE `project3`.`transactie` 
CHANGE COLUMN `idbrood` `idbrood` INT NULL DEFAULT NULL ;


INSERT INTO `project3`.`transactie` (`code`, `idbrood`) VALUES ('0123456789', '2');
INSERT INTO `project3`.`transactie` (`code`, `idbrood`) VALUES ('9876543210', '8');


