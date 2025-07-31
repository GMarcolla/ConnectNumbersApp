using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAppsChat
{
    public class Network
    {
        private int[] parent;

        public Network(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Size must be a positive integer");

            parent = new int[size + 1];
            
            for (int i = 1; i <= size; i++)
            {
                parent[i] = i;
            }
        }

        private int Find(int x)
        {
            if (parent[x] != x)
                parent[x] = Find(parent[x]);
            return parent[x];
        }

        public void Connect(int a, int b)
        {
            Validate(a);
            Validate(b);
            int rootA = Find(a);
            int rootB = Find(b);
            if (rootA != rootB)
                parent[rootA] = rootB;
        }

        public bool Query(int a, int b)
        {
            Validate(a);
            Validate(b);
            return Find(a) == Find(b);
        }

        private void Validate(int x)
        {
            if (x <= 0 || x >= parent.Length)
                throw new ArgumentOutOfRangeException($"Element {x} is out of range");
        }
    }
}
