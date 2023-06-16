#ifndef YONETICIDUGUM_HPP
#define YONETICIDUGUM_HPP
#include "SatirListesi.hpp"
class Yoneticidugum
{
    public:
    
    Yoneticidugum(SatirListesi* veri);
    SatirListesi* veri;
    Yoneticidugum* ysonraki;
    Yoneticidugum* yonceki;


};







#endif