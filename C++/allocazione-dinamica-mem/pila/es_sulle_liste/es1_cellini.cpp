#include <iostream>
#include <list>

using namespace std;

void print(list <int>::iterator iter, list <int> lista) {
    for (iter = lista.begin(); iter != lista.end(); ++iter) {
        cout << *iter << endl;
    }
}

bool primi(int n) {         // controlla se il numero e' primo
    if (n <= 1) {return false;}
    if (n <= 3) {return true;}
    if (n % 2 == 0 || n % 3 == 0) {return false;}

    for (int i = 5; i * i <= n; i += 6) {
        if (n % i == 0 || n % (i + 2) == 0) {
            return false;
        }
    }
    return true;
}

int main() {
    list<int> n = {4, 34, 6, 1, 65, 76, 31, 3, 17, 34, 20, 32, 101}, copy;
    list<int>::iterator it;

    for (it = n.begin(); it != n.end(); ++it) {
        if(*it > 10 && *it < 100 && primi(*it)) {
            copy.push_back(*it);
        }
    }

    print(it, copy);

    return 0;
}