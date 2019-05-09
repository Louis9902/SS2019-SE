using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static string ConfigFilePath = "";


        private void Form1_Load(object sender, EventArgs e)
        {
          

            MessageBox.Show("Load config here");
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do stuff here");
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
