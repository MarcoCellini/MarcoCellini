#include <iostream>
#include <queue>

using namespace std;

struct Numero {
    int numero;
    Numero *next; // Il prossimo numero
};

struct Pila {
    Numero *head; // Il primo numero da salvare
};

void PrintPila(Pila *pila){
    Numero *pointer = pila->head;  // Il primo elemento della lista
    while (pointer != NULL)
    {
        cout << pointer->numero << endl;
        pointer = pointer->next;    // Aggiorno sempre il puntatore a quello nuovo
    }
}

Pila ins(Pila p, Numero *n) {
    p.head = new Numero();
    n = p.head;

    for (int i = 0; i < 10; i++) {
        n->numero = i;
        /* n->next = new Numero();
        n = n->next; */
        n->next = NULL;
        /* n = new Numero(); */
    }

    return p;
}

int main() {
    Pila p;
    Numero *n;

    p = ins(p, n);

    PrintPila(&p);

    return 0;
}