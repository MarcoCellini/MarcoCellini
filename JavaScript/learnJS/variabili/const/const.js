/* una constante == const e' una variabile che non puo' essere modificata */

const PI = 3.14159;     // nome della costante deve essere MAIUSCOLO
let raggio;
let circonferenza;

raggio = Number(window.prompt("inserire il raggio del cerchio"));

circonferenza = raggio * 2 * PI6;

console.log("circonferenza = ", circonferenza);