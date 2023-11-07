using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;


namespace gestionEcole
{
    public partial class Rapport : Form
    {
        ADO ado = new ADO();
        public Rapport()
        {
            InitializeComponent();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            Field_Code.PlaceholderText = "Code";
            Field_Cause.PlaceholderText = "Cause";
            Field_CNE.PlaceholderText = "CNE";
            Field_Etudiant.PlaceholderText = "Nom Etudiant";
            Field_Search.PlaceholderText = "Chercher Par CNE/nom";
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");

            ado.cmd.CommandText = "SELECT * FROM Rapport";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Rapport.DataSource = ado.dt;
            ado.dr.Close();
            dataGrid_Rapport.ReadOnly = true;
        }



        public void afficher()
        {
            if (ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "SELECT * FROM Rapport";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGrid_Rapport.DataSource = ado.dt;
            ado.dr.Close();
        }
        public int verifierCode()
        {
            ado.cmd.CommandText = "SELECT COUNT(Code) FROM Rapport WHERE Code=" + Field_Code.Text;
            ado.cmd.Connection = ado.cnx;
            int cpt = (int)ado.cmd.ExecuteScalar();
            int compteur = (int)cpt;
            return compteur;
        }

        public bool Ajouter()
        {
            if (verifierCode() == 0)
            {
                ado.cmd.CommandText = "INSERT INTO Rapport VALUES('" + Field_Code.Text + "','" + Field_Etudiant.Text + "','" + Field_CNE.Text + "','" + picker_Date.Value + "','" + Field_Cause.Text + "')";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;

        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (Field_Code.Text == "" || Field_Etudiant.Text == "" || Field_CNE.Text == "" || Field_Cause.Text == "")
            {
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Etudiant.Text == "")
                {
                    MessageBox.Show("Donner l'Etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_CNE.Text == "")
                {
                    MessageBox.Show("Donner CNE ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Cause.Text == "")
                {
                    MessageBox.Show("Donner Cause ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (Ajouter())
                {
                    MessageBox.Show("Rapport est enregistrer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();

                }
                else
                {
                    MessageBox.Show("Changer Code", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        public bool modifier()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "UPDATE Rapport SET Etudiant='" + Field_Etudiant.Text + "',CNE='" + Field_CNE.Text + "',Date='" + picker_Date.Value + "',Cause='" + Field_Cause.Text + "' WHERE Code='" + Field_Code.Text + "'";
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void button_Modifier_Click(object sender, EventArgs e)
        {
            if (Field_Code.Text == "" || Field_Etudiant.Text == "" || Field_CNE.Text == "" || Field_Cause.Text == "")
            {
                if (Field_Code.Text == "")
                {
                    MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Etudiant.Text == "")
                {
                    MessageBox.Show("Donner l'Etudiant ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_CNE.Text == "")
                {
                    MessageBox.Show("Donner CNE ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Field_Cause.Text == "")
                {
                    MessageBox.Show("Donner Cause ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (modifier())
                {
                    if (modifier())
                    {
                        MessageBox.Show("Rapport est modifier avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        afficher();
                    }
                    else
                    {
                        MessageBox.Show("Rapport n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        public bool Supprimer()
        {
            if (verifierCode() != 0)
            {
                ado.cmd.CommandText = "DELETE FROM Rapport WHERE Code=" + Field_Code.Text;
                ado.cmd.Connection = ado.cnx;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if (Field_Code.Text == "")
            {
                MessageBox.Show("Donner Code ! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (Supprimer())
                {
                    MessageBox.Show("Rapport est supprimer avec succée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    afficher();
                    Field_Code.Clear();
                }
                else
                {
                    MessageBox.Show("Rapport n'existe pas", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Field_Code.Clear();
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = Field_Search.Text;

            if (searchText.Trim() == "")
            {
                dataGrid_Rapport.DataSource = ado.dt;
            }
            else
            {
                DataView dv = ado.dt.DefaultView;
                dv.RowFilter = $"CNE like '%{searchText}%' OR Etudiant like '%{searchText}%'";
                dataGrid_Rapport.DataSource = dv;
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
                    for (int i = 1; i < dataGrid_Rapport.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i].Value = dataGrid_Rapport.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGrid_Rapport.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGrid_Rapport.Columns.Count; j++)
                        {
                            if (dataGrid_Rapport.Rows[i].Cells[j] != null && dataGrid_Rapport.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGrid_Rapport.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));
                }
            }
        }
    }
}
