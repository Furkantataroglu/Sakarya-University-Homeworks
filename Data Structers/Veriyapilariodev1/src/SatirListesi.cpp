/**
* @file SatirListesi.cpp
* @description Verileri tutuyor
* @course  2. Öğretim  grup 2-C
* @assignment 1. Ödev
* @date 27/11/2022
* @author Furkan Tataroğlu  furkan.tataroglu@ogr.sakarya.edu.tr
*/

#include "SatirListesi.hpp"
#include "Okuekle.hpp"
#include <iomanip>
using namespace std;
#include <fstream>
#include <iostream>
#include <string>


SatirListesi::SatirListesi()
{
    ilk=0;
}
SatirListesi::~SatirListesi(){
    Dugum* gec=ilk;
    while(gec!=0){
        Dugum* silinecek = gec;
        gec=gec->sonraki;
        delete silinecek;
    }

}

void SatirListesi::ekle(int veri)
{   
   
    Dugum* yeniDugum = new Dugum(veri);
   
    if(ilk==0)
    {
        ilk=yeniDugum;
    }
    else
    {
        Dugum* gecici = ilk;
        

        while(gecici->sonraki!=0){
            gecici= gecici->sonraki;
        }
        gecici->sonraki = yeniDugum;
        yeniDugum->onceki= gecici;
        
    }

}
Dugum* SatirListesi::sDugumGetir(int sira)
{
    Dugum* gec=ilk;
    int sayac=0;
    while(gec!=0)
    {
        if(sayac==sira)
        {return gec;}
        gec=gec->sonraki;
        sayac++;
    }
}

void SatirListesi::cikar(int sSira)
{
    Dugum* silinecek = sDugumGetir(sSira);
    if(silinecek)
    {
        Dugum* silOnceki=silinecek->onceki;
        Dugum* silSonraki= silinecek->sonraki;
        

        if(silSonraki)
            silSonraki->onceki=silOnceki;

        if(silOnceki)
        
            silOnceki->sonraki = silSonraki;
        
        else
        ilk=silSonraki;
        
        delete silinecek;
    }
 
}

int SatirListesi::getCount()
{
    int count = 0;
    Dugum* current = ilk; 
    while (current != NULL) 
    {
        count++;
        current = current->sonraki;
    }
    return count;
}
double SatirListesi::Ortalama(int bosluk)
{
    double sum=0;
    double average=0;
        for(int i=0; i<bosluk;i++)
        {
            int gelenVeri=sDugumGetir(i)->veri;
            
            sum=sum+ gelenVeri;
            if(i==bosluk-1)
            {
            average=sum/bosluk;
            return average;
            }
        }
}
Dugum* SatirListesi::dugumleriGetir()
{
    Dugum* gec =ilk;
    
}

ostream& operator<<(ostream& os,SatirListesi& satirlistesi)
{
        Dugum* gecici = satirlistesi.ilk;
        while(gecici!=0){
            os<<setw(15)<<gecici<<setw(15)<<gecici->veri<<setw(15)<<gecici->onceki<<setw(15)<<gecici->sonraki<<endl;
            gecici=gecici->sonraki;
        }
        os<<"-----------------"<<endl;

}

