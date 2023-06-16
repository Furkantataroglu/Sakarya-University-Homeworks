/**
* @file Veriyapilariodev2
* @description Programımız veri yapılarını kullanarak ekrana organizma ve entere basıldığında organizmanın mutasyonlu halini çıkarıyor.
* @course 2. Öğretim örgün C grubu 
* @assignment Veri yapıları 2. ödevi
* @date 24.12.2022
* @author Furkan Tataroğlu    furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "Control.hpp"

int Kontrol::satirsayisi()
{
    ifstream veriler;
  veriler.open("Veri.txt");
  string val;
  int count =0;
  while(getline(veriler, val))
  {
    count++;
  }
  return count;
}