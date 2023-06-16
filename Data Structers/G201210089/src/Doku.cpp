/**
* @file Veriyapilariodev2
* @description Programımız veri yapılarını kullanarak ekrana organizma ve entere basıldığında organizmanın mutasyonlu halini çıkarıyor.
* @course 2. Öğretim örgün C grubu 
* @assignment Veri yapıları 2. ödevi
* @date 24.12.2022
* @author Furkan Tataroğlu    furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "Doku.hpp"
#include "Radix.hpp"
#include <iostream>
using namespace std;
#include <fstream>
#include <string>
#include <sstream>
#include "BinaryAgac.hpp"

Organ *Doku::setup(int satirsayisi)
{
    Organ* organ = new Organ();
    ifstream veriler;
  veriler.open("Veri.txt");
  string val;
  int intval;
  int count =0;
 for(int i =0;i<satirsayisi/20;i++){
    BinaryTree* tree = new BinaryTree();
    for (int i=0; i<20;i++)
    {
    getline(veriler,val);
        int index =0;
        istringstream ss(val);
        for (int i =0; i<val.length(); i++)
        {
            if(isspace(val.at(i)))
            {
                count++;
            }
        }
        count++;
        int* sayilar = new int [count];
        for (int i = 0; i < count; i++)
        {
            ss>>intval;
            sayilar[i]= intval;
        }
        Radix *radix = new Radix(sayilar,count);
        int *siraliSayilar = radix->Sort();
        count=0;
        tree->Ekle(siraliSayilar[count/2]);
        radix->~Radix();
        delete [] siraliSayilar;
        delete [] sayilar;
    }
    organ->ekle(tree);
    
 }    
  veriler.close();

    return organ;
}

