var type = true;

var gioco = [
                [0, 0, 0],
                [0, 0, 0],
                [0, 0, 0]
            ];

var vittorie = [
                [0, 1, 2],
                [3, 4, 5],
                [6, 7, 8],
                [0, 3, 6],
            ];

function x(ID) {
    if (type) {
        document.getElementById(ID).innerHTML = "X";
        gioco[ID[1]][ID[2]] = -1;
        type = false;
    } else {
        document.getElementById(ID).innerHTML = "O";    
        gioco[ID[1]][ID[2]] = 1;
        type = true;
    }

    console.log(gioco);
}