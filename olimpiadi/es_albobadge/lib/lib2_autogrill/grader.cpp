#include <iostream>
#include <cassert>
#include <utility>
#include <vector>
#include <list>
#include <bits/stdc++.h>

using namespace std;

vector<int> aperti;

void inizia() {
    return;
}

void apri(long long p) {
    make_heap(aperti.begin(), aperti.end());
    aperti.push_back(p);
}


void chiudi(long long p) {
    make_heap(aperti.begin(), aperti.end());
    remove(aperti.begin(), aperti.end(), p);
}

long long chiedi(long long p) {
    make_heap(aperti.begin(), aperti.end());
    if (aperti.empty())
        return -1;
    sort(aperti.begin(), aperti.end());
    for (long long x : aperti) {
        if (x >= p) {
            return x;
        }
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
        if(i != Q - 1)
        if (t == 'a') apri(p);
        else if (t == 'c') chiudi(p);
        else {
            if(i == Q - 1)
                cout << chiedi(p);
            else
                cout << chiedi(p) << endl;
        };
    }

    return 0;
}