# Gebruikersscenario's

Deze gebruikersscenario’s beschrijven wie mijn portfoliosite gebruikt, welk doel de gebruiker heeft en welke gevolgen dit heeft voor het ontwerp.

## Scenario 1 — Recruiter zoekt een geschikte stagiair

### Gebruiker

Een recruiter die kandidaten selecteert voor een stage in software engineering.

### Situatie

De recruiter opent mijn portfolio via een link in mijn cv of LinkedIn profiel. De recruiter heeft weinig tijd en bekijkt de website mogelijk op een telefoon.

### Doel

De recruiter wil snel bepalen of mijn opleiding, vaardigheden en projecten aansluiten bij de stage.

### Stappen

1. De recruiter opent de Who-am-I-pagina.
2. De recruiter leest mijn korte introductie.
3. De recruiter opent via de hoofdnavigatie het projectenoverzicht.
4. De recruiter bekijkt per project de beschrijving, technologieën en status.
5. De recruiter bepaalt of mijn profiel voldoende aansluit bij de stage.

### Benodigde informatie

- Mijn opleiding en studierichting.
- Mijn technische interesses.
- Mijn huidige vaardigheden.
- Mijn belangrijkste projecten.
- De gebruikte technologieën per project.
- De status van ieder project.

### Mogelijke problemen

- De introductie is te lang.
- De navigatie is moeilijk te vinden.
- Projectinformatie is niet snel te scannen.
- De pagina werkt niet goed op een telefoon.
- Mijn vaardigheidsniveau wordt niet eerlijk beschreven.

### Gevolgen voor het ontwerp

- De hoofdnavigatie staat op iedere pagina op dezelfde plaats.
- De Who-am-I-pagina bevat een korte, duidelijke introductie.
- Er komt een duidelijke link naar het projectenoverzicht.
- Projecten worden weergegeven in overzichtelijke projectkaarten.
- Iedere projectkaart toont de technologieën en projectstatus.
- De website wordt mobile-first en zonder horizontale scrollbar gebouwd.

### Gekoppelde requirements

`FR-01`, `FR-02`, `FR-04`, `FR-05`, `NFR-03`, `NFR-04` en `NFR-09`.

### Succescriterium

De recruiter kan binnen twee minuten minimaal één relevant project vinden en zien welke technologieën ik daarvoor heb gebruikt.

---

## Scenario 2 — Technisch teamlid beoordeelt mijn praktische ervaring

### Gebruiker

Een softwareontwikkelaar of technisch teamleider die betrokken is bij de selectie van een stagiair.

### Situatie

Na de eerste selectie bekijkt deze persoon mijn portfolio uitgebreider op een laptop of desktopcomputer.

### Doel

De gebruiker wil controleren wat ik werkelijk heb gebouwd, welke technologieën ik heb toegepast en wat mijn eigen bijdrage was.

### Stappen

1. De gebruiker opent het projectenoverzicht.
2. De gebruiker vergelijkt verschillende projecten.
3. De gebruiker leest per project het doel en de gebruikte technologieën.
4. De gebruiker bekijkt wat mijn eigen bijdrage aan het project was.
5. De gebruiker controleert of het project afgerond of nog in ontwikkeling is.
6. De gebruiker opent eventueel een GitHub-link.


### Benodigde informatie

- Het probleem dat met het project wordt opgelost.
- Mijn eigen bijdrage aan het project.
- De gebruikte programmeertalen en hulpmiddelen.
- Wat ik tijdens het project heb geleerd.
- De actuele status van het project.
- Een werkende repositorylink wanneer het project openbaar is.

### Mogelijke problemen

- Alleen technologieën noemen zonder uit te leggen waarvoor ze zijn gebruikt.
- Niet duidelijk maken wat mijn eigen bijdrage was.
- Niet-werkende of verzonnen GitHub-links gebruiken.
- Opleidingsprojecten presenteren alsof het professionele producten zijn.

### Gevolgen voor het ontwerp

- Iedere projectkaart krijgt een vaste, consistente structuur.
- Mijn eigen bijdrage wordt apart vermeld.
- De technologieën worden duidelijk benoemd.
- De projectstatus wordt met tekst duidelijk aangegeven, niet alleen met kleur.
- Alleen bestaande en werkende GitHub-links worden toegevoegd.
- Mijn ervaring wordt eerlijk beschreven.

### Gekoppelde requirements

`FR-02`, `FR-04`, `FR-05`, `NFR-07` en `NFR-09`.

### Succescriterium

De gebruiker kan bij ieder project onderscheiden wat ik zelf heb gedaan, welke technologieën ik heb gebruikt en wat de huidige projectstatus is.


---

## Scenario 3 — Medestudent zoekt uitleg over een onderwerp

### Gebruiker

Een medestudent die meer wil leren over een onderwerp dat ik tijdens mijn opleiding heb bestudeerd.

### Situatie

De medestudent zoekt bijvoorbeeld uitleg over semantische HTML  en opent mijn blogoverzicht.

### Doel

De medestudent wil snel bepalen welk blogartikel relevante uitleg bevat.

### Stappen

1. De medestudent opent de Who-am-I-pagina.
2. De medestudent gaat via de hoofdnavigatie naar het blogoverzicht.
3. De medestudent scant de titels en korte beschrijvingen.
4. De medestudent kiest het onderwerp dat aansluit bij de informatiebehoefte.
5. De medestudent bepaalt of het artikel later gelezen moet worden.

### Benodigde informatie

- Een duidelijke titel per blogitem.
- Het onderwerp van het artikel.
- Een korte en begrijpelijke samenvatting.
- De publicatiedatum.
- Een duidelijke melding wanneer een volledig artikel nog niet beschikbaar is.

### Mogelijke problemen

- Vage titels die het onderwerp niet duidelijk maken.
- Te lange samenvattingen.
- Onduidelijke datums.
- Links die naar niet-bestaande artikelen verwijzen.
- Moeilijk leesbare tekst op kleine schermen.

### Gevolgen voor het ontwerp

- Blogitems krijgen beschrijvende titels.
- Ieder blogitem toont een datum en korte samenvatting.
- De blogitems worden met semantische `<article>`-elementen opgebouwd.
- De tekst krijgt een leesbare regelafstand en regellengte.
- Niet-beschikbare artikelen krijgen geen misleidende link.
- De blogitems staan op mobiele schermen onder elkaar.

### Gekoppelde requirements

`FR-03`, `FR-04`, `FR-06`, `NFR-01`, `NFR-03`, `NFR-04` en `NFR-09`.

### Succescriterium

De medestudent kan binnen één minuut een relevant blogonderwerp vinden en op basis van de samenvatting bepalen waarover het artikel gaat.

---

## Scenario 4 — Bezoeker gebruikt alleen het toetsenbord

### Gebruiker

Een bezoeker die door een permanente of tijdelijke motorische beperking geen muis gebruikt en met het toetsenbord navigeert.

### Situatie

De gebruiker opent de portfoliosite en gebruikt de Tab-toets om door de navigatie en links te bewegen. De gebruiker kan daarnaast ingezoomde tekst nodig hebben.

### Doel

De gebruiker wil zelfstandig de introductie, projecten en blogitems kunnen bekijken zonder vast te lopen.

### Stappen

1. De gebruiker opent de Who-am-I-pagina.
2. De gebruiker drukt op de Tab-toets.
3. De gebruiker ziet welk element focus heeft.
4. De gebruiker navigeert met het toetsenbord naar Projecten.
5. De gebruiker opent daarna het blogoverzicht.
6. De gebruiker vergroot eventueel de pagina tot 200%.
7. De gebruiker keert via de navigatie terug naar de Who-am-I-pagina.

### Benodigde ondersteuning

- Een logische volgorde van links.
- Een zichtbare focusaanduiding.
- Semantische koppen en paginaonderdelen.
- Voldoende kleurcontrast.
- Tekst die bij inzoomen leesbaar blijft.
- Alt-teksten voor informatieve afbeeldingen.
- Navigatie die zonder muis werkt.

### Mogelijke problemen

- Niet kunnen zien welk element geselecteerd is.
- Vastlopen in een interactief onderdeel.
- Te weinig contrast tussen tekst en achtergrond.
- Horizontaal moeten scrollen na inzoomen.
- Onduidelijke links zoals “klik hier”.

### Gevolgen voor het ontwerp

- Alle links zijn bereikbaar met de Tab-toets.
- Interactieve elementen krijgen een zichtbare `:focus-visible`-stijl.
- De HTML gebruikt passende semantische elementen.
- Linkteksten beschrijven duidelijk waar de link naartoe gaat.
- Tekst en achtergrond voldoen aan WCAG AA-contrast.
- Informatieve afbeeldingen krijgen een passende alt-tekst.
- De website wordt getest met toetsenbordbediening en 200% zoom.

### Gekoppelde requirements

`FR-04`, `NFR-01`, `NFR-03`, `NFR-04`, `NFR-05`, `NFR-06`, `NFR-07` en `NFR-09`.

### Succescriterium

De gebruiker kan zonder muis alle drie de pagina’s bereiken, altijd zien welk element focus heeft en de inhoud bij 200% zoom blijven lezen.

