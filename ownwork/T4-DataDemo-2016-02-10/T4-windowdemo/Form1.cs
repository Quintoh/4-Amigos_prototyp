using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T4_DataDemo_2016_02_10;

namespace T4_windowdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += new EventHandler(Dosomething);
            Inventory MyInventory = new Inventory();

            //  foreach (var item in MyInventory.GetArtworkList )
            //  {
            //      listBox1.Items.Add(item);
            //  }


            listBox1.DataSource = MyInventory.GetArtworkList;
            listBox1.DisplayMember = "Artist";
        }

        private void Dosomething(object sender, EventArgs e)
        {
            MessageBox.Show($"Du valde nr: {((Artwork)listBox1.SelectedItem).id}");
        }

       
    }
}
