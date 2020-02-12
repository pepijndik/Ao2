# Dump File
#
# Database is ported from MS Access
#--------------------------------------------------------
# Program Version 5.1.232

CREATE DATABASE IF NOT EXISTS `videotheek`;
USE `videotheek`;

#
# Table structure for table 'Dvd'
#

DROP TABLE IF EXISTS `Dvd`;

CREATE TABLE `Dvd` (
  `Id-Dvd` INTEGER NOT NULL AUTO_INCREMENT, 
  `Titel` VARCHAR(50), 
  `Regisseur` VARCHAR(50), 
  `Acteurs` LONGTEXT, 
  `Genre` VARCHAR(50), 
  `Korte Omschrijving` LONGTEXT, 
  `Bijzonderheden` LONGTEXT, 
  `Jaar van uitgifte` INTEGER DEFAULT 0, 
  `Tijdsduur Film` INTEGER, 
  `Leeftijd` VARCHAR(255), 
  INDEX (`Id-Dvd`), 
  PRIMARY KEY (`Id-Dvd`), 
  INDEX (`Titel`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Dvd'
#

INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (1, 'The Rainmaker', 'Francis Ford Coppola', 'Matt Damon, Mickey Rourke, Danny DeVito, Jon Voigt', 'Thriller', 'Matt Damon speel Rudy Baylor, een beginnen advocaat die in een opvallende zware rechts verzeild raakt. Zijn tegenstanders: eeen legertje door de wol geverfde gehaaide juristen (geleid door Jon Voight). Zijn medestanders: Deck Shifflet (Danny DeVito), een nogal opvliegende \'media-advocaat\'die steeds zakt voor zijn rechtbanexamen. Rudy\'s kansen zijn niniem, tot hij een spoor van cooryptie ontdekte dat hem kan leiden naar z\'n enige kans om deze zaak te winnen: de waarheid', 'gebaseerd op een boek van John Grisham', 1997, 90, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (2, 'Harry Potter en de Vuurbeker', 'Mike Newell', 'Daniel RadCliffe, Rupert Grint, Emma Watson', 'Familie', 'Als de naam van Harry Potter uit de vuurbeker komt, wordt hij een deelnemer in de zware strijd om de eer tussen drie toverscholen. Harry heeft zichzelf niet opgegeven voor het toernooi, maar wie dan wel? Harry moet de strijd aangaan met een vreselijke draak, woeste waterdemonen en een betoverd doorlhof. Hij belandt in dde werede greeep van Hij-Die-Niet-Genoemd-Mag-Worden.', 'Verfilming van het vierde Harry Potter boek van J.K. Rowling', 2005, 111, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (3, 'Men in Black II (MIIB)', 'Barry Sonnenfeld', 'Tommy Lee Jones, Will Smith', 'Comedie', 'Tommy Lee Jones en WillSmith zijn terug als de agenten Kay en Jay. Opnieuw nemen zij het op tegen kwaadwillende aliens, waarvan de \'gewone mensen\' niet eens weten dat ze op onze planeet rondlopen.', NULL, 2002, 82, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (4, 'Shawshank Redemption', 'Frank Darabont', 'Tim Robbins, Morgan Freeman', 'Avontuur', 'Bankier Andy Dufresne wordt onterecht veroordeeld tot tweemaal levenslang voor de moord op zijn vrouwe ne haar minnaar. Hij belandt inde zwaarbewaakte gevangenis \'Shawshank\' en gedurende tweintig jaar is hij overgeleverd aan corryptie en bedrog. Zijn medegevangene en enige vriend Red heeft alle hoop op vrijlating laten varen. Dan bedenkt Andy een ingenieus plan.', 'gebaseerd op een boek van Stephen King. 7 oscar nominaties.', 1994, 135, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (5, 'Ellendige avonturen', 'Brad Silberling', 'Jim Carrey, Jude Law, Mery Streep', 'Avontuur', 'Beste kijker, Houdt u van films vol zingende konijntjes, ontpolffende ruimteschepen of cheerleaders, dan hebt u helemaal de verkeerde dvd vast. Deze film is uiterst alarmerend, of anders gezegd  een spannende film over tegenspoed met drie vindingrijke wezens en een gemene acteur genaamd Coutn Olaf (Carrey), die hun enorme fortuin wil inpikken. Een verdachte brand, heerlijke pasta, slecht gemanierde bloedzuigers, een ongelooflijk dodelijke adder en een oplichter komen allemaal aan bod in deze film.', NULL, 2005, 105, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (6, 'The Matrix', 'Wachowski', 'Kenau Reeves, Laurence Fishburne', 'Science Fiction', 'Waarneming: Onze alledaagse werled is echt. Realiteit: Deze wereld is bedrog, een gedetailleerde legen voortgebracht door oppermachtige machines met kunstmatige intelligentie die ons leven beheersen. Reeves en Fishburne leiden de strijd voor de bevrijding van het menselijk ras in The Matrix.', NULL, 1999, 131, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (7, 'Assepoester', NULL, NULL, 'Tekenfilm', 'Walt Disney\'s Assepoester, gebaseerd op het mooiste sprookje ter werled, boeit al jaren. Dit betovernde verhaal met prachtige muziek, spectaculaire animaties en overgetelijke personages moet je gezien hebben', NULL, 2002, 72, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (8, 'Casino Royale', 'Martin Campbell', 'Daniel Craig, Eva Green, Judi Dench', 'Actie', 'James Bond komt in actie tegen een criminele bankier. Deze staat op het punt om miljoenen te winnen in een casino met het spel poker en wil het geld aanwenden om terroristische activiteiten te financieren.', 'Casino Royale is het eerste boek uit Ian Flemming\'s 007-reeks', 2006, 144, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (9, 'Mr Beans Holiday', 'Steve Bendelack', 'Willem Dafoe, Rowan Atkinson, Jean Rochefort, Karel Roden, Emma de Caunes', 'Komedie', 'Mr. Bean gaat op vakantie in Zuid-Frankrijk, waar hij verzeild raakt van de ene chaotische situatie in de andere. Uiteindelijk komt hij uit bij het filmfestival in Cannes.', 'Vervolg op Bean. Rowan Atkinson heeft aangegeven dat dit het laatste verhaal zal zijn rond zijn personage Mr. Bean.', 2007, 90, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (10, 'Pirates of the Caribean', ' Gore Verbinski', 'Met: Johnny Depp, Orlando Bloom, Geoffrey Rush, Keira Knightley, Jonathan Pryce, Brye Cooper, Ben Wilson (V), Lee Arenberg', 'Komedie', 'Jack Sparrow, een piraat én gentleman, begint een samenwerking met de dochter van een gouveneur. Samen proberen ze de plannen van de slechte kapitein Barbossa te torpederen. Barbossa probeer een oude vloek ongedaan te maken, die er voor zorgt dat zijn bemanning zweeft tussen leven en dood.', NULL, 2003, 133, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (11, 'Zwartboek', 'Paul Verhoeven', 'Carice van Houten, Thom Hoffman, Halina Reijn', 'Actie', 'Wanneer het onderduikadres van de mooie joodse zangeres Rachel Steinn per ongeluk wordt gebombardeerd, besluit ze om met een groep joden de Biesbosch over te steken naar reeds bevrijd gebied. De boot stuit echter op een Duitse patrouille en alle vluchtelingen worden op brute wijze afgeslacht. Alleen Rachel weet te ontkomen. Ze sluit zich aan bij het verzet, en weet als Ellis de Vries aan te pappen met de hoge Duitse SD-officier Müntze. Deze is erg van haar gecharmeerd en biedt haar een baan aan. Het verzet heeft ondertussen het plan opgevat een groep gevangen genomen verzetslieden te bevrijden met hulp van Ellis. Dit mislukt jammerlijk omdat het verraden is. Ellis wordt zowel door het verzet als door de Duitsers als schuldige aangewezen. Met Müntze aan haar zijde duikt ze weer onder, samen het einde van de oorlog afwachtend. De bevrijding brengt Ellis geen vrijheid; zelfs niet wanneer ze de echte verrader weet te ontmaskeren. \"Iedereen die overleeft is op een of andere wijze schuldig\".', NULL, 2006, 138, 'Vanaf 16 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (12, 'Barbie en de twaalf dansende prinsessen', 'Greg Richardson', NULL, 'Tekenfilm', 'In Barbie en de 12 Dansende Princessen danst Barbie zich een weg naar jouw hart in dit leuke en betoverende, geheel nieuwe avontuur. Volg Barbie als de mooie Prinses Genevieve en haar elf dansende prinsessenzusjes als zij een geheime toegang ontdekken naar een wonderbaarlijke, magische wereld waar wensen uitkomen! Maar wanneer hun vader het gevaar loopt zijn koninkrijk kwijt te raken moeten Prinses Genevieve en haar zusjes samenwerken om de zaak tot een goed einde te brengen en hun vader te redden. Ze leren dat de kracht van familie ieder obstakel kan overwinnen!', NULL, 2006, 83, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (13, 'De club van Sinterklaas, deel 2', NULL, NULL, 'Komedie', '5 december staat weer voor de deur en sinterklaas en zijn pieten maken zich klaar voor de reis naar Nederland. Omdat er in wagen 27 nog heel veel pakjes liggen die niet getest zijn, besluit testpiet mee te reizen met Suprisepiet, die wagen 27 naar Nederland moet brengen. Ze hebben het samen heel gezellig, maar al snel komen ze in gevaar. De gemene meneer de directeur wil dat ieder kind in Nederland op 5 december maar 1 cadeautje krijgt: de door hem ontworpen vierkante Jeu de Boules ballen. En hij zorgt ervoor dat niets hem in de weg staat om zijn doel te bereiken!', NULL, 2003, 140, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (14, 'The Bourne Ultimatum', 'Paul Greengrass', 'Matt Damon, Julia Stiles , Joan Allen', 'Actie', 'In The Bourne Identity uit 2002 probeerde hij erachter te komen wie hij was. In The Bourne Supremacy uit 2004 nam hij wraak voor wat hem was aangedaan. Nu komt hij thuis…en kan alles weer terughalen. We zien Bourne als een man zonder land of verleden. Hij werd ooit onderworpen aan een spijkerharde training waarvan hij niets meer weet, gegeven door mensen die hij niet meer herkent. Bourne werd een geraffineerd menselijk wapen, het moeilijkste doelwit waar de CIA ooit jacht op heeft gemaakt....', 'Vervolg op The Bourne Identity en The Bourne Supremacy', 2007, 110, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (15, 'High School Musical', 'Kenny Ortega', 'Zac Efron, Vanessa Anne Hudgens , Ashley Tisdale', 'Musical', 'Een muziek - en dansspektakel van buitengewone klasse! Dankzij een onvrijwillig karaoke-optreden op oudejaarsavond ontdekken de ambitieuze basketbalaanvoerder Troy en het verlegen wiskundegenie Gabriella hun gemeenschappelijke zangtalent. Als ze auditie doen voor de hoofdrollen in de schoolmusical en zich voor de tweede ronde weten te kwalificeren, is de wannabe-diva Sharpay behoorlijk kwaad. Ze laat dan ook geen kans voorbijgaan om de audities voor de beide nieuwkomers te verpesten.', NULL, 2007, 98, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (16, 'Pride and Prejudice', 'Simon Langton', 'Colin Firth, Jennifer Ehle, David Bamber', 'Romantisch', '\'Het is een alom erkend feit dat een vrijgezel met een groot vermogen, een echtgenote nodig heeft.\' De komst van de jonge aristocraat Mr Darcy veroorzaakt grote opschudding in het gezin van de Bennets met vijf dochters in de huwbare leeftijd. Vooral Mrs Bennet is ervan overtuigd dat één van haar dochters het hart van deze rijke vrijgezel zal weten te veroveren. De intelligente en ironische Elizabeth lijkt de uitverkorene. Maar Elizabeth laat zich beinvloeden door de roddels die in de kleine gemeenschap de ronde doen en wijst hem af. Haar onterechte vooroordeel en zijn trots zorgen voor grote onderlinge misverstanden. Als blijkt dat Darcy de eer van haar familie gered heeft na een schandaal met haar jongere zuster, verandert haar opinie radicaal.', NULL, 1995, 325, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (17, 'Alles is liefde', 'Joram Lursen', 'Carice van Houten, Chantal Janzen, Daan Schuurmans', 'Romantisch', 'Alles is Liefde is een romantische komedie over de liefdesperikelen van zes koppels die er achter komen dat liefde overal is. En dat ze het allemaal willen. Maar liefde is als Sinterklaas, je moet er in geloven, anders wordt het niks.Klaasje is gescheiden van Dennis, die haar heeft bedrogen met de schooljuf. Dennis wil haar terug, maar zijn kansen lijken verkeken als zij een jonge minnaar in huis haalt. Klaasjes beste vriendin Simone is de spil van haar gezin. Haar man Ted voelt zich vaak overbodig. Dat hij is ontslagen, durft hij haar niet te vertellen. Badmeester Victor verheugt zich op het huwelijk met zijn grote liefde Kees. Maar Kees twijfelt en slaat zijn angsten van zich af tijdens weekendjes larpen (Live Action Role Play). Victors zus Kiki, verkoopster bij de Bijenkorf, droomt van een prins op het witte paard. Ze weet niet dat een echte prins, Valentijn, van haar droomt. Met de komst van een mysterieuze Sinterklaas bereiken de liefdesperikelen een hoogtepunt, maar komen ook de happy endings dichterbij.', NULL, 2007, 110, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (18, 'Titanic, Ship of Dreams', 'James Cameron', 'Leonardo DiCaprio, Kate Winslet, Jonathan Hyde', 'Romantisch, tragedie', 'Niets ter wereld evenaart de spectaculaire en adembenemende grandeur van Titanic. Als winnaar van elf Oscars, onder andere voor Beste Film, veroverde dit meeslepende verhaal de harten van miljoenen bioscoop bezoekers over de gehele wereld en groeide het uit tot de meest geliefde film ooit. Internationale superster Leonardo DiCaprio en Oscar-genomineerde Kate Winslet schitteren als Jack en Rose, de jonge geliefden die elkaar ontmoeten tijdens de eerste reis van de \'onzinkbare\' R.M.S. Titanic.', 'Gebaseerd op waargebeurd verhaal.', 1996, 189, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (19, 'Chocolat', 'Lasse Hallström', 'Johnny Depp, Carrie-Anne Moss, Juliette Binoche', 'Romantisch', 'In het Franse dorpje Lansquenet staat de tijd stil. Al een eeuw is er niets veranderd, maar dan vestigt Vianne Rocher (Juliette Binoche) zich met haar dochter in het ingedutte plaatsje. Ze opent een chocolaterie en ze beschikt over de welhaast magische gave om voor elke inwoner de juiste soort chocola uit te kiezen. De lekkernijen uit haar winkel doen de strenge gelovige, stugge dorpelingen langzaam maar zeker voor haar smelten. Viannes vermogen om de verborgen verlangens van haar dorpsgenoten...', NULL, 1999, 131, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (20, 'Into the wild', 'Sean Penn', 'Emile Hirsch, Marcia Gay Harden, William Hurt', 'Drama', 'De 22-jarige, pas afgestudeerde Christopher McCandless laat zijn familie en veelbelovende toekomst achter zich, op zoek naar avontuur. Zonder materiele bezittingen, weg van de valkuilen van de moderne wereld, probeert hij zijn weg te vinden in de wildernis van Alaska. Bijzondere ontmoetingen en de verraderlijke kracht en pracht van de natuur vormen zijn bestaan. Maar kan hij overleven?', 'Gebaseerd op de gelijknamige beststeller van outdoorjournalist Jon Krakauer uit 1996. Dit waargebeurde verhaal werd op indrukwekkende wijze verfilmd door Sean Penn.', 2008, 140, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (21, 'The White Masai', 'Hermine Huntgeburth', 'Nina Hoss, Jacky Ido, Katja Flint', 'Drama', 'Carola is samen met haar vriend Stefan op reis in Kenia.Tijdens een uitstap raakt ze helemaal in de ban van Lemalian, een aantrekkelijke Masai krijger. Ze kan hem niet vergeten, verlaat zelfs haar vriend en reist dwars door Kenia om Lemalian opnieuw te ontmoeten. Aan de zijde van haar grote liefde begint Carola een onbekend avontuur te midden van een primitieve stam.', 'Het waargebeurde verhaal, naar de bestseller van Corinne Hofmann, \" De Blanke Masai\'.', 2005, 120, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (22, 'Hotel Rwanda', 'Terry George', 'Don Cheadle, Nick Nolte, Sophie Okonedo', 'Drama', 'Hutu Paul Rusesabagina (Don Cheadle) is hotelmanager van het luxe vijf-sterren hotel \"Hotel des Milles Collines\" in Rwanda. Tijdens de burgeroorlog tussen de Hutu\'s en Tutsi\'s begin jaren \'90 biedt Paul onderdak aan meer dan twaalfhonderd Tutsi-vluchtelingen in zijn hotel. Onder hen bevinden zich vooral zakenmensen, politici en andere leden van de Tutsi-elite die het voornaamste doelwit waren van Hutu-milities. In het heetst van de strijd vecht Paul ook voor zijn eigen leven en dat van zijn (Tutsi) vrouw en kinderen.', 'Het indrukwekkende, waargebeurde verhaal van een gewone man die de moed, kracht en het vermogen had om zijn eigen leven op het spel te zetten om tal van onschuldige mensen te kunnen redden...', 2006, 110, 'Vanaf 16 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (23, 'Oorlogswinter', 'Martin Koolhoven', '  Martijn Lakemeier, Melody Klaver, Jamie Campbell Bower, Anneke Blok, Tygo Gernandt, Raymond Thiry, Yorick van Wageningen, Dan van Husen, Gerard Jan Rijnders', 'Oorlog', 'Oorlogswinter is het verhaal van Michiel, die in de laatste ijskoude winter van de oorlog volwassen wordt. Zijn oom Ben, die in het verzet zit, is zijn grote voorbeeld en Michiel kan niet wachten tot hij ook wat kan betekenen in de strijd tegen de bezetter. Tot zijn grote ergernis neemt echter niemand hem serieus, totdat zijn oudere buurjongen Dirk hem een opdracht geeft. Voordat hij het weet, zit Michiel tot over zijn oren in de problemen, terwijl hij niemand in vertrouwen kan nemen.', NULL, 2009, 100, 'Vanaf 12 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (24, 'Notebook', 'Nick Cassavetes', 'James Garner, Rachel McAdams, Ed Grady', 'Romantisch', 'Een doorleefde man beschrijft vanuit zijn versleten dagboek het ongeloofl ijk meeslepende liefdesverhaal van Allie en Noah: De jonge Allie Hamilton (Rachel McAdams) wordt op haar vakantie hopeloos verliefd op de knappe Noah Calhoun (Ryan Gosling) en ze beleven een onvergetelijke zomer vol hartstocht en passie. Onder druk van haar ouders verliezen de twee elkaar uit het oog. Als Allie op het punt van trouwen staat met de man die wel door haar ouders goedgekeurd wordt, slaat de twijfel toe. Kiest ze voor de liefde van haar leven of kiest ze voor haar ouders goedkeuring. Een bijna onmogelijke opgave en... Kan ze haar Noah vinden? Hebben ze na al die jaren echt nog zulke warme gevoelensvoor elkaar of zijn de herinneringen mooier dan de werkelijkheid?', NULL, 2009, 115, 'Vanaf 6 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (25, 'Doornroosje K3 Musical', 'Studio 100', 'K3: Kristel, Kathleen, Karin', 'Musical', 'Het sprookje Doornroosje wordt door de bekende meidengroep K3 uitgespeeld in een musical.', NULL, 2007, 115, 'Alle leeftijden');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (26, 'Star Wars - Clone Wars', 'Dave Filoni', NULL, 'Science Fiction', 'Star Wars zoals je het nooit eerder zag, in de eerste lange animatiefilm van Lucasfilm Animation. \r\n\r\nTerwijl het heelal geteisterd wordt door de Clone Wars, trachten de Jedi-ridders de orde te handhaven en de vrede te herstellen. Steeds meer stelsels vallen ten prooi aan de duistere kant en de Galactische Republiek dreigt te bezwijken onder de druk van de Separartisten en hun onuitroeibare droïdeleger..', NULL, 2008, 98, 'Vanaf 6 jaar');
INSERT INTO `Dvd` (`Id-Dvd`, `Titel`, `Regisseur`, `Acteurs`, `Genre`, `Korte Omschrijving`, `Bijzonderheden`, `Jaar van uitgifte`, `Tijdsduur Film`, `Leeftijd`) VALUES (27, 'Wall-E', 'Andrew Stanton', NULL, 'Tekenfilm', 'Na honderden (700) eenzame jaren doen waarvoor hij bedoeld was - het schoonhouden van de aarde - ontdekt WALL-E (afkorting voor Wijdverspreid Afval Lading Losser E-type) een nieuw doel in zijn leven (naast het verzamelen van knick-knacks) wanneer hij een glanzende zoekrobot ontmoet genaamd EVE. EVE komt erachter dat WALL-E onbewust op de sleutel naar de toekomst van de aarde is gestuit, en racet het heelal in om haar bevindingen te vertellen aan de mensen (die al tijden vurig wachten op het moment dat ze te horen krijgen dat het weer veilig genoeg is om terug te keren naar de aarde.', 'Een nieuwe film uit de Pixar Animation Studios  (\"The Incredibles\", \"Cars\", \"Ratatouille\")', 2008, 98, 'Alle leeftijden');
# 27 records

#
# Table structure for table 'Klanten'
#

DROP TABLE IF EXISTS `Klanten`;

CREATE TABLE `Klanten` (
  `Id-Klant` INTEGER NOT NULL AUTO_INCREMENT, 
  `Voorletters` VARCHAR(50), 
  `Voorvoegsel` VARCHAR(50), 
  `Achternaam` VARCHAR(50), 
  `Adres` VARCHAR(50), 
  `Postcode` VARCHAR(50), 
  `Woonplaats` VARCHAR(50), 
  INDEX (`Id-Klant`), 
  INDEX (`Postcode`), 
  PRIMARY KEY (`Id-Klant`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Klanten'
#

INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (1, 'P.', NULL, 'Pienter', 'Wissel 14', '1234 TT', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (2, 'B.', 'van der', 'Laan', 'Spoorweg 34', '1122 QQ', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (3, 'J.E.', NULL, 'Haverkort', 'Spoorstraat 14', '1133 WS', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (4, 'T.', NULL, 'Nagel', 'Wemeltje 8', '4455 DE', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (5, 'D.', NULL, 'Leeflang', 'Waterweg 9', '9987 BS', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (6, 'J.', 'de', 'Korte', 'Akela 8', '1588 DE', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (7, 'V.', NULL, 'Vermeer', 'Ruwaard 10', '4599 GG', 'Vleuten');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (8, 'C.', 'van der', 'Laken', 'Mauritsstraat 87', '4551 KI', 'Vleuten');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (9, 'J.', NULL, 'Verschuren', 'Boomgaard 3', '4877 KU', 'Vleuten');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (10, 'M.', NULL, 'Verbree', 'Damweg 84', '4588 JU', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (11, 'H.', 'ter', 'Berg', 'Kerkstraat 43', '5966 GT', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (12, 'O.', NULL, 'Aleppo', 'Goolstraat 122', '4588 HF', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (13, 'H. B.', NULL, 'Kakiay', 'Zuwe 32', '8932 NX', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (14, 'M.I.', 'de', 'Groot', 'Koningsstraat 245', '4553 LZ', 'Utrecht');
INSERT INTO `Klanten` (`Id-Klant`, `Voorletters`, `Voorvoegsel`, `Achternaam`, `Adres`, `Postcode`, `Woonplaats`) VALUES (15, 'H.', NULL, 'Nemeth', 'Jachthuis 78', '8877 KJ', 'Utrecht');
# 15 records

#
# Table structure for table 'Uitleengegevens'
#

DROP TABLE IF EXISTS `Uitleengegevens`;

CREATE TABLE `Uitleengegevens` (
  `Id-Uitleengegevens` INTEGER NOT NULL AUTO_INCREMENT, 
  `Datum` TIMESTAMP DEFAULT CURRENT_TIMESTAMP, 
  `Id-Klant` INTEGER DEFAULT 0, 
  `Titel Dvd` INTEGER, 
  `Retour` TINYINT(1) DEFAULT 0, 
  INDEX (`Id-Klant`), 
  INDEX (`Id-Uitleengegevens`), 
  INDEX (`Titel Dvd`), 
  PRIMARY KEY (`Id-Uitleengegevens`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Uitleengegevens'
#

INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (1, '2009-02-09 00:00:00', 1, 3, 1);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (2, '2009-02-09 00:00:00', 1, 2, 1);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (3, '2009-02-09 00:00:00', 2, 8, 0);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (4, '2009-02-09 00:00:00', 3, 4, 0);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (5, '2009-02-09 00:00:00', 5, 7, 1);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (6, '2009-02-03 00:00:00', 7, 14, 0);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (7, '2009-02-03 00:00:00', 7, 15, 1);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (8, '2009-02-07 00:00:00', 12, 12, 0);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (9, '2009-02-07 00:00:00', 12, 13, 0);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (10, '2009-02-11 00:00:00', 10, 11, 0);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (11, '2009-02-11 00:00:00', 15, 14, 1);
INSERT INTO `Uitleengegevens` (`Id-Uitleengegevens`, `Datum`, `Id-Klant`, `Titel Dvd`, `Retour`) VALUES (12, '2009-02-11 00:00:00', 13, 2, 0);
# 12 records

