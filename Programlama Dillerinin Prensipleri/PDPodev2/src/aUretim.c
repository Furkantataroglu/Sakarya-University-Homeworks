#include "aUretim.h"
#include <stdlib.h>
#include <time.h>
AProduction AProductionCreate(){
    AProduction this;
    this=(AProduction)malloc(sizeof(struct AURETIM));
    this->super = CreateProduction();
    
    this->super->Uret = &Uret;
    this->pDELETE=&AProductionDelete;
    return this;
}
int Uret(){
    
    int randomnumber;
    randomnumber = rand() % (5 - 1 + 1) + 1;
    return randomnumber;
}
void AProductionDelete(const AProduction this){
    if(this==NULL) return;
    this->super->pDELETE(this->super);
    free(this);
};