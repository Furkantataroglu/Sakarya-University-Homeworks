/**
* @file main.cpp
* @description main
* @course  2. Öğretim  grup 2-C
* @assignment 1. Ödev
* @date 27/11/2022
* @author Furkan Tataroğlu - furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include <iostream>
#include "SatirListesi.hpp"
#include "Okuekle.hpp"
#include "YoneticiListesi.hpp"
#include "EkranaYazdir.hpp"
using namespace std;
#include <fstream>
#include <string>
#include <sstream>
#include <time.h>
void cizgi (int adet)
{
    for(int i=0; i<adet; i++)
    {
        cout<<"----------  "; 
    }
}


int main()
{   srand(time(NULL));
    YoneticiListesi* listee = new YoneticiListesi();
    SatirListesi* liste = new SatirListesi();
    
    Okuekle* ekle = new Okuekle();
    ekle->okueklee(liste, listee);  

    
    
   

}