#include <iostream>

using namespace std;

char found_char(char carattere, char frase[], int lunghezza) {
    char *puntatore;
    for (int i = 0; i <  lunghezza; i++) {
        if (frase[i] == carattere) {
            puntatore = &frase[i];
            return puntatore;
        }
    }
    

    return 0;
}

int main() {
    char s[] = "C'era una volta tanto tempo fa...", car;
    
    int l = sizeof(s) / sizeof(char);

    cout << "\nInserire il carattere da cercare nella frase:\t";
    cin >> car;

    found_char(car, s, l);

    return 0;
}