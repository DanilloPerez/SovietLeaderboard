function toggleDarkmode() {
    var element = document.body
    element.classList.toggle("Dark-Mode") 
    document.getElementById("navbarSupportedContent").classList.toggle("Dark-Mode")
    var elements = document.getElementsByClassName("Background")
    for (var i = 0; i < elements.length; i++) {
        elements[i].classList.toggle("Dark-Mode")
    }
    document.getElementById("").classList.toggle("Dark-Mode")
}
function checkDarkmode() {
    if (document.body.classList.contains("Dark-Mode")) {
        return true
    }
    return false
}