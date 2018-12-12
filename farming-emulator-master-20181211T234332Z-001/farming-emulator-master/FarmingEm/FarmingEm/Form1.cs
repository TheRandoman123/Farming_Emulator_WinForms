using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmingEm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public void StartGame() {
            Start Start = new Start();
            DialogResult result = Start.ShowDialog(this);
            //string info = 
            if (result == DialogResult.OK) {
                // Do Stuff
            }
            Start.Dispose();
        }


        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
