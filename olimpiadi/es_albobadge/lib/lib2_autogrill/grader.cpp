#include <iostream>
#include <cassert>
#include <utility>
#include <vector>
#include <list>
#include <cmath>

using namespace std;

list<int> aperti;

void inizia() {
    return;
}

void apri(long long p) {
    aperti.push_back(p);
}


void chiudi(long long p) {
    aperti.remove(p);
}

long long chiedi(long long p) {
    if (aperti.empty())
        return -1;
    aperti.sort();
    int cont = 0;
    list <int>::iterator iter, pre;
    for (iter = aperti.begin(); iter != aperti.end(); ++iter) {
        if (*iter > p) {
            pre = prev(iter);
            if (*pre > 10000)
                return *iter;
            if (abs(p - *pre) > abs(p - *iter))
                return *pre;
            else if (abs(p - *pre) <= abs(p - *iter))
                return *iter;
            else
                return *iter;
        } else if (*iter == p)
            return *iter;
        cont++;
    }
    return -1;
}


int main() {
    freopen("autogrill.input1.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
    
    int Q;
    cin >> Q;

    inizia();

    for (int i = 0; i < Q; i++){
        long long p;
        char t;
        cin >> t >> p;
        if (t == 'a') apri(p);
        else if (t == 'c') chiudi(p);
        else cout << chiedi(p) << endl;
    }

    return 0;
}
