
// Tanımlar
const mobileMenuToggler =  document.getElementById("mobile-menu-toggler"),
      body = document.body;
      mobileHeader =  document.getElementById("mobil-header"),
      mobileMenu =  document.getElementById("mobil-menu"),
      logo = mobileHeader.querySelector(".left"),
      logoImg = logo.querySelector(".logo"),
      bars = mobileHeader.querySelector(".right i"),
      mobileMenuTogglerDiv = mobileHeader.querySelector(".mobile-menu-toggler-div");



// Mobil Menü Toggler
mobileMenuToggler.addEventListener("click", function() {
    body.classList.toggle("mobil-menu-opened");
    mobileMenu.classList.toggle("opened");
    bars.classList.toggle("rotated");
    bars.classList.toggle("fa-chevron-up");
    mobileMenuTogglerDiv.classList.toggle("mobile-menu-toggler-div-opened");
});

// Mobil Menü Scroll Events
window.onscroll = function() {mobilHeader()};


var sticky = mobileHeader.offsetTop;

function mobilHeader() {
  if (window.pageYOffset > sticky) {
    mobileHeader.classList.add("mobil-header-scrolled");
    logoImg.classList.add("logo-scrolled");
  } else {
    mobileHeader.classList.remove("mobil-header-scrolled");
    logoImg.classList.remove("logo-scrolled");
  }
}



// Menü Sub Items Toggle

function toggleSubItems(subID) {
    var subIDDiv = document.getElementById(subID);
    subIDDiv.classList.toggle("opened-sub");
}