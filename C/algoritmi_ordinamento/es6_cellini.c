#include<stdio.h>
#include<stdlib.h>
#include<string.h>

int cmpfunc (const void * a, const void * b)
{
    const char **ia = (const char **)a;
    const char **ib = (const char **)b;
    return strcmp(*ia, *ib);
}

int main()
{
    char arr_str[5] [8] = { {"ciao"},
                            {"sono"},
                            {"pippo"},
                            {"pluto"},
                            {"armadio"} };

    qsort (arr_str, 8, sizeof (char*), cmpfunc);

    for (int i = 0; i < sizeof(arr_str)/8; i++)
        printf ("%s\t", arr_str[i]);

    return 0;
}