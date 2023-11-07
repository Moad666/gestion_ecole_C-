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

namespace gestionEcole
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();
        private void Auth_Load(object sender, EventArgs e)
        {
            ado.getConnection();
            Field_Pass.UseSystemPasswordChar = true;
            Field_Login.PlaceholderText = "Login";
            Field_Pass.PlaceholderText = "Password";
            //panel_right.BackColor = Color.Black;
            //this.BackColor = Color.Black;
            //panel_right.BackColor = ColorTranslator.FromHtml("#12465a");
            this.BackColor = ColorTranslator.FromHtml("#12465a");
            //guna2ControlBox1.BackColor = ColorTranslator.FromHtml("#12465a");
            //guna2ControlBox3.BackColor = ColorTranslator.FromHtml("#12465a");
            //this.Text = String.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous quitter ? ","Confirmation",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            if(Field_Login.Text == "" || Field_Pass.Text == "")
            {
                if(Field_Login.Text == "")
                {
                    MessageBox.Show("Donner login ! ", "Confirmation", MessageBoxButtons.OK);
                }
                if(Field_Pass.Text == "")
                {
                    MessageBox.Show("Donner password ! ", "Confirmation", MessageBoxButtons.OK);
                }
            }else
            {
                ado.cmd.CommandText = "SELECT loginAdmin, passAdmin FROM Admin";
                ado.cmd.Connection = ado.cnx;
                ado.dr = ado.cmd.ExecuteReader();
                bool qst = false;
                while (ado.dr.Read())
                {
                    if (ado.dr[0].ToString() == Field_Login.Text && ado.dr[1].ToString() == Field_Pass.Text)
                    {
                        qst = true;
                        break;
                    }
                }
                if (qst == true)
                {
                    Dash d = new Dash();
                    this.Hide();
                    d.Show();
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas l'autorisation ! ", "Confirmation", MessageBoxButtons.OK);
                    ado.dr.Close();
                }
            }
           
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void guna2ImageButton1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
