using System;

namespace BinarySearchTree
{
	class Program
	{
		static void Main(string[] args)
		{
			var binaryTree = new BinaryTree<int>();
			
			binaryTree.Add(8);

			binaryTree.Add(10);
			binaryTree.Add(3);
			binaryTree.Add(21);
			binaryTree.Add(-1);

			binaryTree.PrintTree();

			Console.ReadKey();
		}
	}


}
