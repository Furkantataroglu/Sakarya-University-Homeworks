/**
* @file Okuekle.cpp
* @description Veriler.txt den verileri alı düğümlere yerleştiriyor ve yazdırıyor.
* @course  2. Öğretim  grup 2-C
* @assignment 1. Ödev
* @date 27/11/2022
* @author Furkan Tataroğlu  furkan.tataroglu@ogr.sakarya.edu.tr
*/

#include "Okuekle.hpp"
#include "YoneticiListesi.hpp"
#include "SatirListesi.hpp"
#include "YoneticiDugum.hpp"
#include "EkranaYazdir.hpp"
#include <fstream>
#include <sstream>
#include <random>
#include <iomanip>
using namespace std;
Okuekle::Okuekle()
{
    satirsayisii=0;
    count=0;
}
void Okuekle::okueklee(SatirListesi* liste, YoneticiListesi* listee)
{
    ifstream veriler;
    veriler.open("veriler.txt"); 
    
if(veriler.is_open())
{
   YoneticiListesi* listee = new YoneticiListesi();
    while(getline(veriler, val))
    {
       
        istringstream ss(val);
        for (int i =0; i<val.length(); i++)
        {
            if(isspace(val.at(i)))
            {
                count++;
            }
        }
        
        SatirListesi* liste=new SatirListesi();
        
      
        for (int i = 0; i < count; i++)
        {
            ss>>vall;
            liste->ekle(vall);
            
        }
          
          
          listee->ekle(liste);
        
        satirsayisii++;
         
        count=0;
    } 
    veriler.close();


  
    Yazdir* yazdir = new Yazdir();
    int sira=0;
    int sutun=1;
    char secim=0;
    int b=0;
    
    while(true)
    {   
        string line;
        system("cls");
        if(sutun==1)
        {
            cout<<"Ilk"<<setw(100)<<"--------->"<<endl;
        }
        else if(sira<=8*sutun)
        {
            if(sutun*8>=satirsayisii)
            cout<<"<---------"<<setw(100)<<"Son"<<endl;
            else
            cout <<"<---------"<<setw(100)<<"--------->"<<endl;
        }
        yazdir->rYoneticiDugumadresi(listee, sutun, satirsayisii, sira,b );  
        cout<<endl;
        yazdir->satirGetir(listee,secim,sira,sutun);
       
    
       
        
        cin>>secim;
        if (secim=='d')
        {
            sira = sira+8;
            sutun++;
            
            if (sira>=satirsayisii)
            {
                sira = satirsayisii-1;
                sutun--;
                 if(sira==8*sutun-8)
            {
         
            b=b+8;
      
            }        
                
            }
            else
            {
                sira=(8*sutun)-8;
                  if(sira==8*sutun-8)
            {
         
            b=b+8;
      
            }        
            }
        
        }        
         if (secim=='a')
        {
            sira = sira-8;
            sutun--;
            if(sutun<=0)
            {
                sutun=1;
            }
            
            if (sira<8)
            {
                sira = 0;
                b=0;
            }
              else
            {
                sira=(8*sutun)-8;
                 if (sira<8)
            {
                sira = 0;
                b=0;
            }

            if(b!=0)
            {
                b=b-8;
            }
            
            }


        
        }        

        if(secim=='c')
        {
            if(sira<=satirsayisii-2)
            {
            sira++;
            }
           
            if(sira==8*sutun)
            {
                sutun++;
            }
             if(sira==8*sutun-8)
            {
         
            b=b+8;
      
            }        

        }
        if(secim=='z')
        {
            if(sira!=0)
            {
                sira--;
            }
            if(sira<8*sutun-8)
            {
                if(sutun!=1)
                {
                    sutun--;
                }
            } 
           if(sira<8)
           {
            b=0;
           }
            if(sira==(8*(sutun+1))-9)
            {
            if(b!=0)
            {
                b=b-8;
            }
            }
        }
       

        int bosluk=0;
        if(secim=='p')
        {  
             if(satirsayisii==1)
        {
             listee->dugumGetir(sira)->veri->~SatirListesi();
            listee->yCikar(sira);
            cout<<"Tum Satirlar Silindi"<<endl;
            satirsayisii--;
            return;

        }
        else
        {
            listee->dugumGetir(sira)->veri->~SatirListesi();
            listee->yCikar(sira);
            satirsayisii--;
             if(sira!=0)
                   sira--;
        }
        }
        

        if(secim=='k')
        {
             int random_integer;
            int sayi = listee->dugumGetir(sira)->veri->getCount();
            random_integer = rand() % sayi;
            cin>>secim;
            if(secim=='k')
            {   if(sayi!=1)
                {
                listee->dugumGetir(sira)->veri->cikar(random_integer);
                }
                if(sayi==1)
                {
                    listee->dugumGetir(sira)->veri->cikar(random_integer);
                    listee->dugumGetir(sira)->veri->~SatirListesi();
                   listee->yCikar(sira);
                   satirsayisii--;
                   if(sira!=0)
                   sira--;
                }
                
            }
            else 
            cout<<"Yanlış Giriş";
         
        }
    } 
    
    
    }    
}
   

    



  






