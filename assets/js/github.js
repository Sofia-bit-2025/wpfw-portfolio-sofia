const GITHUB_API_URL =
  "https://api.github.com/repos/Sofia-bit-2025/wpfw-portfolio-sofia";

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

const fetchRepository = async () => {
  const response = await fetch(GITHUB_API_URL);

  if (!response.ok) {
    throw new Error(`HTTP ${response.status}`);
  }

  const repository = await response.json();

  if (!isValidRepository(repository)) {
    throw new Error("Onverwachte GitHub API-response.");
  }

  return repository;
};