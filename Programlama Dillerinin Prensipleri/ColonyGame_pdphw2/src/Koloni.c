#include "Koloni.h"

Koloni new_Koloni(int population){
    Koloni this;
    this = (Koloni)malloc(sizeof(struct KOLONI));
    this->population=population;
    this->delete=&delete_Koloni;

    return this;
}
void delete_Koloni(const Koloni this){
    if(this==NULL) return;
    free(this);
}