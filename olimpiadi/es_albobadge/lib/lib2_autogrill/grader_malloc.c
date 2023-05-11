#include <stdio.h>
#include <stdlib.h>
#include <signal.h>
#include <string.h>

long long aperti[100000];
int real_size = 0;

void inizia()
{
    return;
}

void apri(long long p, int index)
{
    aperti[index] = p;
}

void chiudi(long long p)
{
    int index = -2;
    for (size_t i = 0; i < real_size; i++)
    {
        if (aperti[i] == p)
            index = i;
    }

    for (size_t i = 0; i < real_size; i++)
    {
        if (i != -2)
            aperti[i] = aperti[i + 1];
        else
        {
            raise(SIGSEGV);
        }
    }
}

long long chiedi(long long p)
{
    if (real_size == 0)
        return -1;
    for (size_t i = 0; i < real_size; i++)
    {
        if (aperti[i] >= p)
        {
            printf("OK");
            return aperti[i];
        }
    }

    return -1;
}

int main()
{
    FILE *fptr;
    fptr = fopen("autogrill.input1.txt", "r");

    char buf[10];
    fgets(buf, 10, fptr);
    real_size = atoi(&buf[0]);
    inizia();

    char buffer[100];
    int i = 0;

    FILE *fout;
    fout = fopen("output.txt", "w");

    while (fgets(buffer, 100, fptr))
    {
        char t = buffer[0];
        long long p = atoi(&buffer[2]);
        if (i != real_size - 1)
            if (t == 'a')
                apri(p, i);
            else if (t == 'c')
                chiudi(p);
            else
            {
                if (i == real_size - 1)
                    fprintf(fout, "%i", chiedi(p));
                else
                    fprintf(fout, "%i\n", chiedi(p));
            };
        i++;
    }

    return 0;
}