using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace gestionEcole
{
    public partial class Etudiant : Form
    {
        public Etudiant()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();
        private void Etudiant_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            //this.BackColor = ColorTranslator.FromHtml("#12465a");
            datagrid_Etudiant.ReadOnly = true;
            Field_ID.PlaceholderText = "ID";
            Field_CNE.PlaceholderText = "CNE";
            Field_Nom.PlaceholderText = "Nom";
            Field_prenom.PlaceholderText = "Prenom";
            Field_Age.PlaceholderText = "Age";
            Field_Paiment.PlaceholderText = "Prix";
            Field_Search.PlaceholderText = "Chercher par nom / CNE";
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");

            combo_Annee.Items.Add("1ére");
            combo_Annee.Items.Add("2éme");
            combo_Annee.Items.Add("3éme");

            combo_Filiere.Items.Add("Science");
            combo_Filiere.Items.Add("littéraire");
            combo_Filiere.Items.Add("Economie");
            combo_Filiere.Items.Add("Science Math");

            combo_Groupe.Items.Add("G1");
            combo_Groupe.Items.Add("G2");
            combo_Groupe.Items.Add("G3");
            combo_Groupe.Items.Add("G4");
            combo_Groupe.Items.Add("G5");
            combo_Groupe.Items.Add("G6");

            ado.cmd.CommandText = "SELECT * FROM Etudiant";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            datagrid_Etudiant.DataSource = ado.dt;
            ado.dr.Close();
        }
        
       
        


        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Etudiant";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            datagrid_Etudiant.DataSource = ado.dt;
            ado.dr.Close();
        }
        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(ID) FROM Etudiant WHERE ID=" + Field_ID.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }
        public bool Ajouter()
        {
            if (verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO Etudiant VALUES('" + Field_ID.Text + "','" + Field_CNE.Text + "','" + Field_Nom.Text + "','" + Field_prenom.Text + "','" + Field_Age.Text + "','" + combo_Groupe.Text + "','" + combo_Filiere.Text + "','" + Field_Paiment.Text + "','"+ combo_Annee.Text+"')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public bool modifier()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE Etudiant SET CNE='" + Field_CNE.Text + "',Nom='" + Field_Nom.Text + "',Prenom='" + Field_prenom.Text + "',Age='" + Field_Age.Text + "',Groupe='" + combo_Groupe.Text + "',Filiere='" + combo_Filiere.Text + "',Prix='" + Field_Paiment.Text + "',Année='"+combo_Annee.Text +"'WHERE ID='" + Field_ID.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Etudiant WHERE ID=" + Field_ID.Text;
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (Field_ID.Text == "" || Field_CNE.Text == "" || Field_Nom.Text == "" || Field_prenom.Text == "" || Field_Age.Text == "" || combo_Filiere.Text == "" || combo_Groupe.Text == "" || Field_Paiment.Text == "")
            {
                if (Field_CNE.Text == "")
                {
                    MessageBox.Show("Donner CNE ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_ID.Text == "")
                {
                    MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_prenom.Text == "")
                {
                    MessageBox.Show("Donner Prenom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Age.Text == "")
                {
                    MessageBox.Show("Donner Age ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Filiere.Text == "")
                {
                    MessageBox.Show("Donner Filiere ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Groupe.Text == "")
                {
                    MessageBox.Show("Donner Groupe ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Paiment.Text == "")
                {
                    MessageBox.Show("Donner Prix ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Etudiant est ajouter avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                    Field_Nom.Clear();
                    Field_prenom.Clear();
                    Field_Age.Clear();
                    Field_CNE.Clear();
                    Field_Paiment.Clear();

                }
                else
                {
                    MessageBox.Show("Etudiant déjà existe", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_ID.Clear();
                    Field_Nom.Clear();
                    Field_prenom.Clear();
                    Field_Age.Clear();
                    Field_CNE.Clear();
                    Field_Paiment.Clear();
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (Field_ID.Text == "" || Field_CNE.Text == "" || Field_Nom.Text == "" || Field_prenom.Text == "" || Field_Age.Text == "" || combo_Filiere.Text == "" || combo_Groupe.Text == "" || Field_Paiment.Text == "")
            {
                if (Field_CNE.Text == "")
                {
                    MessageBox.Show("Donner CNE ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_ID.Text == "")
                {
                    MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_prenom.Text == "")
                {
                    MessageBox.Show("Donner Prenom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Age.Text == "")
                {
                    MessageBox.Show("Donner Age ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Filiere.Text == "")
                {
                    MessageBox.Show("Donner Filiere ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Groupe.Text == "")
                {
                    MessageBox.Show("Donner Groupe ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Paiment.Text == "")
                {
                    MessageBox.Show("Donner Prix ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                if (modifier())
                {
                    MessageBox.Show("Etudiant est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                    Field_Nom.Clear();
                    Field_prenom.Clear();
                    Field_Age.Clear();
                    Field_CNE.Clear();
                    Field_Paiment.Clear();
                }else
                {
                    MessageBox.Show("Etudiant n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_ID.Clear();
                    Field_Nom.Clear();
                    Field_prenom.Clear();
                    Field_Age.Clear();
                    Field_CNE.Clear();
                    Field_Paiment.Clear();
                }
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(Field_ID.Text == "")
            {
                MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if (Supprimer())
                {
                    MessageBox.Show("Etudiant est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                }else
                {
                    MessageBox.Show("Etudiant n'exite pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_ID.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                datagrid_Etudiant.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"CNE like '%{searchText}%' OR Nom like '%{searchText}%'";
                datagrid_Etudiant.DataSource = dv;
            }
        }
    }
}
