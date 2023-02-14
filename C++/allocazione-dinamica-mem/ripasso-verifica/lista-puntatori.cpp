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

void push_front(struct Lista *l, int newValue) {
    struct Numero *newTesta;
    newTesta = new Numero();
    newTesta->numero = newValue;
    newTesta->next = l->head;
    l->head = newTesta;
}

void push_back(struct Lista *l, int newValue) {
    struct Numero *tempNumero = l->head;
    struct Numero *last;
    
    last->numero = newValue;
    //last->next = NULL;
    
    while (tempNumero->next != NULL) {
        if ((tempNumero->next)->next == NULL) {
            break;
        } else {
            tempNumero = tempNumero->next;
        }
    }

    tempNumero->next = last;
    last->next = NULL;
}

void pop_front(struct Lista *l) {
    struct Numero *tempNumero;
    tempNumero = l->head;
    l->head = tempNumero->next;
    delete(tempNumero);
}

void pop_back(struct Lista *l) {
    struct Numero *tempNumero = l->head;
    struct Numero *remove;

    while (tempNumero->next != NULL) {
        if ((tempNumero->next)->next == NULL) {
            break;
        } else {
            tempNumero = tempNumero->next;
        }
    }

    remove = tempNumero->next;
    tempNumero->next = NULL;
    delete(remove);
}

int main() {
    Lista lista;            // Nuova lista

    lista = fill(&lista);

    print(&lista);
    
    push_front(&lista, 99);
    push_front(&lista, 101);

    cout << endl << endl;
    print(&lista);

    pop_front(&lista);

    cout << endl << endl;
    print(&lista);

    
    pop_back(&lista);
    
    cout << endl << endl;
    print(&lista);

    push_back(&lista, 69);

    cout << endl << endl;
    print(&lista);

    return 0;
}