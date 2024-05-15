document.addEventListener("DOMContentLoaded", function () {
  document.addEventListener("click", function (event) {
    const navbar = document.getElementById("navbar");
    const toggler = document.querySelector(".navbar-toggler");

    const isNavItemClicked = event.target.closest(".nav-item");

    // Jika pengguna mengklik di luar navbar atau pada elemen nav-item
    if (!navbar.contains(event.target) || isNavItemClicked) {
      const navbarCollapse = document.querySelector("#navbarSupportedContent");
      if (navbarCollapse.classList.contains("show")) {
        toggler.click();
      }
    }
  });
});
