using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HuffmanCompressionAlgorithm
{
    public class Nodes
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Nodes Right { get; set; }
        public Nodes Left { get; set; }

        public List<bool> Traversing(char symbol, List<bool> data)
        {
            if (Right == null && Left == null)
            {
                return (symbol.Equals(this.Symbol)) ? data : null;
            }
            else
            {
                List<bool> left = null, right = null;
                if (Left != null)
                {
                    List<bool> lpath = new List<bool>();
                    lpath.AddRange(data);
                    lpath.Add(false);
                    left = Left.Traversing(symbol, lpath);
                }
                if (Right != null)
                {
                    List<bool> rpath = new List<bool>();
                    rpath.AddRange(data);
                    rpath.Add(true);
                    left = Right.Traversing(symbol, rpath);
                }
                return (left != null) ? left : right;
            }
        }
    }
}
