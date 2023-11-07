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

namespace gestionEcole
{
    public partial class Salle : Form
    {
        public Salle()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();

        private void Salle_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            Field_Id.PlaceholderText = "Id";
            Field_Nom.PlaceholderText = "Nom Salle";
            Field_NbrChaise.PlaceholderText = "Nombre Chaise";
            Field_NbrEtd.PlaceholderText = "Nombre Etudiant";
            Field_NbrTable.PlaceholderText = "Nombre Table";
            Field_Search.PlaceholderText = "Chercher par nom salle";
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");
            ado.cmd.CommandText = "SELECT * FROM Salle";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Salle.DataSource = ado.dt;
            ado.dr.Close();
            dataGrid_Salle.ReadOnly = true;

        }

        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Salle";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Salle.DataSource = ado.dt;
            ado.dr.Close();
        }

      
      
        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(Id) FROM Salle WHERE Id=" + Field_Id.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }

        public bool Ajouter()
        {
            try
            {
                if (verifierCode() == 0)
                {
                    // Vérifie si le nombre d'étudiants est supérieur au nombre de chaises et tables
                    int nbrEtd = int.Parse(Field_NbrEtd.Text);
                    int nbrChaiseTable = int.Parse(Field_NbrChaise.Text) + int.Parse(Field_NbrTable.Text);
                    if (nbrEtd < nbrChaiseTable)
                    {
                        ado.cmd.CommandText = "INSERT INTO Salle VALUES('" + Field_Id.Text + "','" + Field_Nom.Text + "','" + Field_NbrEtd.Text + "','" + Field_NbrChaise.Text + "','" + Field_NbrTable.Text + "')";
                        ado.cmd.Connection = ado.cnx;
                        ado.cmd.ExecuteNonQuery();
                        return true;
                    }else
                    {
                        MessageBox.Show("Nombre des etudiants doit être > au nombre des chaises et tables");
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 16)
                {
                    MessageBox.Show("Nombre des etudiants doit être > au nombre des chaises et tables");
                }
                else
                {
                    MessageBox.Show("Salle existe deja", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return false;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if(Field_Id.Text == "" || Field_Nom.Text == "" || Field_NbrEtd.Text == "" || Field_NbrChaise.Text == "" || Field_NbrTable.Text == "")
            {
                if (Field_Id.Text == "")
                {
                    MessageBox.Show("Donner Id ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_NbrEtd.Text == "")
                {
                    MessageBox.Show("Donner Nombre des etudiants ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_NbrChaise.Text == "")
                {
                    MessageBox.Show("Donner Nombre des Chaises ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_NbrTable.Text == "")
                {
                    MessageBox.Show("Donner Nombre Tables ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                    if (Ajouter())
                    {
                        MessageBox.Show("Salle est ajouter avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        afficher();
                        Field_Id.Clear();
                        Field_Nom.Clear();
                        Field_NbrEtd.Clear();
                        Field_NbrChaise.Clear();
                        Field_NbrTable.Clear();
                    }

            }
        }

        public bool modifier()
        {
            try
            {
                if (verifierCode() != 0)
                {
                    int nbrEtd = int.Parse(Field_NbrEtd.Text);
                    int nbrChaiseTable = int.Parse(Field_NbrChaise.Text) + int.Parse(Field_NbrTable.Text);
                    if (nbrEtd < nbrChaiseTable)
                    {
                        ado.cmd.CommandText = "UPDATE Salle SET NomSalle='" + Field_Nom.Text + "',NombreEtudiant='" + Field_NbrEtd.Text + "',NombreChaise='" + Field_NbrChaise.Text + "',NombreTable='"+Field_NbrTable.Text + "' WHERE Id='" + Field_Id.Text + "'";
                        ado.cmd.Connection = ado.cnx;
                        ado.cmd.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nombre des etudiants doit être > au nombre des chaises et tables");
                    }

                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 16)
                {
                    MessageBox.Show("Nombre des etudiants doit être > au nombre des chaises et tables","Attention",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Salle existe deja", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return false;


        }
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (Field_Id.Text == "" || Field_Nom.Text == "" || Field_NbrEtd.Text == "" || Field_NbrChaise.Text == "" || Field_NbrTable.Text == "")
            {
                if (Field_Id.Text == "")
                {
                    MessageBox.Show("Donner Id ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Nom.Text == "")
                {
                    MessageBox.Show("Donner Nom ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_NbrEtd.Text == "")
                {
                    MessageBox.Show("Donner Nombre des etudiants ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_NbrChaise.Text == "")
                {
                    MessageBox.Show("Donner Nombre des Chaises ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_NbrTable.Text == "")
                {
                    MessageBox.Show("Donner Nombre Tables ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                if (modifier())
                {
                    MessageBox.Show("Salle est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Id.Clear();
                    Field_Nom.Clear();
                    Field_NbrEtd.Clear();
                    Field_NbrChaise.Clear();
                    Field_NbrTable.Clear();
                }
            }
        }

        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Salle WHERE Id=" + Field_Id.Text;
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if (Field_Id.Text == "")
            {
                MessageBox.Show("Donner Id ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if (Supprimer())
                {
                    MessageBox.Show("Salle est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Id.Clear();
                }
                else
                {
                    MessageBox.Show("Salle n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Id.Clear();
                }
            }
        }
       

        private void button_Search_Click(object sender, EventArgs e)
        {
            string search_Field = Field_Search.Text;
            if (search_Field.Trim() == "") // en elimine tous les esapces de debut et fin
            {
                dataGrid_Salle.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                /*
                 * . La classe DataView permet de visualiser les données d'une DataTable sous différentes formes,
                 * comme trier, filtrer ou rechercher des données.
                        dv.Sort
                 */
                dv.RowFilter = $"NomSalle like '%{search_Field}%'";                
                dataGrid_Salle.DataSource = dv;
            }
            
        }
    }
}
