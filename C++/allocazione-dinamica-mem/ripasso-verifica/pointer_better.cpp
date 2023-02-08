#include <iostream>
using namespace std;

struct Numero {
    int numero;
    Numero *next; // Il prossimo numero
};

struct Lista {
    Numero *head; // Il primo numero da salvare
};

void PrintLista(Lista *lista){
    Numero *pointer = lista->head;  // Il primo elemento della lista
    while (pointer != NULL)
    {
        cout << pointer->numero << endl;
        pointer = pointer->next;    // Aggiorno sempre il puntatore a quello nuovo
    }
}

int main()
{

    Lista p; // Nuova lista
    Numero *n;  // Numero di appoggio
    p.head = new Numero(); // La testa va inizializzata la prima volta
    n = p.head;    // Variabile di appoggio che aggiorneremo

    for (int i = 0; i < 10; i++) {
        n->numero = i;  // Assegno il numero    
        n->next = new Numero(); // Il prossimo numero
        n = n->next;    // Assegno il nuovo numero alla variabile di appoggio
    }

    PrintLista(&p);
    return 0;
}