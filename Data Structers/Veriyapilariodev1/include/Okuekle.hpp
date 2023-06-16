#ifndef OKUEKLE_HPP
#define OKUEKLE_HPP
using namespace std;
#include <string>
#include "SatirListesi.hpp"
#include "YoneticiListesi.hpp"
#include "Dugum.hpp"
#include <fstream>
#include <iostream>
class Okuekle
{
  public:
    ifstream veriler;
    Okuekle();
    void okueklee(SatirListesi* liste, YoneticiListesi* listee);
    istringstream ss(string val);
    int satirsayisii;
    string str;
    string val;
    int vall;
    int count;

};

#endif