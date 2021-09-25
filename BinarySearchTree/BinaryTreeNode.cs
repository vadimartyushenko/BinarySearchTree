using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
	/// <summary>
	/// Класс, описывающий узел бинарного дерева поиска
	/// </summary>
	/// <typeparam name="T">Тип данных, хранящийся в узле бинарного дерева</typeparam>
	class BinaryTreeNode<T> where T:IComparable
	{
		#region Ctor
		public BinaryTreeNode(T data)
		{
			Data = data;
		}

		#endregion

		#region Public Fields
		/// <summary>
		/// Данные, хранящиеся в узле дерева
		/// </summary>
		public T Data { get; set; }

		/// <summary>
		/// Ссылка на левого потомка
		/// </summary>
		public BinaryTreeNode<T> LeftNode { get; set; }

		/// <summary>
		/// Ссылка на правого потомка
		/// </summary>
		public BinaryTreeNode<T> RightNode { get; set; }

		/// <summary>
		/// Ссылка на родительский узел
		/// </summary>
		public BinaryTreeNode<T> ParentNode { get; set; }

		/// <summary>
		/// Расположение узла относитетельно его родителя
		/// </summary>
		public Side? NodeSide => ParentNode == null
			? (Side?)null
			: ParentNode.LeftNode == this
				? Side.Left
				: Side.Right;


		#endregion

		/// <summary>
		/// Преобразование экземпляра класса в строку
		/// </summary>
		/// <returns>Данные, принадлежащие узлу</returns>
		public override string ToString() => Data.ToString();

	}

	/// <summary>
	/// Расположения узла относительно родителя
	/// </summary>
	public enum Side
	{
		Left,
		Right
	}

}
