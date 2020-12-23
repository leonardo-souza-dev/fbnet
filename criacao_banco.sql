CREATE TABLE `Categoria` (
  `Id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(10) COLLATE latin1_general_cs NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;

CREATE TABLE `Produtor` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(25) COLLATE latin1_general_cs DEFAULT NULL,
  `NomeAvatar` varchar(25) COLLATE latin1_general_cs NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;


CREATE TABLE `ProdutorCategoria` (
  `ProdutorId` int(10) unsigned NOT NULL,
  `CategoriaId` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`ProdutorId`,`CategoriaId`),
  KEY `Constr_CourseMembership_Course_fk` (`CategoriaId`),
  CONSTRAINT `Constr_CourseMembership_Course_fk` FOREIGN KEY (`CategoriaId`) REFERENCES `Categoria` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Constr_CourseMembership_Student_fk` FOREIGN KEY (`ProdutorId`) REFERENCES `Produtor` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
