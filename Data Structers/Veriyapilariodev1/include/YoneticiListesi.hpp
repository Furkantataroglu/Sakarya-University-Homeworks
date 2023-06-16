#ifndef YONETICILISTESI_HPP
#define YONETICILISTESI_HPP
#include "YoneticiDugum.hpp"

class YoneticiListesi
{
    public:
    Yoneticidugum* ilk;
    YoneticiListesi();
    ~YoneticiListesi();
    void ekle (SatirListesi* veri);
    void yCikar(int sira);
    friend ostream& operator<<(ostream& os,YoneticiListesi& yoneticilistesi);
    Yoneticidugum* dugumGetir(int sira);
    
    private:
       

};







#endif