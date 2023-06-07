let cont = 0, record = 0;

function control(probability) {
    if (Math.floor(Math.random() * 100) > probability)
        return true;
    return false;
}

function plus() {
    let x = document.getElementById("cont");
    if (control(cont))
        x.innerHTML = ++cont;
    else {
        if (cont > record) {
            let r = document.getElementById("record");
            record = cont;
            r.innerHTML = r.innerHTML.split('=')[0] + "= " + record;
        }
        x.innerHTML = cont = 0;
    }
}
