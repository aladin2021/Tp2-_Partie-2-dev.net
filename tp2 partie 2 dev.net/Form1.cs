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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //déclaration les variables 
        string Nom, Prenom, lieu;
        
        
        //déclaration d'un tableaux
        List<string> Namelistclients = new List<string>();

         private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Nom = textBoxNom.Text;
            Prenom = textBoxPrenom.Text;
            lieu = textBoxlieu.Text;
         
            Namelistclients.Add(Nom);
            Namelistclients.Add(Prenom);
            Namelistclients.Add(lieu);
            MessageBox.Show("le client est ajouté avec succée.merci");

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxlieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlister_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            Form2 newForm = new Form2();
            this.Hide();
            newForm.remplirData(Namelistclients);
            newForm.Show();
        }

      
    }
}
