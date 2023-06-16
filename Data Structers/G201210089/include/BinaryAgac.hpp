#ifndef BinaryAgac_HPP
#define BinaryAgac_HPP
#include "BinaryTreeNode.hpp"
#include <iostream>
#include <cmath>
using namespace std;
class BinaryTree
{
public:
    BinaryTree();
    ~BinaryTree();
    void Ekle (int value);
    void Clear();
	int* Array()
	{
		int* array = new int [20];
		postorderarray(kok, array);
		return array;
		delete[] array;
	}
	void postorderarray(BinaryTreeNode* root, int *&array)
	{   	
		static int sayac = 0;	
		if(root!=nullptr)
		{
		postorderarray(root->Left,array);
		postorderarray(root->Right,array);
		array[sayac]=root->Value;
		sayac++;
		if(sayac==20)
		sayac=0;
		
		}
		
	}
   int Height()
   {
			return Height(kok);
   }
   bool isEmpty()const{
			return kok == NULL;
   }

   bool balanced()
   {
       return isBalanced(kok);
   }

    void inorder(){
			inorder(kok);
		}
	void preorder(){
			preorder(kok);
		}
	void postorder(){
			postorder(kok);
		}
    int kokgetir(){
		return kokgetir(kok);
	}
private:
    BinaryTreeNode * kok;
    bool DeleteNode(BinaryTreeNode *&subNode){
			BinaryTreeNode *DelNode = subNode;
			
			if(subNode->Right == NULL) subNode = subNode->Left;
			else if(subNode->Left == NULL) subNode = subNode->Right;
			else{
				DelNode = subNode->Left;
				BinaryTreeNode *parent = subNode;
				while(DelNode->Right != NULL){
					parent = DelNode;
					DelNode = DelNode->Right;
				}
				subNode->Value = DelNode->Value;
				if(parent == subNode) subNode->Left = DelNode->Left;
				else parent->Right = DelNode->Left;
			}
			delete DelNode;
			return true;
		}
    

    int Height(BinaryTreeNode *subNode)
    {
			if(subNode == nullptr) return -1;
			return 1+max(Height(subNode->Left),Height(subNode->Right));
    }



    void inorder(BinaryTreeNode *subNode){
			if(subNode != NULL){
				inorder(subNode->Left);
				cout<<subNode->Value<<" ";
				inorder(subNode->Right);
			}
		}
	int kokgetir(BinaryTreeNode* root)
	{
		return root->Value;
	}

		void preorder(BinaryTreeNode *subNode){
			if(subNode != NULL){
				cout<<subNode->Value<<" ";
				preorder(subNode->Left);
				preorder(subNode->Right);
			}
		}
		void postorder(BinaryTreeNode *subNode){
			if(subNode != nullptr){
				postorder(subNode->Left);
				postorder(subNode->Right);
				cout<<subNode->Value<<" ";
			}
		}

    bool isBalanced(BinaryTreeNode* root)
{
    // for height of left subtree
    int lh;
 
    // for height of right subtree
    int rh;
 
    // If tree is empty then return true
    if (root == NULL)
        return 1;
 
    // Get the height of left and right sub trees
    lh = Height(root->Left);
    rh = Height(root->Right);
 
    if (abs(lh - rh) <= 1 && isBalanced(root->Left)
        && isBalanced(root->Right))
        return 1;
 
    // If we reach here then tree is not height-balanced
    return 0;
}
};

#endif