#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#define MAXN 1005
int dp[MAXN][MAXN];

 #define max(a,b) ((a) > (b) ? (a) : (b))


int solve(int t) {
    int N, M;
    scanf("%d %d", &N, &M);

    int V[N], G[M];
    for (int i = 0; i < N; i++) {
        scanf("%d", &V[i]);
    }
    for (int i = 0; i < M; i++) {
        scanf("%d", &G[i]);
    }

    memset(dp, 0, sizeof dp);
    for (int i = 0; i < N; i++) {
        dp[i][0] = i;
        for (int j = 0; j < M; j++) {
            dp[i + 1][j + 1] = max(dp[i + 1][j], dp[i][j + 1] + 1);
            if(G[j] > V[i]) {
                dp[i + 1][j + 1] = max(dp[i + 1][j + 1], dp[i][j] + 2);
            }
        }
    }

    return dp[N][M];
}
int main() {
    // se preferisci leggere e scrivere da file
    // ti basta decommentare le seguenti due righe:

    freopen("mostra_input_7.txt", "r", stdin);
    freopen("output2.txt", "w", stdout);

    int T, t;
    scanf("%d", &T);

    for (t = 1; t <= T; t++) {
        printf("Case #%d: %d\n", t, solve(t));
    }
}