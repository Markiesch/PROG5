USE master;
GO

DROP DATABASE IF EXISTS NinjaManager;

CREATE DATABASE NinjaManager;
GO

USE NinjaManager;

CREATE TABLE Ninja (
  id INT NOT NULL PRIMARY KEY,
  name VARCHAR(45) NOT NULL,
  currency INT NOT NULL
);

CREATE TABLE Category (
  id INT NOT NULL PRIMARY KEY,
  name VARCHAR(45) NOT NULL,
);

CREATE TABLE Equipment (
  id INT NOT NULL PRIMARY KEY,
  name VARCHAR(50) NOT NULL,
  price INT NOT NULL,
  strength INT NOT NULL,
  intelligence INT NOT NULL,
  agility INT NOT NULL,
  category_id INT NOT NULL
  CONSTRAINT fk_Equipment_Category1
    FOREIGN KEY (category_id)
    REFERENCES Category (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

CREATE TABLE NinjaEquipment (
  ninja_id INT NOT NULL,
  equipment_id INT NOT NULL,
  PRIMARY KEY (ninja_id, equipment_id),
  CONSTRAINT fk_Ninja_has_Equipment_Ninja
    FOREIGN KEY (ninja_id)
    REFERENCES Ninja (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Ninja_has_Equipment_Equipment1
    FOREIGN KEY (equipment_id)
    REFERENCES Equipment (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);


USE master;