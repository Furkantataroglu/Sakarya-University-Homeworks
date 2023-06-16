#ifndef SatirListesi_hpp
#define SatirListesi_hpp
#include<iostream>
#include<exception>
#include "Dugum.hpp"

class SatirListesi
{
    public:
        SatirListesi();
        ~SatirListesi();
        void ekle(int veri);
        void cikar(int sSira);
        int getCount();
        friend ostream& operator<<(ostream& os,SatirListesi& satirlistesi);
        Dugum* sDugumGetir(int sira);
        Dugum* dugumleriGetir();
        double Ortalama(int bosluk);
    private:
        Dugum* ilk;

};

#endif