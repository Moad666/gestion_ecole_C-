using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Windows.Forms.DataVisualization.Charting;


namespace gestionEcole
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();
        private void Dash_Load(object sender, EventArgs e)
        {

            ado.getConnection();
            ado.cmd.CommandText = "SELECT Filiere,COUNT(ID) as Nombre_Etudiant FROM Etudiant Group by Filiere";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            chart1.BackColor = ColorTranslator.FromHtml("#12465a");
            chart1.DataSource = ado.dt;
            chart1.Series[0].XValueMember = "Filiere";
            chart1.Series[0].YValueMembers = "Nombre_Etudiant";
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart1.DataBind();


            ado.cmd.CommandText = "SELECT COUNT(*) as Nombre_Etudiant FROM Bulletin where Moyenne_Generale>= 10";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            chart2.BackColor = ColorTranslator.FromHtml("#12465a");
            chart2.DataSource = ado.dt;
            chart2.Series[0].XValueMember = "Nombre_Etudiant";
            chart2.Series[0].YValueMembers = "Nombre_Etudiant";
            chart2.Series[0].ChartType = SeriesChartType.Doughnut;
            chart2.DataBind();

            ado.cmd.CommandText = "select COUNT(*) as Nombre_Rapport from rapport";
            ado.cmd.Connection = ado.cnx;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            chart3.BackColor = ColorTranslator.FromHtml("#12465a");
            chart3.DataSource = ado.dt;
            chart3.Series[0].XValueMember = "Nombre_Rapport";
            chart3.Series[0].YValueMembers = "Nombre_Rapport";
            chart3.Series[0].ChartType = SeriesChartType.Doughnut;
            chart3.DataBind();





            panel_Left.BackColor = ColorTranslator.FromHtml("#12465a");
            panel_Title.BackColor = ColorTranslator.FromHtml("#12465a");
            panel_Paaa.BackColor = ColorTranslator.FromHtml("#12465a");
            /*Timer timer = new Timer();
            timer.Interval = 1000; // Mettre à jour toutes les secondes
            timer.Tick += Timer_Tick;
            timer.Start();*/
        }
        /*private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }*/
        /*private Form currentChildForm;
        private void openChildForm(Form childForm)
        {

        }*/
        private Etudiant etudiantForm;
        private Enseignant enseignantForm;
        private Parent parentForm;
        private Note noteForm;
        private Emploi emploiForm;
        private Cours coursForm;
        private Salle salleForm;
        private Materiel materielForm;
        private Rapport rapportForm;
        private Bulletin bullForm;
        private Abscence absForm;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if ( absForm != null|| bullForm != null|| rapportForm != null|| materielForm != null || enseignantForm != null || parentForm != null || noteForm != null || emploiForm != null || coursForm != null || salleForm != null )
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if(enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if(parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if(noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if(emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }

            }
            panel_Paaa.Controls.Clear();
            etudiantForm = new Etudiant();
            etudiantForm.TopLevel = false;
            etudiantForm.FormBorderStyle = FormBorderStyle.None;
            etudiantForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(etudiantForm);
            etudiantForm.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if ( absForm != null|| bullForm != null|| rapportForm != null|| materielForm != null || etudiantForm != null || parentForm != null || noteForm != null || emploiForm != null || coursForm != null || salleForm != null)
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            enseignantForm = new Enseignant();
            enseignantForm.TopLevel = false;
            enseignantForm.FormBorderStyle = FormBorderStyle.None;
            enseignantForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(enseignantForm);
            enseignantForm.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if ( absForm != null|| bullForm !=null || rapportForm != null|| materielForm != null|| etudiantForm != null || enseignantForm != null || noteForm != null || emploiForm != null || coursForm != null || salleForm != null)
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            parentForm = new Parent();
            parentForm.TopLevel = false;
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(parentForm);
            parentForm.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if ( absForm != null|| bullForm !=null || rapportForm !=null || materielForm != null|| etudiantForm != null || enseignantForm != null || parentForm != null || emploiForm != null || coursForm != null || salleForm != null)
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            noteForm = new Note();
            noteForm.TopLevel = false;
            noteForm.FormBorderStyle = FormBorderStyle.None;
            noteForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(noteForm);
            noteForm.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if ( absForm != null||bullForm != null|| rapportForm != null||etudiantForm != null || materielForm != null || parentForm != null || noteForm != null || coursForm != null || salleForm != null)
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            emploiForm = new Emploi();
            emploiForm.TopLevel = false;
            emploiForm.FormBorderStyle = FormBorderStyle.None;
            emploiForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(emploiForm);
            emploiForm.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if ( absForm!= null|| bullForm !=null|| rapportForm != null|| etudiantForm != null || materielForm != null || parentForm != null || noteForm != null || emploiForm != null || salleForm != null)
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            coursForm = new Cours();
            coursForm.TopLevel = false;
            coursForm.FormBorderStyle = FormBorderStyle.None;
            coursForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(coursForm);
            coursForm.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            if ( absForm!= null|| bullForm != null|| rapportForm != null|| materielForm != null ||etudiantForm != null || enseignantForm != null || parentForm != null || noteForm != null || emploiForm != null || coursForm != null)
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            salleForm = new Salle();
            salleForm.TopLevel = false;
            salleForm.FormBorderStyle = FormBorderStyle.None;
            salleForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(salleForm);
            salleForm.Show();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            if ( absForm != null|| bullForm != null|| rapportForm != null||salleForm != null || etudiantForm != null || enseignantForm != null || parentForm != null || noteForm != null || emploiForm != null || coursForm != null)
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            materielForm = new Materiel();
            materielForm.TopLevel = false;
            materielForm.FormBorderStyle = FormBorderStyle.None;
            materielForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(materielForm);
            materielForm.Show();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            if (  absForm!= null|| bullForm !=null || materielForm != null || salleForm != null || etudiantForm != null || enseignantForm != null || parentForm != null || noteForm != null || emploiForm != null || coursForm != null)
            {
                if (absForm != null)
                {
                    absForm.Close();
                    absForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            rapportForm = new Rapport();
            rapportForm.TopLevel = false;
            rapportForm.FormBorderStyle = FormBorderStyle.None;
            rapportForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(rapportForm);
            rapportForm.Show();
        }

  

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (rapportForm != null || materielForm != null || salleForm != null || etudiantForm != null || enseignantForm != null || parentForm != null || noteForm != null || emploiForm != null || coursForm != null)
            {
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            bullForm = new Bulletin();
            bullForm.TopLevel = false;
            bullForm.FormBorderStyle = FormBorderStyle.None;
            bullForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(bullForm);
            bullForm.Show();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            if (rapportForm != null || bullForm != null || materielForm != null || salleForm != null || etudiantForm != null || enseignantForm != null || parentForm != null || noteForm != null || emploiForm != null || coursForm != null)
            {
                if (rapportForm != null)
                {
                    rapportForm.Close();
                    rapportForm = null;
                }
                if (bullForm != null)
                {
                    bullForm.Close();
                    bullForm = null;
                }
                if (materielForm != null)
                {
                    materielForm.Close();
                    materielForm = null;
                }
                if (salleForm != null)
                {
                    salleForm.Close();
                    salleForm = null;
                }
                if (etudiantForm != null)
                {
                    etudiantForm.Close();
                    etudiantForm = null;
                }
                if (enseignantForm != null)
                {
                    enseignantForm.Close();
                    enseignantForm = null;
                }
                if (parentForm != null)
                {
                    parentForm.Close();
                    parentForm = null;
                }
                if (noteForm != null)
                {
                    noteForm.Close();
                    noteForm = null;
                }
                if (emploiForm != null)
                {
                    emploiForm.Close();
                    emploiForm = null;
                }
                if (coursForm != null)
                {
                    coursForm.Close();
                    coursForm = null;
                }
            }
            panel_Paaa.Controls.Clear();
            absForm = new Abscence();
            absForm.TopLevel = false;
            absForm.FormBorderStyle = FormBorderStyle.None;
            absForm.Dock = DockStyle.Fill;
            panel_Paaa.Controls.Add(absForm);
            absForm.Show();
        }

        private void panel_Paaa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
