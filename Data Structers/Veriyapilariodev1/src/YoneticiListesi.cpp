/**
* @file Dugum.cpp
* @description Yönetici Listesi

* @course  2. Öğretim  grup 2-C
* @assignment 1. Ödev
* @date 27/11/2022
* @author Furkan Tataroğlu  furkan.tataroglu@ogr.sakarya.edu.tr
*/

#include "YoneticiListesi.hpp"
#include <iomanip>
using namespace std;
#include <fstream>
#include <iostream>
#include <string>
#include<exception>
YoneticiListesi::YoneticiListesi()
{
    ilk=0;
}
YoneticiListesi::~YoneticiListesi(){
    Yoneticidugum* gec=ilk;
    while(gec!=0){
        Yoneticidugum* silinecek = gec;
        gec=gec->ysonraki;
        delete silinecek;
    }

}

void YoneticiListesi::ekle(SatirListesi* veri)
{   
   
    Yoneticidugum* yyeniDugum = new Yoneticidugum(veri);
   
    if(ilk==0)
    {
        ilk=yyeniDugum;
    }
    else
    {
        Yoneticidugum* ygecici = ilk;
        

        while(ygecici->ysonraki!=0){
            ygecici= ygecici->ysonraki;
        }
        ygecici->ysonraki = yyeniDugum;
        yyeniDugum->yonceki= ygecici;
        
    }
    

}

Yoneticidugum* YoneticiListesi::dugumGetir(int sira)
{
    Yoneticidugum* ygec =ilk;
    int sayac=0;

    while(ygec!=0)
    {
        if(sayac==sira)
        {return ygec;}
        ygec=ygec->ysonraki;
        sayac++;
    }
}

void YoneticiListesi::yCikar(int sira)
{   
   

    Yoneticidugum* silinecek = dugumGetir(sira);
    if(silinecek)
    {
        Yoneticidugum* silOnceki=silinecek->yonceki;
        Yoneticidugum* silSonraki= silinecek->ysonraki;
        

        if(silSonraki)
            silSonraki->yonceki=silOnceki;

        if(silOnceki)
        
            silOnceki->ysonraki = silSonraki;
        
        else
        ilk=silSonraki;
        
        delete silinecek;
    }
 
}

ostream& operator<<(ostream& os,YoneticiListesi& yoneticilistesi)
{
        Yoneticidugum* ygecici = yoneticilistesi.ilk;
        while(ygecici!=0){
            os<<setw(15)<<ygecici<<setw(15)<<ygecici->yonceki<<setw(15)<<ygecici->veri<<setw(15)<<ygecici->ysonraki<<endl;
            ygecici=ygecici->ysonraki;
        }
        os<<"-----------------"<<endl;

}


