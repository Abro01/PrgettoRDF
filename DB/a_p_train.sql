CREATE TABLE utenti (
    ID int NOT NULL AUTO_INCREMENT,
    Email varchar(50) NOT NULL UNIQUE,
    Nome varchar(20) NOT NULL,
    Cognome varchar(20) NOT NULL,
    Username varchar(20) NOT NULL,
    Password varchar(50) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE biglietti (
    ID int NOT NULL AUTO_INCREMENT,
    Costo int NOT NULL,
    Classe enum('prima','seconda','terza') DEFAULT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE fermate (
    ID int NOT NULL AUTO_INCREMENT,
    Nome varchar(20) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE tratte (
    ID int NOT NULL AUTO_INCREMENT,
    Partenza varchar(20) NOT NULL,
    Arrivo varchar(20) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE treni (
    ID int NOT NULL AUTO_INCREMENT,
    Tipo varchar(20) NOT NULL,
    Nposti int NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE biglietti_treni (
    ID int NOT NULL AUTO_INCREMENT,
    CODTreno int DEFAULT NULL,
    CODBiglietto int DEFAULT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (CODTreno) REFERENCES treni(ID),
    FOREIGN KEY (CODBiglietto) REFERENCES biglietti(ID)
);

CREATE TABLE tratte_fermate (
    ID int NOT NULL AUTO_INCREMENT,
    CODFermata int DEFAULT NULL,
    CODTratta int DEFAULT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (CODFermata) REFERENCES fermate(ID),
    FOREIGN KEY (CODTratta) REFERENCES tratte(ID)
);

CREATE TABLE treni_tratte (
    ID int NOT NULL AUTO_INCREMENT,
    CODTreno int DEFAULT NULL,
    CODTratta int DEFAULT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (CODTreno) REFERENCES treni(ID),
    FOREIGN KEY (CODTratta) REFERENCES tratte(ID)
);

CREATE TABLE utenti_biglietti (
    ID int NOT NULL AUTO_INCREMENT,
    CODUtente int DEFAULT NULL,
    CODBiglietto int DEFAULT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (CODUtente) REFERENCES utenti(ID),
    FOREIGN KEY (CODBiglietto) REFERENCES biglietti(ID)
);
