#include <iostream>

#define n_vagoni 3

using namespace std;

class treno {
    public:
        int postixvagone;
        int p_tot;

        treno() {}        
};

class vagone {
    public:
        int posti_liberi;

        vagone() {}
};

int main() {
    treno t;

    cout << "\nInserire il numero di posti per vagone:\t";
    cin >> t.postixvagone;

    t.p_tot = n_vagoni * t.postixvagone;

    vagone v[n_vagoni];

    for (int i = 0; i < 3; i++) {
        v[i].posti_liberi = t.postixvagone;
    }

    cout << "\n\nIl treno inizia la sua corsa vouto.\n";

    int n = 0;
    for (int i = 0; i < 2; i++) {
        cout << "\n\nIl treno raggiunge la " << i+1 << "^ fermata.\n";
        if (i = 0) {
            cout << "\nTutti i posti sono liberi.";
            cout << "\nInserire il numero di persone che SALGONO sul treno per ogni vagone:\n";
            for (int x = 0; x < n_vagoni; x++) {
                cout << "Vagone " << x+1 << ":\t";
                cin >> n;
                v[i].posti_liberi -= n;
            }

        }
        else {
            cout << "\nInserire il numero di persone che SALGONO sul treno per ogni vagone:\n";
            for (int x = 0; x < n_vagoni; x++) {
                cout << "Vagone " << x+1 << ":\t";
                cin >> n;
                v[i].posti_liberi -= n;
            }
            cout << "\nInserire il numero di persone che SCENDONO sul treno per ogni vagone:\n";
            for (int x = 0; x < n_vagoni; x++) {
                cout << "Vagone " << x+1 << ":\t";
                v[i].posti_liberi += n;
            }
        }
    }

    return 0;
}