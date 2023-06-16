/**
* @file Veriyapilariodev2
* @description Programımız veri yapılarını kullanarak ekrana organizma ve entere basıldığında organizmanın mutasyonlu halini çıkarıyor.
* @course 2. Öğretim örgün C grubu 
* @assignment Veri yapıları 2. ödevi
* @date 24.12.2022
* @author Furkan Tataroğlu    furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "SistemVeOrganizma.hpp"

void Sistem::sistem(Organ *organ,int satirsayisi)
{
    int sayac=0;
    for(int i=0; i<satirsayisi/20;i++)
    {
        if(sayac==100)
        {
            cout<<endl;
            sayac=0;
        }
        if(organ->dugumGetir(i)->veri->balanced())
            cout<<" ";
        else
            cout<<"#";
            
        sayac++;
    }
    
}
