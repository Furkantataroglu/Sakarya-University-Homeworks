/**
* @file Veriyapilariodev2
* @description Programımız veri yapılarını kullanarak ekrana organizma ve entere basıldığında organizmanın mutasyonlu halini çıkarıyor.
* @course 2. Öğretim örgün C grubu 
* @assignment Veri yapıları 2. ödevi
* @date 24.12.2022
* @author Furkan Tataroğlu    furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "BinaryAgac.hpp"
#include <iostream>
#include <cmath>
using namespace std;

BinaryTree::BinaryTree()
: kok(nullptr)
{
}
void BinaryTree::Clear()
{
    
			while(!isEmpty()) 
            DeleteNode(kok);
		
}
BinaryTree::~BinaryTree()
{
    Clear();
}



void BinaryTree::Ekle(int value)
{
    if(kok==nullptr)
    {
        kok= new BinaryTreeNode(value);
    }
    else
    {
        BinaryTreeNode* Current = kok;
        while(true)
        {
            if(value < Current->Value)
            {
                if(Current->Left == nullptr)
                {
                    Current->Left = new BinaryTreeNode(value);
                    break;
                }
                else
                {
                    Current = Current->Left;
                }
            }
            else if(value> Current->Value)
            {
                if(Current->Right==nullptr)
                {
                    Current->Right = new BinaryTreeNode(value);
                    break;
                }
                else{
                    Current= Current->Right;
                }
            }
            else 
            {
                if(Current->Left == nullptr)
                {
                    Current->Left = new BinaryTreeNode(value);
                    break;
                }
                else
                {
                    Current = Current->Left;
                }
            }
        }
    }
}


