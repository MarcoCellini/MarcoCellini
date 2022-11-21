#include <iostream>

using namespace std;

int main() {
    int *puntatore, n = 5;         // memorizzo l'indirizzo dov'e' presente il numero

    puntatore = &n;     // assegno il valore int alla cella di mem puntatore

    cout << "locazione:\t" << &puntatore << "\nvalore:\t" << *puntatore << endl;        // * per il contenuto della locazione & per l'indirizzo

    return 0;
}