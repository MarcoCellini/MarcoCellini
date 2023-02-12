/* ripete qualcosa fino a quando non cambia una determinata condizione */

let nome = "";

/* se nel promt si schiaccia annulla si inserire il valore NULL */

while (nome == "" || nome == null) {            // fino a quando non inserisce una non nome glielo richiede
    nome = window.prompt("Inserire il nome:");
}

console.log("weeee ", nome);

/* infinitive while loop */

/* while (1) {
    console.log("weeeee");
} */