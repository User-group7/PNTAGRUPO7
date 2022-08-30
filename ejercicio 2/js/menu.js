window.addEventListener("scroll", () => {
    let navbar = document.getElementById("navbar");
    var value = window.scrollY;
    if(value >= 700) {
      navbar.className = "menu menu-opacity";
    } else {
      navbar.className = "menu";
    }
  });