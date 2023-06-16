#ifndef AURETIM_H
#define AURETIM_H
#include "Uretim.h"

struct AURETIM{
    Production super;
    void(*pDELETE)(struct AURETIM*);
};
typedef struct AURETIM* AProduction;

AProduction AProductionCreate();
int Uret();
void AProductionDelete(const AProduction);

#endif