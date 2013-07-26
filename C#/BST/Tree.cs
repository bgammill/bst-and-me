using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Tree
    {
        public Node Root { get; set; }

        public Tree(int rootValue)
        {
            this.Root = new Node(rootValue);
        }

        public void Insert(int value)
        {
            var currentNode = this.Root;

            while (true)
            {
                if (currentNode.Value > value)
                {
                    if (currentNode.Left != null)
                    {
                        currentNode = currentNode.Left;
                        continue;   
                    }
                    else
                    {
                        currentNode.Left = new Node(value);
                        break;
                    }
                }
                else if (currentNode.Value < value)
                {
                    if (currentNode.Right != null)
                    {
                        currentNode = currentNode.Right;
                        continue;
                    }
                    else
                    {
                        currentNode.Right = new Node(value);
                        break;
                    }
                }
            }
        }

        public Node Find(int value)
        {
            var currentNode = this.Root;

            while (true)
            {
                if (currentNode.Value == value)
                {
                    return currentNode;
                }
                else if (currentNode.Value > value)
                {
                    currentNode = currentNode.Left;
                    continue;
                }
                else if (currentNode.Value < value)
                {
                    currentNode = currentNode.Right;
                    continue;
                }
            }
        }
    }
}