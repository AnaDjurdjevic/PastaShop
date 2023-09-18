-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema pasta_shop
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema pasta_shop
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pasta_shop` DEFAULT CHARACTER SET utf8 ;
USE `pasta_shop` ;

-- -----------------------------------------------------
-- Table `pasta_shop`.`ACCOUNT`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`ACCOUNT` (
  `Username` VARCHAR(20) NOT NULL,
  `Password` VARCHAR(256) NOT NULL,
  PRIMARY KEY (`Username`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`EMPLOYEE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`EMPLOYEE` (
  `FirstName` VARCHAR(20) NOT NULL,
  `LastName` VARCHAR(20) NOT NULL,
  `WorkPlace` VARCHAR(20) NOT NULL,
  `ACCOUNT_Username` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`ACCOUNT_Username`),
  CONSTRAINT `fk_EMPLOYEE_ACCOUNT1`
    FOREIGN KEY (`ACCOUNT_Username`)
    REFERENCES `pasta_shop`.`ACCOUNT` (`Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`LOCATION`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`LOCATION` (
  `PostNumber` INT(11) NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`PostNumber`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`CUSTOMER`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`CUSTOMER` (
  `Address` VARCHAR(200) NOT NULL,
  `Telephone` VARCHAR(45) NOT NULL,
  `LOCATION_PostNumber` INT(11) NOT NULL,
  `ACCOUNT_Username` VARCHAR(20) NOT NULL,
  INDEX `fk_CUSTOMER_LOCATION1_idx` (`LOCATION_PostNumber` ASC) VISIBLE,
  PRIMARY KEY (`ACCOUNT_Username`),
  CONSTRAINT `fk_CUSTOMER_LOCATION1`
    FOREIGN KEY (`LOCATION_PostNumber`)
    REFERENCES `pasta_shop`.`LOCATION` (`PostNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_CUSTOMER_ACCOUNT1`
    FOREIGN KEY (`ACCOUNT_Username`)
    REFERENCES `pasta_shop`.`ACCOUNT` (`Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`ENTERPRISE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`ENTERPRISE` (
  `JIB` CHAR(13) NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `CUSTOMER_ACCOUNT_Username` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`CUSTOMER_ACCOUNT_Username`),
  CONSTRAINT `fk_ENTERPRISE_CUSTOMER1`
    FOREIGN KEY (`CUSTOMER_ACCOUNT_Username`)
    REFERENCES `pasta_shop`.`CUSTOMER` (`ACCOUNT_Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`INDIVIDUAL`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`INDIVIDUAL` (
  `FirstName` VARCHAR(20) NOT NULL,
  `LastName` VARCHAR(20) NOT NULL,
  `CUSTOMER_ACCOUNT_Username` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`CUSTOMER_ACCOUNT_Username`),
  CONSTRAINT `fk_INDIVIDUAL_CUSTOMER1`
    FOREIGN KEY (`CUSTOMER_ACCOUNT_Username`)
    REFERENCES `pasta_shop`.`CUSTOMER` (`ACCOUNT_Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`PASTA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`PASTA` (
  `Type` VARCHAR(45) NOT NULL,
  `Price` DECIMAL(4,2) NOT NULL,
  `EMPLOYEE_ACCOUNT_Username` VARCHAR(20) NOT NULL,
  `Quantity` DECIMAL(7,0) NOT NULL,
  `IdPasta` INT(11) NOT NULL AUTO_INCREMENT,
  INDEX `fk_PASTA_EMPLOYEE1_idx` (`EMPLOYEE_ACCOUNT_Username` ASC) VISIBLE,
  PRIMARY KEY (`IdPasta`),
  CONSTRAINT `fk_PASTA_EMPLOYEE1`
    FOREIGN KEY (`EMPLOYEE_ACCOUNT_Username`)
    REFERENCES `pasta_shop`.`EMPLOYEE` (`ACCOUNT_Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`ORDER`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`ORDER` (
  `ConfirmationNumber` INT NOT NULL AUTO_INCREMENT,
  `Date` DATE NOT NULL,
  `Status` CHAR(10) NOT NULL,
  `CUSTOMER_ACCOUNT_Username` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`ConfirmationNumber`),
  INDEX `fk_ORDER_CUSTOMER1_idx` (`CUSTOMER_ACCOUNT_Username` ASC) VISIBLE,
  CONSTRAINT `fk_ORDER_CUSTOMER1`
    FOREIGN KEY (`CUSTOMER_ACCOUNT_Username`)
    REFERENCES `pasta_shop`.`CUSTOMER` (`ACCOUNT_Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`ITEM`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`ITEM` (
  `Quantity` DECIMAL(4,0) NOT NULL,
  `Price` DECIMAL(4,2) NOT NULL,
  `ORDER_ConfirmationNumber` INT NOT NULL,
  `PASTA_IdPasta` INT(11) NOT NULL,
  INDEX `fk_ITEM_ORDER1_idx` (`ORDER_ConfirmationNumber` ASC),
  PRIMARY KEY (`ORDER_ConfirmationNumber`, `PASTA_IdPasta`),
  INDEX `fk_ITEM_PASTA1_idx` (`PASTA_IdPasta` ASC) VISIBLE,
  CONSTRAINT `fk_ITEM_ORDER1`
    FOREIGN KEY (`ORDER_ConfirmationNumber`)
    REFERENCES `pasta_shop`.`ORDER` (`ConfirmationNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ITEM_PASTA1`
    FOREIGN KEY (`PASTA_IdPasta`)
    REFERENCES `pasta_shop`.`PASTA` (`IdPasta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`BANK`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`BANK` (
  `IdBANK` INT(11) NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `LOCATION_PostNumber` INT(11) NOT NULL,
  PRIMARY KEY (`IdBANK`),
  INDEX `fk_BANK_LOCATION1_idx` (`LOCATION_PostNumber` ASC) VISIBLE,
  CONSTRAINT `fk_BANK_LOCATION1`
    FOREIGN KEY (`LOCATION_PostNumber`)
    REFERENCES `pasta_shop`.`LOCATION` (`PostNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`SUPPLIER`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`SUPPLIER` (
  `Address` VARCHAR(50) NOT NULL,
  `Telephone` VARCHAR(20) NOT NULL,
  `IdSupplier` INT(11) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL,
  `LOCATION_PostNumber` INT(11) NOT NULL,
  PRIMARY KEY (`IdSupplier`),
  INDEX `fk_SUPPLIER_LOCATION1_idx` (`LOCATION_PostNumber` ASC) VISIBLE,
  CONSTRAINT `fk_SUPPLIER_LOCATION1`
    FOREIGN KEY (`LOCATION_PostNumber`)
    REFERENCES `pasta_shop`.`LOCATION` (`PostNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`BANK_ACCOUNT`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`BANK_ACCOUNT` (
  `BankAccountNumber` CHAR(16) NOT NULL,
  `BANK_idBANK` INT(11) NOT NULL,
  `SUPPLIER_IdSupplier` INT(11) NOT NULL,
  PRIMARY KEY (`BankAccountNumber`),
  INDEX `fk_BILL_BANK1_idx` (`BANK_idBANK` ASC) VISIBLE,
  INDEX `fk_BILL_SUPPLIER1_idx` (`SUPPLIER_IdSupplier` ASC) VISIBLE,
  CONSTRAINT `fk_BILL_BANK1`
    FOREIGN KEY (`BANK_idBANK`)
    REFERENCES `pasta_shop`.`BANK` (`IdBANK`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_BILL_SUPPLIER1`
    FOREIGN KEY (`SUPPLIER_IdSupplier`)
    REFERENCES `pasta_shop`.`SUPPLIER` (`IdSupplier`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`EXPENDITURE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`EXPENDITURE` (
  `ExpenditureNumber` INT(11) NOT NULL AUTO_INCREMENT,
  `Date` DATE NOT NULL,
  `Amount` DECIMAL(6,2) NOT NULL,
  `BANK_ACCOUNT_BankAccountNumber` CHAR(16) NOT NULL,
  PRIMARY KEY (`ExpenditureNumber`),
  INDEX `fk_EXPENDITURE_BANK_ACCOUNT1_idx` (`BANK_ACCOUNT_BankAccountNumber` ASC) VISIBLE,
  CONSTRAINT `fk_EXPENDITURE_BANK_ACCOUNT1`
    FOREIGN KEY (`BANK_ACCOUNT_BankAccountNumber`)
    REFERENCES `pasta_shop`.`BANK_ACCOUNT` (`BankAccountNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`PURCHASE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`PURCHASE` (
  `PurchaseNumber` INT(11) NOT NULL AUTO_INCREMENT,
  `Date` DATE NOT NULL,
  `SUPPLIER_IdSupplier` INT(11) NOT NULL,
  `EXPENDITURE_ExpenditureNumber` INT(11) NULL,
  PRIMARY KEY (`PurchaseNumber`),
  INDEX `fk_PURCHASE_SUPPLIER1_idx` (`SUPPLIER_IdSupplier` ASC) VISIBLE,
  INDEX `fk_PURCHASE_EXPENDITURE1_idx` (`EXPENDITURE_ExpenditureNumber` ASC) VISIBLE,
  CONSTRAINT `fk_PURCHASE_SUPPLIER1`
    FOREIGN KEY (`SUPPLIER_IdSupplier`)
    REFERENCES `pasta_shop`.`SUPPLIER` (`IdSupplier`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PURCHASE_EXPENDITURE1`
    FOREIGN KEY (`EXPENDITURE_ExpenditureNumber`)
    REFERENCES `pasta_shop`.`EXPENDITURE` (`ExpenditureNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`INGREDIENT`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`INGREDIENT` (
  `IdIngredient` INT(11) NOT NULL AUTO_INCREMENT,
  `Price` DECIMAL(4,2) NOT NULL,
  `Type` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`IdIngredient`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`PURCHASE_ITEM`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`PURCHASE_ITEM` (
  `Quantity` DECIMAL(4,2) NOT NULL,
  `Price` DECIMAL(4,2) NOT NULL,
  `PURCHASE_PurchaseNumber` INT(11) NOT NULL,
  `INGREDIENT_IdIngredient` INT(11) NOT NULL,
  PRIMARY KEY (`PURCHASE_PurchaseNumber`, `INGREDIENT_IdIngredient`),
  INDEX `fk_PURCHASE_ITEM_INGREDIENT1_idx` (`INGREDIENT_IdIngredient` ASC) VISIBLE,
  CONSTRAINT `fk_PURCHASE_ITEM_PURCHASE1`
    FOREIGN KEY (`PURCHASE_PurchaseNumber`)
    REFERENCES `pasta_shop`.`PURCHASE` (`PurchaseNumber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PURCHASE_ITEM_INGREDIENT1`
    FOREIGN KEY (`INGREDIENT_IdIngredient`)
    REFERENCES `pasta_shop`.`INGREDIENT` (`IdIngredient`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`WORK_ORDER`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`WORK_ORDER` (
  `Date` DATE NOT NULL,
  `IdWorkOrder` INT NOT NULL AUTO_INCREMENT,
  `Description` VARCHAR(500) NULL,
  PRIMARY KEY (`IdWorkOrder`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pasta_shop`.`WORK_ORDER_ITEM`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pasta_shop`.`WORK_ORDER_ITEM` (
  `PASTA_IdPasta` INT(11) NOT NULL,
  `Quantity` INT NOT NULL,
  `WORK_ORDER_IdWorkOrder` INT NOT NULL,
  PRIMARY KEY (`PASTA_IdPasta`, `WORK_ORDER_IdWorkOrder`),
  INDEX `fk_PASTA_has_WORK_ORDER_PASTA1_idx` (`PASTA_IdPasta` ASC) VISIBLE,
  INDEX `fk_WORK_ORDER_ITEM_WORK_ORDER1_idx` (`WORK_ORDER_IdWorkOrder` ASC) VISIBLE,
  CONSTRAINT `fk_PASTA_has_WORK_ORDER_PASTA1`
    FOREIGN KEY (`PASTA_IdPasta`)
    REFERENCES `pasta_shop`.`PASTA` (`IdPasta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_WORK_ORDER_ITEM_WORK_ORDER1`
    FOREIGN KEY (`WORK_ORDER_IdWorkOrder`)
    REFERENCES `pasta_shop`.`WORK_ORDER` (`IdWorkOrder`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
