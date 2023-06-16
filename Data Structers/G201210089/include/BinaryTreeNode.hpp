#ifndef BinarytreeNode_HPP
#define BinarytreeNode_HPP
class BinaryTreeNode
{
public:
    BinaryTreeNode(int data, BinaryTreeNode * left = nullptr,BinaryTreeNode* right=nullptr);

    int Value;
    BinaryTreeNode * Left;
    BinaryTreeNode * Right;
};





#endif