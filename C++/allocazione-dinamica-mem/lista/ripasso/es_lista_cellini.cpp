#include <iostream>
#include <list>

using namespace std;

void print(list<int> x) {
    for(int i : x) {
        cout << i << "\t";
    }
    cout << endl;
}

int main() {
    list<int> lista;
    list<int>::iterator it;

    srand(time(NULL));
    for (int i = 0; i < 5; i++) {
        lista.push_back(rand());
    }

    int cont = 0;
    for (it = lista.begin(); it != lista.end(); ++it) {
        if (cont == 2) {
            lista.insert(it, 33);
        }
        cont++;
    }

    print(lista);

    return 0;
}