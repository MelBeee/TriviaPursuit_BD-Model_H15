-- Creation du Package

create or replace PACKAGE GESTIONQUESTIONS AS 

TYPE CURSEURQUESTIONS IS REF CURSOR;

PROCEDURE INSERTIONQUESTIONS(PDESCRIPTION in QUESTIONS.DESCRIPTION%TYPE,PCHOIX1 in QUESTIONS.CHOIX1%TYPE,PCHOIX2 in QUESTIONS.CHOIX2%TYPE,PCHOIX3 in QUESTIONS.CHOIX3%TYPE,PREPONSE IN QUESTIONS.REPONSE%TYPE,PNOMCATEGORIE IN QUESTIONS.NomCategorie%TYPE); 

PROCEDURE SUPPRIMERQUESTIONS(PIDQUESTIONS IN QUESTIONS.IDQUESTION%TYPE);

FUNCTION LISTER(PNOMCATEGORIE IN QUESTIONS.NOMCATEGORIE%TYPE) return CURSEURQUESTIONS;

END GESTIONQUESTIONS;

-- Body du Package

create or replace PACKAGE BODY GESTIONQUESTIONS AS

  PROCEDURE INSERTIONQUESTIONS(PDESCRIPTION in QUESTIONS.DESCRIPTION%TYPE,PCHOIX1 in QUESTIONS.CHOIX1%TYPE,PCHOIX2 in QUESTIONS.CHOIX2%TYPE,PCHOIX3 in QUESTIONS.CHOIX3%TYPE,PREPONSE IN QUESTIONS.REPONSE%TYPE,PNOMCATEGORIE IN QUESTIONS.NomCategorie%TYPE) AS
  BEGIN
    INSERT INTO QUESTIONS(IDQUESTION,DESCRIPTION,CHOIX1,CHOIX2,CHOIX3,REPONSE,NOMCATEGORIE) VALUES(QUESTIONSEQ.NEXTVAL,PDESCRIPTION,PCHOIX1,PCHOIX2,PCHOIX3,PREPONSE,PNOMCATEGORIE);
    commit;
  END INSERTIONQUESTIONS;

  PROCEDURE SUPPRIMERQUESTIONS(PIDQUESTIONS IN QUESTIONS.IDQUESTION%TYPE) AS
  BEGIN
    DELETE FROM QUESTIONS WHERE IDQUESTION=PIDQUESTIONS;
    commit;
  END SUPPRIMERQUESTIONS;
  
  FUNCTION LISTER(PNOMCATEGORIE IN QUESTIONS.NOMCATEGORIE%TYPE) return CURSEURQUESTIONS AS
  NEWQUESTIONS CURSEURQUESTIONS;
  
  BEGIN
  
  OPEN NEWQUESTIONS FOR SELECT IDQUESTION,CHOIX1,CHOIX2,CHOIX3,DESCRIPTION,REPONSE FROM QUESTIONS WHERE NOMCATEGORIE=PNOMCATEGORIE;
    -- TODO : impl�mentation requise pour FUNCTION GESTIONEMPLOYES.LISTER
    RETURN NEWQUESTIONS;
    
  END LISTER;
  

END GESTIONQUESTIONS;