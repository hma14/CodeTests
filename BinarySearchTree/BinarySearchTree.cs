using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***
Write a function that checks if a given binary tree is a valid 
binary search tree. A binary search tree (BST) is a binary tree 
where the value of each node is larger or equal to the values in 
all the nodes in that node's left subtree and is smaller than the 
values in all the nodes in that node's right subtree.

For example, for the following tree:

n1 (Value: 1, Left: null, Right: null)
n2 (Value: 2, Left: n1, Right: n3)
n3 (Value: 3, Left: null, Right: null)
Call to IsValidBST(n2) should return true since a tree with root at n2 is a valid binary search tree.

Explanation: Subtrees rooted at nodes n1 and n3 are valid binary search trees as they have no children. A tree rooted at node n2 is a valid binary search tree since its value (2) is larger or equal to the largest value in its left subtree (1, rooted at n1) and is smaller than the smallest value in its right subtree (3 rooted at n3).
    ***/


public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool IsValidBST(Node root)
    {
        if (root == null)
            return true;

        else if (root.Left != null && root.Left.Value > root.Value)
            return false;
        else if (root.Right != null && root.Value > root.Right.Value)
            return false;
        else
        {
            return (IsValidBST(root.Left) && IsValidBST(root.Right));
        }
    }

    public static Node find(int v, Node root)
    {
        if (root == null)
            return null;
        if (root.Value == v)
            return root;

        if (v < root.Value)
        {
            return find(v, root.Left);
        }
        else
        {
            return find(v, root.Right);
        }
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n4 = new Node(4, null, null);
        Node n9 = new Node(9, null, null);
        Node n11 = new Node(11, null, null);
        Node n13 = new Node(13, null, null);

        Node n14 = new Node(8, null, null);

        Node n16 = new Node(16, null, null);
        Node n8 = new Node(8, null, null);
        Node n12 = new Node(12, n8, n14);
        Node n10 = new Node(10, n9, n11);
        Node n15 = new Node(15, n12, n16);
        Node n2 = new Node(2, null, null);
        Node n6 = new Node(6, null, null);
        
        Node n7 = new Node(7, n6, n15);
        Node n3 = new Node(3, n2, n4);
        Node n5 = new Node(5, n3, n7);

#if false
        Node tmp = find(6, n5);
        if (tmp != null)
            Console.WriteLine(tmp.Value);
#else
        Console.WriteLine(IsValidBST(n5));
#endif
    }
}