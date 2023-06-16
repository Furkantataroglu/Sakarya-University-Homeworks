/**
* @file YoneticiDugum.cpp
* @description Yönetici Listesi Düğümü satir listelerini tutacak
* @course  2. Öğretim  grup 2-C
* @assignment 1. Ödev
* @date 27/11/2022
* @author Furkan Tataroğlu  furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "YoneticiDugum.hpp"
Yoneticidugum::Yoneticidugum(SatirListesi* veri)
{
    this -> veri = veri;
    yonceki=ysonraki=0;
}