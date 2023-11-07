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
    public partial class Note : Form
    {
        ADO ado = new ADO();
        public Note()
        {
            InitializeComponent();
        }

        private void Note_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            Field_Search.PlaceholderText = "Chercher par CNE d'etudiant";
            Field_Note1.PlaceholderText = "Note 1";
            Field_Note2.PlaceholderText = "Note 2";
            Field_Note3.PlaceholderText = "Note 3";
            Field_ID.PlaceholderText = "ID";
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");
            dataGrid_Notes.ReadOnly = true;

            combo_Matiere.Items.Add("Français");
            combo_Matiere.Items.Add("Math");
            combo_Matiere.Items.Add("Arabe");
            combo_Matiere.Items.Add("SVT");
            combo_Matiere.Items.Add("PC");
            combo_Matiere.Items.Add("Education Islamique");
            combo_Matiere.Items.Add("Sport");
            combo_Matiere.Items.Add("Informatique");
            combo_Matiere.Items.Add("Anglais");

            ado.cmd.CommandText = "SELECT * FROM Note";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Notes.DataSource = ado.dt;
            ado.dr.Close();

            remplirComboEtd();

        }

        public void remplirComboEtd()
        {
            ado.cmd.CommandText = "SELECT CNE FROM Etudiant order by CNE asc";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(ado.dr);
            combo_NomEtd.DataSource = tab;
            combo_NomEtd.DisplayMember = "CNE";
            combo_NomEtd.ValueMember = "CNE";
            ado.dr.Close();
        }

      
 
        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Note";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Notes.DataSource = ado.dt;
            ado.dr.Close();
        }

        public bool Ajouter()
        {
            ado.cmd.CommandText = "INSERT INTO Note(Code,Nom,Matiere,Note1,Note2,Note3) VALUES('"+ Field_ID.Text+"','"+ combo_NomEtd.Text + "','" + combo_Matiere.Text + "','" + Field_Note1.Text + "','" + Field_Note2.Text + "','" + Field_Note3.Text +"')";
            ado.cmd.Connection = ado.cnx;
            ado.cmd.ExecuteNonQuery();
            return true;
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(combo_NomEtd.Text == "" || combo_Matiere.Text == ""|| Field_Note1.Text == "" ||Field_Note2.Text == "" || Field_Note3.Text == "")
            {
                if (combo_NomEtd.Text == "")
                {
                    MessageBox.Show("Donner Nom d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Matiere.Text == "")
                {
                    MessageBox.Show("Donner Matiere ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Note1.Text == "")
                {
                    MessageBox.Show("Donner Note 1 d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Note2.Text == "")
                {
                    MessageBox.Show("Donner Note 2 d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Note3.Text == "")
                {
                    MessageBox.Show("Donner Note 3 d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Notes sont ajouter avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Note1.Clear();
                    Field_Note2.Clear();
                    Field_Note3.Clear();
                    Field_ID.Clear();
                }else
                {
                    MessageBox.Show("Notes n'ont pas ajouter", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool modifier()
        {
             ado.cmd.CommandText = "UPDATE Note SET Nom='" + combo_NomEtd.Text + "',Matiere='"+combo_Matiere.Text+ "',Note1=" + Field_Note1.Text + ",Note2=" + Field_Note2.Text + ",Note3=" + Field_Note3.Text +" WHERE Code='" + Field_ID.Text + "'";
             ado.cmd.Connection = ado.cnx;
             ado.cmd.ExecuteNonQuery();
             return true;
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (combo_NomEtd.Text == "" || combo_Matiere.Text == "" || Field_Note1.Text == "" || Field_Note2.Text == "" || Field_Note3.Text == "")
            {
                if (combo_NomEtd.Text == "")
                {
                    MessageBox.Show("Donner Nom d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Matiere.Text == "")
                {
                    MessageBox.Show("Donner Matiere ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Note1.Text == "")
                {
                    MessageBox.Show("Donner Note 1 d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Note2.Text == "")
                {
                    MessageBox.Show("Donner Note 2 d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Note3.Text == "")
                {
                    MessageBox.Show("Donner Note 3 d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }else
            {
                if (modifier())
                {
                    MessageBox.Show("Notes sont modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Note1.Clear();
                    Field_Note2.Clear();
                    Field_Note3.Clear();
                }else
                {
                    MessageBox.Show("Notes n'ont pas modifier", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool Supprimer()
        {
                ado.cmd.CommandText = "DELETE FROM Note WHERE Code=" + Field_ID.Text;
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
           
        }
        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if(combo_NomEtd.Text == "")
            {
                MessageBox.Show("Donner Nom d'etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if (Supprimer())
                {
                    MessageBox.Show("Suppression est effectué avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                }
                else
                {
                    MessageBox.Show("Suppression n'est effectué", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Notes.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"CNE like '%{searchText}%'";
                dataGrid_Notes.DataSource = dv;
            }
        }
    }
}
