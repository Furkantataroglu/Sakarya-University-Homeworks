#ifndef KOLONI_H
#define KOLONI_H
#include "stdio.h"
#include "stdlib.h"
#include "math.h"

struct KOLONI{
    int population;
    int deger;
    int yemek;
    int kazanma;
    int kaybetme;
    void (*delete)(struct KOLONI*);
};
typedef struct KOLONI* Koloni;
Koloni new_Koloni(int);
void delete_Koloni(const Koloni);

#endif