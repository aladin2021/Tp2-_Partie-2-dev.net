using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tp2_partie_2_dev.net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //déclaration la liste
        List<string> uInput = new List<string>();
  
        //déclaration un méthode pour accepter user Input pour form2
        public void remplirData(List<string> userInput)
        {
            uInput = userInput;
            for (int x = 0; x < userInput.Count;)
            {
                Namelistclients.Items.Add(uInput[x]);



            }
 
        
        }
        
        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRevenir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Namelistclients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
       

      
    }
}
