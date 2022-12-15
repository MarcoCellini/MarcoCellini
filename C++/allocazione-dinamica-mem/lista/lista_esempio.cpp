#include <iostream>
#include <list>

using namespace std;

int main() {
    list <int> lista = {1, 2, 6, 5, 8, 1, 100, 3, 7};       // dichiarazione di una lista

    lista.push_back(9);     // come per i vettori

    cout << lista.front() << endl;       // stampa il primo della lista

    lista.remove(3);        // rimuovo l'elemento 3

    list <int>::iterator iter;
                                // iteratore alla lista
    iter = lista.begin();

    for (iter = lista.begin(); iter != lista.end(); ++iter) {
        cout << *iter << endl;
    }

    return 0;
}