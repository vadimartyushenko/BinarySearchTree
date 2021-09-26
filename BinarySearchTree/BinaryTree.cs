using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
	/// <summary>
	/// Класс, реализующий бинарное дерево
	/// </summary>
	/// <typeparam name="T">Тип данных, хранящийся в узле бинарного дерева</typeparam>
	class BinaryTree<T> where T : IComparable
	{
		/// <summary>
		/// Корень дерева
		/// </summary>
		public BinaryTreeNode<T> RootNode { get; set; }

		#region Public Methods

		/// <summary>
		/// Добавление нового узла в бинарное дерево
		/// </summary>
		/// <param name="node">Добавляемый узел</param>
		/// <param name="currentNode">Текущий узел</param>
		/// <returns>Узел</returns>
		public BinaryTreeNode<T> Add(BinaryTreeNode<T> node, BinaryTreeNode<T> currentNode = null)
		{
			if (RootNode == null)
			{
				node.ParentNode = null;
				return RootNode = node;
			}

			currentNode ??= RootNode;
			node.ParentNode = currentNode;
			
			var result = node.Data.CompareTo(currentNode.Data);

			if (result == 0)
				return currentNode;

			if (result < 0)
				return currentNode.LeftNode == null ? currentNode.LeftNode = node : Add(node, currentNode.LeftNode);
			else
				return currentNode.RightNode == null ? currentNode.RightNode = node : Add(node, currentNode.RightNode);

		}

		/// <summary>
		/// Добавление данных в бинарное дерево
		/// </summary>
		/// <param name="data">Данные</param>
		/// <returns>Узел</returns>
		public BinaryTreeNode<T> Add(T data)
		{
			return Add(new BinaryTreeNode<T>(data));
		}
		
		/// <summary>
		/// Вывод бинарного дерева на консоль
		/// </summary>
		public void PrintTree()
		{
			PrintTree(RootNode);
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Вывод бинарного дерева начиная с заданого узла
		/// </summary>
		/// <param name="startNode">Узел, с которого начинается вывод</param>
		/// <param name="indent">Отступ</param>
		/// <param name="side">Сторона узла</param>
		private static void PrintTree(BinaryTreeNode<T> startNode, string indent = "", Side? side = null)
		{
			if (startNode == null) return;

			var nodeSide = side == null ? "+" : side == Side.Left ? "L" : "R";
			Console.WriteLine($"{indent} [{nodeSide}] - {startNode.Data}");
			indent += new string(' ', 3);

			PrintTree(startNode.LeftNode, indent, Side.Left);
			PrintTree(startNode.RightNode, indent, Side.Right);
		}

		#endregion
	}
}
