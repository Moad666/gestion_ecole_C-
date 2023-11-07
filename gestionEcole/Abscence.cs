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
    public partial class Abscence : Form
    {
        public Abscence()
        {
            InitializeComponent();
        }

        ADO ado = new ADO();
        private void Abscence_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");

            Field_Code.PlaceholderText = "Code";
            Field_CNE.PlaceholderText = "CNE";
            Field_Heures.PlaceholderText = "Nombre heures";
            Field_Nom.PlaceholderText = "Nom étudiant";
            Field_Search.PlaceholderText = "Chercher par CNE";

            combo_Matiere.Items.Add("Français");
            combo_Matiere.Items.Add("Math");
            combo_Matiere.Items.Add("Arabe");
            combo_Matiere.Items.Add("SVT");
            combo_Matiere.Items.Add("PC");
            combo_Matiere.Items.Add("Education Islamique");
            combo_Matiere.Items.Add("Sport");
            combo_Matiere.Items.Add("Informatique");
            combo_Matiere.Items.Add("Anglais");

            ado.cmd.CommandText = "SELECT * FROM Abscence";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Abs.DataSource = ado.dt;
            ado.dr.Close();
        }

        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Abscence";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Abs.DataSource = ado.dt;
            ado.dr.Close();
        }
        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(Code) FROM Abscence WHERE Code=" + Field_Code.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }
        public bool Ajouter()
        {
            if (verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO Abscence VALUES('" + Field_Code.Text + "','" + Field_Nom.Text + "','" + Field_CNE.Text + "','" + combo_Matiere.Text + "','" + Field_Heures.Text + "','" + picker_Date.Value + "')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(Field_Code.Text == "" || Field_Nom.Text == "" || Field_CNE.Text == "" || combo_Matiere.Text == "")
            {
                if(Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_CNE.Text == "")
                {
                    MessageBox.Show("Donner CNE ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Abscence est enregistrer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                    Field_CNE.Clear();
                    Field_Heures.Clear();
                    Field_Nom.Clear();
                }else
                {
                    MessageBox.Show("Abscence n'est pas enregistrer", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Code.Clear();
                    Field_CNE.Clear();
                    Field_Heures.Clear();
                    Field_Nom.Clear();
                }
            }
        }

        public bool modifier()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE Abscence SET Nom='" + Field_Nom.Text + "',CNE='" + Field_CNE.Text + "',Matiere='" + combo_Matiere.Text + "',Heures='" + Field_Heures.Text + "',DateAbscence='" + picker_Date.Value + "' WHERE Code='" + Field_Code.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;


        }
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (Field_Code.Text == "" || Field_Nom.Text == "" || Field_CNE.Text == "" || combo_Matiere.Text == "")
            {
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_CNE.Text == "")
                {
                    MessageBox.Show("Donner CNE ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Matiere.Text == "")
                {
                    MessageBox.Show("Donner Matiere ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                if (modifier())
                {
                    MessageBox.Show("Abscence est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                    Field_CNE.Clear();
                    Field_Heures.Clear();
                    Field_Nom.Clear();
                }
                else
                {
                    MessageBox.Show("Abscence n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_Code.Clear();
                    Field_CNE.Clear();
                    Field_Heures.Clear();
                    Field_Nom.Clear();
                }
            }
        }

        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Abscence WHERE Code=" + Field_Code.Text;
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
                    MessageBox.Show("Abscence est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                }
                else
                {
                    MessageBox.Show("Abscence n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Code.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Abs.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"CNE like '%{searchText}%'";
                dataGrid_Abs.DataSource = dv;
            }
        }
    }
}
