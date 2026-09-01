# Requirements portfoliosite

Dit document beschrijft aan welke eisen mijn portfoliosite moet voldoen.

## Functionele requirements

Functionele requirements beschrijven wat de website moet bieden.

| ID    | Requirement                                                                            | Controle                                       | Status  |
| ----- | -------------------------------------------------------------------------------------- | ---------------------------------------------- | ------- |
| FR-01 | De bezoeker kan een Who-am-I-pagina bekijken.                                          | `index.html` openen met Live Server.           | Gepland |
| FR-02 | De bezoeker kan een projectenoverzicht bekijken.                                       | `projects.html` openen met Live Server.        | Gepland |
| FR-03 | De bezoeker kan een blogoverzicht bekijken.                                            | `blog.html` openen met Live Server.            | Gepland |
| FR-04 | De bezoeker kan vanaf iedere pagina naar de andere pagina’s navigeren.                 | Alle navigatielinks op iedere pagina testen.   | Gepland |
| FR-05 | De projectenpagina toont per project een titel, beschrijving en gebruikte technologie. | De inhoud van iedere projectkaart controleren. | Gepland |
| FR-06 | Het blogoverzicht toont per blogartikel een titel en korte beschrijving.               | De inhoud van ieder blogitem controleren.      | Gepland |

## Niet-functionele requirements

Niet-functionele requirements beschrijven hoe goed de website moet werken.

| ID     | Requirement                                                                                                              | Controle                                                                | Status  |
| ------ | ------------------------------------------------------------------------------------------------------------------------ | ----------------------------------------------------------------------- | ------- |
| NFR-01 | De website gebruikt passende semantische HTML5-elementen.                                                                | De HTML-code en gebruikte elementen controleren.                        | Gepland |
| NFR-02 | De vormgeving staat in een apart CSS-bestand.                                                                            | Controleren of alle HTML-pagina’s naar hetzelfde CSS-bestand verwijzen. | Gepland |
| NFR-03 | De website is bruikbaar op mobiel, tablet en desktop.                                                                    | Testen op ongeveer 375 px, 768 px en 1280 px breedte.                   | Gepland |
| NFR-04 | De pagina’s veroorzaken geen horizontale scrollbar.                                                                      | Iedere pagina op verschillende schermbreedtes controleren.              | Gepland |
| NFR-05 | De website is met het toetsenbord te bedienen en heeft een zichtbare focusaanduiding.                                    | Met de Tab-toets langs alle links navigeren.                            | Gepland |
| NFR-06 | Informatieve afbeeldingen krijgen een betekenisvolle alt-tekst. Decoratieve afbeeldingen krijgen een leeg `alt`-attribuut. | De `alt`-attributen in de HTML controleren.                             | Gepland |
| NFR-07 | Tekst en achtergrond hebben voldoende contrast volgens WCAG AA.                                                          | De kleuren controleren met een contrastchecker.                         | Gepland |
| NFR-08 | De HTML bevat geen fouten volgens de W3C-validator.                                                                      | Iedere HTML-pagina afzonderlijk valideren.                              | Gepland |
| NFR-09 | De vormgeving en navigatie zijn op alle pagina’s consistent.                                                             | De header, navigatie, kleuren en typografie vergelijken.                | Gepland |

## Documentatierequirements

Documentatierequirements beschrijven welke uitleg en bewijsstukken nodig zijn.

| ID     | Requirement                                                                                         | Controle                                                                    | Status  |
| ------ | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------- | ------- |
| DOC-01 | De HTTP-request/response-cyclus van de statische website wordt kort uitgelegd.                      | Controleren of `request-response.md` aanwezig en compleet is.               | Gepland |
| DOC-02 | Het ontwerp is gebaseerd op minimaal twee concrete gebruikersscenario’s.                            | Controleren of `user-scenarios.md` minimaal twee scenario’s bevat.          | Gepland |
| DOC-03 | Minimaal drie ontwerpkeuzes worden aan de gebruikersscenario’s gekoppeld en onderbouwd.             | Controleren of `design-decisions.md` minimaal drie onderbouwde keuzes bevat. | Gepland |
| DOC-04 | Voor de onderbouwing wordt minimaal één betrouwbare bron van MDN of web.dev gebruikt.               | De bronvermelding en bijbehorende link controleren.                         | Gepland |
| DOC-05 | Het proces, AI-gebruik, ontvangen feedback en de bestede tijd worden eerlijk vastgelegd.            | Het proceslogboek na iedere werksessie bijwerken.                           | Gepland |