const GITHUB_API_BASE_URL = "https://api.github.com/repos/Sofia-bit-2025";

const GITHUB_REPOSITORIES = [
  "wpfw-portfolio-sofia",
  "smart-environment-dashboard-pv",
  "database-assignments",
];

const formatDate = (dateString) => {
  const date = new Date(dateString);

  if (Number.isNaN(date.getTime())) {
    return "Datum onbekend";
  }

  return new Intl.DateTimeFormat("nl-NL", {
    day: "numeric",
    month: "short",
    year: "numeric",
  }).format(date);
};

const isValidRepository = (repository) => {
  return (
    repository &&
    typeof repository === "object" &&
    typeof repository.name === "string" &&
    typeof repository.html_url === "string" &&
    typeof repository.updated_at === "string"
  );
};

const fetchRepository = async (repositoryName) => {
  const url = `${GITHUB_API_BASE_URL}/${repositoryName}`;

  const response = await fetch(url);

  if (!response.ok) {
    throw new Error(
      `GitHub request voor ${repositoryName} mislukt: HTTP ${response.status}`,
    );
  }

  const repository = await response.json();

  if (!isValidRepository(repository)) {
    throw new Error(`Onverwachte GitHub API-response voor ${repositoryName}.`);
  }

  return repository;
};

const fetchRepositories = async () => {
  const requests = GITHUB_REPOSITORIES.map((repositoryName) =>
    fetchRepository(repositoryName),
  );

  return Promise.all(requests);
};

const createRepositoryInformation = (repository) => {
  const information = document.createElement("ul");

  information.className = "tag-list";

  information.setAttribute(
    "aria-label",
    `Repositoryinformatie voor ${repository.name}`,
  );

  if (repository.language) {
    const language = document.createElement("li");

    language.className = "tag";
    language.textContent = repository.language;

    information.appendChild(language);
  }

  const updated = document.createElement("li");

  updated.className = "tag";
  updated.textContent = `Bijgewerkt ${formatDate(repository.updated_at)}`;

  information.appendChild(updated);

  return information;
};

const createRepositoryCard = (repository) => {
  const listItem = document.createElement("li");

  const article = document.createElement("article");
  article.className = "card";

  const title = document.createElement("h3");

  const link = document.createElement("a");
  link.href = repository.html_url;
  link.textContent = repository.name;

  title.appendChild(link);

  const description = document.createElement("p");

  description.textContent =
    repository.description || "Geen beschrijving beschikbaar.";

  const information = createRepositoryInformation(repository);

  article.append(title, description, information);

  listItem.appendChild(article);

  return listItem;
};

const renderRepositories = (repositoryListElement, repositories) => {
  repositoryListElement.replaceChildren();

  for (const repository of repositories) {
    const repositoryCard = createRepositoryCard(repository);

    repositoryListElement.appendChild(repositoryCard);
  }
};

const setApiStatus = (statusElement, message, isError = false) => {
  statusElement.textContent = message;

  statusElement.hidden = message === "";

  statusElement.classList.toggle("api-status--error", isError);
};

const initGitHubRepositories = async () => {
  const statusElement = document.querySelector("#github-status");

  const repositoryListElement = document.querySelector("#github-repositories");

  if (!statusElement || !repositoryListElement) {
    return;
  }

  setApiStatus(statusElement, "Repositories laden...");

  try {
    const repositories = await fetchRepositories();

    renderRepositories(repositoryListElement, repositories);

    setApiStatus(statusElement, "");
  } catch (error) {
    repositoryListElement.replaceChildren();

    setApiStatus(
      statusElement,
      "De GitHub-gegevens konden niet worden geladen. Probeer het later opnieuw.",
      true,
    );

    console.error("GitHub-repositories laden mislukt:", error);
  }
};

initGitHubRepositories();
