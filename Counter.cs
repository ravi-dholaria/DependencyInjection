using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Counter : ICounter
    {
        public int _count;
        public int Count => _count; 
        public void Increment()
        {
            _count++;
        }
    }
}
