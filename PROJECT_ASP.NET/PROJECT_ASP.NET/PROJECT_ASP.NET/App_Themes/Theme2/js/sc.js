
// Get the email input elements and error elements
const emailInputs = document.querySelectorAll('input[type="email"]');
const errorElements = document.querySelectorAll('.error-message');

// Loop through each email input
emailInputs.forEach((emailInput, index) => {
  // Add an event listener for the "input" event
  emailInput.addEventListener('input', function () {
    const email = emailInput.value;
    const isValid = validateEmail(email);

    if (isValid) {
      // Remove any existing error message or styling
      emailInput.classList.remove('error');
      errorElements[index].textContent = '';
    } else {
      // Add error styling to the input element
      emailInput.classList.add('error');
      // Display the error message
      errorElements[index].textContent = 'Please enter a valid email address.';
    }
  });
});
