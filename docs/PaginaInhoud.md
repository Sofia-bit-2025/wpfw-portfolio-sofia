# Concrete pagina-inhoud en navigatie

Dit document beschrijft de geplande zichtbare inhoud van mijn portfoliosite.

De website wordt in het Engels geschreven. De projectdocumentatie blijft in het Nederlands.

Projectstatussen, publicatiedatums en links worden alleen gepubliceerd wanneer ze overeenkomen met de werkelijkheid.

## 1. Gedeelde onderdelen

De drie pagina’s gebruiken dezelfde header, navigatie en footer. Alleen de inhoud binnen `<main>` verschilt per pagina.

### Skiplink

De skiplink is de eerste interactieve link op iedere pagina.

Zichtbare tekst:

> Skip to main content

De link verwijst naar `#main-content`.

### Header

De header bevat mijn naam, een korte professionele omschrijving en de hoofdnavigatie.

#### Naam

> Sofia

De naam is een link naar `index.html`.

#### Professionele omschrijving

> Software Engineering Portfolio

### Hoofdnavigatie

De navigatie staat op iedere pagina in dezelfde volgorde en op dezelfde plaats.

| Linktekst | Bestemming | Functie |
|---|---|---|
| `About Me` | `index.html` | Informatie over mijn achtergrond, vaardigheden en professionele richting bekijken |
| `Projects` | `projects.html` | Mijn persoonlijke softwareprojecten bekijken |
| `Blog` | `blog.html` | Mijn technische artikelen en leerervaringen bekijken |

De actieve navigatielink krijgt een herkenbare vormgeving en het attribuut `aria-current="page"`.



### Footer

De footer blijft bewust kort. Informatie over HTML, CSS en andere gebruikte technologieën wordt in `README.md` beschreven.

#### Zichtbare inhoud

> © 2026 Sofia · Software Engineering Portfolio  
> GitHub · LinkedIn

#### Profielkoppelingen

- [GitHub](https://github.com/Sofia-bit-2025)
- [LinkedIn](https://www.linkedin.com/in

De profielkoppelingen worden vóór publicatie gecontroleerd.

---

## 2. About Me-pagina

### Bestandsnaam

`index.html`

### Paginatitel in het browsertabblad

`Sofia | Software Engineering Portfolio`

### Meta-omschrijving

> Portfolio of Sofia, an ICT Software Engineering student focused on backend development, databases, accessible web applications and AI engineering.

### Hero

#### Korte aanduiding

> ICT Software Engineering Student

#### Hoofdtitel

> Hi, I'm Sofia.

#### Introductietekst

> I am an ICT Software Engineering student at The Hague University of Applied Sciences. I am developing practical skills in backend development, database-driven applications and accessible web interfaces, with a long-term goal of specialising in AI engineering.

#### Actieknoppen

| Knoptekst | Bestemming |
|---|---|
| `View My Projects` | `projects.html` |
| `Read My Blog` | `blog.html` |

### Sectie: About Me

#### Titel

> About Me

#### Tekst

> I enjoy understanding how software works behind the interface: how data is structured, how application components communicate and how technical decisions affect security, usability and maintainability.
>
> I learn by combining theory with practical exercises and personal projects. I want to understand why a solution works, how it can be tested and how it can be improved.

### Sectie: Current Focus

#### Titel

> What I'm Learning

#### Introductietekst

> I am currently strengthening my software-engineering foundation and preparing to build full-stack applications with a frontend, backend and relational database.

#### Leeronderwerpen

- Semantic HTML and accessible web interfaces
- Responsive CSS and mobile-first design
- Git and GitHub workflows
- Java and object-oriented programming
- SQL and relational database design
- TypeScript and frontend development
- C# and ASP.NET Core
- REST APIs and backend architecture
- Automated testing and debugging

### Sectie: Current Skills

#### Titel

> Current Skills

#### Web Development

- Semantic HTML5
- CSS3
- Responsive layout
- Accessibility fundamentals

#### Programming and Data

- Java fundamentals
- SQL
- Relational databases
- UML modelling

#### Software Engineering Practices

- Git and GitHub
- Requirements analysis
- Technical documentation
- Scrum and Agile collaboration

### Sectie: Technical Interests

#### Titel

> Technical Interests

#### Tekst

> My main interests are backend development, database-driven applications, software architecture and secure web development. I am also interested in how AI can be integrated responsibly into reliable software products.

#### Interessegebieden

- Backend Development
- Database-Driven Applications
- Secure Web Applications
- Software Architecture
- Artificial Intelligence
- AI-Enabled Applications

### Sectie: Career Direction

#### Titel

> Where I'm Heading

#### Tekst

> My short-term goal is to become ready for a software-engineering internship where I can contribute to a development team, work with real requirements and improve through professional feedback.
>
> In the longer term, I want to specialise in AI engineering while maintaining a strong foundation in backend development, databases, testing and software architecture.

### Afsluitend onderdeel

#### Titel

> Explore My Work

#### Tekst

> Discover the personal projects I am developing or read the technical notes I write while learning.

#### Actieknoppen

| Knoptekst | Bestemming |
|---|---|
| `View My Projects` | `projects.html` |
| `Read My Blog` | `blog.html` |

---

## 3. Projectenpagina

### Bestandsnaam

`projects.html`

### Paginatitel in het browsertabblad

`Projects | Sofia`

### Meta-omschrijving

> Personal software projects by Sofia, focused on backend development, databases, secure workflows and responsible AI integration.

### Paginaheader

#### Hoofdtitel

> Projects

#### Introductietekst

> These personal projects reflect the direction in which I am developing as a software engineer: reliable backend systems, structured data, secure web applications and responsible AI integration.

De genoemde technologieën zijn een geplande technische richting. Ze worden pas als gebruikte technologieën gepresenteerd nadat ze werkelijk zijn toegepast.

### Project 1: AI Study Companion

#### Status

> Concept and Planning

Wanneer de implementatie werkelijk is begonnen, kan de status worden aangepast naar:

> In Development

#### Korte introductie

> A personal learning application that helps students organise study materials and ask questions about their own documents.

#### The Problem

> Study materials are often spread across documents, platforms and folders. General AI tools can provide answers without showing which source was used, making it difficult for students to verify the information.

#### The Solution

> AI Study Companion brings learning materials together in one private workspace. Users can upload documents, organise them by subject and ask questions about their own content. Each answer includes references to the source material so the user can verify the information.

#### Planned Features

- Upload and organise study documents
- Ask questions about personal learning materials
- Receive source-grounded answers
- View the references used for each answer
- Save previous questions
- Keep documents separated per user

#### My Role

> I am defining the requirements, user experience, database structure, frontend, backend API, AI integration, security decisions, testing strategy and technical documentation.

#### Planned Technology Stack

- TypeScript
- React
- C#
- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- AI API
- Vector search
- Docker
- GitHub Actions

#### Technical Focus

- Authentication and authorisation
- Document processing
- Source retrieval
- Protection of private user data
- Secure API configuration
- Error handling
- Automated testing

#### Projectlink

Een GitHub-link wordt pas toegevoegd wanneer de repository bestaat en openbaar kan worden getoond.

### Project 2: Secure Invoice Workflow

#### Status

> Concept and Planning

#### Korte introductie

> A secure web application for registering, validating and approving invoices through a controlled workflow.

#### The Problem

> Processing invoices through email and separate files can lead to missing documents, duplicate processing and unclear approval decisions. Teams need one reliable place to register invoices and follow their status.

#### The Solution

> Secure Invoice Workflow provides a central application for registering invoices, validating important information and routing each invoice to the correct reviewer. Every status change is recorded so authorised users can see what happened and when.

#### Planned Features

- Register new invoices
- Validate required invoice information
- Detect possible duplicate invoices
- Assign invoices to a reviewer
- Approve or reject invoices
- Track the current invoice status
- Record an audit history
- Search and filter invoices

#### My Role

> I am defining the requirements, user roles, workflow, database model, frontend, backend API, validation rules, access control, tests and technical documentation.

#### Planned Technology Stack

- TypeScript
- React
- C#
- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- REST API
- xUnit
- Docker
- GitHub Actions

#### Technical Focus

- Role-based access control
- Input validation
- Duplicate detection
- Workflow state management
- Audit logging
- Database consistency
- Automated testing

#### Projectlink

Een GitHub-link wordt pas toegevoegd wanneer de repository bestaat en openbaar kan worden getoond.

### Afsluitend onderdeel

#### Titel

> Interested in How I Work?

#### Tekst

> Read my learning notes to see how I approach requirements, accessibility, architecture and technical problem-solving.

#### Actieknop

| Knoptekst | Bestemming |
|---|---|
| `Visit My Blog` | `blog.html` |

---

## 4. Blogpagina

### Bestandsnaam

`blog.html`

### Paginatitel in het browsertabblad

`Blog | Sofia`

### Meta-omschrijving

> Technical learning notes by Sofia about software design, web accessibility, backend development, databases and responsible AI.

### Paginaheader

#### Hoofdtitel

> Blog

#### Introductietekst

> I write about the concepts, tools and technical decisions I encounter while developing my software-engineering and AI skills. Each note connects theory to a practical example or project.

Publicatiedatums en links worden pas getoond wanneer een artikel werkelijk bestaat.

### Blogitem 1

#### Datum

> 24 August 2026

#### Categorie

> Software Design

#### Titel

> From Requirements to a Clear Technical Plan

#### Samenvatting

> Writing code is not always the first step. Clear requirements help define what an application must do, who will use it and how the result can be tested. In this note, I explain how I turn an idea into functional and non-functional requirements before implementation begins.

#### Gerelateerd project

> Secure Invoice Workflow

### Blogitem 2

#### Datum

> 28 August 2026

#### Categorie

> Web Accessibility

#### Titel

> Designing Accessible Navigation Without JavaScript

#### Samenvatting

> A simple navigation menu can still be responsive and accessible. This note explores semantic HTML, keyboard focus, `aria-current` and flexible layouts that work without a JavaScript hamburger menu.

#### Gerelateerd project

> Software Engineering Portfolio

### Blogitem 3

#### Datum

> 31 August 2026

#### Categorie

> Artificial Intelligence

#### Titel

> Why AI Answers Should Refer to Their Sources

#### Samenvatting

> AI-generated answers become more useful when users can inspect the information on which they are based. This note introduces source retrieval, grounded answers and the importance of communicating uncertainty.

#### Gerelateerd project

> AI Study Companion

### Afsluitend onderdeel

#### Titel

> Learning in Public

#### Tekst

> I use this blog to document what I learn, explain technical decisions in my own words and reflect on how my understanding develops through practice.

#### Actieknop

| Knoptekst | Bestemming |
|---|---|
| `View My Projects` | `projects.html` |

---

## 5. Technische implementatienotities

Deze onderdelen ondersteunen de pagina-inhoud, maar zijn zelf geen zichtbare webtekst:

- Iedere pagina gebruikt één `<main id="main-content">`.
- Iedere pagina bevat één zichtbare `<h1>`.
- De skiplink verwijst naar `#main-content`.
- De actieve navigatielink gebruikt `aria-current="page"`.
- Alle pagina’s verwijzen vanuit `<head>` naar `assets/css/style.css`.
- Informatieve afbeeldingen krijgen een betekenisvolle `alt`-tekst.
- Decoratieve afbeeldingen krijgen `alt=""`.
- Niet-bestaande project- of bloglinks worden niet als werkende links weergegeven.
- GitHub- en LinkedIn-adressen worden vóór publicatie gecontroleerd.

## 6. Definitieve footerinhoud

De footer toont op iedere pagina:

> © 2026 Sofia · Software Engineering Portfolio  
> GitHub · LinkedIn

De uitgebreidere technische informatie over HTML5, CSS3, toegankelijkheid en de projectstructuur wordt in `README.md` geplaatst.