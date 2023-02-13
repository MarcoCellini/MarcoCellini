#include <iostream>

using namespace std;

struct Numero {
    int numero;
    Numero *next; // Il prossimo numero
};

struct Lista {
    Numero *head; // Il primo numero da salvare
};

void print(struct Lista *l) {
    struct Numero *temp = l->head;          // mi metto con uno temporaneo al livello della testa

    while (temp->next != NULL) {            // scorro fino a quando trovo NULL scendendo di uno alla volta
        cout << temp->numero << endl;
        temp = temp->next;
    }
}

Lista fill(struct Lista *l) {
    Numero *numero;                  // Numero di appoggio
    l->head = new Numero();          // La testa va inizializzata la prima volta
    numero = l->head;             // Variabile di appoggio che aggiorneremo

    for (int i = 0; i < 10; i++) {
        numero->numero = i;                      // Assegno il numero    
        numero->next = new Numero();                 // Il prossimo numero
        numero = numero->next;                    // Assegno il nuovo numero alla variabile di appoggio
    }

    return *l;
}

int main() {
    Lista lista;            // Nuova lista

    lista = fill(&lista);

    print(&lista);
    
    return 0;
}