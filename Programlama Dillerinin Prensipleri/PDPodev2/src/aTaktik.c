#include "aTaktik.h"
#include <stdlib.h>
#include <time.h>
Astrategy AstrategyCreate(){
    Astrategy this;
    this=(Astrategy)malloc(sizeof(struct ASTRATEGY));
    this->super = CreateStrategy();
    
    this->super->Savas = &Savas;
    this->DELETE=&AstrategyDelete;
    return this;
}
int Savas(){
    int randomnumber;
    randomnumber = rand() % 1000;
    return randomnumber;
}
void AstrategyDelete(const Astrategy this){
    if(this==NULL) return;
    this->super->DELETE(this->super);
    free(this);
};