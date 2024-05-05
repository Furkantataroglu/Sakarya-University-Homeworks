#ifndef SEKIL_H
#define SEKIL_H
#include "stdio.h"
#include "stdlib.h"
#include "time.h"
#include "math.h"
#include "string.h"

struct strategy
{
    int (*Savas)();
    void (*DELETE)(struct strategy*);
};
typedef struct strategy* Strategy;
Strategy CreateStrategy();
void DELETE(const Strategy);
#endif