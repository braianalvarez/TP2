//GIT asdsad

using System;

namespace TP_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] listado = new int[] {150, 130, 25, 34, 20, 53, 18, 47, 19};
			
			Heap a = new Heap();
			int [] list = a.BuildHeapMin(listado);
			
			foreach (int b in list) {
				Console.WriteLine(b);
			}
			
 			Console.ReadKey(true);
		}
	}
}