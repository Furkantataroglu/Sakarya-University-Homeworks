/**
* @file Veriyapilariodev2
* @description Programımız veri yapılarını kullanarak ekrana organizma ve entere basıldığında organizmanın mutasyonlu halini çıkarıyor.
* @course 2. Öğretim örgün C grubu 
* @assignment Veri yapıları 2. ödevi
* @date 24.12.2022
* @author Furkan Tataroğlu    furkan.tataroglu@ogr.sakarya.edu.tr
*/
#include "BinaryTreeNode.hpp"

BinaryTreeNode::BinaryTreeNode(int data, BinaryTreeNode * left,
                   BinaryTreeNode* right)
                   : Value(data),
                   Left(left),
                   Right(right)
                   {

                   }

