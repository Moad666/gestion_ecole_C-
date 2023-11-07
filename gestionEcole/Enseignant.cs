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
    public partial class Enseignant : Form
    {
        public Enseignant()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();
        private void Enseignant_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            dataGrid_Ens.ReadOnly = true;
            Field_Code.PlaceholderText = "Code";
            Field_Age.PlaceholderText = "Age";
            Field_Nom.PlaceholderText = "Nom";
            Field_Prenom.PlaceholderText = "Prenom";
            Field_Salaire.PlaceholderText = "Salaire";
            Field_Search.PlaceholderText = "Chercher par nom enseignant";
            combo_Filiere.Items.Add("Science");
            combo_Filiere.Items.Add("littéraire");
            combo_Filiere.Items.Add("Economie");
            combo_Filiere.Items.Add("Science Math");
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");
            combo_Groupe.Items.Add("G1");
            combo_Groupe.Items.Add("G2");
            combo_Groupe.Items.Add("G3");
            combo_Groupe.Items.Add("G4");
            combo_Groupe.Items.Add("G5");
            combo_Groupe.Items.Add("G6");

            combo_Matiere.Items.Add("Français");
            combo_Matiere.Items.Add("Math");
            combo_Matiere.Items.Add("Arabe");
            combo_Matiere.Items.Add("SVT");
            combo_Matiere.Items.Add("PC");
            combo_Matiere.Items.Add("Education Islamique");
            combo_Matiere.Items.Add("Sport");
            combo_Matiere.Items.Add("Informatique");
            combo_Matiere.Items.Add("Anglais");

            ado.cmd.CommandText = "SELECT * FROM Ens";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Ens.DataSource = ado.dt;
            ado.dr.Close();


        }



        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Ens";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Ens.DataSource = ado.dt;
            ado.dr.Close();
        }
        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(Code) FROM Ens WHERE Code=" + Field_Code.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }

        public bool Ajouter()
        {
            if (verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO Ens VALUES('" + Field_Code.Text + "','" + Field_Nom.Text + "','" + Field_Prenom.Text + "','" + Field_Age.Text + "','" + combo_Groupe.Text + "','" + combo_Filiere.Text + "','" + combo_Matiere.Text + "','" + Field_Salaire.Text + "')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (Field_Code.Text == "" || Field_Nom.Text == "" || Field_Prenom.Text == "" || Field_Age.Text == "" || combo_Filiere.Text == "" || combo_Groupe.Text == "" || combo_Matiere.Text == "" || Field_Salaire.Text == "")
            {
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Salaire.Text == "")
                {
                    MessageBox.Show("Donner Salaire ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Prenom.Text == "")
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
                if (combo_Matiere.Text == "")
                {
                    MessageBox.Show("Donner Matiere ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Enseignant est ajouter avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                    Field_Nom.Clear();
                    Field_Prenom.Clear();
                    Field_Age.Clear();
                    Field_Salaire.Clear();

                }else
                {
                    MessageBox.Show("Enseignant déjà existe", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_Code.Clear();
                    Field_Nom.Clear();
                    Field_Prenom.Clear();
                    Field_Age.Clear();
                    Field_Salaire.Clear();
                }
            }
        }

        public bool modifier()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE Ens SET Nom='" + Field_Nom.Text + "',Prenom='" + Field_Prenom.Text + "',Age='" + Field_Age.Text + "',Groupe='" + combo_Groupe.Text + "',Filiere='" + combo_Filiere.Text + "',Matiere='" + combo_Matiere.Text + "',Salaire='" + Field_Salaire.Text + "' WHERE Code='" + Field_Code.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (Field_Code.Text == "" || Field_Nom.Text == "" || Field_Prenom.Text == "" || Field_Age.Text == "" || combo_Filiere.Text == "" || combo_Groupe.Text == "" || combo_Matiere.Text == "" || Field_Salaire.Text == "")
            {
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Salaire.Text == "")
                {
                    MessageBox.Show("Donner Salaire ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Prenom.Text == "")
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
                if (combo_Matiere.Text == "")
                {
                    MessageBox.Show("Donner Matiere ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                if (modifier())
                {
                    MessageBox.Show("Enseignant est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                    Field_Nom.Clear();
                    Field_Prenom.Clear();
                    Field_Age.Clear();
                    Field_Salaire.Clear();
                }else
                {
                    MessageBox.Show("Enseignant n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_Code.Clear();
                    Field_Nom.Clear();
                    Field_Prenom.Clear();
                    Field_Age.Clear();
                    Field_Salaire.Clear();
                }
            }
        }
        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Ens WHERE Code=" + Field_Code.Text;
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
                    MessageBox.Show("Enseignant est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                }else
                {
                    MessageBox.Show("Enseignant n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Code.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Ens.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"Nom like '%{searchText}%'";
                dataGrid_Ens.DataSource = dv;
            }
        }
    }
}
