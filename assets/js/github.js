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
