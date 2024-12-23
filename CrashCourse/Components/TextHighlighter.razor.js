export function highlightText(id) {
    let el = document.getElementById(id);
    if (el) {
        el.style.color = "green";
        el.style.fontWeight = "bold";
    }
}
