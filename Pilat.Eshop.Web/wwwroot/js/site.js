// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.onscroll = function() {
    let currentScrollPos = window.pageYOffset;

    // 20 is an arbitrary number here, just to make you think if you need the prevScrollpos variable:
    if (currentScrollPos > 10) {
        // I am using 'display' instead of 'top':
        // document.getElementById("navbar").style.display = "none";
        document.getElementById("navbar").classList.add("shadow");
        document.getElementById("navbar").classList.add("gradient");
        document.getElementById("navbar").classList.remove("pt-4");

    } else {
        // document.getElementById("navbar").style.display = "initial";


        document.getElementById("navbar").classList.remove("gradient");
        document.getElementById("navbar").classList.remove("shadow");
        document.getElementById("navbar").classList.add("pt-4");
    }
}