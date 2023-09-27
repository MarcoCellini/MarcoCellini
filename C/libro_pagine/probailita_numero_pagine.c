#include <stdio.h>
#include <stdlib.h>
#include <math.h>

struct dictonary {      // dizionario dei risultati
    int key;
    int value;
};

void last_number(int n) {
    int tmp = n, count = 0;
    do {
        tmp /= 10;
        count++;
    } while (tmp != 0);
    printf("%f", pow(10, (double)(count - 1)));
}

int main(int argc, char **argv) {
    if (argc != 2) {                // controllo il passaggio del nummero di pagine
        printf("%s <numero pagine libro>", argv[0]);
        exit(1);
    }

    last_number(atoi(argv[1]));

    return 0;
}