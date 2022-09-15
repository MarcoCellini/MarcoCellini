#include <iostream>
#include <string>
using namespace std;

class myClass {
    public:                 // tipo di accesso
        int myNum;              // Attributo (int variabile)
        string myString;     // Attributo (variabile string)
};

int main() {
    myClass myObj;      // creazione di un oggetto della classe "myClass"

    // Accedere agli attributi e settare i valori
    myObj.myNum = 69;
    myObj.myString = "Pippo";

    // Stampare i valori
    cout << myObj.myNum << "\n" << myObj.myString << "\n";

    return 0;
}