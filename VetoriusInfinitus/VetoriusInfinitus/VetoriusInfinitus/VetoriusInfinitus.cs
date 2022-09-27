using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoriusInfinitus
{
    public class VetoriusInfinitus
    {
        private int[] _infiniteVector;

        public VetoriusInfinitus()
        {
            InfiniteVector = new int[0];
        }
        
        public VetoriusInfinitus(int[] infiniteVector) => InfiniteVector = infiniteVector;

        public int[] InfiniteVector
        {
            get => _infiniteVector;
            set => _infiniteVector = value;
        }

        public void add(int number)
        {
            InfiniteVector[InfiniteVector.Length] = number;
            Console.WriteLine(InfiniteVector[InfiniteVector.Length]);
        }
    }
}
