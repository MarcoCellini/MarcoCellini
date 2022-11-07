#include <iostream>
#include <fstream>

#define persone 3

int old_contact = 0;

using namespace std;

fstream Rubrica;

class rubrica {
    public:
        int numero;
        string nome, cognome;

        rubrica() {}
        ~rubrica() {}
        
};

rubrica r[100];

void search() {

}

void control(int n, int x) {
    for (int i = 0; i < persone; i++) {
        if (r[i].numero == n && i != x) {
            r[i].numero = -1;
        }
    }
}

void fill_from_file() {
    Rubrica.open("rubrica.txt", ios::in);

    char line[100];
    while (!Rubrica.eof()) {
        Rubrica.getline(line, 100);

        

        old_contact++;
    }

    Rubrica.close();
}

void IO_fill_rub() {
    Rubrica.open("rubrica.txt", ios::app);

    for (int i = 0; i < persone; i++) {
        cout << "\nInserire il nome:\t";
        cin >> r[i].nome;
        cout << "\nInserire il cognome:\t";
        cin >> r[i].cognome;
        cout << "\nInserire il numero di telefono:\t";
        cin >> r[i].numero;
        control(r[i].numero, i);
    }

    for (int i = 0; i < persone; i++) {
        if (r[i].numero != -1) {
            Rubrica << r[i].nome << " " << r[i].cognome << ":\t" << r[i].numero << endl;
        }
        else {
            Rubrica << r[i].nome << " " << r[i].cognome << ":\t" << "numero ripetuto" << endl;
        }
    }

    Rubrica.close();
}

int main() {
    fill_from_file();
    IO_fill_rub();

    return 0;
}