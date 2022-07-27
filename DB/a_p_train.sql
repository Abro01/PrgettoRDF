CREATE TABLE utenti (
    ID int NOT NULL AUTO_INCREMENT,
    Nome varchar(20) NOT NULL,
    Cognome varchar(20) NOT NULL,
    Email varchar(30) NOT NULL,
    Password varchar(20) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE treni(
    ID int NOT NULL AUTO_INCREMENT,
    Modello varchar(20) NOT NULL,
    NPosti int NOT NULL,
    CODTratta int NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY(CODTratta) REFERENCES tratte(ID)
);

CREATE TABLE biglietti(
    ID int NOT NULL AUTO_INCREMENT,
    Costo int NOT NULL,
    Classe ENUM('Business', 'Prima', 'Seconda') NOT NULL,
    CODTratta int NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY(CODTratta) REFERENCES tratte(ID)
);

CREATE TABLE tratte(
    ID int NOT NULL AUTO_INCREMENT,
    Partenza varchar(20) NOT NULL,
    Arrivo varchar(20) NOT NULL,
    Orario TIME NOT NULL,
    Data DATE NOT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE fermate(
    ID int NOT NULL AUTO_INCREMENT,
    Nome varchar(20) NOT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE utenti_biglietti(
    ID int NOT NULL AUTO_INCREMENT,
    CODUtente int NOT NULL,
    CODBiglietto int NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY(CODUtente) REFERENCES utenti(ID),
    FOREIGN KEY(CODBiglietto) REFERENCES biglietti(ID)
);

CREATE TABLE tratte_fermate(
    ID int NOT NULL AUTO_INCREMENT,
    CODTratta int NOT NULL,
    CODFermata int NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY(CODTratta) REFERENCES tratte(ID),
    FOREIGN KEY(CODFermata) REFERENCES fermate(ID)
);
