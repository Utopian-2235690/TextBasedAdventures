# TextBasedAdventures
Hier ga de Text Based Adventure opdracht inleveren.


Text Based Adventure Documentatie
Programma werking:
In deze game heb je de volgende functionaliteiten:
•	Main Menu
•	Beinvloedbaar game einde
•	Status system
•	Stats system (Extra systeem)
•	Game Over

1: Main Menu
In de Main Menu kan je maar twee opties kiezen, de game starten of de game stoppen.

De code waardoor je de game kan starten is eigenlijk gewoon dat je nog een class oproept waar alle classes achter elkaar opgeroepen worden als 1 van ze afgemaakt wordt in-game. De code om de game stoppen is vrij simple en is alleen Environment.Exit(1), het enige dat het doet is de game stoppen.



2: Beinvloedbaar game einde
Deze functie van de game zorgt ervoor dat je Andere soort eindes kan kiezen door middel van andere paden te nemen in-game. Er zijn 4 eindes die je kan behalen, 3 eindes waarbij je ontsnapt en 1 einde waarbij je verliest door dood te gaan.

Bij elk einde wordt je gezegd dat je ontsnapt bent of dood gegaan bent door een Console.WriteLine, daarna wordt de Main Menu opnieuw opgeroepen door een nieuwe instance ervan te maken, wat de game reset.



3: Status system
Deze functie zorgt voor de status die je kan krijgen in-game, ‘Injured’. Het is een simple status wat omlaag gaat maar het beinvloedt het einde van de game NIET.
 
Je kan op 2 plekken in de game ge-injured worden door te veel kiezelstenen te gooien in de kamer met een grote boom of door in de library de rechter boekenkasten te inspecteren. Er is een int die buiten de methode/void staat en het enige wat er gebeurt als je ge-injured wordt is dat er 1 bij de int opgetelt wordt.



4: Stats system (Extra systeem)
Als extra systeem is er een stats system waardoor je kan zien in welke kamer je bent en hoe erg je ge-injured bent. Het is te zien in bijna alle scenes.

In elke kamer class is er een status system wat bij houdt of je ge-injured bent en in welke kamer je bent. Het gebruikt de int _injuredLevel om te kijken hoe injured je bent, level 0 is de default. In elke class is de naam voor de kamer aangepast.



5: Game Over
Je verliest als je dood gaat, dus Game Over. Je kan dood gaan als je de 2de deur in gaat in de gang class. Vanaf daar zit je vast dus het enige wat je kan doen is in de douchecabine stappen om dood te gaan.

De game laat je weten dat je dood bent gegaan en daarna roept het een nieuwe instance op van de Main Menu, wat de game reset waardoor je helemaal opnieuw kan beginnen. 
