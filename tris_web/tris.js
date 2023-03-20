let type = true;

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

function victory(value) {
    if (value < 0) {
        window.alert("Ha vinto il giocatore 1 [X]");
    } else if (value > 0) {
        window.alert("Ha vinto il giocatore 2 [O]");
    }
}

function is_win(value) {
    for (let i = 0; i < gioco.length; i++) {
        for (let j = 0; j < gioco.length; j++) {
            if (gioco[i][j] === value) {
                if (dx(i, j, value)) {
                    console.log("andiamo a destra");
                    if (dx(i, j + 1, value)) {
                        console.log("win");
                        victory(value);
                    }
                }

                if (dw(i, j, value)) {
                    console.log("andiamo giu");
                    if (dw(i + 1, j, value)) {
                        console.log("win");
                        victory(value);
                    }
                }

                if (dn(i, j, value)) {
                    console.log("andiamo diag neg");
                    if (dn(i + 1, j + 1, value)) {
                        console.log("win");
                        victory(value);
                    }
                }

                if (dp(i, j, value)) {
                    console.log("andiamo diag pos");
                    if (dp(i + 1, j - 1, value)) {
                        console.log("win");
                        victory(value);
                    }
                }
            }
        }
    }
}

function x(ID) {
    if (type && status[ID[1]][ID[2]] == false) {
        document.getElementById(ID).innerHTML = "X";
        gioco[ID[1]][ID[2]] = -1;
        status[ID[1]][ID[2]] = true;
        type = false;
    } else if (status[ID[1]][ID[2]] == false) {
        document.getElementById(ID).innerHTML = "O";
        gioco[ID[1]][ID[2]] = 1;
        status[ID[1]][ID[2]] = true;
        type = true;
    }
    console.log(gioco);
    is_win(-1);
    is_win(1);
}