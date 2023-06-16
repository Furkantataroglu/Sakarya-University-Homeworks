#ifndef EkranaYazdir_hpp
#define EkranaYazdir_hpp
#include "Dugum.hpp"
#include "Okuekle.hpp"
#include "SatirListesi.hpp"
#include "YoneticiDugum.hpp"
#include "YoneticiListesi.hpp"

class Yazdir
{
    public:
    void cizgiCizdir();
    void rYoneticiDugumadresi(YoneticiListesi* liste, int sutun,int satirsayisii,int sira,int b);
    void rSatir(SatirListesi* liste);
    void satirGetir(YoneticiListesi* list,char secim,int sira,int sutun);
    void ara(int sira,int sutun);

    
};








#endif