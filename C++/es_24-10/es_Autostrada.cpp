#include <iostream>

using namespace std;

class casello {
    protected:
        bool festivo;

    public:
        casello() {}
        ~casello() {}

        void set_casello(bool valore) {festivo = valore;}
        bool get_casello() {return festivo;}
};
class tir : public casello {
    int prezzo_tir;
        
};