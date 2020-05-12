CREATE SCHEMA `diepvries` ;


CREATE TABLE `diepvries`.`product` (
  `idproduct` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
  `hoeveelheidinKG` VARCHAR(45) NULL,
  PRIMARY KEY (`idproduct`),
  UNIQUE INDEX `naam_UNIQUE` (`naam` ASC));


INSERT INTO `diepvries`.`product` (`naam`, `hoeveelheidinKG`) VALUES ('Kip', '2');
INSERT INTO `diepvries`.`product` (`naam`, `hoeveelheidinKG`) VALUES ('kaas', '1');


CREATE TABLE `diepvries`.`data` (
  `iddata` INT NOT NULL AUTO_INCREMENT,
  `insteekdatum` date not NULL,
  `vervaldatum` date not NULL,
  PRIMARY KEY (`iddata`)
);

ALTER TABLE `diepvries`.`data` 
ADD COLUMN `idproduct` INT NULL AFTER `vervaldatum`;



INSERT INTO `diepvries`.`data` (`insteekdatum`, `vervaldatum`) VALUES ('2020-02-25', '2021-02-16');
INSERT INTO `diepvries`.`data` (`insteekdatum`, `vervaldatum`) VALUES ('2020-12-12', '2022-12-16');

UPDATE `diepvries`.`data` SET `idproduct` = '2' WHERE (`iddata` = '1');
UPDATE `diepvries`.`data` SET `idproduct` = '1' WHERE (`iddata` = '2');


CREATE TABLE `diepvries`.`positie` (
  `idpositie` INT NOT NULL,
  `lade 1-6` VARCHAR(45) NULL,
  `beschikbaarheidinKG` VARCHAR(45) NULL,
  PRIMARY KEY (`idpositie`),
  UNIQUE INDEX `lade_UNIQUE` (`lade 1-6` ASC));

