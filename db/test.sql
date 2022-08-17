CREATE TABLE "departements_test" (
	"id"	INTEGER NOT NULL UNIQUE,
	"departement"	TEXT NOT NULL,
	"approbe_par"	TEXT NOT NULL,
	"montant"	TEXT NOT NULL,
	"last_update"	REAL NOT NULL DEFAULT (datetime('now', 'localtime')),
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "liste_de_po_test" (
	"id"	INTEGER NOT NULL UNIQUE,
	"numero_de_po"	TEXT NOT NULL,
	"fournisseur"	TEXT NOT NULL,
	"demande_par"	TEXT,
	"description"	TEXT,
	"commentaire"	TEXT,
	"statut"		TEXT,
	"approbe_par"	TEXT,
	"last_update"	REAL NOT NULL DEFAULT (datetime('now', 'localtime')),
	FOREIGN KEY("approbe_par") REFERENCES "departements_test",
	PRIMARY KEY("id" AUTOINCREMENT)
);

INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('Finance', 'Aimée Blanche', 'CAD$24,999');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('Communications', 'Antoinette Camille', 'CAD$10,000');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('Information', 'François Chanel', 'Sans Limite');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('Éditorial', 'Charlotte Marin', 'CAD$10,000');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('diteur', 'Chloé Crevier', 'Sans Limite');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('Administration', 'Chloét Chloé', 'Sans Limite');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('KAZ', 'Desiree Corinne', 'Sans Limite');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('Capital humain', 'Denise Elaine', 'Sans Limite');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('Publicité', 'Francine Francine', 'CAD$24,999');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('KREM', 'Genevieve Genevieve', 'CAD$24,999');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('TI', 'Lorraine Lorraine', 'Sans Limite');
INSERT INTO "main"."departements_test" ("departement", "approbe_par", "montant") VALUES ('BI', 'Lorraine Lorraine', 'CAD$24,999');


CREATE VIEW administration AS SELECT * FROM departements_test WHERE departement='Administration';
CREATE VIEW bi AS SELECT * FROM departements_test WHERE departement='BI';
CREATE VIEW c_humain AS SELECT * FROM departements_test WHERE departement='Capital humain';
CREATE VIEW editorial AS SELECT * FROM departements_test WHERE departement='Éditorial';
CREATE VIEW finance AS SELECT * FROM departements_test WHERE departement='Finance';
CREATE VIEW information AS SELECT * FROM departements_test WHERE departement='Information';
CREATE VIEW nuglif AS SELECT * FROM departements_test WHERE departement='Nuglif';
CREATE VIEW p_numeriques AS SELECT * FROM departements_test WHERE departement='Produits Numériques';
CREATE VIEW publicite AS SELECT * FROM departements_test WHERE departement='Publicité';
CREATE VIEW ti AS SELECT * FROM departements_test WHERE departement='TI';
CREATE VIEW editeur AS SELECT * FROM departements_test WHERE departement='Éditeur';


INSERT INTO "main"."liste_de_po_test" ("numero_de_po","fournisseur","demande_par","description","commentaire","statut") VALUES ('XX59590','KREM','Louise Pasroch','Soumission CA-QUO-1X2V75','','Complet');
INSERT INTO "main"."liste_de_po_test" ("numero_de_po","fournisseur","demande_par","description","commentaire","statut") VALUES ('XX59591','Animation','Adrian Arbre','20X2365W7.1632-01','','Complet');
INSERT INTO "main"."liste_de_po_test" ("numero_de_po","fournisseur","demande_par","description","commentaire","statut") VALUES ('XX59592','KAZ corp','Richter Francois','21S225M366','','Complet');

CREATE VIEW liste_complet AS SELECT * FROM liste_de_po_test WHERE statut='Complet';
CREATE VIEW liste_partiel AS SELECT * FROM liste_de_po_test WHERE statut='Partiel';

CREATE VIEW liste_tout AS
SELECT
"numero_de_po","fournisseur","demande_par","description","commentaire","statut", departements_test.approbe_par
FROM liste_de_po_test
INNER JOIN departements_test ON departements_test.id = liste_de_po_test.approbe_par;