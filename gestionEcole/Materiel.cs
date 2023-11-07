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
   
    public partial class Materiel : Form
    {
        ADO ado = new ADO();
        public Materiel()
        {
            InitializeComponent();
        }

        private void Materiel_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            Field_ID.PlaceholderText = "ID";
            Field_Search.PlaceholderText = "Chercher par type";
            Field_Qte.PlaceholderText = "Quantité";
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");
            combo_Type.Items.Add("Climatiseur");
            combo_Type.Items.Add("Tableau");
            combo_Type.Items.Add("Projecteur");
            combo_Type.Items.Add("Ordinateur");
            combo_Type.Items.Add("Caméra");
            dataGrid_Equipement.ReadOnly = true;
            ado.cmd.CommandText = "SELECT * FROM Materiel";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Equipement.DataSource = ado.dt;
            ado.dr.Close();
        }
        public void afficher()
        {
            if(ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Materiel";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Equipement.DataSource = ado.dt;
            ado.dr.Close();
        }
       
        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(ID) FROM Materiel WHERE ID=" + Field_ID.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }
        public bool Ajouter()
        {
            if (verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO Materiel VALUES('" + Field_ID.Text + "','" + combo_Type.Text + "','"+ Field_Qte.Text+"')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(Field_ID.Text == "" || combo_Type.Text == "" || Field_Qte.Text == "")
            {
                if(Field_ID.Text == "")
                {
                    MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(combo_Type.Text == "")
                {
                    MessageBox.Show("Donner Type ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Qte.Text == "")
                {
                    MessageBox.Show("Donner Quantité ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Materiel est ajouter avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                    Field_Qte.Clear();
                }else
                {
                    MessageBox.Show("Changer ID", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_ID.Clear();
                    Field_Qte.Clear();
                }
            }
        }

        public bool modifier()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE Materiel SET Type='" + combo_Type.Text + "',Quantité='"+ Field_Qte.Text +"' WHERE ID='" + Field_ID.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (Field_ID.Text == "" || combo_Type.Text == "" || Field_Qte.Text == "")
            {
                if (Field_ID.Text == "")
                {
                    MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Type.Text == "")
                {
                    MessageBox.Show("Donner Type ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Qte.Text == "")
                {
                    MessageBox.Show("Donner Quantité ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (modifier())
                {
                    MessageBox.Show("Materiel est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                    Field_Qte.Clear();
                }else
                {
                    MessageBox.Show("Materiel n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Field_ID.Clear();
                    Field_Qte.Clear();
                }
            }
        }

        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Materiel WHERE ID=" + Field_ID.Text;
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if(Field_ID.Text == "")
            {
                MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if (Supprimer())
                {
                    MessageBox.Show("Materiel est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                }
                else
                {
                    MessageBox.Show("Materiel n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_ID.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Equipement.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"Type like '%{searchText}%'";
                dataGrid_Equipement.DataSource = dv;
            }

        }
    }
}
