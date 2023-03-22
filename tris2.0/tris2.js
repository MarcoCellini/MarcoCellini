let type = true, cont = 0, win = false, bot = false;

let gioco = [
    [0, 0, 0],
    [0, 0, 0],
    [0, 0, 0]
];

let status = [
    [false, false, false],
    [false, false, false],
    [false, false, false]
];

function dx(r, c, n) {
    try {
        if (gioco[r][c + 1] === n)
            return true;
    } catch {
        return false;
    }
    return false;
}

function dw(r, c, n) {
    try {
        if (gioco[r + 1][c] === n)
            return true;
    } catch {
        return false;
    }
    return false;
}

function dn(r, c, n) {
    try {
        if (gioco[r + 1][c + 1] === n)
            return true;
    } catch {
        return false;
    }
    return false;
}

function dp(r, c, n) {
    try {
        if (gioco[r + 1][c - 1] === n)
            return true;
    } catch {
        return false;
    }
    return false;
}

function victory(value, type_win) {
    win = true;
    switch (type_win) {
        case "dp":
            document.getElementById("dp").style.visibility = "visible";
            break;
        case "dn":
            document.getElementById("dn").style.visibility = "visible";
            break;
        case "h0":
            document.getElementById("htop").style.visibility = "visible";
            break;
        case "h1":
            document.getElementById("hmiddle").style.visibility = "visible";
            break;
        case "h2":
            document.getElementById("hbottom").style.visibility = "visible";
            break;
        case "v0":
            document.getElementById("vsx").style.visibility = "visible";
            break;
        case "v1":
            document.getElementById("vm").style.visibility = "visible";
            break;
        case "v2":
            document.getElementById("vdx").style.visibility = "visible";
            break;
    }

    if (value < 0) {
        document.getElementById("pop-up").innerHTML = "Il vincitore è il giocatore 1 [X]";
    } else if (value > 0) {
        document.getElementById("pop-up").innerHTML = "Il vincitore è il giocatore 2 [O]";
    }
}

function control() {
    for (let r = 0; r < status.length; r++) {
        for (let c = 0; c < status.length; c++) {
            if (!status[r][c])
                return false;
        }
    }
    return true;
}

function is_win(value, busy) {
    for (let i = 0; i < gioco.length; i++) {
        for (let j = 0; j < gioco.length; j++) {
            if (gioco[i][j] === value) {
                if (dx(i, j, value)) {
                    if (dx(i, j + 1, value)) {
                        victory(value, "h" + i);
                    }
                }

                if (dw(i, j, value)) {
                    if (dw(i + 1, j, value)) {
                        victory(value, "v" + j);
                    }
                }

                if (dn(i, j, value)) {
                    if (dn(i + 1, j + 1, value)) {
                        victory(value, "dn");
                    }
                }

                if (dp(i, j, value)) {
                    if (dp(i + 1, j - 1, value)) {
                        victory(value, "dp");
                    }
                }
            }
        }
    }

    if (busy == 9 && control() && !win)
        document.getElementById("pop-up").innerHTML = "Parità";
}

function restart() {
    location.reload();
}

function render() {
    for (let r = 0; r < gioco.length; r++) {
        for (let c = 0; c < gioco.length; c++) {
            if (gioco[r][c] === -1) {
                switch (r) {
                    case 0:
                        document.getElementById("t" + r + c).innerHTML = "X";
                        break;
                    case 1:
                        document.getElementById("m" + r + c).innerHTML = "X";
                        break;
                    case 2:
                        document.getElementById("b" + r + c).innerHTML = "X";
                        break;
                }
            } else if (gioco[r][c] === 1) {
                switch (r) {
                    case 0:
                        document.getElementById("t" + r + c).innerHTML = "O";
                        break;
                    case 1:
                        document.getElementById("m" + r + c).innerHTML = "O";
                        break;
                    case 2:
                        document.getElementById("b" + r + c).innerHTML = "O";
                        break;
                }
            } else {
                switch (r) {
                    case 0:
                        document.getElementById("t" + r + c).innerHTML = "&nbsp;&nbsp;&nbsp;";
                        break;
                    case 1:
                        document.getElementById("m" + r + c).innerHTML = "&nbsp;&nbsp;&nbsp;";
                        break;
                    case 2:
                        document.getElementById("b" + r + c).innerHTML = "&nbsp;&nbsp;&nbsp;";
                        break;
                }
            }
        }
    }
}

function fill_matrix(ID) {
    if (type && status[ID[1]][ID[2]] == false) {
        gioco[ID[1]][ID[2]] = -1;
        status[ID[1]][ID[2]] = true;
        type = false;
    } else if (status[ID[1]][ID[2]] == false) {
        gioco[ID[1]][ID[2]] = 1;
        status[ID[1]][ID[2]] = true;
        type = true;
    }
}

function x(ID) {
    if (!win) {
        cont += 1;
        if (!bot) {
            bot = !bot;
            console.log("io");
            fill_matrix(ID);
        } else {
            bot = !bot;
            console.log("bot");
            random_choose();
        }
        
        render();
        is_win(-1, cont);
        is_win(1, cont);
    }
}

function n_isvalid(r, c){
    if (!status[r][c])
        return true;
    else
        return false;
}

function random_choose() {
    let value = Math.floor(Math.random() * 9), r, c;

    if (value < 3)
        r = 0, c = value;
    else if (value > 5)
        r = 2, c = value - 6;
    else
        r = 1, c = value - 3;
    if (n_isvalid(r, c))
        fill_matrix("n" + r + c, true);
    else
        random_choose();
}
