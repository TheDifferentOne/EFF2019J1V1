CREATE DATABASE Gestion_Associations_Stages
GO
USE Gestion_Associations_Stages
GO

CREATE TABLE Ville(
	Id_Ville INT PRIMARY KEY,
	Nom_Ville VARCHAR(30),
	Pays VARCHAR(30)
	);

CREATE TABLE Volontaire(
	Id_Vlt INT PRIMARY KEY,
	Nom_Vlt VARCHAR(30),
	Prenom_Vlt VARCHAR(30),
	Mail VARCHAR(80),
	Mot_Passe VARCHAR(20),
	Id_Ville INT REFERENCES Ville(Id_Ville),
	Actif BIT 
	);

CREATE TABLE Association(
	Id_Ass INT PRIMARY KEY,
	Nom_Ass VARCHAR(30),
	RaisonSocial VARCHAR(50),
	Adresse VARCHAR(80),
	Telephone VARCHAR(15),
	Id_Ville INT REFERENCES Ville(Id_Ville)
	);

CREATE TABLE Stage(
	Id_Stage INT PRIMARY KEY,
	Date_Debut DATE,
	Date_Fin DATE,
	Id_Association INT REFERENCES Association(Id_Ass)
	);

CREATE TABLE Demande_Inscription(
	Id_Inscription INT PRIMARY KEY,
	Date_Demande DATE,
	Id_Volontaire INT REFERENCES Volontaire(Id_Vlt),
	Id_Stage INT REFERENCES Stage(Id_Stage),
	Etat VARCHAR(15)
	);

--Insertion des donnees
--Ville--
insert into Ville (Id_Ville, Nom_Ville, Pays) values (1, 'Maslovka', 'Russia');
insert into Ville (Id_Ville, Nom_Ville, Pays) values (2, 'Arboga', 'Sweden');
insert into Ville (Id_Ville, Nom_Ville, Pays) values (3, 'Vavatenina', 'Madagascar');
insert into Ville (Id_Ville, Nom_Ville, Pays) values (4, 'Dolní Kounice', 'Czech Republic');
insert into Ville (Id_Ville, Nom_Ville, Pays) values (5, 'Libode', 'South Africa');
--Volantaire--
insert into Volontaire (Id_Vlt, Nom_Vlt, Prenom_Vlt, Mail, Mot_Passe, Id_Ville, Actif) values (1, 'Malletratt', 'Rudolf', 'rmalletratt0@thetimes.co.uk', 'e1UL8mO6ulk', 1, 'True');
insert into Volontaire (Id_Vlt, Nom_Vlt, Prenom_Vlt, Mail, Mot_Passe, Id_Ville, Actif) values (2, 'Lindborg', 'Nickey', 'nlindborg1@webnode.com', 'k6UeXlzTG1', 2, 'True');
insert into Volontaire (Id_Vlt, Nom_Vlt, Prenom_Vlt, Mail, Mot_Passe, Id_Ville, Actif) values (3, 'Shurville', 'Rhoda', 'rshurville2@google.cn', 'GRMNBZi', 3, 'True');
insert into Volontaire (Id_Vlt, Nom_Vlt, Prenom_Vlt, Mail, Mot_Passe, Id_Ville, Actif) values (4, 'Jiran', 'Evaleen', 'ejiran3@flickr.com', 'IrLpaIX4zPo', 4, 'True');
insert into Volontaire (Id_Vlt, Nom_Vlt, Prenom_Vlt, Mail, Mot_Passe, Id_Ville, Actif) values (5, 'Bettington', 'Puff', 'pbettington4@rakuten.co.jp', '3RwUBeIb', 5, 'False');
--Association--
insert into Association (Id_Ass, Nom_Ass, RaisonSocial, Adresse, Telephone, Id_Ville) values (1, 'Corkery-Jacobson', 'Lac w fb of r bk wl of thorax w penet thoracic cavity, subs', '482 Jenna Hill', '844-857-3675', 1);
insert into Association (Id_Ass, Nom_Ass, RaisonSocial, Adresse, Telephone, Id_Ville) values (2, 'Borer and Sons', 'Unsp inj msl/tnd lng extn msl toe at ank/ft lev, l ft, init', '439 Carpenter Pass', '704-870-9327', 2);
insert into Association (Id_Ass, Nom_Ass, RaisonSocial, Adresse, Telephone, Id_Ville) values (3, 'MacGyver Inc', 'Superficial foreign body of ankle', '229 Marcy Terrace', '144-664-7771', 3);
insert into Association (Id_Ass, Nom_Ass, RaisonSocial, Adresse, Telephone, Id_Ville) values (4, 'Reichel LLC', 'Disp fx of lateral condyle of r tibia, 7thQ', '07923 Forest Dale Center', '492-875-7860', 4);
insert into Association (Id_Ass, Nom_Ass, RaisonSocial, Adresse, Telephone, Id_Ville) values (5, 'Bins, Leffler and Schneider', 'Breakdown (mechanical) of ocular prosth dev/grft, subs', '43093 Corben Crossing', '243-597-1311', 5);
--Stage--
insert into Stage (Id_Stage, Date_Debut, Date_Fin, Id_Association) values (1, '12/24/2018', '09/19/2020', 4);
insert into Stage (Id_Stage, Date_Debut, Date_Fin, Id_Association) values (2, '04/09/2019', '03/13/2020', 4);
insert into Stage (Id_Stage, Date_Debut, Date_Fin, Id_Association) values (3, '02/01/2019', '01/03/2020', 3);
insert into Stage (Id_Stage, Date_Debut, Date_Fin, Id_Association) values (4, '09/01/2019', '05/21/2020', 2);
--Demande_Inscription--
insert into Demande_Inscription (Id_Inscription, Date_Demande, Id_Volontaire, Id_Stage, Etat) values (1, '02/13/2020', 1, 1, 'Success');
insert into Demande_Inscription (Id_Inscription, Date_Demande, Id_Volontaire, Id_Stage, Etat) values (2, '02/18/2019', 2, 2, 'Success');
insert into Demande_Inscription (Id_Inscription, Date_Demande, Id_Volontaire, Id_Stage, Etat) values (3, '09/23/2019', 3, 3, 'Failed');
insert into Demande_Inscription (Id_Inscription, Date_Demande, Id_Volontaire, Id_Stage, Etat) values (4, '03/14/2020', 4, 4, 'Success');
