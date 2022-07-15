-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Lug 15, 2022 alle 17:46
-- Versione del server: 10.4.24-MariaDB
-- Versione PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `a&p_train`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `biglietti`
--

CREATE TABLE `biglietti` (
  `ID` int(11) NOT NULL,
  `Costo` int(11) NOT NULL,
  `Classe` enum('prima','seconda','terza') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `biglietti_treni`
--

CREATE TABLE `biglietti_treni` (
  `ID` int(11) NOT NULL,
  `CODTreno` int(11) DEFAULT NULL,
  `CODBiglietto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `fermate`
--

CREATE TABLE `fermate` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `tratte`
--

CREATE TABLE `tratte` (
  `ID` int(11) NOT NULL,
  `Partenza` varchar(20) NOT NULL,
  `Arrivo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `tratte_fermate`
--

CREATE TABLE `tratte_fermate` (
  `ID` int(11) NOT NULL,
  `CODFermata` int(11) DEFAULT NULL,
  `CODTratta` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `treni`
--

CREATE TABLE `treni` (
  `ID` int(11) NOT NULL,
  `Tipo` varchar(20) NOT NULL,
  `Nposti` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `treni_tratte`
--

CREATE TABLE `treni_tratte` (
  `ID` int(11) NOT NULL,
  `CODTreno` int(11) DEFAULT NULL,
  `CODTratta` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti`
--

CREATE TABLE `utenti` (
  `Email` varchar(50) NOT NULL,
  `Nome` varchar(20) NOT NULL,
  `Cognome` varchar(20) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti_biglietti`
--

CREATE TABLE `utenti_biglietti` (
  `ID` int(11) NOT NULL,
  `CODUtente` varchar(50) DEFAULT NULL,
  `CODBiglietto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `biglietti`
--
ALTER TABLE `biglietti`
  ADD PRIMARY KEY (`ID`);

--
-- Indici per le tabelle `biglietti_treni`
--
ALTER TABLE `biglietti_treni`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `CODTreno` (`CODTreno`),
  ADD KEY `CODBiglietto` (`CODBiglietto`);

--
-- Indici per le tabelle `fermate`
--
ALTER TABLE `fermate`
  ADD PRIMARY KEY (`ID`);

--
-- Indici per le tabelle `tratte`
--
ALTER TABLE `tratte`
  ADD PRIMARY KEY (`ID`);

--
-- Indici per le tabelle `tratte_fermate`
--
ALTER TABLE `tratte_fermate`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `CODFermata` (`CODFermata`),
  ADD KEY `CODTratta` (`CODTratta`);

--
-- Indici per le tabelle `treni`
--
ALTER TABLE `treni`
  ADD PRIMARY KEY (`ID`);

--
-- Indici per le tabelle `treni_tratte`
--
ALTER TABLE `treni_tratte`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `CODTreno` (`CODTreno`),
  ADD KEY `CODTratta` (`CODTratta`);

--
-- Indici per le tabelle `utenti`
--
ALTER TABLE `utenti`
  ADD PRIMARY KEY (`Email`);

--
-- Indici per le tabelle `utenti_biglietti`
--
ALTER TABLE `utenti_biglietti`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `CODUtente` (`CODUtente`),
  ADD KEY `CODBiglietto` (`CODBiglietto`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `biglietti`
--
ALTER TABLE `biglietti`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `biglietti_treni`
--
ALTER TABLE `biglietti_treni`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `fermate`
--
ALTER TABLE `fermate`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `tratte`
--
ALTER TABLE `tratte`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `tratte_fermate`
--
ALTER TABLE `tratte_fermate`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `treni`
--
ALTER TABLE `treni`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `treni_tratte`
--
ALTER TABLE `treni_tratte`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `utenti_biglietti`
--
ALTER TABLE `utenti_biglietti`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `biglietti_treni`
--
ALTER TABLE `biglietti_treni`
  ADD CONSTRAINT `biglietti_treni_ibfk_1` FOREIGN KEY (`CODTreno`) REFERENCES `treni` (`ID`),
  ADD CONSTRAINT `biglietti_treni_ibfk_2` FOREIGN KEY (`CODBiglietto`) REFERENCES `biglietti` (`ID`);

--
-- Limiti per la tabella `tratte_fermate`
--
ALTER TABLE `tratte_fermate`
  ADD CONSTRAINT `tratte_fermate_ibfk_1` FOREIGN KEY (`CODFermata`) REFERENCES `fermate` (`ID`),
  ADD CONSTRAINT `tratte_fermate_ibfk_2` FOREIGN KEY (`CODTratta`) REFERENCES `tratte` (`ID`);

--
-- Limiti per la tabella `treni_tratte`
--
ALTER TABLE `treni_tratte`
  ADD CONSTRAINT `treni_tratte_ibfk_1` FOREIGN KEY (`CODTreno`) REFERENCES `treni` (`ID`),
  ADD CONSTRAINT `treni_tratte_ibfk_2` FOREIGN KEY (`CODTratta`) REFERENCES `tratte` (`ID`);

--
-- Limiti per la tabella `utenti_biglietti`
--
ALTER TABLE `utenti_biglietti`
  ADD CONSTRAINT `utenti_biglietti_ibfk_1` FOREIGN KEY (`CODUtente`) REFERENCES `utenti` (`Email`),
  ADD CONSTRAINT `utenti_biglietti_ibfk_2` FOREIGN KEY (`CODBiglietto`) REFERENCES `biglietti` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
