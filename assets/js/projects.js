const projects = [
  {
    id: 1,
    title: "WPFW portfolio",
    description:
      "Portfolio gebouwd met HTML, CSS en JavaScript voor mijn WPFW-opdrachten.",
    technologies: [
      "HTML5",
      "CSS",
      "JavaScript",
      "DOM API",
      "Fetch API",
      "Toegankelijkheid",
    ],
    status: "In ontwikkeling",
    repositoryUrl: "https://github.com/Sofia-bit-2025/wpfw-portfolio-sofia",
    details: [
      "Projectgegevens worden vanuit JavaScript naar de DOM gerenderd.",
      "Het project kan worden gezocht op titel, beschrijving en techniek.",
      "Het contactformulier bevat client-side validatie en toegankelijke feedback.",
      "GitHub-data wordt via de Fetch API opgehaald en dynamisch weergegeven.",
    ],
  },
];

const normalizeText = (value) => {
  return value.trim().toLocaleLowerCase("nl-NL");
};

const projectMatchesSearch = (project, searchTerm) => {
  const normalizedSearchTerm = normalizeText(searchTerm);

  if (normalizedSearchTerm === "") {
    return true;
  }

  const searchableContent = normalizeText(
    [project.title, project.description, ...project.technologies].join(" "),
  );

  return searchableContent.includes(normalizedSearchTerm);
};

const filterProjects = (projectList, searchTerm) => {
  return projectList.filter((project) =>
    projectMatchesSearch(project, searchTerm),
  );
};

const createTechnologyList = (project) => {
  const list = document.createElement("ul");

  list.className = "tag-list";

  list.setAttribute("aria-label", `Gebruikte technieken voor ${project.title}`);

  for (const technology of project.technologies) {
    const item = document.createElement("li");

    item.className = "tag";
    item.textContent = technology;

    list.appendChild(item);
  }

  return list;
};