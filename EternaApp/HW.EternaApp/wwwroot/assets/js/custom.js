var path = window.location.pathname.split("/")[1]

if (path == "") {
    document.getElementById("home").classList.add("active")
}
else {
    document.getElementById(path).classList.add("active")
}