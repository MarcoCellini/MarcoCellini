#include <stdio.h>
#include <assert.h>
#include<stdlib.h>

#define MAXN 100000

int cmpfunc (const void * a, const void * b) {
   return ( *(int*) - *(int*)b );
}

int sfangate(int N, int V[]) {    
    qsort (V, (sizeof V)/4, sizeof (int), cmpfunc);    
}


int V[MAXN];

int main() {
    FILE *fr, *fw;
    int N, i;

    fr = fopen("input.txt", "r");
    fw = fopen("output.txt", "w");
    assert(1 == fscanf(fr, "%d", &N));
    for(i=0; i<N; i++)
        assert(1 == fscanf(fr, "%d", &V[i]));

    fprintf(fw, "%d\n", sfangate(N, V));
    fclose(fr);
    fclose(fw);
    return 0;
}