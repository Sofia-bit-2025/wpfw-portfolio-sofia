const toggleButton = document.querySelector(".blog-toggle");
const blogContent = document.querySelector("#semantic-html-content");

toggleButton.addEventListener("click", () => {
  const isExpanded = toggleButton.getAttribute("aria-expanded") === "true";

  toggleButton.setAttribute("aria-expanded", String(!isExpanded));
  blogContent.hidden = isExpanded;

  toggleButton.textContent = isExpanded ? "Lees verder" : "Toon minder";
});
