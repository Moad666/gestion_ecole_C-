namespace gestionEcole
{
    partial class Enseignant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_Ens = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Field_Code = new Guna.UI2.WinForms.Guna2TextBox();
            this.Field_Prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.Field_Salaire = new Guna.UI2.WinForms.Guna2TextBox();
            this.Field_Nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.Field_Age = new Guna.UI2.WinForms.Guna2TextBox();
            this.combo_Filiere = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_Groupe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_Matiere = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.button_Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.button_Supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.Field_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Picture_Home = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ens)).BeginInit();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Ens
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataGrid_Ens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Ens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGrid_Ens.ColumnHeadersHeight = 18;
            this.dataGrid_Ens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Ens.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Ens.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGrid_Ens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Ens.Location = new System.Drawing.Point(43, 451);
            this.dataGrid_Ens.Name = "dataGrid_Ens";
            this.dataGrid_Ens.RowHeadersVisible = false;
            this.dataGrid_Ens.RowHeadersWidth = 51;
            this.dataGrid_Ens.RowTemplate.Height = 24;
            this.dataGrid_Ens.Size = new System.Drawing.Size(1298, 262);
            this.dataGrid_Ens.TabIndex = 0;
            this.dataGrid_Ens.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Ens.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_Ens.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Ens.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_Ens.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Ens.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Ens.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Ens.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid_Ens.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Ens.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Ens.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_Ens.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Ens.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGrid_Ens.ThemeStyle.ReadOnly = false;
            this.dataGrid_Ens.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Ens.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Ens.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Ens.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_Ens.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid_Ens.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Ens.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.Field_Code.Location = new System.Drawing.Point(43, 158);
            this.Field_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Code.Name = "Field_Code";
            this.Field_Code.PasswordChar = '\0';
            this.Field_Code.PlaceholderText = "";
            this.Field_Code.SelectedText = "";
            this.Field_Code.Size = new System.Drawing.Size(229, 33);
            this.Field_Code.TabIndex = 1;
            // 
            // Field_Prenom
            // 
            this.Field_Prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_Prenom.DefaultText = "";
            this.Field_Prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_Prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_Prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Prenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_Prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Prenom.Location = new System.Drawing.Point(713, 158);
            this.Field_Prenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Prenom.Name = "Field_Prenom";
            this.Field_Prenom.PasswordChar = '\0';
            this.Field_Prenom.PlaceholderText = "";
            this.Field_Prenom.SelectedText = "";
            this.Field_Prenom.Size = new System.Drawing.Size(229, 33);
            this.Field_Prenom.TabIndex = 2;
            // 
            // Field_Salaire
            // 
            this.Field_Salaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_Salaire.DefaultText = "";
            this.Field_Salaire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_Salaire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_Salaire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Salaire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Salaire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Salaire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_Salaire.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Salaire.Location = new System.Drawing.Point(43, 241);
            this.Field_Salaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Salaire.Name = "Field_Salaire";
            this.Field_Salaire.PasswordChar = '\0';
            this.Field_Salaire.PlaceholderText = "";
            this.Field_Salaire.SelectedText = "";
            this.Field_Salaire.Size = new System.Drawing.Size(229, 33);
            this.Field_Salaire.TabIndex = 3;
            // 
            // Field_Nom
            // 
            this.Field_Nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_Nom.DefaultText = "";
            this.Field_Nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_Nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_Nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_Nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Nom.Location = new System.Drawing.Point(387, 158);
            this.Field_Nom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Nom.Name = "Field_Nom";
            this.Field_Nom.PasswordChar = '\0';
            this.Field_Nom.PlaceholderText = "";
            this.Field_Nom.SelectedText = "";
            this.Field_Nom.Size = new System.Drawing.Size(229, 33);
            this.Field_Nom.TabIndex = 5;
            // 
            // Field_Age
            // 
            this.Field_Age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_Age.DefaultText = "";
            this.Field_Age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_Age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_Age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_Age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Age.Location = new System.Drawing.Point(1027, 158);
            this.Field_Age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Age.Name = "Field_Age";
            this.Field_Age.PasswordChar = '\0';
            this.Field_Age.PlaceholderText = "";
            this.Field_Age.SelectedText = "";
            this.Field_Age.Size = new System.Drawing.Size(229, 33);
            this.Field_Age.TabIndex = 6;
            // 
            // combo_Filiere
            // 
            this.combo_Filiere.BackColor = System.Drawing.Color.Transparent;
            this.combo_Filiere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Filiere.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Filiere.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Filiere.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Filiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Filiere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Filiere.ItemHeight = 30;
            this.combo_Filiere.Location = new System.Drawing.Point(387, 238);
            this.combo_Filiere.Name = "combo_Filiere";
            this.combo_Filiere.Size = new System.Drawing.Size(229, 36);
            this.combo_Filiere.TabIndex = 9;
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
            this.combo_Groupe.Location = new System.Drawing.Point(713, 238);
            this.combo_Groupe.Name = "combo_Groupe";
            this.combo_Groupe.Size = new System.Drawing.Size(229, 36);
            this.combo_Groupe.TabIndex = 10;
            // 
            // combo_Matiere
            // 
            this.combo_Matiere.BackColor = System.Drawing.Color.Transparent;
            this.combo_Matiere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Matiere.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Matiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Matiere.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Matiere.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Matiere.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Matiere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Matiere.ItemHeight = 30;
            this.combo_Matiere.Location = new System.Drawing.Point(1027, 238);
            this.combo_Matiere.Name = "combo_Matiere";
            this.combo_Matiere.Size = new System.Drawing.Size(229, 36);
            this.combo_Matiere.TabIndex = 11;
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
            this.button_Add.Location = new System.Drawing.Point(116, 349);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 45);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "Ajouter";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
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
            this.button_Modifier.Location = new System.Drawing.Point(374, 349);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(180, 45);
            this.button_Modifier.TabIndex = 13;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
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
            this.button_Supprimer.Location = new System.Drawing.Point(624, 349);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(180, 45);
            this.button_Supprimer.TabIndex = 14;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
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
            this.button_Search.Location = new System.Drawing.Point(901, 349);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(180, 45);
            this.button_Search.TabIndex = 17;
            this.button_Search.Text = "Recherche";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
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
            this.Field_Search.Location = new System.Drawing.Point(1087, 362);
            this.Field_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Search.Name = "Field_Search";
            this.Field_Search.PasswordChar = '\0';
            this.Field_Search.PlaceholderText = "";
            this.Field_Search.SelectedText = "";
            this.Field_Search.Size = new System.Drawing.Size(229, 32);
            this.Field_Search.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Groupe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filiere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1124, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Matiere";
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label5);
            this.panel_Title.Controls.Add(this.Picture_Home);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1344, 75);
            this.panel_Title.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enseignant";
            // 
            // Picture_Home
            // 
            this.Picture_Home.BackColor = System.Drawing.SystemColors.Control;
            this.Picture_Home.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.Picture_Home.IconColor = System.Drawing.Color.White;
            this.Picture_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Picture_Home.IconSize = 40;
            this.Picture_Home.Location = new System.Drawing.Point(21, 25);
            this.Picture_Home.Name = "Picture_Home";
            this.Picture_Home.Size = new System.Drawing.Size(40, 40);
            this.Picture_Home.TabIndex = 0;
            this.Picture_Home.TabStop = false;
            // 
            // Enseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 853);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Field_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.combo_Matiere);
            this.Controls.Add(this.combo_Groupe);
            this.Controls.Add(this.combo_Filiere);
            this.Controls.Add(this.Field_Age);
            this.Controls.Add(this.Field_Nom);
            this.Controls.Add(this.Field_Salaire);
            this.Controls.Add(this.Field_Prenom);
            this.Controls.Add(this.Field_Code);
            this.Controls.Add(this.dataGrid_Ens);
            this.Name = "Enseignant";
            this.Text = "Enseignant";
            this.Load += new System.EventHandler(this.Enseignant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ens)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_Ens;
        private Guna.UI2.WinForms.Guna2TextBox Field_Code;
        private Guna.UI2.WinForms.Guna2TextBox Field_Prenom;
        private Guna.UI2.WinForms.Guna2TextBox Field_Salaire;
        private Guna.UI2.WinForms.Guna2TextBox Field_Nom;
        private Guna.UI2.WinForms.Guna2TextBox Field_Age;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Filiere;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Groupe;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Matiere;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private Guna.UI2.WinForms.Guna2Button button_Modifier;
        private Guna.UI2.WinForms.Guna2Button button_Supprimer;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2TextBox Field_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox Picture_Home;
    }
}