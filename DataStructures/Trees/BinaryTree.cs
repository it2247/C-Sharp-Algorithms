﻿using System;
using System.Collections.Generic;

using DataStructures;

namespace DataStructures.Trees
{
    /// <summary>
    /// A minimal binary tree node.
    /// </summary>
    /// <typeparam name="T">Type of node value.</typeparam>
    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Parent { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        /// <summary>
        /// CONSTRUCTORS
        /// </summary>
        public BinaryTreeNode() : this(default(T), null, null, null) { }
        public BinaryTreeNode(T value) : this(value, null, null, null) { }
        public BinaryTreeNode(T value, BinaryTreeNode<T> parent, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.Value = value;
            this.Parent = parent;
            this.Left = left;
            this.Right = right;
        }

        // 
        // IComparable CompareTo implementation
        public int CompareTo(BinaryTreeNode<T> other)
        {
            if (other == null)
                return -1;

            return this.Value.CompareTo(other.Value);
        }
    }//end-of-tree-node-class



    /// <summary>
    /// The rooted binary tree data structure.
    /// This is not a search binary tree. For the search version check: BinarySearchTree.cs
    /// <warning>Not Implemented yet.</warning>
    /// <todo>Implement binary tree data structure.</todo>
    /// </summary>
    /// <typeparam name="T">Type of elements.</typeparam>
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        /// <summary>
        /// TREE INSTANCE VARIABLES
        /// </summary>
        private BinaryTreeNode<T> _root { get; set; }
        private int _count { get; set; }

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public BinaryTree()
        {
            _root = null;
            _count = 0;
        }


        /// <summary>
        /// Returns the number of elements in the Tree
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _count;
        }


        /// <summary>
        /// Checks if the tree is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return _count == 0;
        }


        /// <summary>
        /// Inserts an element to the tree
        /// </summary>
        /// <param name="key">Value.</param>
        public void Insert(T key)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Deletes an element from tree
        /// </summary>
        /// <param name="key">Value.</param>
        public void Delete(T key)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Find the element in the tree, returns null if not found.
        /// </summary>
        /// <param name="key">Value.</param>
        /// <returns></returns>
        public T Find(T key)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Finds all the elements in the tree that match the predicate.
        /// </summary>
        /// <param name="searchPredicate">Predicate</param>
        /// <returns></returns>
        public T[] FindAll(Predicate<T> searchPredicate)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Traverses the tree and applies the action to every node.
        /// </summary>
        /// <param name="action">Action to apply.</param>
        public void Traverse(Action<T> action)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Clears this tree.
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }
    }//end-of-tree-class

}
