#ifndef ATAKTIK_H
#define ATAKTIK_H
#include "Taktik.h"

struct ASTRATEGY{
    Strategy super;
    void(*DELETE)(struct ASTRATEGY*);
};
typedef struct ASTRATEGY* Astrategy;

Astrategy AstrategyCreate();
int Savas();
void AstrategyDelete(const Astrategy);

#endif