const REQUIRED_MESSAGES = {
  name: "Vul je naam in.",
  email: "Vul je e-mailadres in.",
  message: "Schrijf een bericht.",
};

const getErrorElement = (field) => {
  const errorId =
    field.getAttribute("aria-describedby");

  return errorId
    ? document.getElementById(errorId)
    : null;
};