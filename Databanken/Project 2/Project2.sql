

CREATE DATABASE project2;


CREATE TABLE `project2`.`winkel` (
  `idwinkel` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
  PRIMARY KEY (`idwinkel`));
  
  
  
  CREATE TABLE `project2`.`product` (
  `idproduct` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
  `idwinkel` INT NULL,
  PRIMARY KEY (`idproduct`),
  INDEX `winkel_idx` (`idwinkel` ASC),
  CONSTRAINT `winkel`
    FOREIGN KEY (`idwinkel`)
    REFERENCES `project2`.`winkel` (`idwinkel`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    

CREATE TABLE `project2`.`gerecht` (
  `idgerecht` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,

  PRIMARY KEY (`idgerecht`),
  INDEX `product_idx` (`idproduct` ASC),
  CONSTRAINT `product`
    FOREIGN KEY (`idproduct`)
    REFERENCES `project2`.`product` (`idproduct`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);



CREATE TABLE `project2`.`evenement` (
  `idevenement` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
  `aantal dagen` INT NULL,
  `aantal personen` INT NULL,
  PRIMARY KEY (`idevenement`));
  
  
  
  ALTER TABLE `project2`.`gerecht` 
DROP FOREIGN KEY `product`;
ALTER TABLE `project2`.`gerecht` 
DROP INDEX `product_idx` ;
;


ALTER TABLE `project2`.`product` 
DROP FOREIGN KEY `winkel`;
ALTER TABLE `project2`.`product` 
DROP INDEX `winkel_idx` ;
;


CREATE TABLE `project2`.`evenementgerecht` (
  `idkoppeltabel1` INT NOT NULL AUTO_INCREMENT,
  `idevenement` INT NULL,
  `idgerecht` INT NULL,
  PRIMARY KEY (`idkoppeltabel1`));

CREATE TABLE `project2`.`gerechtproduct` (
  `idkoppeltabel2` INT NOT NULL AUTO_INCREMENT,
  `idgerecht` INT NULL,
  `idproduct` INT NULL,
  PRIMARY KEY (`idkoppeltabel2`));


ALTER TABLE `project2`.`evenementgerecht` 
ADD INDEX `evenement_idx` (`idevenement` ASC),
ADD INDEX `gerecht_idx` (`idgerecht` ASC);
;
ALTER TABLE `project2`.`evenementgerecht` 
ADD CONSTRAINT `evenement`
  FOREIGN KEY (`idevenement`)
  REFERENCES `project2`.`evenement` (`idevenement`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION,
ADD CONSTRAINT `gerecht`
  FOREIGN KEY (`idgerecht`)
  REFERENCES `project2`.`gerecht` (`idgerecht`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
  
  
    ALTER TABLE `project2`.`gerechtproduct` 
ADD INDEX `gerecht2_idx` (`idgerecht` ASC),
ADD INDEX `product_idx` (`idproduct` ASC);
;
ALTER TABLE `project2`.`gerechtproduct` 
ADD CONSTRAINT `gerecht2`
  FOREIGN KEY (`idgerecht`)
  REFERENCES `project2`.`gerecht` (`idgerecht`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION,
ADD CONSTRAINT `product`
  FOREIGN KEY (`idproduct`)
  REFERENCES `project2`.`product` (`idproduct`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;


ALTER TABLE `project2`.`product` 
ADD COLUMN `hoeveelheid` VARCHAR(45) NULL AFTER `idwinkel`;

ALTER TABLE `project2`.`product` 
ADD INDEX `FK_winkel_idx` (`idwinkel` ASC);
;
ALTER TABLE `project2`.`product` 
ADD CONSTRAINT `FK_winkel`
  FOREIGN KEY (`idwinkel`)
  REFERENCES `project2`.`product` (`idwinkel`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

ALTER TABLE `project2`.`winkel` 
ADD CONSTRAINT `productwinkel`
  FOREIGN KEY (`idwinkel`)
  REFERENCES `project2`.`product` (`idwinkel`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
  
  ALTER TABLE `project2`.`gerechtproduct` 
CHANGE COLUMN `idkoppeltabel2` `idgerechtproduct` INT(11) NOT NULL ;

ALTER TABLE `project2`.`product` 
CHANGE COLUMN `naam` `naamProduct` VARCHAR(45) NULL DEFAULT NULL ;


create view gerechtmetproducten as 
SELECT gerechtproduct.idgerechtproduct, gerechtproduct.idgerecht, product.idproduct, gerecht.naam, product.hoeveelheid,gerechtproduct.Hoeveelheid as HoeveelheidInGerecht, product.naamProduct FROM 
(gerechtproduct join gerecht on gerecht.idgerecht = gerechtproduct.idgerecht) 
join product on product.idproduct = gerechtproduct.idproduct;


select * from (gerechtproduct join


