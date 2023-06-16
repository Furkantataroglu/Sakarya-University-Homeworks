#include "Taktik.h"

Strategy CreateStrategy(){
    Strategy this;
    this = (Strategy)malloc(sizeof(struct strategy));
    return this;
}
void DELETE(const Strategy this)
{
    if(this== NULL) return;
    free(this);
}