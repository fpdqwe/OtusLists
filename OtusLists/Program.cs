using System.Collections;
using System.Diagnostics;

namespace OtusLists
{
	internal class Program
	{
		private static readonly int _amountOfValues = 1000000;
		private static readonly int _targetElement = 496753;
		private static readonly int _divideBy = 777;
		private static List<int> _list;
		private static ArrayList _arrayList;
		private static LinkedList<int> _linkedList;
		static void Main(string[] args)
		{
			Console.WriteLine("=====	Lists test started!    =====");

			var sw = new Stopwatch();

			sw.Start();
			FillList();
			sw.Stop();
			Console.WriteLine($"List filled in {sw.ElapsedMilliseconds} ms.");
			FindElementInList();
			ListDivide();

			sw.Restart();
			FillArrayList();
			sw.Stop();
			Console.WriteLine($"ArrayList filled in {sw.ElapsedMilliseconds} ms.");
			FindElementInArrayList();
			ArrayListDivide();

			sw.Restart();
			FillLinkedList();
			sw.Stop();
			Console.WriteLine($"LinkedList filled in {sw.ElapsedMilliseconds} ms.");
			FindElementInLinkedList();
			LinkedListDivide();
		}

		private static void FillList()
		{
			var rnd = new Random();
			_list = new List<int>(_amountOfValues);
			for(int i = 0; i < _amountOfValues; i++)
			{
				_list.Add(rnd.Next(int.MinValue, int.MaxValue));
			}
		}
		private static void FillArrayList()
		{
			var rnd = new Random();
			_arrayList = new ArrayList(_amountOfValues);
			for(int i = 0; i < _amountOfValues; i++)
			{
				_arrayList.Add(rnd.Next(int.MinValue, int.MaxValue));
			}
		}
		private static void FillLinkedList()
		{
			var rnd = new Random();
			_linkedList = new LinkedList<int>();
			for(int i = 0; i < _amountOfValues; i++)
			{
				_linkedList.AddLast(rnd.Next(int.MinValue, int.MaxValue));
			}
		}
		private static void FindElementInList()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			var resultByIndex = _list[_targetElement - 1];
			stopwatch.Stop();
			Console.WriteLine($"Element #{_targetElement} found in List in {stopwatch.ElapsedMilliseconds} ms.");
		}
		private static void FindElementInArrayList()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			var result = _arrayList[_targetElement - 1];
			stopwatch.Stop();
			Console.WriteLine($"Element #{_targetElement} found in ArrayList in {stopwatch.ElapsedMilliseconds} ms.");
		}
		private static void FindElementInLinkedList()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			_linkedList.ElementAt(_targetElement - 1);
			stopwatch.Stop();
			Console.WriteLine($"Element #{_targetElement} found in LinkedList in {stopwatch.ElapsedMilliseconds} ms.");
		}
		private static void ListDivide()
		{
			Console.WriteLine("=====	List Division Test    =====");
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			int i = 0;
			int j = 0;
			foreach (var item in _list)
			{
				
				if (item % _divideBy == 0)
				{
					Console.Write($"Element #{i}: {item}; ");
					
					stopwatch.Stop();
					j++;
					if (j % 7 == 0) Console.WriteLine("");
					stopwatch.Start();
				}
				i++;
			}

			stopwatch.Stop();
			Console.WriteLine($"\nDivision in List executed in {stopwatch.ElapsedMilliseconds} ms");
		}
		private static void ArrayListDivide()
		{
			Console.WriteLine("=====	ArrayList Division Test    =====");
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			int i = 0;
			int j = 0;
			foreach (var item in _arrayList)
			{
				if ((int)item % _divideBy == 0)
				{
					Console.Write($"Element #{i}: {item}; ");
					
					stopwatch.Stop();
					j++;
					if (j % 7 == 0) Console.WriteLine("");
					stopwatch.Start();
				}
				i++;
			}

			stopwatch.Stop();
			Console.WriteLine($"\nDivision in ArrayList executed in {stopwatch.ElapsedMilliseconds} ms");
		}
		private static void LinkedListDivide()
		{
			Console.WriteLine("=====	LinkedList Division Test    =====");
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			int i = 0;
			int j = 0;
			foreach ( var item in _linkedList)
			{
				if (item % _divideBy == 0)
				{
					Console.Write($"Element #{i}: {item}; ");
					
					stopwatch.Stop();
					j++;
					if (j % 7 == 0) Console.WriteLine("");
					stopwatch.Start();
				}
				i++;
			}

			stopwatch.Stop();
			Console.WriteLine($"\nDivision in LinkedList executed in {stopwatch.ElapsedMilliseconds} ms");
		}
	}
}
