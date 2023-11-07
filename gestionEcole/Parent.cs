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
    public partial class Parent : Form
    {
        ADO ado = new ADO();
        public Parent()
        {
            InitializeComponent();
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            Field_CIN.PlaceholderText = "CIN";
            Field_Nom.PlaceholderText = "Nom";
            Field_Prenom.PlaceholderText = "Prenom";
            Field_Telephone.PlaceholderText = "Telephone";
            Field_Code.PlaceholderText = "Code";
            Field_Search.PlaceholderText = "Chercher par CIN";
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");
            combo_Sexe.Items.Add("Pére");
            combo_Sexe.Items.Add("Mére");
            combo_Sexe.Items.Add("Frére");
            combo_Sexe.Items.Add("Soeur");
            dataGrid_Parent.ReadOnly = true;
            ado.cmd.CommandText = "SELECT * FROM Parent";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Parent.DataSource = ado.dt;
            ado.dr.Close();

            remplirComboEtudiant();
            remplirComboPrenomEtd();
        }

        public void remplirComboEtudiant()
        {
            ado.cmd.CommandText = "SELECT Nom FROM Etudiant order by Nom asc";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(ado.dr);
            combo_Etd.DataSource = tab;
            combo_Etd.DisplayMember = "Nom";
            combo_Etd.ValueMember = "Nom";
            ado.dr.Close();
        }

        public void remplirComboPrenomEtd()
        {
            ado.cmd.CommandText = "SELECT Prenom FROM Etudiant order by Prenom asc";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(ado.dr);
            combo_PrenomEtd.DataSource = tab;
            combo_PrenomEtd.DisplayMember = "Prenom";
            combo_PrenomEtd.ValueMember = "Prenom";
            ado.dr.Close();
        }

        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Parent";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Parent.DataSource = ado.dt;
            ado.dr.Close();
        }

        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(Code) FROM Parent WHERE Code=" + Field_Code.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }

        public bool Ajouter()
        {
            if(verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO Parent VALUES('" + Field_Code.Text + "','" + Field_CIN.Text + "','" + Field_Nom.Text + "','" + Field_Prenom.Text + "','" + combo_Sexe.Text + "','" + Field_Telephone.Text + "','" + combo_Etd.Text + "','" + combo_PrenomEtd.Text + "')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
            
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            if( Field_Code.Text == ""|| Field_CIN.Text == "" || Field_Nom.Text == "" || Field_Prenom.Text == "" || Field_Telephone.Text == "" || combo_Sexe.Text == "" || combo_Etd.Text == "" || combo_PrenomEtd.Text == "")
            {
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_CIN.Text == "")
                {
                    MessageBox.Show("Donner Cin ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Prenom.Text == "")
                {
                    MessageBox.Show("Donner Prenom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Telephone.Text == "")
                {
                    MessageBox.Show("Donner Telephone ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Sexe.Text == "")
                {
                    MessageBox.Show("Donner Tuteur ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Etd.Text == "")
                {
                    MessageBox.Show("Donner Nom Etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_PrenomEtd.Text == "")
                {
                    MessageBox.Show("Donner Prenom Etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Parent est ajouter avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_CIN.Clear();
                    Field_Nom.Clear();
                    Field_Prenom.Clear();
                    Field_Telephone.Clear();
                }else
                {
                    MessageBox.Show("Parent n'est pas ajouter", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_CIN.Clear();
                    Field_Nom.Clear();
                    Field_Prenom.Clear();
                    Field_Telephone.Clear();
                }
            }
        }





       
        public bool modifier()
        {
            if(verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE Parent SET Cin='" + Field_CIN.Text + "',Nom='" + Field_Nom.Text + "',Prenom='" + Field_Prenom.Text + "',Sexe='" + combo_Sexe.Text + "',Telephone='" + Field_Telephone.Text + "',NomEtudiant='" + combo_Etd.Text + "',PrenomEtudiant='" + combo_PrenomEtd.Text + "' WHERE Code='" + Field_Code.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (Field_Code.Text == "" || Field_CIN.Text == "" || Field_Nom.Text == "" || Field_Prenom.Text == "" || Field_Telephone.Text == "" || combo_Sexe.Text == "" || combo_Etd.Text == "" || combo_PrenomEtd.Text == "")
            {
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_CIN.Text == "")
                {
                    MessageBox.Show("Donner Cin ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Prenom.Text == "")
                {
                    MessageBox.Show("Donner Prenom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Telephone.Text == "")
                {
                    MessageBox.Show("Donner Telephone ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Sexe.Text == "")
                {
                    MessageBox.Show("Donner Tuteur ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Etd.Text == "")
                {
                    MessageBox.Show("Donner Nom Etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_PrenomEtd.Text == "")
                {
                    MessageBox.Show("Donner Prenom Etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                if (modifier())
                {
                    MessageBox.Show("Parent est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_CIN.Clear();
                    Field_Nom.Clear();
                    Field_Prenom.Clear();
                    Field_Telephone.Clear();
                }else
                {
                    MessageBox.Show("Parent n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_CIN.Clear();
                    Field_Nom.Clear();
                    Field_Prenom.Clear();
                    Field_Telephone.Clear();
                }
            }
        }

        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Parent WHERE Code=" + Field_Code.Text;
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
                    MessageBox.Show("Parent est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                }else
                {
                    MessageBox.Show("Parent n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Code.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Parent.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"Cin like '%{searchText}%'";
                dataGrid_Parent.DataSource = dv;
            }
        }
    }
}
