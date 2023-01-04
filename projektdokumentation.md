# Projekt-Dokumentation

Jütte

| Datum       | Version | Zusammenfassung                                              |
| ----------- | ------- | ------------------------------------------------------------ |
| 04.01.2023  | 0.0.1   | Vorarbeit bis Aufgabe 6                                      |
|             | 0.0.2   |                                                              |
|             | 0.0.3   |                                                              |
|             | 0.0.4   |                                                              |
|             | 0.0.5   |                                                              |
|             | 0.0.6   |                                                              |
|             | 1.0.0   |                                                              |

# 0 Ihr Projekt

In der Webapplikation kann ein Nutzer durch das Erraten von Wörtern Geldbeträge gewinnen und sich mit anderen Spielern in einem Scoreboard messen.

# 1 Analyse

* Tier 1 (Presentation):
    Anzeige der Loginseite, der Kreuzworträtsel-Seite, der Kreuzworträtsel-Bearbeiten-Seite, der Highscore Liste und clientseitige Eingabeprüfungen.
* Tier 2 (Webserver):
    Ist für die Steuerung des GUIs (Anweisungen von tieferen Schichten) und die weiterleitung der Aktionen des Benutzers zu tieferen schichten zuständig. 
* Tier 3 (Application Server):
    Ist für die Businesslogik sowie das Speichern der Daten in der Datenbank und für die serverseitigen Eingabeprüfungen zuständig.
* Tier 4 (Dataserver):
    Ist für die Persistenz der Daten zuständig. Hier werden die Benutzerdaten gespeichert. 

# 2 Technologie

* Tier 1 (Presentation):
    HTML und CSS
* Tier 2 (Webserver):
    Blazor
* Tier 3 (Application Server):
    C#
* Tier 4 (Dataserver):
    Firebase 

# 3 Datenbank

Firebase wird über das Firebase SDK angesprochen. Das Interfece ist bei Firebase eine Webseite. 
Interface???
✍️ Wie steuern Sie Ihre Datenbank an? Wie ist das Interface aufgebaut? 

# 4.1 User Stories

✍️ Formulieren Sie klare Anforderungen in der Form von User Stories (*„als … möchte ich … damit …“*) und zu jeder Anforderung mindestens einen dazugehörigen Testfall (in Kapitel 4.2). 

✍️ Formulieren Sie weitere, eigene Anforderungen und Testfälle, wie Sie Ihre Applikation erweitern möchten. Geben Sie diesen statt einer Nummer einen Buchstaben (`A`, `B`, etc.)

| US-№ | Verbindlichkeit | Typ            | Beschreibung                                                                                                          |
| ---- | --------------- | -------------- | --------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional     | Als ein Administrator möchte ich mich mit Passwort und E-Mail einloggen, damit niemand sich als mich ausgeben kann    |
| 2    | Muss            | Funktional     | Als ein Administrator möchte ich Phrasen und Rätsel-Wörter anlegen, ändern und löschen können, damit ich die Phrasen und Rätsel-Wörter aktuell halten kann |
| 3    | Muss            | Funktional     | Als Administrator möchte ich Kategorien anlegen und jedes Wort bzw. Frage einer Kategorie zuordnen können, damit ich mehr Dynamik ins Spiel bringen kann |
| 4    | Muss            | Funktional     | Als Administrator möchte ich Einträge der Highscore-Liste löschen können, damit falsche Highscores nicht mehr angezeigt werden |
| 5    | Muss            | Funktional     | Als System möchte ich, dass jeder Benutzer, welcher einen Highscore erreicht, einen Namen eingeben muss, damit ich den Highscore in der Highscore-Liste mit Namen abbilden kann |
| 6    | Muss            | Funktional     | Als Spieler möchte ich zu jeder Zeit den Kontostand sehen, damit ich weiss, wie viel Geld ich habe                    |
| 7    | Muss            | Funktional     | Als Spieler möchte ich zu jeder Zeit die Lebenspunkte sehen, damit ich weiss, wie viel Leben ich noch habe            |
| 8    | Muss            | Funktional     | Als Spieler möchte ich wissen, ob die Antwort richtig oder falsch war, damit ich weiss, ob mit ein Leben abgezogen wird oder nicht |
| 9    | Muss            | Funktional     | Als System möchte ich die Highscore-Listen-Ränge den Geldbeträgen nach verteilen, damit jeder Spieler weiss, wie viele Spieler mehr Geld als er selbst gewonnen haben |
| 10   | Muss            | Funktional     | Als System möchte ich jedem Spieler jede Phrase oder jedes Rätsel-Wort nur einmal anzeigen, damit der Spieler nicht bevorteilt ist |
| 11   | Muss            | Funktional     | Als Spieler möchte ich jederzeit aufhören können, damit ich meinen Betrag in die Highscore-Liste übertragen kann      |
| 12   | Muss            | Funktional     | Als System möchte ich wissen wie viel Runden ein Benutzer gespielt hat, damit Auswertungen getroffen werden können    |

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc. oder Zahl), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). 

# 4.2 Testfälle

| TC-№ | Vorbereitung       | Eingabe                                                          | Erwartete Ausgabe                                               |
| ---- | ------------------ | ---------------------------------------------------------------- | --------------------------------------------------------------- |
| 1.1  | Webseite ist geöffnet, Administrator möchte sich einloggen | 1. Administrator gibt richtige Benutzerdaten ein| 2. Benutzer wird eingeloggt              |
| 1.2  | Webseite ist geöffnet, Administrator möchte sich einloggen | 1. Administrator gibt falsche Benutzerdaten ein| 2. Benutzer wird nichteingeloggt          |
| 2.1  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer legt neues Medium an | 2. Neues Medium befindet sich in der Datenbank                 |
| 2.2  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer löscht ein Medium   | 2. Gelöschtes Medium befindet sich nicht mehr in der Datenbank  |
| 2.3  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer ändert ein medium   | 2. Geändertes Medium befindet sich aktualisiert in der Datenbank |
| 3.1  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer erstellt eine neue Kategorie | 2. Medien können der Kategorie hinzugefügt werden      |
| 4.1  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer löscht einen Highscore-Listeneintrag | 2. Highscore-Listeneintrag ist nicht mehr vorhanden |
| 5.1  | Webseite ist geöffnet Benutzer spielt ein Spiel | 1. Benutzer beendet das Spiel
3. Benutzer gibt einen Namen ein  | 2. Benutzer wird aufgefortdert einen Namen einzugeben
4. Name erscheint mit Highscore in der Highscore-Liste |
| 6.1  | | 1. | 2. |
| 7.1  | | 1. | 2. |
| 8.1  | | 1. | 2. |
| 9.1  | | 1. | 2. |
| 10.1 | | 1. | 2. |
| 11.1 | | 1. | 2. |
| 12.1 | | 1. | 2. |
Medium steht für Rätsel-Wort und Phrase. 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

# 5 Prototyp

✍️ Erstellen Sie Prototypen für das GUI (Admin-Interface und Quiz-Seite).

# 6 Implementation

✍️ Halten Sie fest, wann Sie welche User Story bearbeitet haben

| User Story | Datum | Beschreibung |
| ---------- | ----- | ------------ |
| ...        |       |              |

# 7 Projektdokumentation

| US-№ | Erledigt? | Entsprechende Code-Dateien oder Erklärung |
| ---- | --------- | ----------------------------------------- |
| 1    | ja / nein |                                           |
| ...  |           |                                           |

# 8 Testprotokoll

✍️ Fügen Sie hier den Link zu dem Video ein, welches den Testdurchlauf dokumentiert.

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

# 9 `README.md`

✍️ Beschreiben Sie ausführlich in einer README.md, wie Ihre Applikation gestartet und ausgeführt wird. Legen Sie eine geeignete Möglichkeit (Skript, Export, …) bei, Ihre Datenbank wiederherzustellen.

# 10 Allgemeines

- [ ] Ich habe die Rechtschreibung überprüft
- [ ] Ich habe überprüft, dass die Nummerierung von Testfällen und User Stories übereinstimmen
- [ ] Ich habe alle mit ✍️ markierten Teile ersetzt
