#include<stdio.h>
#include<math.h>

void  main()
{

int r,c,y,quad;
float media,somma=0;

printf ("\n\nInserisce dei numeri in una matrice");
printf ("\nLe righe sono:\t");
scanf ("%d",&r);
printf ("\nLe colonne sono:\t");
scanf ("%d",&c);

int i,mx [r] [c];

for (i=0;i<c;i++)
{
    for (y=0;y<r;y++)
    {
        printf ("\nInserire il numero:\t");
        scanf ("%d",&mx[i] [y]);
        somma=somma+ mx[i] [y];
    }
    
}

printf ("\nLa matrice e':\n");

for (i=0;i<c;i++)
{
    for (y=0;y<r;y++)
    {
        printf ("%d\t",mx[i] [y]);
    }
    printf ("\n");
}

media=somma/(r*c);

printf ("\nLa somma totale e':\t%f mentre la media e':\t%f",somma,media);
printf ("\nIl quadrato e':\n");

for (i=0;i<c;i++)
{
    for (y=0;y<r;y++)
    {
        quad=pow (mx[i] [y],2);
        printf ("%d\t",quad);
    }
    printf ("\n");
}


    return(0);

}
