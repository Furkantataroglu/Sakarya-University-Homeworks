/**
* @file Veriyapilariodev2
* @description Programımız veri yapılarını kullanarak ekrana organizma ve entere basıldığında organizmanın mutasyonlu halini çıkarıyor.
* @course 2. Öğretim örgün C grubu 
* @assignment Veri yapıları 2. ödevi
* @date 24.12.2022
* @author Furkan Tataroğlu    furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "Organ.hpp"
#include <iomanip>
using namespace std;
#include <fstream>
#include <iostream>
#include <string>
#include<exception>
Organ::Organ()
{
    ilk=0;
}
Organ::~Organ(){
    OrganDugum* gec=ilk;
    while(gec!=0){
        OrganDugum* silinecek = gec;
        gec=gec->ysonraki;
        delete silinecek;
    }

}

void Organ::ekle(BinaryTree* veri)
{   
   
    OrganDugum* yyeniDugum = new OrganDugum(veri);
   
    if(ilk==0)
    {
        ilk=yyeniDugum;
    }
    else
    {
        OrganDugum* ygecici = ilk;
        

        while(ygecici->ysonraki!=0){
            ygecici= ygecici->ysonraki;
        }
        ygecici->ysonraki = yyeniDugum;
        yyeniDugum->yonceki= ygecici;
        
    }
    

}

OrganDugum* Organ::dugumGetir(int sira)
{
    OrganDugum* ygec =ilk;
    int sayac=0;

    while(ygec!=0)
    {
        if(sayac==sira)
        {return ygec;}
        ygec=ygec->ysonraki;
        sayac++;
    }
}