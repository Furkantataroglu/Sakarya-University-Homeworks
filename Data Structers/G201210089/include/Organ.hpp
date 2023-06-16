#ifndef Organ_hpp
#define Organ_hpp
#include "BinaryAgac.hpp"
#include "OrganDugum.hpp"
class Organ
{
 public:
    OrganDugum* ilk;
    Organ();
    ~Organ();
    void ekle (BinaryTree* veri);
    void yCikar(int sira);
    friend ostream& operator<<(ostream& os,Organ& organ);
    OrganDugum* dugumGetir(int sira);
    
    private:
    
};


#endif