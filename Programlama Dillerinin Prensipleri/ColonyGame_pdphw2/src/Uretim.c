#include "Uretim.h"

Production CreateProduction(){
    Production this;
    this = (Production)malloc(sizeof(struct PRODUCTION));
    return this;
}
void pDELETE(const Production this)
{
    if(this== NULL) return;
    free(this);
}