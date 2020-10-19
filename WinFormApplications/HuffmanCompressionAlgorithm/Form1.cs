using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanCompressionAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int ReturnCount(string word, char letter) { return word.Count(x => x == Char.ToLower(letter)); }

        public void Main()
        {
            string text = "old macdonald had a farm, and in that farm he fucked a cow";
            for (int i = 65; i <= 90; i++)
            {
                ListViewItem row = new ListViewItem(((char)i).ToString());
                row.SubItems.Add(ReturnCount(text, ((char)i)).ToString());
                lvInformation.Items.AddRange(new ListViewItem[] { row });
            }
        }

        private void startProgramBtn_Click(object sender, EventArgs e)
        {
            Main();    
        }
    }
}
