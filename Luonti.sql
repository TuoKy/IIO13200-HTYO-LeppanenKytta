-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Card`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Card` (
  `idCard` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `CardName` VARCHAR(45) NULL UNIQUE COMMENT '',
  `CardSet` VARCHAR(45) NULL COMMENT '',
  `CardType` VARCHAR(45) NULL COMMENT '',
  `CardRarity` VARCHAR(45) NULL COMMENT '',
  `CardCost` INT NULL COMMENT '',
  `CardAttack` INT NULL COMMENT '',
  `CardHealth` INT NULL COMMENT '',
  `CardText` VARCHAR(256) NULL COMMENT '',
  `CardPlayerClass` VARCHAR(45) NULL COMMENT '',
  `CardImg` VARCHAR(256) NULL COMMENT '',
  PRIMARY KEY (`idCard`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`User` (
  `idUser` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `UserName` VARCHAR(45) NOT NULL COMMENT '',
  `UserPassword` VARCHAR(45) NOT NULL COMMENT '',
  PRIMARY KEY (`idUser`)  COMMENT '',
  UNIQUE INDEX `UserName_UNIQUE` (`UserName` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Deck`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Deck` (
  `idDeck` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `DeckName` VARCHAR(45) NOT NULL COMMENT '',
  `User_idUser` INT NOT NULL COMMENT '',
  PRIMARY KEY (`idDeck`)  COMMENT '',
  INDEX `fk_Deck_User1_idx` (`User_idUser` ASC)  COMMENT '',
  CONSTRAINT `fk_Deck_User1`
    FOREIGN KEY (`User_idUser`)
    REFERENCES `mydb`.`User` (`idUser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Deck_has_Card`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Deck_has_Card` (
  `Deck_idDeck` INT NOT NULL COMMENT '',
  `Card_idCard` INT NOT NULL COMMENT '',
  `CardCount` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Deck_idDeck`, `Card_idCard`)  COMMENT '',
  INDEX `fk_Deck_has_Card_Card1_idx` (`Card_idCard` ASC)  COMMENT '',
  INDEX `fk_Deck_has_Card_Deck_idx` (`Deck_idDeck` ASC)  COMMENT '',
  CONSTRAINT `fk_Deck_has_Card_Deck`
    FOREIGN KEY (`Deck_idDeck`)
    REFERENCES `mydb`.`Deck` (`idDeck`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Deck_has_Card_Card1`
    FOREIGN KEY (`Card_idCard`)
    REFERENCES `mydb`.`Card` (`idCard`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

ALTER TABLE `mydb`.`deck` 
ADD COLUMN `DeckClass` VARCHAR(45) NULL COMMENT '' AFTER `User_idUser`;

ALTER TABLE `mydb`.`deck` 
ADD COLUMN `CardCount` INT NULL COMMENT '' AFTER `DeckClass`;

INSERT INTO user (UserName,UserPassword) VALUES ('admin','admin');
