namespace gestionEcole
{
    partial class Emploi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Field_Code = new Guna.UI2.WinForms.Guna2TextBox();
            this.combo_Jour = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_HD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_HF = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.button_Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.combo_Horaire = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid_Emploi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Field_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.Field_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Picture_Home = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Emploi)).BeginInit();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).BeginInit();
            this.SuspendLayout();
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
            this.Field_Code.Location = new System.Drawing.Point(477, 138);
            this.Field_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Code.Name = "Field_Code";
            this.Field_Code.PasswordChar = '\0';
            this.Field_Code.PlaceholderText = "";
            this.Field_Code.SelectedText = "";
            this.Field_Code.Size = new System.Drawing.Size(229, 29);
            this.Field_Code.TabIndex = 1;
            // 
            // combo_Jour
            // 
            this.combo_Jour.BackColor = System.Drawing.Color.Transparent;
            this.combo_Jour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Jour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Jour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Jour.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Jour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Jour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Jour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Jour.ItemHeight = 30;
            this.combo_Jour.Location = new System.Drawing.Point(121, 215);
            this.combo_Jour.Name = "combo_Jour";
            this.combo_Jour.Size = new System.Drawing.Size(229, 36);
            this.combo_Jour.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jours";
            // 
            // combo_HD
            // 
            this.combo_HD.BackColor = System.Drawing.Color.Transparent;
            this.combo_HD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_HD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_HD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_HD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_HD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_HD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_HD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_HD.ItemHeight = 30;
            this.combo_HD.Location = new System.Drawing.Point(477, 215);
            this.combo_HD.Name = "combo_HD";
            this.combo_HD.Size = new System.Drawing.Size(229, 36);
            this.combo_HD.TabIndex = 4;
            // 
            // combo_HF
            // 
            this.combo_HF.BackColor = System.Drawing.Color.Transparent;
            this.combo_HF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_HF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_HF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_HF.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_HF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_HF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_HF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_HF.ItemHeight = 30;
            this.combo_HF.Location = new System.Drawing.Point(837, 215);
            this.combo_HF.Name = "combo_HF";
            this.combo_HF.Size = new System.Drawing.Size(229, 36);
            this.combo_HF.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Heure Debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Heure Fin";
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
            this.button_Supprimer.Location = new System.Drawing.Point(652, 337);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(180, 45);
            this.button_Supprimer.TabIndex = 19;
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
            this.button_Modifier.Location = new System.Drawing.Point(393, 337);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(180, 45);
            this.button_Modifier.TabIndex = 18;
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
            this.button_Add.Location = new System.Drawing.Point(121, 337);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 45);
            this.button_Add.TabIndex = 17;
            this.button_Add.Text = "Ajouter";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
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
            this.combo_Horaire.Location = new System.Drawing.Point(837, 138);
            this.combo_Horaire.Name = "combo_Horaire";
            this.combo_Horaire.Size = new System.Drawing.Size(229, 36);
            this.combo_Horaire.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1072, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Matin/Soire";
            // 
            // dataGrid_Emploi
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGrid_Emploi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Emploi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_Emploi.ColumnHeadersHeight = 18;
            this.dataGrid_Emploi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Emploi.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid_Emploi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Emploi.Location = new System.Drawing.Point(21, 455);
            this.dataGrid_Emploi.Name = "dataGrid_Emploi";
            this.dataGrid_Emploi.RowHeadersVisible = false;
            this.dataGrid_Emploi.RowHeadersWidth = 51;
            this.dataGrid_Emploi.RowTemplate.Height = 24;
            this.dataGrid_Emploi.Size = new System.Drawing.Size(1309, 256);
            this.dataGrid_Emploi.TabIndex = 24;
            this.dataGrid_Emploi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Emploi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_Emploi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Emploi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_Emploi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Emploi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Emploi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Emploi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid_Emploi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Emploi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Emploi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_Emploi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Emploi.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGrid_Emploi.ThemeStyle.ReadOnly = false;
            this.dataGrid_Emploi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Emploi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Emploi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Emploi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_Emploi.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid_Emploi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Emploi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Field_Id
            // 
            this.Field_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_Id.DefaultText = "";
            this.Field_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Id.Location = new System.Drawing.Point(121, 138);
            this.Field_Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Id.Name = "Field_Id";
            this.Field_Id.PasswordChar = '\0';
            this.Field_Id.PlaceholderText = "";
            this.Field_Id.SelectedText = "";
            this.Field_Id.Size = new System.Drawing.Size(229, 29);
            this.Field_Id.TabIndex = 25;
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
            this.button_Search.Location = new System.Drawing.Point(907, 337);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(180, 45);
            this.button_Search.TabIndex = 26;
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
            this.Field_Search.Location = new System.Drawing.Point(1093, 350);
            this.Field_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Search.Name = "Field_Search";
            this.Field_Search.PasswordChar = '\0';
            this.Field_Search.PlaceholderText = "";
            this.Field_Search.SelectedText = "";
            this.Field_Search.Size = new System.Drawing.Size(209, 32);
            this.Field_Search.TabIndex = 27;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label5);
            this.panel_Title.Controls.Add(this.Picture_Home);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1344, 75);
            this.panel_Title.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Emploi du temps";
            // 
            // Picture_Home
            // 
            this.Picture_Home.BackColor = System.Drawing.SystemColors.Control;
            this.Picture_Home.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.Picture_Home.IconColor = System.Drawing.Color.White;
            this.Picture_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Picture_Home.IconSize = 40;
            this.Picture_Home.Location = new System.Drawing.Point(21, 25);
            this.Picture_Home.Name = "Picture_Home";
            this.Picture_Home.Size = new System.Drawing.Size(40, 40);
            this.Picture_Home.TabIndex = 0;
            this.Picture_Home.TabStop = false;
            // 
            // Emploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 853);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.Field_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.Field_Id);
            this.Controls.Add(this.dataGrid_Emploi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_Horaire);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_HF);
            this.Controls.Add(this.combo_HD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Jour);
            this.Controls.Add(this.Field_Code);
            this.Name = "Emploi";
            this.Text = "Emploi";
            this.Load += new System.EventHandler(this.Emploi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Emploi)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox Field_Code;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Jour;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox combo_HD;
        private Guna.UI2.WinForms.Guna2ComboBox combo_HF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button button_Supprimer;
        private Guna.UI2.WinForms.Guna2Button button_Modifier;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Horaire;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_Emploi;
        private Guna.UI2.WinForms.Guna2TextBox Field_Id;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2TextBox Field_Search;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox Picture_Home;
    }
}