# Projekt-Dokumentation

Jütte

| Datum       | Version | Zusammenfassung                                              |
| ----------- | ------- | ------------------------------------------------------------ |
| 04.01.2023  | 0.0.1   | Vorarbeit bis und mit Aufgabe 5                              |
| 01.03.2023  | 0.0.2   | Aufgabe 6 und 7 erledigt                                     |
| 02.03.2023  | 0.0.3   | Fertigstellung                                               |

# 0 Ihr Projekt

In der Webapplikation kann ein Nutzer durch das Erraten von Wörtern Geldbeträge gewinnen und sich mit anderen Spielern in einem Scoreboard messen.

# 1 Analyse

* Tier 1 (Presentation):
    Anzeige der Loginseite, der Kreuzworträtsel-Seite, der Kreuzworträtsel-Bearbeiten-Seite, der Highscore Liste und clientseitige Eingabeprüfungen.
* Tier 2 (Webserver):
    Ist für die Steuerung des GUIs (Anweisungen von tieferen Schichten) und die Weiterleitung der Aktionen des Benutzers zu tieferen Schichten zuständig. 
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

Firebase wird über das Firebase SDK angesprochen. Das Interface ist bei Firebase eine Webseite. Um mit Firebase in meinem Projekt kommunizieren zu können, muss das NuGet Paket von Firebase im Projekt heruntergeladen werden. Mit den Funktionen vom NuGet Paket kann nun mithilfe von Links mit Firebase kommunizieren. Die Datenbank hat die Form eines JSON-Baums.

# 4.1 User Storys

| US-№ | Verbindlichkeit | Typ            | Beschreibung                                                                                                          |
| ---- | --------------- | -------------- | --------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional     | Als ein Administrator möchte ich mich mit Passwort und E-Mail einloggen, damit niemand sich als mich ausgeben kann    |
| 2    | Muss            | Funktional     | Als ein Administrator möchte ich Phrasen und Rätsel-Wörter anlegen, ändern und löschen können, damit ich die Phrasen und Rätsel-Wörter aktuell halten kann |
| 3    | Muss            | Funktional     | Als Administrator möchte ich Kategorien anlegen und jedes Wort bzw. Frage einer Kategorie zuordnen können, damit ich mehr Dynamik ins Spiel bringen kann |
| 4    | Muss            | Funktional     | Als Administrator möchte ich Einträge der Highscore-Liste löschen können, damit falsche Highscores nicht mehr angezeigt werden |
| 5    | Muss            | Funktional     | Als System möchte ich, dass jeder Benutzer, welcher einen Highscore erreicht, einen Namen eingeben muss, damit ich den Highscore in der Highscore-Liste mit Namen abbilden kann |
| 6    | Muss            | Funktional     | Als Spieler möchte ich zu jeder Zeit den Kontostand sehen, damit ich weiss, wie viel Geld ich habe                    |
| 7    | Muss            | Funktional     | Als Spieler möchte ich zu jeder Zeit die Lebenspunkte sehen, damit ich weiss, wie viel Leben ich noch habe            |
| 8    | Muss            | Funktional     | Als Spieler möchte ich wissen, ob die Antwort richtig oder falsch war, damit ich weiss, ob mir ein Leben abgezogen wird oder nicht |
| 9    | Muss            | Funktional     | Als System möchte ich die Highscore-Listen-Ränge den Geldbeträgen nach verteilen, damit jeder Spieler weiss, wie viele Spieler mehr Geld als er selbst gewonnen haben |
| 10   | Muss            | Funktional     | Als System möchte ich jedem Spieler jede Phrase oder jedes Rätsel-Wort nur einmal anzeigen, damit der Spieler nicht bevorteilt ist |
| 11   | Muss            | Funktional     | Als Spieler möchte ich jederzeit aufhören können, damit ich meinen Betrag in die Highscore-Liste übertragen kann      |
| 12   | Muss            | Funktional     | Als System möchte ich wissen wie viel Runden ein Benutzer gespielt hat, damit Auswertungen getroffen werden können    | 
| A    | Muss            | Rand           | Als Entwickler möchte ich mit .net MAUI Blazor arbeiten, damit ich mit dieser Technologie besser zurechtkomme         | 

# 4.2 Testfälle

| TC-№ | Vorbereitung       | Eingabe                                                          | Erwartete Ausgabe                                               |
| ---- | ------------------ | ---------------------------------------------------------------- | --------------------------------------------------------------- |
| 1.1  | Webseite ist geöffnet, Administrator möchte sich einloggen | 1. Administrator gibt richtige Benutzerdaten ein| 2. Benutzer wird eingeloggt              |
| 1.2  | Webseite ist geöffnet, Administrator möchte sich einloggen | 1. Administrator gibt falsche Benutzerdaten ein| 2. Benutzer wird nicht eingeloggt          |
| 2.1  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer legt neues Medium an | 2. Neues Medium befindet sich in der Datenbank                 |
| 2.2  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer löscht ein Medium   | 2. Gelöschtes Medium befindet sich nicht mehr in der Datenbank  |
| 2.3  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer ändert ein Medium   | 2. Geändertes Medium befindet sich aktualisiert in der Datenbank |
| 3.1  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer erstellt eine neue Kategorie | 2. Medien können der Kategorie hinzugefügt werden      |
| 4.1  | Webseite ist geöffnet, Administrator ist eingeloggt | 1. Benutzer löscht einen Highscore-Listeneintrag | 2. Highscore-Listeneintrag ist nicht mehr vorhanden |
| 5.1  | Webseite ist geöffnet, Benutzer spielt ein Spiel | 1. Benutzer beendet das Spiel</br>3. Benutzer gibt einen Namen ein  | 2. Benutzer wird aufgefordert einen Namen einzugeben</br>4. Name erscheint mit Highscore in der Highscore-Liste |
| 6.1  | Webseite ist geöffnet, Benutzer spielt ein Spiel | 1.                                  | 2. Der Kontostand wird angezeigt                               |
| 7.1  | Webseite ist geöffnet, Benutzer spielt ein Spiel | 1.                                  | 2. Die Lebenspunkte werden angezeigt                           |
| 8.1  | Webseite ist geöffnet, Benutzer spielt ein Spiel | 1. Benutzer tätigt eine richtige Eingabe | 2. Die Eingabe wird als richtig dargestellt               |
| 8.2  | Webseite ist geöffnet, Benutzer spielt ein Spiel | 1. Benutzer tätigt eine falsche Eingabe | 2. Die Eingabe wird als falsch dargestellt                 |
| 9.1  | Webseite ist geöffnet | 1. Benutzer navigiert zur Highscore-Liste                      | 2. Die Highscore Liste wird nach Rang aufsteigend sortiert     |
| 10.1 | Webseite ist geöffnet, Benutzer spielt ein Spiel | 1. Benutzer beantwortet ein Medium  | 2. Dieses Medium wird dem Benutzer nicht mehr angezeigt        |
| 11.1 | Webseite ist geöffnet, Benutzer spielt ein Spiel | 1. Benutzer beendet das Spiel | 2. Der Gewinn wird in die Highscore-Liste übertragen                 |
| 12.1 | Webseite ist geöffnet, Benutzer spielt ein Spiel | 1. Benutzer schliesst eine Runde ab | 2. Die Runde wird gezählt                                      |

Medium steht für Rätsel-Wort und Phrase. 

# 5 Prototyp
Spieler Views</br>
![UserViews](https://user-images.githubusercontent.com/69578012/211195650-72e98056-1931-49f2-bffa-8cd3971d9328.png)</br>
Admin Views</br>
![AdminViews](https://user-images.githubusercontent.com/69578012/211195656-7d59344c-9e9a-4b1b-aa9c-974daf7ab41f.png)</br>

# 6 Implementation

| User Story | Datum                   | Beschreibung                 |
| ---------- | ----------------------- | ---------------------------- |
| 1          | 21.02.2023              | Zu diesem Zeitpunkt erledigt |
| 2          | 21.02.2023              | Zu diesem Zeitpunkt erledigt |
| 3          | 21.02.2023              | Zu diesem Zeitpunkt erledigt |
| 4          | 21.02.2023              | Zu diesem Zeitpunkt erledigt |
| 5          | 24.02.2023              | Zu diesem Zeitpunkt erledigt |
| 6          | 24.02.2023              | Zu diesem Zeitpunkt erledigt |
| 7          | 24.02.2023              | Zu diesem Zeitpunkt erledigt |
| 8          | 24.02.2023              | Zu diesem Zeitpunkt erledigt |
| 9          | 24.02.2023              | Zu diesem Zeitpunkt erledigt |
| 10         | 28.02.2023              | Zu diesem Zeitpunkt erledigt |
| 11         | 24.02.2023              | Zu diesem Zeitpunkt erledigt |
| 12         | 24.02.2023              | Zu diesem Zeitpunkt erledigt |
| A          | 12.01.2023 - 02.03.2023 | Zu diesem Zeitpunkt erledigt |

# 7 Projektdokumentation

| US-№ | Erledigt? | Entsprechende Code-Dateien oder Erklärung                                           |
| ---- | --------- | ----------------------------------------------------------------------------------- |
| 1    | ja        | Siehe Zeilen 41 bis 47 in der Datei: `Pages/AdminLogin.razor`                       |
| 2    | ja        | Siehe Zeilen 128 bis 137 und 146 bis 160 in der Datei: `Pages/AdminView.razor`      |
| 3    | ja        | Siehe Zeilen 120 bis 126 und 139 bis 144 in der Datei: `Pages/AdminView.razor`      |
| 4    | ja        | Siehe Zeilen 162 bis 166 in der Datei: `Pages/AdminView.razor`                      |
| 5    | ja        | Siehe Zeilen 123 bis 139 und 219 bis 228 in der Datei: `Pages/GameView.razor`       |
| 6    | ja        | Siehe Zeile 50 in der Datei: `Pages/GameView.razor`                                 |
| 7    | ja        | Siehe Zeile 51 in der Datei: `Pages/GameView.razor`                                 |
| 8    | ja        | Siehe Zeile 210 und 214 in der Datei: `Pages/GameView.razor`                        |
| 9    | ja        | Siehe Zeile 20, 24 und 49 bis 55 in der Datei: `Pages/Scoreboard.razor`             |
| 10   | ja        | Siehe Zeile 160 in der Datei: `Pages/GameView.razor`                                |
| 11   | ja        | Siehe Zeile 53 und 219 bis 228 in der Datei: `Pages/GameView.razor`                 |
| 12   | ja        | Siehe Zeile 52 in der Datei: `Pages/GameView.razor`                                 |
| A    | ja        | Anhand des Codes kann man erkennen, dass ich .net MAUI Blazor verwendet habe.       |

# 8 Testprotokoll

[Demo Video](https://www.youtube.com/watch?v=Z9OQcDoH66g)</br>
Timestamps in der Beschreibung</br>
[Ergänzungsvideo Testfall 8.2](https://www.youtube.com/watch?v=-pAOzPCUU_8)

| TC-№ | Datum      | Resultat | Tester     |
| ---- | ---------- | -------- | ---------- |
| 1.1  | 02.03.2023 | OK       | Joel Jütte |
| 1.2  | 02.03.2023 | OK       | Joel Jütte |
| 2.1  | 02.03.2023 | OK       | Joel Jütte |
| 2.2  | 02.03.2023 | OK       | Joel Jütte |
| 2.3  | 02.03.2023 | OK       | Joel Jütte |
| 3.1  | 02.03.2023 | OK       | Joel Jütte |
| 4.1  | 02.03.2023 | OK       | Joel Jütte |
| 5.1  | 02.03.2023 | OK       | Joel Jütte |
| 6.1  | 02.03.2023 | OK       | Joel Jütte |
| 7.1  | 02.03.2023 | OK       | Joel Jütte |
| 8.1  | 02.03.2023 | OK       | Joel Jütte |
| 8.2  | 02.03.2023 | OK/NOK   | Joel Jütte |
| 9.1  | 02.03.2023 | OK       | Joel Jütte |
| 10.1 | 02.03.2023 | OK       | Joel Jütte |
| 11.1 | 02.03.2023 | OK       | Joel Jütte |
| 12.1 | 02.03.2023 | OK       | Joel Jütte |

Bemerkungen:</br>
Admin View buggt, wie im Video erklärt.</br>
Beim Bearbeiten eines Wortes wird ein neuer Eintrag gemacht und das alte gelöscht. Es wird nicht das bestehende Element bearbeitet.</br>
Bei falschen Eingaben gibt es einen Bug. Es wird eine Fehlermeldung und eine Erfolgsmeldung angezeigt.

Fazit:</br>
Die App ist voll funktionsfähig, hat allerdings noch 3 Bugs. Diese sind unter den Testfällen bei Bemerkungen aufgeführt.

# 9 `README.md`

[Zur README.md Datei:](https://github.com/quicktey/JuetteJoel_LB151/blob/main/README.md)
