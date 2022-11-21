using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace AP3_GestionHackathon
{
    public partial class FormConnexion : Form
    {

        private string email;
        private string mdp;



        public FormConnexion()
        {
            InitializeComponent();
        }

        private void ConnexionBtn_Click(object sender, EventArgs e)
        {
            email = tbEmail.Text;
            mdp = tbMdp.Text;

            if(Modele.VerifAdmin(email, mdp))
            { 
                FormMenu FM = new FormMenu();
                FM.Show();
                this.Hide();
            } else
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            


        }

        private void Btnacces_Click(object sender, EventArgs e)
        {
            FormMenu FM = new FormMenu();
            FM.Show();
            this.Hide();
        }
    }
}
