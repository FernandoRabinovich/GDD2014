CREATE TABLE GRAFO_LOCO.Localidad
	(
	idLocalidad int NOT NULL PRIMARY KEY ,
	Nombre char(50) NOT NULL,
	idCiudad int FOREIGN KEY REFERENCES GRAFO_LOCO.Ciudad (idCiudad)
	)  ON [PRIMARY]