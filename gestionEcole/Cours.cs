using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionEcole
{
    public partial class Cours : Form
    {
        public Cours()
        {
            InitializeComponent();
        }

        ADO ado = new ADO();
        private void Cours_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            Field_Search.PlaceholderText = "CHERCHER par enseignant";
            Field_Code.PlaceholderText = "Code";
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");
            dataGrid_Cours.ReadOnly = true;
            remplirComboHoraire();
            remplirComboGroupes();
            remplirComboEns();
            remplirComboSalle();

            combo_Annee.Items.Add("1ére");
            combo_Annee.Items.Add("2éme");
            combo_Annee.Items.Add("3éme");

            ado.cmd.CommandText = "SELECT * FROM Cours";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Cours.DataSource = ado.dt;
            ado.dr.Close();

        }
        public void remplirComboSalle()
        {
            ado.cmd.CommandText = "SELECT NomSalle FROM Salle";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(ado.dr);
            combo_Salle.DataSource = tab;
            combo_Salle.DisplayMember = "NomSalle";
            combo_Salle.ValueMember = "NomSalle";
            ado.dr.Close();
        }
        public void remplirComboEns()
        {
            ado.cmd.CommandText = "SELECT Nom FROM Ens";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(ado.dr);
            combo_Ens.DataSource = tab;
            combo_Ens.DisplayMember = "Nom";
            combo_Ens.ValueMember = "Nom";
            ado.dr.Close();
        }

        public void remplirComboGroupes()
        {
            ado.cmd.CommandText = "SELECT DISTINCT Groupe FROM Etudiant";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(ado.dr);
            combo_Groupe.DataSource = tab;
            combo_Groupe.DisplayMember = "Groupe";
            combo_Groupe.ValueMember = "Groupe";
            ado.dr.Close();
        }

        public void remplirComboHoraire()
        {
            ado.cmd.CommandText = "SELECT DISTINCT Code FROM EmploiTemps";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(ado.dr);
            combo_Horaire.DataSource = tab;
            combo_Horaire.DisplayMember = "Code";
            combo_Horaire.ValueMember = "Code";
            ado.dr.Close();
        }

       
        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Cours";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Cours.DataSource = ado.dt;
            ado.dr.Close();
        }

        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(Code) FROM Cours WHERE Code=" + Field_Code.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }

        public bool Ajouter()
        {
            if (verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO Cours VALUES('" + Field_Code.Text + "','" + combo_Groupe.Text + "','"+combo_Annee.Text + "','" +combo_Ens.Text + "','" + combo_Horaire.Text + "','" + combo_Salle.Text +"')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(combo_Salle.Text == "" || combo_Annee.Text == "" || Field_Code.Text == "" || combo_Groupe.Text == "" || combo_Horaire.Text == "" || combo_Ens.Text == "")
            {
                if (combo_Salle.Text == "")
                {
                    MessageBox.Show("Donner la salle ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Annee.Text == "")
                {
                    MessageBox.Show("Donner l'Année ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Groupe.Text == "")
                {
                    MessageBox.Show("Donner Groupe ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Horaire.Text == "")
                {
                    MessageBox.Show("Donner Horaire ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Ens.Text == "")
                {
                    MessageBox.Show("Donner Enseignant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Cours est ajouter avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                }else
                {
                    MessageBox.Show("Cours existe deja", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Code.Clear();
                }
            }
        }

        public bool modifier()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE Cours SET Groupe='" + combo_Groupe.Text + "',Année='"+combo_Annee.Text + "',Enseignant='" + combo_Ens.Text + "',Horaire='" + combo_Horaire.Text+"',Salle='"+combo_Salle.Text +"' WHERE Code='" + Field_Code.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;


        }
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if ( combo_Salle.Text=="" ||combo_Annee.Text == ""|| Field_Code.Text == "" || combo_Groupe.Text == "" || combo_Horaire.Text == "" || combo_Ens.Text == "")
            {
                if (combo_Salle.Text == "")
                {
                    MessageBox.Show("Donner la salle ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Annee.Text == "")
                {
                    MessageBox.Show("Donner l'Année ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Groupe.Text == "")
                {
                    MessageBox.Show("Donner Groupe ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Horaire.Text == "")
                {
                    MessageBox.Show("Donner Horaire ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Ens.Text == "")
                {
                    MessageBox.Show("Donner Enseignant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }else
            {
                if (modifier())
                {
                    MessageBox.Show("Cours est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                }else
                {
                    MessageBox.Show("Cours n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_Code.Clear();
                }
            }
        }

        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Cours WHERE Code=" + Field_Code.Text;
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if(Field_Code.Text == "")
            {
                MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if (Supprimer())
                {
                    MessageBox.Show("Cours est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                }else
                {
                    MessageBox.Show("Cours n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Code.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Cours.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"Enseignant like '%{searchText}%'";
                dataGrid_Cours.DataSource = dv;
            }
        }

        private void Picture_Home_Click(object sender, EventArgs e)
        {

        }
    }
}
