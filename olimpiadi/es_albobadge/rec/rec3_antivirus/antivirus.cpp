#include <string>
#include <iostream>
#include <fstream>
#include <cstdio>

using namespace std;

void solve(int t) {
    int N1, N2, N3, N4;
    cin >> N1 >> N2 >> N3 >> N4;

    int M, pos = 0;
    cin >> M;

    string F1, F2, F3, F4, tmp;
    cin >> F1 >> F2 >> F3 >> F4;

    int p1, p2, p3, p4;

    while (pos != N1 - M) {
        tmp = F1.substr(pos, M);
        if ()
        pos++;
    }
    

    cout << "Case #" << t << ": " << p1 << " " << p2 << " " << p3 << " " << p4 << endl;
}

int main() {

    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);

    int T;
    cin >> T;

    for (int t = 1; t <= T; t++) {
        solve(t);
    }
}