#include <iostream>
#include <vector>

using namespace std;

#define N 3

struct nodo {
    string nome;
    int voto;
};

vector <nodo> alunni;

void firstAdd () {
    for (int i = 0; i < N; i++) {
        alunni.push_back(nodo());
        cout << "\nInserire il nome:\t";
        cin >> alunni.at(i).nome;
        cout << "Inserire il voto:\t";
        cin >> alunni.at(i).voto;
    }
}

void insert() {
    alunni.push_back(nodo());
    cout << "\nInserire il nome:\t";
    cin >> alunni.at(alunni.size() - 1).nome;
    cout << "Inserire il voto:\t";
    cin >> alunni.at(alunni.size() - 1).voto;
}

void remove() {
    int x;
    cout << "\nQuale vuoi eliminare:\t";
    cin >> x;
    alunni.erase(alunni.begin() + x - 1);
}

void edit() {
    
}

void stampa() {
    
}

int main() {
    firstAdd();

    char x;
    cout << "\nScegli la modalita':\n[i] per inserire\n[r] per rimuovere\n[m] per modificare\n........";
    cin >> x;
    switch (x) {
        case 'i':
            insert();
        break;

        case 'r':
            remove();
        break;

        case 'm':
            edit();
        break;
    }

    stampa();

    return 0;
}