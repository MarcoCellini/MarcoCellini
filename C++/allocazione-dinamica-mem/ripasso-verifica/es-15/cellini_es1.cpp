#include <iostream>

using namespace std;

struct Numero {
    string valore;
    Numero *next;
};

struct Lista {
    Numero *head;
};

void print(struct Lista *l) {
    struct Numero *temp = l->head;          // mi metto con uno temporaneo al livello della testa

    while (temp->next != NULL) {            // scorro fino a quando trovo NULL scendendo di uno alla volta
        cout << temp->valore << endl;
        temp = temp->next;
    }
}

Lista fill(struct Lista *l, string op) {
    struct Numero *tempN;
    l->head = new Numero();
    tempN = l->head;

    string word = "";
    for (auto i : op) {
        if (i != ' ') {
            word += i;
        } else {
            tempN->valore = word;
            tempN->next = new Numero();
            tempN = tempN->next;
            word = "";
        }
    }
    tempN->valore = word;
    tempN->next = new Numero();
    tempN = tempN->next;

    return *l;
}

int main() {
    struct Lista lista;

    string operazione;
    cout << "\nInserire l'operazione in notazione polacca inversa:\t";
    getline(cin, operazione);

    lista = fill(&lista, operazione);

    print(&lista);

    return 0;
}