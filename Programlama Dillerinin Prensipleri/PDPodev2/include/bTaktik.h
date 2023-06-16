#ifndef BTAKTIK_H
#define BTAKTIK_H
#include "Taktik.h"

struct BSTRATEGY{
    Strategy super;
    void(*DELETE)(struct BSTRATEGY*);
};
typedef struct BSTRATEGY* Bstrategy;
Bstrategy BstrategyCreate();
int BSavas();
void BstrategyDelete(const Bstrategy);

#endif