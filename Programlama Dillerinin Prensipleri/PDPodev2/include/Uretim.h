#ifndef URETIM_H
#define URETIM_H
#include "stdio.h"
#include "stdlib.h"
#include "time.h"
#include "math.h"
#include "string.h"

struct PRODUCTION
{
    int* value;
    int* population;
    int (*Uret)();
    void (*pDELETE)(struct PRODUCTION*);
};
typedef struct PRODUCTION* Production;
Production CreateProduction();
void pDELETE(const Production);
#endif