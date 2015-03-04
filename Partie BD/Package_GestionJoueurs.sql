-- Creation du Package

create or replace PACKAGE GESTIONJOUEURS AS 

TYPE CURSEURJOUEUR IS REF CURSOR;

PROCEDURE SUPPRESSIONJOUEUR(USERNAME IN JOUEURS.NOMJOUEUR%TYPE);
  
PROCEDURE INSERTIONJOUEUR(USERNAME IN JOUEURS.NOMJOUEUR%TYPE);

END GESTIONJOUEURS;

-- Body du Package

create or replace PACKAGE BODY GESTIONJOUEURS AS

PROCEDURE INSERTIONJOUEUR(USERNAME IN JOUEURS.NOMJOUEUR%TYPE) AS
  BEGIN
   insert into joueurs(NOMJOUEUR) values (username);
  commit; 
  END INSERTIONJOUEUR;
  
  PROCEDURE SUPPRESSIONJOUEUR(USERNAME IN JOUEURS.NOMJOUEUR%TYPE) AS
  BEGIN
    delete from joueurs where nomjoueur = username; 
    commit; 
  END SUPPRESSIONJOUEUR;

END GESTIONJOUEURS;