--------------------------------------------------------
--  File created - poniedzia³ek-czerwca-03-2019   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table BADANIA
--------------------------------------------------------

  CREATE TABLE "BAZA"."BADANIA" 
   (	"ID_BADANIA" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"TYP" VARCHAR2(50 BYTE), 
	"PODTYP" VARCHAR2(50 BYTE), 
	"NAZWA" VARCHAR2(60 BYTE), 
	"CENA" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table CHOROBY
--------------------------------------------------------

  CREATE TABLE "BAZA"."CHOROBY" 
   (	"ID_CHOROBY" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NAZWA" VARCHAR2(30 BYTE), 
	"TYP" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table KARTABADAN
--------------------------------------------------------

  CREATE TABLE "BAZA"."KARTABADAN" 
   (	"ID_KARTABADAN" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ID_PACJENTA" NUMBER(*,0), 
	"ID_BADANIA" NUMBER(*,0), 
	"TERMIN_BADANIA" DATE, 
	"DATA_REJESTRACJI" DATE
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table LEKARSTWA_RECEPTY
--------------------------------------------------------

  CREATE TABLE "BAZA"."LEKARSTWA_RECEPTY" 
   (	"ID" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ID_RECEPTY" NUMBER(*,0), 
	"ID_LEKARSTWA" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table LEKARZE
--------------------------------------------------------

  CREATE TABLE "BAZA"."LEKARZE" 
   (	"ID_LEKARZA" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"IMIÊ" VARCHAR2(20 BYTE), 
	"NAZWISKO" VARCHAR2(20 BYTE), 
	"SPECJALIZACJA" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table LEKI
--------------------------------------------------------

  CREATE TABLE "BAZA"."LEKI" 
   (	"ID_LEKARSTWA" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NAZWA" VARCHAR2(20 BYTE), 
	"OPIS" VARCHAR2(300 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table PACJENCI
--------------------------------------------------------

  CREATE TABLE "BAZA"."PACJENCI" 
   (	"ID_PACJENTA" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"IMIÊ" VARCHAR2(20 BYTE), 
	"NAZWISKO" VARCHAR2(20 BYTE), 
	"PESEL" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table RECEPTY
--------------------------------------------------------

  CREATE TABLE "BAZA"."RECEPTY" 
   (	"ID_RECEPTY" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"PUSTA" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table WIZYTY
--------------------------------------------------------

  CREATE TABLE "BAZA"."WIZYTY" 
   (	"ID_WIZYTY" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"DATA_REJESTRACJI" DATE, 
	"DATA_WIZYTY" DATE, 
	"ID_LEKARZA" NUMBER(*,0), 
	"ID_PACJENTA" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table WIZYTY_CHOROBY
--------------------------------------------------------

  CREATE TABLE "BAZA"."WIZYTY_CHOROBY" 
   (	"ID" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ID_CHOROBY" NUMBER(*,0), 
	"ID_WIZYTY" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table WIZYTY_RECEPTY
--------------------------------------------------------

  CREATE TABLE "BAZA"."WIZYTY_RECEPTY" 
   (	"ID" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ID_RECEPTY" NUMBER(*,0), 
	"ID_WIZYTY" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Sequence INKREMENTACJA_ID
--------------------------------------------------------

   CREATE SEQUENCE  "BAZA"."INKREMENTACJA_ID"  MINVALUE 1 MAXVALUE 9999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
REM INSERTING into BAZA.BADANIA
SET DEFINE OFF;
Insert into BAZA.BADANIA (ID_BADANIA,TYP,PODTYP,NAZWA,CENA) values ('4','badanie','dasdas','Testowe','20');
REM INSERTING into BAZA.CHOROBY
SET DEFINE OFF;
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('25','Dehydratacja','Uk³ad ruchowy');
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('22','Dusznica bolesna','Uk³ad kr¹¿enia');
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('23','Pylica p³uc','Uk³ad oddechowy');
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('24','Kolka jelitowa','Uk³ad pokarmowy');
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('26','Osteoporoza','Uk³ad ruchowy');
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('27','GruŸlica','ZakaŸna');
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('28','Ró¿yczka','ZakaŸna');
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('29','Paradontoza','Jama ustna');
Insert into BAZA.CHOROBY (ID_CHOROBY,NAZWA,TYP) values ('30','Choroba popromienna','Inne');
REM INSERTING into BAZA.KARTABADAN
SET DEFINE OFF;
REM INSERTING into BAZA.LEKARSTWA_RECEPTY
SET DEFINE OFF;
Insert into BAZA.LEKARSTWA_RECEPTY (ID,ID_RECEPTY,ID_LEKARSTWA) values ('2','3','21');
Insert into BAZA.LEKARSTWA_RECEPTY (ID,ID_RECEPTY,ID_LEKARSTWA) values ('3','4','21');
Insert into BAZA.LEKARSTWA_RECEPTY (ID,ID_RECEPTY,ID_LEKARSTWA) values ('5','6','21');
Insert into BAZA.LEKARSTWA_RECEPTY (ID,ID_RECEPTY,ID_LEKARSTWA) values ('1',null,null);
Insert into BAZA.LEKARSTWA_RECEPTY (ID,ID_RECEPTY,ID_LEKARSTWA) values ('4','5','21');
Insert into BAZA.LEKARSTWA_RECEPTY (ID,ID_RECEPTY,ID_LEKARSTWA) values ('6','7','30');
REM INSERTING into BAZA.LEKARZE
SET DEFINE OFF;
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('41','Micha³','Lipecki','Okulistya');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('21','Kamil','Wolañski','Chirurg');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('42','Marek','Robek','Kardiochirurg');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('43','Robert','Hryczyñski','Psychiatra');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('44','Zbigniew','Grawik','Ortopeda');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('45','Wiktor','Suwald','Neurolog');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('46','Jadwiga','Filecka','Dermatolog');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('47','Aleksandra','Nowakowska','Ginekolog');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('48','Karol','Laskowski','Anastezjolog');
Insert into BAZA.LEKARZE (ID_LEKARZA,"IMIÊ",NAZWISKO,SPECJALIZACJA) values ('49','Jakub','Bukowski','Chirurg plastyczny');
REM INSERTING into BAZA.LEKI
SET DEFINE OFF;
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('21','Dexak','Lek Dexak stosowany jest w leczeniu bólu. W³aœciwoœci preparatu opieraj¹ siê o dzia³anie substancji czynnej, któr¹ jest deksketoprofen.');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('23','Kodeina','Kodeina (3-metylomorfina) jest lekiem nale¿¹cym do opioidów. Choæ s³ynie z dzia³ania przeciwbólowego, ma tak¿e inne zastosowania w farmakologii, np. jako œrodek o dzia³aniu przeciwkaszlowym (w mniejszych dawkach). ');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('24','Emanera','Emanera to lek wydawany na receptê, który hamuje wydzielanie kwasu solnego w ¿o³¹dku. Przeznaczony jest dla pacjentów doros³ych oraz dzieci powy¿ej 12 lat.');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('25','Flavobil','Stosowany pomocniczo w zaburzeniach ukrwienia mózgu (zawroty i bóle g³owy, szum w uszach, os³abienie pamiêci, pogorszenie koncentracji i zdolnoœci intelektualnych) i zaburzeniach kr¹¿enia obwodowego w obrêbie koñczyn dolnych (chromanie przestankowe, bóle, zaburzenia czucia, mrowienie).');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('26','Arthrotec','Arthrotec jest lekiem typu „dwa w jednym”: dzia³a przeciwbólowo i przeciwzapalnie a jednoczeœnie dzia³a os³onowo, wiêc chroni ¿o³¹dek przed niepo¿¹danymi skutkami za¿ywania tego leku. Posiada dwie substancje czynne: diklofenak i mizoprostol.');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('27','Espiro','Espiro to lek o dzia³aniu moczopêdnym, który zawiera eplerenon. Przeznaczony jest dla osób doros³ych, natomiast nie powinny go przyjmowaæ dzieci oraz m³odzie¿ – bez wzglêdu na wiek.');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('28','Lactoral','Lactoral stosowany jest w celu przywrócenia i/lub uzupe³nienia prawid³owej flory bakteryjnej przewodu pokarmowego w stanach wskazuj¹cych na zaburzenia mikroflory spowodowanych np. stosowaniem antybiotyków. ');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('29','Deprim','Deprim to lek stosowany w medycynie rodzinnej w terapii lekkich stanów depresyjnych i chwiejnego nastroju. Preparat oddzia³uje na oœrodkowy uk³ad nerwowy, poprawia nastrój i zmniejsza napiêcie nerwowe.');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('30','Naraya','Doustny preparat antykoncepcyjny, sk³adaj¹cy siê z dwóch sk³adników: drospirenonu (progestagen) i etynyloestradiolu (syntetyczny estrogen).');
Insert into BAZA.LEKI (ID_LEKARSTWA,NAZWA,OPIS) values ('32','Monural','Monural to lek stosowany w urologii do leczenia ostrych zapaleñ pêcherza moczowego oraz w zapobieganiu chorobom dróg moczowych.');
REM INSERTING into BAZA.PACJENCI
SET DEFINE OFF;
Insert into BAZA.PACJENCI (ID_PACJENTA,"IMIÊ",NAZWISKO,PESEL) values ('21','Amelia','Kopeæ','92071314764');
Insert into BAZA.PACJENCI (ID_PACJENTA,"IMIÊ",NAZWISKO,PESEL) values ('22','Jan','D¹browski','98042308336');
Insert into BAZA.PACJENCI (ID_PACJENTA,"IMIÊ",NAZWISKO,PESEL) values ('23','Lena','Kowalska','85052248319');
Insert into BAZA.PACJENCI (ID_PACJENTA,"IMIÊ",NAZWISKO,PESEL) values ('24','Monika','Lipiñska','95061446318');
Insert into BAZA.PACJENCI (ID_PACJENTA,"IMIÊ",NAZWISKO,PESEL) values ('25','Mateusz','Krupa','66060144861');
Insert into BAZA.PACJENCI (ID_PACJENTA,"IMIÊ",NAZWISKO,PESEL) values ('26','Patryk','Wojciechowski','74120399441');
Insert into BAZA.PACJENCI (ID_PACJENTA,"IMIÊ",NAZWISKO,PESEL) values ('27','Maciej','B¹k','87121265412');
Insert into BAZA.PACJENCI (ID_PACJENTA,"IMIÊ",NAZWISKO,PESEL) values ('28','Micha³','Majda','98042904319');
REM INSERTING into BAZA.RECEPTY
SET DEFINE OFF;
Insert into BAZA.RECEPTY (ID_RECEPTY,PUSTA) values ('2',null);
Insert into BAZA.RECEPTY (ID_RECEPTY,PUSTA) values ('3',null);
Insert into BAZA.RECEPTY (ID_RECEPTY,PUSTA) values ('4',null);
Insert into BAZA.RECEPTY (ID_RECEPTY,PUSTA) values ('6',null);
Insert into BAZA.RECEPTY (ID_RECEPTY,PUSTA) values ('1',null);
Insert into BAZA.RECEPTY (ID_RECEPTY,PUSTA) values ('5',null);
Insert into BAZA.RECEPTY (ID_RECEPTY,PUSTA) values ('7',null);
REM INSERTING into BAZA.WIZYTY
SET DEFINE OFF;
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('23',to_date('19/06/03','RR/MM/DD'),to_date('19/06/29','RR/MM/DD'),'41','21');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('24',to_date('19/06/03','RR/MM/DD'),to_date('19/06/03','RR/MM/DD'),'41','21');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('25',to_date('19/06/03','RR/MM/DD'),to_date('19/06/03','RR/MM/DD'),'41','21');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('41',to_date('19/06/03','RR/MM/DD'),to_date('19/06/03','RR/MM/DD'),'41','21');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('42',to_date('19/06/03','RR/MM/DD'),to_date('19/06/03','RR/MM/DD'),'41','21');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('43',to_date('19/06/03','RR/MM/DD'),to_date('19/06/03','RR/MM/DD'),'47','21');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('45',to_date('19/06/03','RR/MM/DD'),to_date('19/06/03','RR/MM/DD'),'41','21');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('22',to_date('12/03/16','RR/MM/DD'),to_date('13/03/16','RR/MM/DD'),'45','25');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('44',to_date('19/06/03','RR/MM/DD'),to_date('19/06/03','RR/MM/DD'),'41','21');
Insert into BAZA.WIZYTY (ID_WIZYTY,DATA_REJESTRACJI,DATA_WIZYTY,ID_LEKARZA,ID_PACJENTA) values ('46',to_date('19/06/03','RR/MM/DD'),to_date('19/06/03','RR/MM/DD'),'41','28');
REM INSERTING into BAZA.WIZYTY_CHOROBY
SET DEFINE OFF;
Insert into BAZA.WIZYTY_CHOROBY (ID,ID_CHOROBY,ID_WIZYTY) values ('2','25','42');
Insert into BAZA.WIZYTY_CHOROBY (ID,ID_CHOROBY,ID_WIZYTY) values ('3','25','43');
Insert into BAZA.WIZYTY_CHOROBY (ID,ID_CHOROBY,ID_WIZYTY) values ('5','25','45');
Insert into BAZA.WIZYTY_CHOROBY (ID,ID_CHOROBY,ID_WIZYTY) values ('1',null,null);
Insert into BAZA.WIZYTY_CHOROBY (ID,ID_CHOROBY,ID_WIZYTY) values ('4','25','44');
Insert into BAZA.WIZYTY_CHOROBY (ID,ID_CHOROBY,ID_WIZYTY) values ('6','25','46');
REM INSERTING into BAZA.WIZYTY_RECEPTY
SET DEFINE OFF;
Insert into BAZA.WIZYTY_RECEPTY (ID,ID_RECEPTY,ID_WIZYTY) values ('2','3','42');
Insert into BAZA.WIZYTY_RECEPTY (ID,ID_RECEPTY,ID_WIZYTY) values ('3','4','43');
Insert into BAZA.WIZYTY_RECEPTY (ID,ID_RECEPTY,ID_WIZYTY) values ('5','6','45');
Insert into BAZA.WIZYTY_RECEPTY (ID,ID_RECEPTY,ID_WIZYTY) values ('1',null,null);
Insert into BAZA.WIZYTY_RECEPTY (ID,ID_RECEPTY,ID_WIZYTY) values ('4','5','44');
Insert into BAZA.WIZYTY_RECEPTY (ID,ID_RECEPTY,ID_WIZYTY) values ('6','7','46');
--------------------------------------------------------
--  DDL for Index BADANIA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."BADANIA_PK" ON "BAZA"."BADANIA" ("ID_BADANIA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index CHOROBY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."CHOROBY_PK" ON "BAZA"."CHOROBY" ("ID_CHOROBY") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index KARTABADAN_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."KARTABADAN_PK" ON "BAZA"."KARTABADAN" ("ID_KARTABADAN") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index LEKARSTWA_RECEPTY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."LEKARSTWA_RECEPTY_PK" ON "BAZA"."LEKARSTWA_RECEPTY" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index LEKARZE2_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."LEKARZE2_PK" ON "BAZA"."LEKARZE" ("ID_LEKARZA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index LEKI_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."LEKI_PK" ON "BAZA"."LEKI" ("ID_LEKARSTWA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PACJENCI_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."PACJENCI_PK" ON "BAZA"."PACJENCI" ("ID_PACJENTA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index RECEPTY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."RECEPTY_PK" ON "BAZA"."RECEPTY" ("ID_RECEPTY") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index WIZYTY_CHOROBY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."WIZYTY_CHOROBY_PK" ON "BAZA"."WIZYTY_CHOROBY" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index WIZYTY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."WIZYTY_PK" ON "BAZA"."WIZYTY" ("ID_WIZYTY") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index WIZYTY_RECEPTY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BAZA"."WIZYTY_RECEPTY_PK" ON "BAZA"."WIZYTY_RECEPTY" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Package BADANIA_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."BADANIA_TAPI" 
is

type BADANIA_tapi_rec is record (
ID_BADANIA  BADANIA.ID_BADANIA%type
,TYP  BADANIA.TYP%type
,CENA  BADANIA.CENA%type
,PODTYP  BADANIA.PODTYP%type
,NAZWA  BADANIA.NAZWA%type
);
type BADANIA_tapi_tab is table of BADANIA_tapi_rec;

-- insert
procedure ins (
p_TYP in BADANIA.TYP%type default null 
,p_CENA in BADANIA.CENA%type default null 
,p_PODTYP in BADANIA.PODTYP%type default null 
,p_NAZWA in BADANIA.NAZWA%type default null 
);
-- update
procedure upd (
p_ID_BADANIA in BADANIA.ID_BADANIA%type
,p_TYP in BADANIA.TYP%type default null 
,p_CENA in BADANIA.CENA%type default null 
,p_PODTYP in BADANIA.PODTYP%type default null 
,p_NAZWA in BADANIA.NAZWA%type default null 
);
-- delete
procedure del (
p_ID_BADANIA in BADANIA.ID_BADANIA%type
);

procedure  wyswietl_Badania(
ACursor out sys_refcursor );
end BADANIA_tapi;

/
--------------------------------------------------------
--  DDL for Package CHOROBY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."CHOROBY_TAPI" 
is

type CHOROBY_tapi_rec is record (
ID_CHOROBY  CHOROBY.ID_CHOROBY%type
,TYP  CHOROBY.TYP%type
,NAZWA  CHOROBY.NAZWA%type
);
type CHOROBY_tapi_tab is table of CHOROBY_tapi_rec;

-- insert
procedure ins (
p_TYP in CHOROBY.TYP%type default null 
,p_NAZWA in CHOROBY.NAZWA%type
);
-- update
procedure upd (
p_ID_CHOROBY in CHOROBY.ID_CHOROBY%type
,p_TYP in CHOROBY.TYP%type default null 
,p_NAZWA in CHOROBY.NAZWA%type
);
-- delete
procedure del (
p_ID_CHOROBY in CHOROBY.ID_CHOROBY%type
);

--wyswietl
procedure  wyswietl_Choroby(
ACursor out sys_refcursor );
end CHOROBY_tapi;

/
--------------------------------------------------------
--  DDL for Package KARTABADAN_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."KARTABADAN_TAPI" 
is

type KARTABADAN_tapi_rec is record (
ID_BADANIA  KARTABADAN.ID_BADANIA%type
,TERMIN_BADANIA  KARTABADAN.TERMIN_BADANIA%type
,ID_KARTABADAN  KARTABADAN.ID_KARTABADAN%type
,ID_PACJENTA  KARTABADAN.ID_PACJENTA%type
,DATA_REJESTRACJI  KARTABADAN.DATA_REJESTRACJI%type
);
type KARTABADAN_tapi_tab is table of KARTABADAN_tapi_rec;

-- insert
procedure ins (
p_ID_BADANIA in KARTABADAN.ID_BADANIA%type
,p_TERMIN_BADANIA in KARTABADAN.TERMIN_BADANIA%type
,p_ID_PACJENTA in KARTABADAN.ID_PACJENTA%type
,p_DATA_REJESTRACJI in KARTABADAN.DATA_REJESTRACJI%type
);
-- update
procedure upd (
p_ID_BADANIA in KARTABADAN.ID_BADANIA%type
,p_TERMIN_BADANIA in KARTABADAN.TERMIN_BADANIA%type
,p_ID_KARTABADAN in KARTABADAN.ID_KARTABADAN%type
,p_ID_PACJENTA in KARTABADAN.ID_PACJENTA%type
,p_DATA_REJESTRACJI in KARTABADAN.DATA_REJESTRACJI%type
);
-- delete
procedure del (
p_ID_KARTABADAN in KARTABADAN.ID_KARTABADAN%type
);
--wyswietl
procedure  wyswietl_KarteBadan(
ACursor out sys_refcursor );
end KARTABADAN_tapi;

/
--------------------------------------------------------
--  DDL for Package LEKARSTWA_RECEPTY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."LEKARSTWA_RECEPTY_TAPI" 
is

type LEKARSTWA_RECEPTY_tapi_rec is record (
ID_RECEPTY  LEKARSTWA_RECEPTY.ID_RECEPTY%type
,ID_LEKARSTWA  LEKARSTWA_RECEPTY.ID_LEKARSTWA%type
,ID  LEKARSTWA_RECEPTY.ID%type
);
type LEKARSTWA_RECEPTY_tapi_tab is table of LEKARSTWA_RECEPTY_tapi_rec;

-- insert
procedure ins (
p_ID_RECEPTY in LEKARSTWA_RECEPTY.ID_RECEPTY%type default null 
,p_ID_LEKARSTWA in LEKARSTWA_RECEPTY.ID_LEKARSTWA%type default null 
);
-- update
procedure upd (
p_ID_RECEPTY in LEKARSTWA_RECEPTY.ID_RECEPTY%type default null 
,p_ID_LEKARSTWA in LEKARSTWA_RECEPTY.ID_LEKARSTWA%type default null 
,p_ID in LEKARSTWA_RECEPTY.ID%type
);
-- delete
procedure del (
p_ID in LEKARSTWA_RECEPTY.ID%type
);
end LEKARSTWA_RECEPTY_tapi;


/
--------------------------------------------------------
--  DDL for Package LEKARZE_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."LEKARZE_TAPI" 
is

type LEKARZE_tapi_rec is record (
ID_LEKARZA  LEKARZE.ID_LEKARZA%type
,IMIÊ  LEKARZE.IMIÊ%type
,SPECJALIZACJA  LEKARZE.SPECJALIZACJA%type
,NAZWISKO  LEKARZE.NAZWISKO%type
);
type LEKARZE_tapi_tab is table of LEKARZE_tapi_rec;

-- insert
procedure ins (
p_IMIÊ in LEKARZE.IMIÊ%type
,p_SPECJALIZACJA in LEKARZE.SPECJALIZACJA%type
,p_NAZWISKO in LEKARZE.NAZWISKO%type
);
-- update
procedure upd (
p_ID_LEKARZA in LEKARZE.ID_LEKARZA%type
,p_IMIÊ in LEKARZE.IMIÊ%type
,p_SPECJALIZACJA in LEKARZE.SPECJALIZACJA%type
,p_NAZWISKO in LEKARZE.NAZWISKO%type
);
-- delete
procedure del (
p_ID_LEKARZA in LEKARZE.ID_LEKARZA%type
);
--wyswietl
procedure  wyswietl_Lekarzy(
ACursor out sys_refcursor );
end LEKARZE_tapi;

/
--------------------------------------------------------
--  DDL for Package LEKI_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."LEKI_TAPI" 
is

type LEKI_tapi_rec is record (
ID_LEKARSTWA  LEKI.ID_LEKARSTWA%type
,NAZWA  LEKI.NAZWA%type
,OPIS  LEKI.OPIS%type
);
type LEKI_tapi_tab is table of LEKI_tapi_rec;

-- insert
procedure ins (
p_NAZWA in LEKI.NAZWA%type
,p_OPIS in LEKI.OPIS%type
);
-- update
procedure upd (
p_ID_LEKARSTWA in LEKI.ID_LEKARSTWA%type
,p_NAZWA in LEKI.NAZWA%type
,p_OPIS in LEKI.OPIS%type
);
-- delete
procedure del (
p_ID_LEKARSTWA in LEKI.ID_LEKARSTWA%type
);
--wyswietl
procedure  wyswietl_Leki(
ACursor out sys_refcursor );

procedure  getId_Leku(
p_NAZWA in LEKI.NAZWA%type,
ACursor out sys_refcursor);
end LEKI_tapi;

/
--------------------------------------------------------
--  DDL for Package PACJENCI_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."PACJENCI_TAPI" 
is

type PACJENCI_tapi_rec is record (
IMIÊ  PACJENCI.IMIÊ%type
,PESEL  PACJENCI.PESEL%type
,ID_PACJENTA  PACJENCI.ID_PACJENTA%type
,NAZWISKO  PACJENCI.NAZWISKO%type
);
type PACJENCI_tapi_tab is table of PACJENCI_tapi_rec;

-- insert
procedure ins (
p_IMIÊ in PACJENCI.IMIÊ%type
,p_PESEL in PACJENCI.PESEL%type
,p_NAZWISKO in PACJENCI.NAZWISKO%type
);
-- update
procedure upd (
p_IMIÊ in PACJENCI.IMIÊ%type
,p_PESEL in PACJENCI.PESEL%type
,p_ID_PACJENTA in PACJENCI.ID_PACJENTA%type
,p_NAZWISKO in PACJENCI.NAZWISKO%type
);
-- delete
procedure del (
p_ID_PACJENTA in PACJENCI.ID_PACJENTA%type
);
--wyswietl
procedure  wyswietl_Pacjentow(
ACursor out sys_refcursor );
end PACJENCI_tapi;

/
--------------------------------------------------------
--  DDL for Package RECEPTY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."RECEPTY_TAPI" 
is

type RECEPTY_tapi_rec is record (
ID_RECEPTY  RECEPTY.ID_RECEPTY%type
,PUSTA  RECEPTY.PUSTA%type
);
type RECEPTY_tapi_tab is table of RECEPTY_tapi_rec;

-- insert
procedure ins (
p_PUSTA in RECEPTY.PUSTA%type default null 
);
-- update
procedure upd (
p_ID_RECEPTY in RECEPTY.ID_RECEPTY%type
,p_PUSTA in RECEPTY.PUSTA%type default null 
);
-- delete
procedure del (
p_ID_RECEPTY in RECEPTY.ID_RECEPTY%type
);

procedure getMaxId (
ACursor out sys_refcursor
);
end RECEPTY_tapi;

/
--------------------------------------------------------
--  DDL for Package WIZYTY_CHOROBY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."WIZYTY_CHOROBY_TAPI" 
is

type WIZYTY_CHOROBY_tapi_rec is record (
ID_WIZYTY  WIZYTY_CHOROBY.ID_WIZYTY%type
,ID_CHOROBY  WIZYTY_CHOROBY.ID_CHOROBY%type
,ID  WIZYTY_CHOROBY.ID%type
);
type WIZYTY_CHOROBY_tapi_tab is table of WIZYTY_CHOROBY_tapi_rec;

-- insert
procedure ins (
p_ID_WIZYTY in WIZYTY_CHOROBY.ID_WIZYTY%type default null 
,p_ID_CHOROBY in WIZYTY_CHOROBY.ID_CHOROBY%type default null 
);
-- update
procedure upd (
p_ID_WIZYTY in WIZYTY_CHOROBY.ID_WIZYTY%type default null 
,p_ID_CHOROBY in WIZYTY_CHOROBY.ID_CHOROBY%type default null 
,p_ID in WIZYTY_CHOROBY.ID%type
);
-- delete
procedure del (
p_ID in WIZYTY_CHOROBY.ID%type
);
end WIZYTY_CHOROBY_tapi;


/
--------------------------------------------------------
--  DDL for Package WIZYTY_RECEPTY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."WIZYTY_RECEPTY_TAPI" 
is

type WIZYTY_RECEPTY_tapi_rec is record (
ID_RECEPTY  WIZYTY_RECEPTY.ID_RECEPTY%type
,ID_WIZYTY  WIZYTY_RECEPTY.ID_WIZYTY%type
,ID  WIZYTY_RECEPTY.ID%type
);
type WIZYTY_RECEPTY_tapi_tab is table of WIZYTY_RECEPTY_tapi_rec;

-- insert
procedure ins (
p_ID_RECEPTY in WIZYTY_RECEPTY.ID_RECEPTY%type default null 
,p_ID_WIZYTY in WIZYTY_RECEPTY.ID_WIZYTY%type default null 
);
-- update
procedure upd (
p_ID_RECEPTY in WIZYTY_RECEPTY.ID_RECEPTY%type default null 
,p_ID_WIZYTY in WIZYTY_RECEPTY.ID_WIZYTY%type default null 
,p_ID in WIZYTY_RECEPTY.ID%type
);
-- delete
procedure del (
p_ID in WIZYTY_RECEPTY.ID%type
);
end WIZYTY_RECEPTY_tapi;


/
--------------------------------------------------------
--  DDL for Package WIZYTY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "BAZA"."WIZYTY_TAPI" 
is

type WIZYTY_tapi_rec is record (
ID_LEKARZA  WIZYTY.ID_LEKARZA%type
,DATA_WIZYTY  WIZYTY.DATA_WIZYTY%type
,ID_WIZYTY  WIZYTY.ID_WIZYTY%type
,ID_PACJENTA  WIZYTY.ID_PACJENTA%type
,DATA_REJESTRACJI  WIZYTY.DATA_REJESTRACJI%type
);
type WIZYTY_tapi_tab is table of WIZYTY_tapi_rec;

-- insert
procedure ins (
p_ID_LEKARZA in WIZYTY.ID_LEKARZA%type
,p_DATA_WIZYTY in WIZYTY.DATA_WIZYTY%type
,p_ID_PACJENTA in WIZYTY.ID_PACJENTA%type
,p_DATA_REJESTRACJI in WIZYTY.DATA_REJESTRACJI%type
);
-- update
procedure upd (
p_ID_LEKARZA in WIZYTY.ID_LEKARZA%type
,p_DATA_WIZYTY in WIZYTY.DATA_WIZYTY%type
,p_ID_WIZYTY in WIZYTY.ID_WIZYTY%type
,p_ID_PACJENTA in WIZYTY.ID_PACJENTA%type
,p_DATA_REJESTRACJI in WIZYTY.DATA_REJESTRACJI%type
);
-- delete
procedure del (
p_ID_WIZYTY in WIZYTY.ID_WIZYTY%type
);
--wyswietl
procedure  wyswietl_Wizyty(
ACursor out sys_refcursor );

procedure getMaxId (
ACursor out sys_refcursor
);
end WIZYTY_tapi;

/
--------------------------------------------------------
--  DDL for Package Body BADANIA_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."BADANIA_TAPI" 
is
-- insert
procedure ins (
p_TYP in BADANIA.TYP%type default null 
,p_CENA in BADANIA.CENA%type default null 
,p_PODTYP in BADANIA.PODTYP%type default null 
,p_NAZWA in BADANIA.NAZWA%type default null 
) is
begin
insert into BADANIA(
TYP
,CENA
,PODTYP
,NAZWA
) values (
p_TYP
,p_CENA
,p_PODTYP
,p_NAZWA
);end;
-- update
procedure upd (
p_ID_BADANIA in BADANIA.ID_BADANIA%type
,p_TYP in BADANIA.TYP%type default null 
,p_CENA in BADANIA.CENA%type default null 
,p_PODTYP in BADANIA.PODTYP%type default null 
,p_NAZWA in BADANIA.NAZWA%type default null 
) is
begin
update BADANIA set
TYP = p_TYP
,CENA = p_CENA
,PODTYP = p_PODTYP
,NAZWA = p_NAZWA
where ID_BADANIA = p_ID_BADANIA;
end;
-- del
procedure del (
p_ID_BADANIA in BADANIA.ID_BADANIA%type
) is
begin
delete from BADANIA
where ID_BADANIA = p_ID_BADANIA;
end;

procedure wyswietl_Badania(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    Select id_badania, typ, podtyp, nazwa, cena FROM BADANIA;
end;
end BADANIA_tapi;

/
--------------------------------------------------------
--  DDL for Package Body CHOROBY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."CHOROBY_TAPI" 
is
-- insert
procedure ins (
p_TYP in CHOROBY.TYP%type default null 
,p_NAZWA in CHOROBY.NAZWA%type
) is
begin
insert into CHOROBY(
TYP
,NAZWA
) values (
p_TYP
,p_NAZWA
);end;
-- update
procedure upd (
p_ID_CHOROBY in CHOROBY.ID_CHOROBY%type
,p_TYP in CHOROBY.TYP%type default null 
,p_NAZWA in CHOROBY.NAZWA%type
) is
begin
update CHOROBY set
TYP = p_TYP
,NAZWA = p_NAZWA
where ID_CHOROBY = p_ID_CHOROBY;
end;
-- del
procedure del (
p_ID_CHOROBY in CHOROBY.ID_CHOROBY%type
) is
begin
delete from CHOROBY
where ID_CHOROBY = p_ID_CHOROBY;
end;

procedure wyswietl_Choroby(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    Select id_choroby, nazwa, typ from Choroby;
end;
end CHOROBY_tapi;

/
--------------------------------------------------------
--  DDL for Package Body KARTABADAN_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."KARTABADAN_TAPI" 
is
-- insert
procedure ins (
p_ID_BADANIA in KARTABADAN.ID_BADANIA%type
,p_TERMIN_BADANIA in KARTABADAN.TERMIN_BADANIA%type
,p_ID_PACJENTA in KARTABADAN.ID_PACJENTA%type
,p_DATA_REJESTRACJI in KARTABADAN.DATA_REJESTRACJI%type
) is
begin
insert into KARTABADAN(
ID_BADANIA
,TERMIN_BADANIA
,ID_PACJENTA
,DATA_REJESTRACJI
) values (
p_ID_BADANIA
,p_TERMIN_BADANIA
,p_ID_PACJENTA
,p_DATA_REJESTRACJI
);end;
-- update
procedure upd (
p_ID_BADANIA in KARTABADAN.ID_BADANIA%type
,p_TERMIN_BADANIA in KARTABADAN.TERMIN_BADANIA%type
,p_ID_KARTABADAN in KARTABADAN.ID_KARTABADAN%type
,p_ID_PACJENTA in KARTABADAN.ID_PACJENTA%type
,p_DATA_REJESTRACJI in KARTABADAN.DATA_REJESTRACJI%type
) is
begin
update KARTABADAN set
ID_BADANIA = p_ID_BADANIA
,TERMIN_BADANIA = p_TERMIN_BADANIA
,ID_PACJENTA = p_ID_PACJENTA
,DATA_REJESTRACJI = p_DATA_REJESTRACJI
where ID_KARTABADAN = p_ID_KARTABADAN;
end;
-- del
procedure del (
p_ID_KARTABADAN in KARTABADAN.ID_KARTABADAN%type
) is
begin
delete from KARTABADAN
where ID_KARTABADAN = p_ID_KARTABADAN;
end;
procedure wyswietl_KarteBadan(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    Select ID_KARTABADAN, ID_PACJENTA, ID_BADANIA, DATA_REJESTRACJI, TERMIN_BADANIA FROM KARTABADAN;
end;
end KARTABADAN_tapi;

/
--------------------------------------------------------
--  DDL for Package Body LEKARSTWA_RECEPTY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."LEKARSTWA_RECEPTY_TAPI" 
is
-- insert
procedure ins (
p_ID_RECEPTY in LEKARSTWA_RECEPTY.ID_RECEPTY%type default null 
,p_ID_LEKARSTWA in LEKARSTWA_RECEPTY.ID_LEKARSTWA%type default null 
) is
begin
insert into LEKARSTWA_RECEPTY(
ID_RECEPTY
,ID_LEKARSTWA
) values (
p_ID_RECEPTY
,p_ID_LEKARSTWA
);end;
-- update
procedure upd (
p_ID_RECEPTY in LEKARSTWA_RECEPTY.ID_RECEPTY%type default null 
,p_ID_LEKARSTWA in LEKARSTWA_RECEPTY.ID_LEKARSTWA%type default null 
,p_ID in LEKARSTWA_RECEPTY.ID%type
) is
begin
update LEKARSTWA_RECEPTY set
ID_RECEPTY = p_ID_RECEPTY
,ID_LEKARSTWA = p_ID_LEKARSTWA
where ID = p_ID;
end;
-- del
procedure del (
p_ID in LEKARSTWA_RECEPTY.ID%type
) is
begin
delete from LEKARSTWA_RECEPTY
where ID = p_ID;
end;
end LEKARSTWA_RECEPTY_tapi;

/
--------------------------------------------------------
--  DDL for Package Body LEKARZE_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."LEKARZE_TAPI" 
is
-- insert
procedure ins (
p_IMIÊ in LEKARZE.IMIÊ%type
,p_SPECJALIZACJA in LEKARZE.SPECJALIZACJA%type
,p_NAZWISKO in LEKARZE.NAZWISKO%type
) is
begin
insert into LEKARZE(
IMIÊ
,SPECJALIZACJA
,NAZWISKO
) values (
p_IMIÊ
,p_SPECJALIZACJA
,p_NAZWISKO
);end;
-- update
procedure upd (
p_ID_LEKARZA in LEKARZE.ID_LEKARZA%type
,p_IMIÊ in LEKARZE.IMIÊ%type
,p_SPECJALIZACJA in LEKARZE.SPECJALIZACJA%type
,p_NAZWISKO in LEKARZE.NAZWISKO%type
) is
begin
update LEKARZE set
IMIÊ = p_IMIÊ
,SPECJALIZACJA = p_SPECJALIZACJA
,NAZWISKO = p_NAZWISKO
where ID_LEKARZA = p_ID_LEKARZA;
end;
-- del
procedure del (
p_ID_LEKARZA in LEKARZE.ID_LEKARZA%type
) is
begin
delete from LEKARZE
where ID_LEKARZA = p_ID_LEKARZA;
end;

procedure wyswietl_Lekarzy(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    Select ID_LEKARZA, IMIÊ, NAZWISKO, SPECJALIZACJA FROM LEKARZE;
end;
end LEKARZE_tapi;

/
--------------------------------------------------------
--  DDL for Package Body LEKI_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."LEKI_TAPI" 
is
-- insert
procedure ins (
p_NAZWA in LEKI.NAZWA%type
,p_OPIS in LEKI.OPIS%type
) is
begin
insert into LEKI(
NAZWA
,OPIS
) values (
p_NAZWA
,p_OPIS
);end;
-- update
procedure upd (
p_ID_LEKARSTWA in LEKI.ID_LEKARSTWA%type
,p_NAZWA in LEKI.NAZWA%type
,p_OPIS in LEKI.OPIS%type
) is
begin
update LEKI set
NAZWA = p_NAZWA
,OPIS = p_OPIS
where ID_LEKARSTWA = p_ID_LEKARSTWA;
end;
-- del
procedure del (
p_ID_LEKARSTWA in LEKI.ID_LEKARSTWA%type
) is
begin
delete from LEKI
where ID_LEKARSTWA = p_ID_LEKARSTWA;
end;

procedure wyswietl_Leki(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    Select id_lekarstwa, nazwa, opis FROM LEKI;
end;

procedure getId_Leku(
p_NAZWA in LEKI.NAZWA%type,
ACursor out sys_refcursor) is
begin
    open ACursor for
    Select id_lekarstwa FROM LEKI where NAZWA = p_NAZWA;
end;
end LEKI_tapi;

/
--------------------------------------------------------
--  DDL for Package Body PACJENCI_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."PACJENCI_TAPI" 
is
-- insert
procedure ins (
p_IMIÊ in PACJENCI.IMIÊ%type
,p_PESEL in PACJENCI.PESEL%type
,p_NAZWISKO in PACJENCI.NAZWISKO%type
) is
begin
insert into PACJENCI(
IMIÊ
,PESEL
,NAZWISKO
) values (
p_IMIÊ
,p_PESEL
,p_NAZWISKO
);end;
-- update
procedure upd (
p_IMIÊ in PACJENCI.IMIÊ%type
,p_PESEL in PACJENCI.PESEL%type
,p_ID_PACJENTA in PACJENCI.ID_PACJENTA%type
,p_NAZWISKO in PACJENCI.NAZWISKO%type
) is
begin
update PACJENCI set
IMIÊ = p_IMIÊ
,PESEL = p_PESEL
,NAZWISKO = p_NAZWISKO
where ID_PACJENTA = p_ID_PACJENTA;
end;
-- del
procedure del (
p_ID_PACJENTA in PACJENCI.ID_PACJENTA%type
) is
begin
delete from PACJENCI
where ID_PACJENTA = p_ID_PACJENTA;
end;

procedure wyswietl_Pacjentow(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    Select ID_PACJENTA, IMIÊ, NAZWISKO, PESEL FROM PACJENCI;
end;
end PACJENCI_tapi;

/
--------------------------------------------------------
--  DDL for Package Body RECEPTY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."RECEPTY_TAPI" 
is
-- insert
procedure ins (
p_PUSTA in RECEPTY.PUSTA%type default null 
) is
begin
insert into RECEPTY(
PUSTA
) values (
p_PUSTA
);end;
-- update
procedure upd (
p_ID_RECEPTY in RECEPTY.ID_RECEPTY%type
,p_PUSTA in RECEPTY.PUSTA%type default null 
) is
begin
update RECEPTY set
PUSTA = p_PUSTA
where ID_RECEPTY = p_ID_RECEPTY;
end;
-- del
procedure del (
p_ID_RECEPTY in RECEPTY.ID_RECEPTY%type
) is
begin
delete from RECEPTY
where ID_RECEPTY = p_ID_RECEPTY;
end;

procedure getMaxId(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    Select MAX(id_recepty) from recepty;
end;
end RECEPTY_tapi;

/
--------------------------------------------------------
--  DDL for Package Body WIZYTY_CHOROBY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."WIZYTY_CHOROBY_TAPI" 
is
-- insert
procedure ins (
p_ID_WIZYTY in WIZYTY_CHOROBY.ID_WIZYTY%type default null 
,p_ID_CHOROBY in WIZYTY_CHOROBY.ID_CHOROBY%type default null 
) is
begin
insert into WIZYTY_CHOROBY(
ID_WIZYTY
,ID_CHOROBY
) values (
p_ID_WIZYTY
,p_ID_CHOROBY
);end;
-- update
procedure upd (
p_ID_WIZYTY in WIZYTY_CHOROBY.ID_WIZYTY%type default null 
,p_ID_CHOROBY in WIZYTY_CHOROBY.ID_CHOROBY%type default null 
,p_ID in WIZYTY_CHOROBY.ID%type
) is
begin
update WIZYTY_CHOROBY set
ID_WIZYTY = p_ID_WIZYTY
,ID_CHOROBY = p_ID_CHOROBY
where ID = p_ID;
end;
-- del
procedure del (
p_ID in WIZYTY_CHOROBY.ID%type
) is
begin
delete from WIZYTY_CHOROBY
where ID = p_ID;
end;
end WIZYTY_CHOROBY_tapi;

/
--------------------------------------------------------
--  DDL for Package Body WIZYTY_RECEPTY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."WIZYTY_RECEPTY_TAPI" 
is
-- insert
procedure ins (
p_ID_RECEPTY in WIZYTY_RECEPTY.ID_RECEPTY%type default null 
,p_ID_WIZYTY in WIZYTY_RECEPTY.ID_WIZYTY%type default null 
) is
begin
insert into WIZYTY_RECEPTY(
ID_RECEPTY
,ID_WIZYTY
) values (
p_ID_RECEPTY
,p_ID_WIZYTY
);end;
-- update
procedure upd (
p_ID_RECEPTY in WIZYTY_RECEPTY.ID_RECEPTY%type default null 
,p_ID_WIZYTY in WIZYTY_RECEPTY.ID_WIZYTY%type default null 
,p_ID in WIZYTY_RECEPTY.ID%type
) is
begin
update WIZYTY_RECEPTY set
ID_RECEPTY = p_ID_RECEPTY
,ID_WIZYTY = p_ID_WIZYTY
where ID = p_ID;
end;
-- del
procedure del (
p_ID in WIZYTY_RECEPTY.ID%type
) is
begin
delete from WIZYTY_RECEPTY
where ID = p_ID;
end;
end WIZYTY_RECEPTY_tapi;

/
--------------------------------------------------------
--  DDL for Package Body WIZYTY_TAPI
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "BAZA"."WIZYTY_TAPI" 
is
-- insert
procedure ins (
p_ID_LEKARZA in WIZYTY.ID_LEKARZA%type
,p_DATA_WIZYTY in WIZYTY.DATA_WIZYTY%type
,p_ID_PACJENTA in WIZYTY.ID_PACJENTA%type
,p_DATA_REJESTRACJI in WIZYTY.DATA_REJESTRACJI%type
) is
begin
insert into WIZYTY(
ID_LEKARZA
,DATA_WIZYTY
,ID_PACJENTA
,DATA_REJESTRACJI
) values (
p_ID_LEKARZA
,p_DATA_WIZYTY
,p_ID_PACJENTA
,p_DATA_REJESTRACJI
);end;
-- update
procedure upd (
p_ID_LEKARZA in WIZYTY.ID_LEKARZA%type
,p_DATA_WIZYTY in WIZYTY.DATA_WIZYTY%type
,p_ID_WIZYTY in WIZYTY.ID_WIZYTY%type
,p_ID_PACJENTA in WIZYTY.ID_PACJENTA%type
,p_DATA_REJESTRACJI in WIZYTY.DATA_REJESTRACJI%type
) is
begin
update WIZYTY set
ID_LEKARZA = p_ID_LEKARZA
,DATA_WIZYTY = p_DATA_WIZYTY
,ID_PACJENTA = p_ID_PACJENTA
,DATA_REJESTRACJI = p_DATA_REJESTRACJI
where ID_WIZYTY = p_ID_WIZYTY;
end;
-- del
procedure del (
p_ID_WIZYTY in WIZYTY.ID_WIZYTY%type
) is
begin
delete from WIZYTY
where ID_WIZYTY = p_ID_WIZYTY;
end;
procedure wyswietl_Wizyty(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    select w.id_wizyty, w.data_rejestracji, w.data_wizyty, l.imiê as "Imiê Lekarza", l.nazwisko as "Nazwisko Lekarza", p.imiê as "Imiê Pacjenta", p.nazwisko as "Nazwisko Pacjenta",
    ch.nazwa as "Nazwa choroby", wr.id_recepty
    from wizyty w 
    inner join lekarze l on w.ID_LEKARZA = l.id_lekarza
    inner join pacjenci p on w.id_pacjenta = p.id_pacjenta
    inner join Wizyty_Choroby wc on w.ID_WIZYTY = wc.ID_WIZYTY
    inner join Choroby ch on ch.ID_CHOROBY = wc.ID_CHOROBY
    inner join Wizyty_recepty wr on w.ID_WIZYTY = wr.ID_WIZYTY;
end;

procedure getMaxId(
ACursor out sys_refcursor ) is
begin
    open ACursor for
    Select MAX(id_wizyty) from wizyty;
end;
end WIZYTY_tapi;

/
--------------------------------------------------------
--  Constraints for Table BADANIA
--------------------------------------------------------

  ALTER TABLE "BAZA"."BADANIA" MODIFY ("ID_BADANIA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."BADANIA" ADD CONSTRAINT "BADANIA_PK" PRIMARY KEY ("ID_BADANIA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table LEKARSTWA_RECEPTY
--------------------------------------------------------

  ALTER TABLE "BAZA"."LEKARSTWA_RECEPTY" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."LEKARSTWA_RECEPTY" ADD CONSTRAINT "LEKARSTWA_RECEPTY_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table KARTABADAN
--------------------------------------------------------

  ALTER TABLE "BAZA"."KARTABADAN" MODIFY ("ID_KARTABADAN" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."KARTABADAN" MODIFY ("ID_PACJENTA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."KARTABADAN" MODIFY ("ID_BADANIA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."KARTABADAN" MODIFY ("TERMIN_BADANIA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."KARTABADAN" MODIFY ("DATA_REJESTRACJI" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."KARTABADAN" ADD CONSTRAINT "KARTABADAN_PK" PRIMARY KEY ("ID_KARTABADAN")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table PACJENCI
--------------------------------------------------------

  ALTER TABLE "BAZA"."PACJENCI" MODIFY ("ID_PACJENTA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."PACJENCI" MODIFY ("IMIÊ" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."PACJENCI" MODIFY ("NAZWISKO" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."PACJENCI" MODIFY ("PESEL" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."PACJENCI" ADD CONSTRAINT "PACJENCI_PK" PRIMARY KEY ("ID_PACJENTA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "BAZA"."PACJENCI" ADD UNIQUE ("PESEL")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CHOROBY
--------------------------------------------------------

  ALTER TABLE "BAZA"."CHOROBY" MODIFY ("ID_CHOROBY" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."CHOROBY" MODIFY ("NAZWA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."CHOROBY" ADD CONSTRAINT "CHOROBY_PK" PRIMARY KEY ("ID_CHOROBY")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table WIZYTY_RECEPTY
--------------------------------------------------------

  ALTER TABLE "BAZA"."WIZYTY_RECEPTY" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."WIZYTY_RECEPTY" ADD CONSTRAINT "WIZYTY_RECEPTY_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table WIZYTY_CHOROBY
--------------------------------------------------------

  ALTER TABLE "BAZA"."WIZYTY_CHOROBY" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."WIZYTY_CHOROBY" ADD CONSTRAINT "WIZYTY_CHOROBY_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table LEKARZE
--------------------------------------------------------

  ALTER TABLE "BAZA"."LEKARZE" MODIFY ("ID_LEKARZA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."LEKARZE" MODIFY ("IMIÊ" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."LEKARZE" MODIFY ("NAZWISKO" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."LEKARZE" MODIFY ("SPECJALIZACJA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."LEKARZE" ADD CONSTRAINT "LEKARZE2_PK" PRIMARY KEY ("ID_LEKARZA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table WIZYTY
--------------------------------------------------------

  ALTER TABLE "BAZA"."WIZYTY" MODIFY ("ID_WIZYTY" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."WIZYTY" MODIFY ("DATA_REJESTRACJI" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."WIZYTY" MODIFY ("DATA_WIZYTY" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."WIZYTY" MODIFY ("ID_LEKARZA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."WIZYTY" MODIFY ("ID_PACJENTA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."WIZYTY" ADD CONSTRAINT "WIZYTY_PK" PRIMARY KEY ("ID_WIZYTY")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table LEKI
--------------------------------------------------------

  ALTER TABLE "BAZA"."LEKI" MODIFY ("ID_LEKARSTWA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."LEKI" MODIFY ("NAZWA" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."LEKI" MODIFY ("OPIS" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."LEKI" ADD CONSTRAINT "LEKI_PK" PRIMARY KEY ("ID_LEKARSTWA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table RECEPTY
--------------------------------------------------------

  ALTER TABLE "BAZA"."RECEPTY" MODIFY ("ID_RECEPTY" NOT NULL ENABLE);
  ALTER TABLE "BAZA"."RECEPTY" ADD CONSTRAINT "RECEPTY_PK" PRIMARY KEY ("ID_RECEPTY")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table KARTABADAN
--------------------------------------------------------

  ALTER TABLE "BAZA"."KARTABADAN" ADD CONSTRAINT "KARTABADAN_PACJENT" FOREIGN KEY ("ID_PACJENTA")
	  REFERENCES "BAZA"."PACJENCI" ("ID_PACJENTA") ENABLE;
  ALTER TABLE "BAZA"."KARTABADAN" ADD CONSTRAINT "KARTAB_BADANIA" FOREIGN KEY ("ID_BADANIA")
	  REFERENCES "BAZA"."BADANIA" ("ID_BADANIA") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table LEKARSTWA_RECEPTY
--------------------------------------------------------

  ALTER TABLE "BAZA"."LEKARSTWA_RECEPTY" ADD CONSTRAINT "RECEPTYFKA" FOREIGN KEY ("ID_RECEPTY")
	  REFERENCES "BAZA"."RECEPTY" ("ID_RECEPTY") ENABLE;
  ALTER TABLE "BAZA"."LEKARSTWA_RECEPTY" ADD CONSTRAINT "LEKIFK" FOREIGN KEY ("ID_LEKARSTWA")
	  REFERENCES "BAZA"."LEKI" ("ID_LEKARSTWA") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table WIZYTY
--------------------------------------------------------

  ALTER TABLE "BAZA"."WIZYTY" ADD CONSTRAINT "LEKARZEWIZYTY" FOREIGN KEY ("ID_LEKARZA")
	  REFERENCES "BAZA"."LEKARZE" ("ID_LEKARZA") ON DELETE CASCADE ENABLE;
  ALTER TABLE "BAZA"."WIZYTY" ADD CONSTRAINT "WIZYTYPACJENCI" FOREIGN KEY ("ID_PACJENTA")
	  REFERENCES "BAZA"."PACJENCI" ("ID_PACJENTA") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table WIZYTY_CHOROBY
--------------------------------------------------------

  ALTER TABLE "BAZA"."WIZYTY_CHOROBY" ADD CONSTRAINT "WIZYTYFK" FOREIGN KEY ("ID_WIZYTY")
	  REFERENCES "BAZA"."WIZYTY" ("ID_WIZYTY") ENABLE;
  ALTER TABLE "BAZA"."WIZYTY_CHOROBY" ADD CONSTRAINT "CHOROBYFK" FOREIGN KEY ("ID_CHOROBY")
	  REFERENCES "BAZA"."CHOROBY" ("ID_CHOROBY") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table WIZYTY_RECEPTY
--------------------------------------------------------

  ALTER TABLE "BAZA"."WIZYTY_RECEPTY" ADD CONSTRAINT "RECEPTYFK" FOREIGN KEY ("ID_RECEPTY")
	  REFERENCES "BAZA"."RECEPTY" ("ID_RECEPTY") ENABLE;
  ALTER TABLE "BAZA"."WIZYTY_RECEPTY" ADD CONSTRAINT "WIZYTY" FOREIGN KEY ("ID_WIZYTY")
	  REFERENCES "BAZA"."WIZYTY" ("ID_WIZYTY") ENABLE;
