/**
* @file Veriyapilariodev2
* @description Programımız veri yapılarını kullanarak ekrana organizma ve entere basıldığında organizmanın mutasyonlu halini çıkarıyor.
* @course 2. Öğretim örgün C grubu 
* @assignment Veri yapıları 2. ödevi
* @date 24.12.2022
* @author Furkan Tataroğlu    furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "Hucre.hpp"

void Hucre::hucre(Organ *&organ, int satirsayisi)
{
        for(int i=0; i<satirsayisi/20;i++)
    {
        
   if(organ->dugumGetir(i)->veri->kokgetir() % 50 == 0)
    {
         int *p= organ->dugumGetir(i)->veri->Array();
         for(int j =0; j<20;j++)
         {
        
            if(p[j]%2==0)
            {
                p[j]=p[j]/2;
            }
          
         }
         organ->dugumGetir(i)->veri->Clear();
         for(int k =0; k<20;k++)
         organ->dugumGetir(i)->veri->Ekle(p[k]);
    }
    }

}
