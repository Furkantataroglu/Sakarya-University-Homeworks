/**
* @file EkranaYazdir.cpp
* @description Düğümleri ekrana yazdırmaya yarayan fonksiyonlar.
* @course  2. Öğretim  grup 2-C
* @assignment 1. Ödev
* @date 27/11/2022
* @author Furkan Tataroğlu  furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "EkranaYazdir.hpp"
using namespace std;
#include <iomanip>
void Yazdir::cizgiCizdir()
{
    for(int i =0; i< 8; i++)
    
    cout<<setw(11)<<"---------";
    cout<<endl;
     
}
void Yazdir::rYoneticiDugumadresi(YoneticiListesi* liste, int sutun,int satirsayisii,int sira,int b)
{   
    Yazdir d1;
   
    

    for(int i =b; i<8*sutun; i++)
    {   
         if(i<satirsayisii)
         {
        if(i<=8*sutun)
           cout<< setw(11)<<liste->dugumGetir(i);
         }
    
        
    }
    cout<<endl;
    d1.cizgiCizdir();
    for(int i =b; i<8*sutun; i++)
    {   
        
        if(i<satirsayisii)
        {
        if(i<=8*sutun)
       
           cout<< setw(11)<<liste->dugumGetir(i)->yonceki;
        }
  
     
        
    }
    cout<<endl;
    d1.cizgiCizdir();
     
     for(int i =b; i<8*sutun; i++)
    {   
         if(i<satirsayisii)
         {
        if(i<=8*sutun)
           cout<< setw(11) <<"|  x   |";
         }
    
        
    }
   
    cout<<endl;
    d1.cizgiCizdir();
    for(int i =b; i<8*sutun; i++)
    {   
        
        if(i<satirsayisii)
        {
        if(i<=8*sutun)
           cout<< setw(11)<<liste->dugumGetir(i)->ysonraki;
        }
     
        
    }
    cout<<endl;
    d1.cizgiCizdir();
    d1.ara(sira,sutun);cout<<endl;
    

 





}
  void Yazdir::satirGetir(YoneticiListesi* liste,char secim,int sira,int sutun)
  {
    int sayi = liste->dugumGetir(sira)->veri->getCount();
    for(int j=0; j<sayi;j++)
    {
        int i=0;
       if(sira!=0 && sira>=8*(sutun-1))
       {
         i =8*(sutun-1);
       }
    
    cout<<setw(11*(sira-i));cout<<""<<"   |"<<liste->dugumGetir(sira)->veri->sDugumGetir(j)<<"|"<<endl;
    cout<<setw(11*(sira-i));cout<<""<<"   ----------"<<endl;
    cout<<setw(11*(sira-i));cout<<""<<"   |   "<<liste->dugumGetir(sira)->veri->sDugumGetir(j)->veri<<"   |"<<endl;
    cout<<setw(11*(sira-i));cout<<""<<"   ----------"<<endl;
    cout<<setw(11*(sira-i));cout<<""<<"   |"<<liste->dugumGetir(sira)->veri->sDugumGetir(j)->sonraki<<"|"<<endl;
    
    cout<<endl;
  }
  }
void Yazdir::ara(int sira,int sutun)

{
     int i=0;
       if(sira!=0 && sira>=8*(sutun-1))
       {
         i =8*(sutun-1);
       }
    
   cout<<setw(11*(sira-i));cout<<""<<"   ^^^^^^^^"<<endl;
}
