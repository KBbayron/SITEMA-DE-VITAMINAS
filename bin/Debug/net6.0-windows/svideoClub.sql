-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`CLIENTE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`CLIENTE` (
  `cedula` VARCHAR(11) NOT NULL,
  `nombre` VARCHAR(35) NULL,
  `movil` VARCHAR(11) NULL,
  `edad` INT NULL,
  PRIMARY KEY (`cedula`),
  UNIQUE INDEX `cedula_UNIQUE` (`cedula` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`PELICULA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`PELICULA` (
  `idPelicula` INT NOT NULL,
  `descripcion` VARCHAR(50) NULL,
  `genero` VARCHAR(30) NULL,
  `aEstreno` INT NULL,
  `idioma` VARCHAR(15) NULL,
  PRIMARY KEY (`idPelicula`),
  UNIQUE INDEX `idPelicula_UNIQUE` (`idPelicula` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`PRESTAMO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`PRESTAMO` (
  `fPrestamo` VARCHAR(10) NULL,
  `fDevolucion` VARCHAR(10) NULL,
  `idPelicula` INT NULL,
  `cedula` VARCHAR(11) NULL,
  INDEX `FK_CP_idx` (`cedula` ASC) VISIBLE,
  INDEX `FK_PP_idx` (`idPelicula` ASC) VISIBLE,
  CONSTRAINT `FK_CP`
    FOREIGN KEY (`cedula`)
    REFERENCES `mydb`.`CLIENTE` (`cedula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_PP`
    FOREIGN KEY (`idPelicula`)
    REFERENCES `mydb`.`PELICULA` (`idPelicula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
