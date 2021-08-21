using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class Iterator<T> : IIterator<T>
    {
        private IList<T> _list;
        private int _current = 0;

        public Iterator(IList<T> list) => _list = list;

        public bool HasNext() => _current < _list.Count;

        public T Next() => _list[_current++];
    }
}