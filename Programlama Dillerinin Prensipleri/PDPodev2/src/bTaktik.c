#include "bTaktik.h"
#include <stdlib.h>
#include <time.h>
Bstrategy BstrategyCreate(int* value){
     Bstrategy this;
    this=(Bstrategy)malloc(sizeof(struct BSTRATEGY));
    this->super = CreateStrategy(value);
    
    this->super->Savas = &BSavas;
    this->DELETE=&BstrategyDelete;
    return this;
}
int BSavas(){
    int randomnumber;
    randomnumber = rand() % 1000;
    randomnumber=(randomnumber*2)-500;
    if(randomnumber>1000)
    randomnumber=1000;

    if(randomnumber<0)
    randomnumber=0;
    return randomnumber;
}
void BstrategyDelete(const Bstrategy this){
     if(this==NULL) return;
    this->super->DELETE(this->super);
    free(this);

}