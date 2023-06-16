/**
* @file Veriyapilariodev2
* @description Programımız veri yapılarını kullanarak ekrana organizma ve entere basıldığında organizmanın mutasyonlu halini çıkarıyor.
* @course 2. Öğretim örgün C grubu 
* @assignment Veri yapıları 2. ödevi
* @date 24.12.2022
* @author Furkan Tataroğlu    furkan.tataroglu@ogr.sakarya.edu.tr
*/

#include <iostream>
#include <iomanip>
using namespace std;
#include <fstream>
#include <string>
#include <sstream>
#include "Radix.hpp"
#include "BinaryAgac.hpp"
#include "Organ.hpp"
#include "Doku.hpp"
#include "SistemVeOrganizma.hpp"
#include <stdlib.h>
#include "Control.hpp"
#include "Hucre.hpp"

int main()
{   
    cout<<setw(30)<<"ORGANIZMA"<<endl;
    Kontrol satir;
   int satirsayisi = satir.satirsayisi();
    Doku* doku = new Doku();
    Organ* organ = doku->setup(satirsayisi);
    Sistem d1;
    d1.sistem(organ, satirsayisi);
    Hucre* hucre = new Hucre();
    hucre->hucre(organ, satirsayisi);
 
       if (std::cin.get() == '\n') 
       {
            system("CLS");
       }
      
     
     
     cout<<setw(30)<<"ORGANIZMA (mutasyona ugradi)"<<endl;
        d1.sistem(organ, satirsayisi);
 for(int i=0;i<satirsayisi/20;i++)
    {
         organ->dugumGetir(i)->veri->~BinaryTree();
        
    } organ->~Organ();
   
    int a;
    std::cin>>a;
}