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

const getErrorMessage = (field) => {
  const value = field.value.trim();

  if (field.required && value === "") {
    return (
      REQUIRED_MESSAGES[field.name] ??
      "Dit veld is verplicht."
    );
  }

  if (
    field.type === "email" &&
    field.validity.typeMismatch
  ) {
    return "Vul een geldig e-mailadres in.";
  }

  if (
    field.minLength > 0 &&
    value.length < field.minLength
  ) {
    return `Gebruik minimaal ${field.minLength} tekens.`;
  }

  return "";
};

const validateField = (field) => {
  const errorMessage =
    getErrorMessage(field);

  const errorElement =
    getErrorElement(field);

  const isValid =
    errorMessage === "";

  field.setAttribute(
    "aria-invalid",
    String(!isValid),
  );

  if (errorElement) {
    errorElement.textContent =
      errorMessage;
  }

  return isValid;
};

const validateForm = (fields) => {
  let firstInvalidField = null;

  for (const field of fields) {
    const isValid =
      validateField(field);

    if (
      !isValid &&
      !firstInvalidField
    ) {
      firstInvalidField = field;
    }
  }

  return firstInvalidField;
};

const setFormStatus = (
  statusElement,
  message,
  type = null,
) => {
  statusElement.textContent = message;

  statusElement.classList.remove(
    "form__status--success",
    "form__status--error",
  );

  if (type) {
    statusElement.classList.add(
      `form__status--${type}`,
    );
  }
};

const handleFieldBlur = (event) => {
  const field = event.currentTarget;

  validateField(field);
};
