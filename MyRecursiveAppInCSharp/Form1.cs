using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecursiveAppInCSharp
{
    public partial class Form1 : Form
    {
        int chiffre = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        int FonctionRecursive(int chiffre)
        {
                if (chiffre == 1)
                {
                    return 1;
                }
                chiffre = chiffre * FonctionRecursive(chiffre - 1);
                return chiffre;
            

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            int chiffre = 0;
            if (int.TryParse(txtInput.Text, out chiffre))
            {
                FonctionRecursive(chiffre);
                lblResult.Text = "Résultat " + FonctionRecursive(chiffre);
            }

        }

    }

}
