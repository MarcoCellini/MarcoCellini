function add_element (x = []) {
    for (i = 1; i < 5; i++) {
        x.push(i);
    }

    x.push('!');
    x.push('*');
    x.push('$');
    x.push('&');


    return x;
}

// Node.js program to demonstrate the
// process.argv Property
// Include process module
const process = require('process');
  
// Printing process.argv property value
var args = process.argv;

let info = [], cont = 0;
args.forEach((val, index) => {
    if (cont == 2) {info.push(`${val}`);}
    else if (cont == 3) {info.push(`${val}`);}
    cont++;
});

console.log("\nName:\t", info[0], "\nSurname:\t", info[1]);

info = add_element(info);

console.log(info);

/* var combi = [];
var temp= "";
var letLen = Math.pow(2, info.length);

for (var i = 0; i < letLen ; i++){
    temp= "";
    for (var j=0;j<letters.length;j++) {
        if ((i & Math.pow(2,j))){ 
            temp += letters[j]
        }
    }
    if (temp !== "") {
        combi.push(temp);
    }
}

console.log(combi.join("\n")); */