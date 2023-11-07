namespace gestionEcole
{
    partial class Cours
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_Cours = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Field_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.button_Supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.button_Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.Field_Code = new Guna.UI2.WinForms.Guna2TextBox();
            this.combo_Groupe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_Ens = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_Horaire = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Picture_Home = new FontAwesome.Sharp.IconPictureBox();
            this.combo_Annee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Salle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cours)).BeginInit();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Cours
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid_Cours.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Cours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Cours.ColumnHeadersHeight = 18;
            this.dataGrid_Cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Cours.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Cours.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Cours.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Cours.Location = new System.Drawing.Point(40, 471);
            this.dataGrid_Cours.Name = "dataGrid_Cours";
            this.dataGrid_Cours.RowHeadersVisible = false;
            this.dataGrid_Cours.RowHeadersWidth = 51;
            this.dataGrid_Cours.RowTemplate.Height = 24;
            this.dataGrid_Cours.Size = new System.Drawing.Size(1283, 236);
            this.dataGrid_Cours.TabIndex = 0;
            this.dataGrid_Cours.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Cours.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_Cours.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Cours.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_Cours.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Cours.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Cours.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Cours.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid_Cours.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Cours.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Cours.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_Cours.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Cours.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGrid_Cours.ThemeStyle.ReadOnly = false;
            this.dataGrid_Cours.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Cours.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Cours.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Cours.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_Cours.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid_Cours.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Cours.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Field_Search
            // 
            this.Field_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_Search.DefaultText = "";
            this.Field_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Search.Location = new System.Drawing.Point(1047, 369);
            this.Field_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Search.Name = "Field_Search";
            this.Field_Search.PasswordChar = '\0';
            this.Field_Search.PlaceholderText = "";
            this.Field_Search.SelectedText = "";
            this.Field_Search.Size = new System.Drawing.Size(229, 32);
            this.Field_Search.TabIndex = 34;
            // 
            // button_Search
            // 
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(861, 356);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(180, 45);
            this.button_Search.TabIndex = 33;
            this.button_Search.Text = "Recherche";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Supprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Supprimer.ForeColor = System.Drawing.Color.White;
            this.button_Supprimer.Location = new System.Drawing.Point(612, 356);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(180, 45);
            this.button_Supprimer.TabIndex = 30;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Modifier
            // 
            this.button_Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Modifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Modifier.ForeColor = System.Drawing.Color.White;
            this.button_Modifier.Location = new System.Drawing.Point(366, 356);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(180, 45);
            this.button_Modifier.TabIndex = 29;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // button_Add
            // 
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(144, 356);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 45);
            this.button_Add.TabIndex = 28;
            this.button_Add.Text = "Ajouter";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Field_Code
            // 
            this.Field_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_Code.DefaultText = "";
            this.Field_Code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_Code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_Code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_Code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Code.Location = new System.Drawing.Point(272, 193);
            this.Field_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Code.Name = "Field_Code";
            this.Field_Code.PasswordChar = '\0';
            this.Field_Code.PlaceholderText = "";
            this.Field_Code.SelectedText = "";
            this.Field_Code.Size = new System.Drawing.Size(229, 31);
            this.Field_Code.TabIndex = 35;
            // 
            // combo_Groupe
            // 
            this.combo_Groupe.BackColor = System.Drawing.Color.Transparent;
            this.combo_Groupe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Groupe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Groupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Groupe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Groupe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Groupe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Groupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Groupe.ItemHeight = 30;
            this.combo_Groupe.Location = new System.Drawing.Point(612, 193);
            this.combo_Groupe.Name = "combo_Groupe";
            this.combo_Groupe.Size = new System.Drawing.Size(229, 36);
            this.combo_Groupe.TabIndex = 37;
            // 
            // combo_Ens
            // 
            this.combo_Ens.BackColor = System.Drawing.Color.Transparent;
            this.combo_Ens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Ens.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Ens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Ens.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Ens.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Ens.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Ens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Ens.ItemHeight = 30;
            this.combo_Ens.Location = new System.Drawing.Point(612, 261);
            this.combo_Ens.Name = "combo_Ens";
            this.combo_Ens.Size = new System.Drawing.Size(229, 36);
            this.combo_Ens.TabIndex = 38;
            // 
            // combo_Horaire
            // 
            this.combo_Horaire.BackColor = System.Drawing.Color.Transparent;
            this.combo_Horaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Horaire.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Horaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Horaire.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Horaire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Horaire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Horaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Horaire.ItemHeight = 30;
            this.combo_Horaire.Location = new System.Drawing.Point(272, 261);
            this.combo_Horaire.Name = "combo_Horaire";
            this.combo_Horaire.Size = new System.Drawing.Size(229, 36);
            this.combo_Horaire.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Horaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Groupe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Enseignant";
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label4);
            this.panel_Title.Controls.Add(this.Picture_Home);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1633, 75);
            this.panel_Title.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cours";
            // 
            // Picture_Home
            // 
            this.Picture_Home.BackColor = System.Drawing.SystemColors.Control;
            this.Picture_Home.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.Picture_Home.IconColor = System.Drawing.Color.White;
            this.Picture_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Picture_Home.IconSize = 40;
            this.Picture_Home.Location = new System.Drawing.Point(21, 25);
            this.Picture_Home.Name = "Picture_Home";
            this.Picture_Home.Size = new System.Drawing.Size(40, 40);
            this.Picture_Home.TabIndex = 0;
            this.Picture_Home.TabStop = false;
            this.Picture_Home.Click += new System.EventHandler(this.Picture_Home_Click);
            // 
            // combo_Annee
            // 
            this.combo_Annee.BackColor = System.Drawing.Color.Transparent;
            this.combo_Annee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Annee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Annee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Annee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Annee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Annee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Annee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Annee.ItemHeight = 30;
            this.combo_Annee.Location = new System.Drawing.Point(993, 261);
            this.combo_Annee.Name = "combo_Annee";
            this.combo_Annee.Size = new System.Drawing.Size(229, 36);
            this.combo_Annee.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1230, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Année";
            // 
            // combo_Salle
            // 
            this.combo_Salle.BackColor = System.Drawing.Color.Transparent;
            this.combo_Salle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Salle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Salle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Salle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Salle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Salle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Salle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Salle.ItemHeight = 30;
            this.combo_Salle.Location = new System.Drawing.Point(993, 193);
            this.combo_Salle.Name = "combo_Salle";
            this.combo_Salle.Size = new System.Drawing.Size(229, 36);
            this.combo_Salle.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1228, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Salle";
            // 
            // Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 909);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_Salle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_Annee);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Horaire);
            this.Controls.Add(this.combo_Ens);
            this.Controls.Add(this.combo_Groupe);
            this.Controls.Add(this.Field_Code);
            this.Controls.Add(this.Field_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGrid_Cours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cours";
            this.Text = "Cours";
            this.Load += new System.EventHandler(this.Cours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cours)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_Cours;
        private Guna.UI2.WinForms.Guna2TextBox Field_Search;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2Button button_Supprimer;
        private Guna.UI2.WinForms.Guna2Button button_Modifier;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private Guna.UI2.WinForms.Guna2TextBox Field_Code;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Groupe;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Ens;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Horaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox Picture_Home;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Annee;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Salle;
        private System.Windows.Forms.Label label6;
    }
}