#include <iostream>
#include <bitset>
#include <stdlib.h>

using namespace std;

class Conversioni {
    private:
        int n;

    public:
        Conversioni() {}
        ~Conversioni() {}

        void set(int x) {n = x;}
        int get() {return n;}

        bitset<8> converti() {return(bitset<8>(n));}
};

Conversioni c;

void riempi() {
    int valore;
    cout << "\nInserire il numero da convertire:\t";
    cin >> valore;
    if (valore < 0 || valore > 255) {
        cout << "\nValore INVALIDO!!!";
        exit(1);
    }    
    c.set(valore);
}

void print() {
    cout << "\nIl numero " << c.get() << " in binario corrisponde a:\t" << c.converti();
}

int main() {
    riempi();
    print();
    return 0;
}