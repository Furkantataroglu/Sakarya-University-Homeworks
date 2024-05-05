#ifndef OYUN_H
#define OYUN_H
#include "stdio.h"
#include "stdlib.h"
#include "math.h"
#include "Koloni.h"
#include "aTaktik.h"
#include "bTaktik.h"
#include "aUretim.h"
#include "bUretim.h"


struct OYUN{
    
    void (*delete)(struct OYUN*);
};
typedef struct OYUN* Oyun;
Oyun new_Oyun(Koloni[],int);
void delete_Oyun(const Oyun);

#endif