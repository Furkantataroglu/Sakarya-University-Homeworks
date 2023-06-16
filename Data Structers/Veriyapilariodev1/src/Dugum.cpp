/**
* @file Dugum.cpp
* @description SatırListesi düğümü
* @course  2. Öğretim  grup 2-C
* @assignment 1. Ödev
* @date 27/11/2022
* @author Furkan Tataroğlu  furkan.tataroglu@ogr.sakarya.edu.tr
*/

#include "Dugum.hpp"

Dugum::Dugum(int veri)
{
    this->veri=veri;
    onceki= sonraki= 0;

}