using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Iterator
{
	internal class OrderListCollector
	{
		private List<string> _list = new List<string>();

		public void Push(string item)
		{
			_list.Add(item);
		}
		public string Pop()
		{
			string last = _list.Last();
			_list.Remove(last);
			return last;
		}

		public IIterator<string> CreateIterator()
		{
			return new ListIterator(_list);
		}
	}
}
