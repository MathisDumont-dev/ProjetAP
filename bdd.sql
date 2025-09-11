-- MySQL dump 10.19  Distrib 10.3.39-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: VisiTTracking
-- ------------------------------------------------------
-- Server version	10.3.39-MariaDB-0+deb10u1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Medecin`
--

DROP TABLE IF EXISTS `Medecin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Medecin` (
  `idPersonne` int(11) NOT NULL,
  `rue` varchar(50) NOT NULL,
  `numRue` int(11) NOT NULL,
  `cp` int(11) NOT NULL,
  `ville` varchar(40) NOT NULL,
  PRIMARY KEY (`idPersonne`),
  CONSTRAINT `Medecin_ibfk_1` FOREIGN KEY (`idPersonne`) REFERENCES `Personne` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Medecin`
--

LOCK TABLES `Medecin` WRITE;
/*!40000 ALTER TABLE `Medecin` DISABLE KEYS */;
INSERT INTO `Medecin` VALUES (1,'Rue de la Paix',12,75001,'Paris'),(2,'Avenue des Champs-Élysées',5,75008,'Paris'),(3,'Boulevard Haussmann',17,75009,'Paris'),(4,'Rue du Faubourg Saint-Honoré',30,75008,'Paris'),(5,'Rue de Rivoli',48,75004,'Paris');
/*!40000 ALTER TABLE `Medecin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Personne`
--

DROP TABLE IF EXISTS `Personne`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Personne` (
  `id` int(11) NOT NULL,
  `nom` varchar(40) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `telephone` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Personne`
--

LOCK TABLES `Personne` WRITE;
/*!40000 ALTER TABLE `Personne` DISABLE KEYS */;
INSERT INTO `Personne` VALUES (1,'Dupont','Jean',601020304,'jean.dupont@example.com'),(2,'Durand','Marie',702030405,'marie.durand@example.com'),(3,'Martin','Pierre',603040506,'pierre.martin@example.com'),(4,'Bernard','Sophie',704050607,'sophie.bernard@example.com'),(5,'Lefevre','Paul',605060708,'paul.lefevre@example.com'),(6,'Moreau','Lucie',706070809,'lucie.moreau@example.com'),(7,'Simon','Julien',607080910,'julien.simon@example.com'),(8,'Michel','Claire',708091011,'claire.michel@example.com'),(9,'Leroy','Antoine',609101112,'antoine.leroy@example.com'),(10,'Roux','Elise',710111213,'elise.roux@example.com');
/*!40000 ALTER TABLE `Personne` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Visite`
--

DROP TABLE IF EXISTS `Visite`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Visite` (
  `id` int(11) NOT NULL,
  `idMedecin` int(11) NOT NULL,
  `idVisiteur` int(11) NOT NULL,
  `dateVisite` date NOT NULL,
  `heureArrivee` time NOT NULL,
  `tempsAttente` int(11) NOT NULL,
  `heureDepart` time NOT NULL,
  `avecRdv` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idMedecin` (`idMedecin`),
  KEY `idVisiteur` (`idVisiteur`),
  CONSTRAINT `Visite_ibfk_1` FOREIGN KEY (`idMedecin`) REFERENCES `Medecin` (`idPersonne`),
  CONSTRAINT `Visite_ibfk_2` FOREIGN KEY (`idVisiteur`) REFERENCES `Visiteur` (`idPersonne`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Visite`
--

LOCK TABLES `Visite` WRITE;
/*!40000 ALTER TABLE `Visite` DISABLE KEYS */;
INSERT INTO `Visite` VALUES (1,1,6,'2024-09-01','10:00:00',15,'10:30:00',1),(2,2,7,'2024-09-02','11:00:00',20,'11:45:00',0),(3,3,8,'2024-09-03','09:30:00',10,'10:00:00',1),(4,4,9,'2024-09-04','08:45:00',25,'09:30:00',0),(5,5,10,'2024-09-05','14:15:00',5,'14:45:00',1),(6,3,9,'2024-09-06','13:00:00',10,'13:30:00',0),(7,4,6,'2024-09-07','12:00:00',15,'12:45:00',1),(8,2,8,'2024-09-08','15:00:00',20,'15:45:00',0),(9,1,10,'2024-09-09','16:00:00',10,'16:30:00',1),(10,5,7,'2024-09-10','17:00:00',5,'17:30:00',0);
/*!40000 ALTER TABLE `Visite` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Visiteur`
--

DROP TABLE IF EXISTS `Visiteur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Visiteur` (
  `idPersonne` int(11) NOT NULL,
  PRIMARY KEY (`idPersonne`),
  CONSTRAINT `Visiteur_ibfk_1` FOREIGN KEY (`idPersonne`) REFERENCES `Personne` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Visiteur`
--

LOCK TABLES `Visiteur` WRITE;
/*!40000 ALTER TABLE `Visiteur` DISABLE KEYS */;
INSERT INTO `Visiteur` VALUES (6),(7),(8),(9),(10);
/*!40000 ALTER TABLE `Visiteur` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-12 15:21:01
