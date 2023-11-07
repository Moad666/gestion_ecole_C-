using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace gestionEcole
{
    public partial class Bulletin : Form
    {
        public Bulletin()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();
        private void Bulletin_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            Field_ID.PlaceholderText = "ID";
            Field_Search.PlaceholderText = "Chercher par CNE";

            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");

            combo_Periode.Items.Add("Semestre 1");
            combo_Periode.Items.Add("Semestre 2");

            remplirComboCNE();

            ado.cmd.CommandText = "SELECT * FROM Bulletin";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Bulletin.DataSource = ado.dt;
            ado.dr.Close();

            dataGrid_Bulletin.ReadOnly = true;

        }

        public void remplirComboCNE()
        {
            ado.cmd.CommandText = "SELECT DISTINCT CNE FROM Note order by CNE asc";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(ado.dr);
            combo_CNE.DataSource = tab;
            combo_CNE.DisplayMember = "CNE";
            combo_CNE.ValueMember = "CNE";
            ado.dr.Close();
        }
        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Bulletin";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Bulletin.DataSource = ado.dt;
            ado.dr.Close();
        }

        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(ID) FROM Bulletin WHERE ID=" + Field_ID.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }

        public bool Ajouter()
        {
            if (verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO Bulletin(ID,CNE,Période,Année) VALUES('" + Field_ID.Text + "','" + combo_CNE.Text + "','" + combo_Periode.Text + "','" + picker_Date.Value + "')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(Field_ID.Text == "" || combo_CNE.Text == "" || combo_Periode.Text == "")
            {
                if(Field_ID.Text == "")
                {
                    MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_CNE.Text == "")
                {
                    MessageBox.Show("Donner CNE d'étudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Periode.Text == "")
                {
                    MessageBox.Show("Donner Semestre ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
 
            }else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Bulletin est enregistrer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                }else
                {
                    MessageBox.Show("Changer Code", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_ID.Clear();
                }
            }
        }

        public bool modifier()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE Bulletin SET CNE='" + combo_CNE.Text + "',Période='" + combo_Periode.Text + "',Année='" + picker_Date.Value +"' WHERE ID='" + Field_ID.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (Field_ID.Text == "" || combo_CNE.Text == "" || combo_Periode.Text == "")
            {
                if (Field_ID.Text == "")
                {
                    MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_CNE.Text == "")
                {
                    MessageBox.Show("Donner CNE d'étudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (combo_Periode.Text == "")
                {
                    MessageBox.Show("Donner Semestre ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }else
            {
                if (modifier())
                {
                    if (modifier())
                    {
                        MessageBox.Show("Bulletin est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        afficher();
                        Field_ID.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Bulletin n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Bulletin WHERE ID=" + Field_ID.Text;
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if (Field_ID.Text == "")
            {
                MessageBox.Show("Donner ID ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if (Supprimer())
                {
                    MessageBox.Show("Bulletin est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_ID.Clear();
                }
                else
                {
                    MessageBox.Show("Bulletin n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_ID.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Bulletin.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"CNE like '%{searchText}%'";
                dataGrid_Bulletin.DataSource = dv;
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            // license pour utiliser la biblio openXml pour les fichiers excel
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            // afficher une boite de dialogue pour choisir l'emplacement du fichier
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // les fichiers dispo sur la boite de dialogue
            saveFileDialog.Filter = "Excel files (.xlsx)|.xlsx|All files (.)|.";
            // selectionne par defaut du type excel : dans ce cas (.xlsx)|.xlsx
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // add nouvelle feuille a un classeur excel
                    /*
                        ExcelPackage : représente un fichier Excel
                        Workbook : Cette classe représente un classeur Excel
                        Worksheets : Cette propriété de la classe Workbook retourne une collection de feuilles de calcul.
                        Add : Cette méthode de la classe Worksheets permet d'ajouter une nouvelle feuille de calcul à la collection de feuilles de calcul.
                     */
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");
                    for (int i = 1; i < dataGrid_Bulletin.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i].Value = dataGrid_Bulletin.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGrid_Bulletin.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGrid_Bulletin.Columns.Count; j++)
                        {
                            if (dataGrid_Bulletin.Rows[i].Cells[j] != null && dataGrid_Bulletin.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGrid_Bulletin.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
                }
            }
        }
    }
}
