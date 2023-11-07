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
    public partial class Emploi : Form
    {
        public Emploi()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();
     
        

        private void Emploi_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionEcoleDataSet.EmploiTemps'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            ado.getConnection();
            Field_Code.PlaceholderText = "Code";
            Field_Id.PlaceholderText = "ID";
            Field_Search.PlaceholderText = "Chercher par code";
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");
            combo_Jour.Items.Add("Lundi");
            combo_Jour.Items.Add("Mardi");
            combo_Jour.Items.Add("Mercredi");
            combo_Jour.Items.Add("Jeudi");
            combo_Jour.Items.Add("Vendredi");
            combo_Jour.Items.Add("Samedi");
            dataGrid_Emploi.ReadOnly = true;
            combo_Horaire.Items.Add("Matin");
            combo_Horaire.Items.Add("Soire");

            combo_HD.Items.Add("8");
            combo_HD.Items.Add("9");
            combo_HD.Items.Add("10");
            combo_HD.Items.Add("11");
            combo_HD.Items.Add("14");
            combo_HD.Items.Add("15");
            combo_HD.Items.Add("16");
            combo_HD.Items.Add("17");

            combo_HF.Items.Add("9");
            combo_HF.Items.Add("10");
            combo_HF.Items.Add("11");
            combo_HF.Items.Add("12");
            combo_HF.Items.Add("14");
            combo_HF.Items.Add("15");
            combo_HF.Items.Add("16");
            combo_HF.Items.Add("17");
            combo_HF.Items.Add("18");

            ado.cmd.CommandText = "SELECT * FROM EmploiTemps";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Emploi.DataSource = ado.dt;
            ado.dr.Close();

        }

        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(Id) FROM EmploiTemps WHERE Id=" + Field_Id.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }

        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM EmploiTemps";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Emploi.DataSource = ado.dt;
            ado.dr.Close();
        }

        public bool Ajouter()
        {
            if(verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO EmploiTemps VALUES('"+Field_Id.Text+"','" + Field_Code.Text + "','" + combo_Jour.Text + "','" + combo_Horaire.Text + "','" + combo_HD.Text + "','" + combo_HF.Text + "')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
            
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if(Field_Code.Text == "" || combo_Jour.Text == "" || combo_Horaire.Text == "" || combo_HD.Text == "" || combo_HF.Text == "")
            {
                if(Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(combo_Jour.Text == "")
                {
                    MessageBox.Show("Donner Jour ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Horaire.Text == "")
                {
                    MessageBox.Show("Donner Horaire ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_HD.Text == "")
                {
                    MessageBox.Show("Donner Heure Debut ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_HF.Text == "")
                {
                    MessageBox.Show("Donner Heure Fin ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Emploi est ajouter avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Id.Clear();
                }
                else
                {
                    MessageBox.Show("Error : Emploi n'est pas ajouter", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_Code.Clear();
                    Field_Id.Clear();
                }
            }
        }
        public bool modifier()
        {
            if(verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE EmploiTemps SET Code='" + Field_Code.Text + "',Jour='" + combo_Jour.Text + "',Horaire='" + combo_Horaire.Text + "',HeureDebut='" + combo_HD.Text + "',HeureFin='" + combo_HF.Text + "' WHERE Id='" + Field_Id.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
                
            
        }
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (Field_Code.Text == "" || combo_Jour.Text == "" || combo_Horaire.Text == "" || combo_HD.Text == "" || combo_HF.Text == "")
            {
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Jour.Text == "")
                {
                    MessageBox.Show("Donner Jour ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Horaire.Text == "")
                {
                    MessageBox.Show("Donner Horaire ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_HD.Text == "")
                {
                    MessageBox.Show("Donner Heure Debut ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_HF.Text == "")
                {
                    MessageBox.Show("Donner Heure Fin ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }else
            {
                if (modifier())
                {
                    MessageBox.Show("Emploi est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Id.Clear();
                    
                }else
                {
                    MessageBox.Show("Emploi n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_Id.Clear();
                    Field_Code.Clear();
                }
            }
        }


        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM EmploiTemps WHERE Id=" + Field_Id.Text;
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if(Field_Id.Text == "")
            {
                MessageBox.Show("Donner Id", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if (Supprimer())
                {
                    MessageBox.Show("Emploi est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Id.Clear();
                    Field_Code.Clear();
                }else
                {
                    MessageBox.Show("Emploi n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Id.Clear();
                    Field_Code.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Emploi.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"Code like '%{searchText}%'";
                dataGrid_Emploi.DataSource = dv;
            }
        }
    }
}
