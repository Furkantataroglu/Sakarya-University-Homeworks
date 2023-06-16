#include "bUretim.h"
#include <stdlib.h>
#include <time.h>
BProduction BProductionCreate(){
    BProduction this;
    this=(BProduction)malloc(sizeof(struct BURETIM));
    this->super = CreateProduction();
    
    this->super->Uret = &BUret;
    this->pDELETE=&BProductionDelete;
    return this;
}
int BUret(){

    int randomnumber;
    randomnumber = rand() % (10 - 5 + 1) + 5;
    return randomnumber;
}
void BProductionDelete(const BProduction this){
    if(this==NULL) return;
    this->super->pDELETE(this->super);
    free(this);
};