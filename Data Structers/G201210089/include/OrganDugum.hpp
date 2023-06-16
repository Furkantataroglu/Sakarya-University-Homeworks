#ifndef OrganDugum_hpp
#define OrganDugum_hpp
#include "BinaryAgac.hpp"
class OrganDugum
{
public:
    OrganDugum(BinaryTree* veri);
    BinaryTree* veri;
    OrganDugum* ysonraki;
    OrganDugum* yonceki;
    
};
#endif