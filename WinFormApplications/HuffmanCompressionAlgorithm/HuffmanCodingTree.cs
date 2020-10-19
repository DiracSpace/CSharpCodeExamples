using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace HuffmanCompressionAlgorithm
{
    class HuffmanCodingTree
    {
        private List<Nodes> LeafNode = new List<Nodes>();
        public Nodes TreeRoot { get; set; }
        public Dictionary<char, int> Frequencies = new Dictionary<char, int>();

        public void PrepareHuffmanCodingTree(string text)
        {
            for (int index = 0; index < text.Length; index++)
            {
                if (!Frequencies.ContainsKey(text[index])) { Frequencies.Add(text[index], 0); }
                Frequencies[text[index]]++;
            }
            
            foreach (KeyValuePair<char, int> symbol in Frequencies) { LeafNode.Add(new Nodes() { Symbol = symbol.Key, Frequency = symbol.Value }); }
            
            while (LeafNode.Count > 1)
            {
                List<Nodes> sortedLeafNodes = LeafNode.OrderBy(LeafNode => LeafNode.Frequency).ToList<Nodes>();
                if (sortedLeafNodes.Count >= 2)
                {
                    List<Nodes> getPair = sortedLeafNodes.Take(2).ToList<Nodes>();
                    Nodes parent = new Nodes()
                    {
                        Symbol = '*',
                        Frequency = getPair[0].Frequency + getPair[1].Frequency,
                        Left = getPair[0],
                        Right = getPair[1]
                    };
                }
                this.TreeRoot = LeafNode.FirstOrDefault();
            }
        }

        public BitArray EncodingSourceText(string text)
        {
            List<bool> EncodedText = new List<bool>();
            foreach (char letter in text)
            {
                List<bool> encodedSymbol = this.TreeRoot.Traversing(letter, new List<bool>());
                EncodedText.AddRange(encodedSymbol);
            }
            BitArray bitarry = new BitArray(EncodedText.ToArray());
            return bitarry;
        }

        public bool IsLeafNode(Nodes LeafNode) { return (LeafNode.Left == null && LeafNode.Right == null) ? true : false; }

        public string DecodingEncodedString(BitArray bitarry) 
        {
            Nodes presentState = this.TreeRoot;
            string decodedStrMsg = "";
            foreach (bool bit in bitarry)
            {
                if (bit && presentState.Right != null) { presentState = presentState.Right; }
                if (!bit && presentState.Left != null) { presentState = presentState.Left;  }
                if (IsLeafNode(presentState))
                {
                    decodedStrMsg += presentState.Symbol;
                    presentState = this.TreeRoot;
                }
            }
            return decodedStrMsg;
        }
    }
}
