#ifndef BURETIM_H
#define BURETIM_H
#include "Uretim.h"

struct BURETIM{
    Production super;
    void(*pDELETE)(struct BURETIM*);
};
typedef struct BURETIM* BProduction;

BProduction BProductionCreate();
int BUret();
void BProductionDelete(const BProduction);

#endif