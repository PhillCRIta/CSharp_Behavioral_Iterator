using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Iterator
{
	internal class ListIterator : IIterator<string>
	{
		private readonly List<string> _list;

		public ListIterator(List<string> list)
		{
			_list = list;
		}

		private int _index;
		public string Current()
		{
			return _list[_index];
		}

		public bool HasNext()
		{
			return _index < _list.Count;
		}

		public void Next()
		{
			_index++;
		}
	}
}
