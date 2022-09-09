using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice
{
    public partial class Form1 : Form
    {
        private readonly Controleur controleurDee;
        public Form1()
        {
            InitializeComponent();
            controleurDee = new Controleur();
        }

        private void btn_Brasser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controleurDee.BrasserDee(6));
        }
    }
}
