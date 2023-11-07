namespace gestionEcole
{
    partial class Abscence
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
            this.combo_Matiere = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Field_Heures = new Guna.UI2.WinForms.Guna2TextBox();
            this.picker_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Field_CNE = new Guna.UI2.WinForms.Guna2TextBox();
            this.Field_Nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.Field_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.button_Supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.button_Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Picture_Home = new FontAwesome.Sharp.IconPictureBox();
            this.Field_Code = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGrid_Abs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Abs)).BeginInit();
            this.SuspendLayout();
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
            this.combo_Matiere.Location = new System.Drawing.Point(985, 203);
            this.combo_Matiere.Name = "combo_Matiere";
            this.combo_Matiere.Size = new System.Drawing.Size(229, 36);
            this.combo_Matiere.TabIndex = 2;
            // 
            // Field_Heures
            // 
            this.Field_Heures.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_Heures.DefaultText = "";
            this.Field_Heures.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_Heures.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_Heures.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Heures.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_Heures.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Heures.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_Heures.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_Heures.Location = new System.Drawing.Point(590, 289);
            this.Field_Heures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Heures.Name = "Field_Heures";
            this.Field_Heures.PasswordChar = '\0';
            this.Field_Heures.PlaceholderText = "";
            this.Field_Heures.SelectedText = "";
            this.Field_Heures.Size = new System.Drawing.Size(229, 36);
            this.Field_Heures.TabIndex = 3;
            // 
            // picker_Date
            // 
            this.picker_Date.Checked = true;
            this.picker_Date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picker_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.picker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.picker_Date.Location = new System.Drawing.Point(985, 289);
            this.picker_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.picker_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.picker_Date.Name = "picker_Date";
            this.picker_Date.Size = new System.Drawing.Size(242, 36);
            this.picker_Date.TabIndex = 4;
            this.picker_Date.Value = new System.DateTime(2023, 1, 16, 21, 43, 11, 404);
            // 
            // Field_CNE
            // 
            this.Field_CNE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_CNE.DefaultText = "";
            this.Field_CNE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_CNE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_CNE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_CNE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_CNE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_CNE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_CNE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_CNE.Location = new System.Drawing.Point(218, 289);
            this.Field_CNE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_CNE.Name = "Field_CNE";
            this.Field_CNE.PasswordChar = '\0';
            this.Field_CNE.PlaceholderText = "";
            this.Field_CNE.SelectedText = "";
            this.Field_CNE.Size = new System.Drawing.Size(229, 36);
            this.Field_CNE.TabIndex = 5;
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
            this.Field_Nom.Location = new System.Drawing.Point(590, 203);
            this.Field_Nom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Nom.Name = "Field_Nom";
            this.Field_Nom.PasswordChar = '\0';
            this.Field_Nom.PlaceholderText = "";
            this.Field_Nom.SelectedText = "";
            this.Field_Nom.Size = new System.Drawing.Size(229, 36);
            this.Field_Nom.TabIndex = 6;
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
            this.Field_Search.Location = new System.Drawing.Point(1119, 474);
            this.Field_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Search.Name = "Field_Search";
            this.Field_Search.PasswordChar = '\0';
            this.Field_Search.PlaceholderText = "";
            this.Field_Search.SelectedText = "";
            this.Field_Search.Size = new System.Drawing.Size(199, 32);
            this.Field_Search.TabIndex = 39;
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
            this.button_Search.Location = new System.Drawing.Point(933, 461);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(180, 45);
            this.button_Search.TabIndex = 38;
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
            this.button_Supprimer.Location = new System.Drawing.Point(686, 461);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(180, 45);
            this.button_Supprimer.TabIndex = 37;
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
            this.button_Modifier.Location = new System.Drawing.Point(406, 461);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(180, 45);
            this.button_Modifier.TabIndex = 36;
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
            this.button_Add.Location = new System.Drawing.Point(130, 461);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 45);
            this.button_Add.TabIndex = 35;
            this.button_Add.Text = "Ajouter";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label4);
            this.panel_Title.Controls.Add(this.Picture_Home);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1615, 75);
            this.panel_Title.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Abscence";
            // 
            // Picture_Home
            // 
            this.Picture_Home.BackColor = System.Drawing.SystemColors.Control;
            this.Picture_Home.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.Picture_Home.IconColor = System.Drawing.Color.White;
            this.Picture_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Picture_Home.IconSize = 40;
            this.Picture_Home.Location = new System.Drawing.Point(21, 25);
            this.Picture_Home.Name = "Picture_Home";
            this.Picture_Home.Size = new System.Drawing.Size(40, 40);
            this.Picture_Home.TabIndex = 0;
            this.Picture_Home.TabStop = false;
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
            this.Field_Code.Location = new System.Drawing.Point(218, 203);
            this.Field_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Code.Name = "Field_Code";
            this.Field_Code.PasswordChar = '\0';
            this.Field_Code.PlaceholderText = "";
            this.Field_Code.SelectedText = "";
            this.Field_Code.Size = new System.Drawing.Size(229, 36);
            this.Field_Code.TabIndex = 45;
            // 
            // dataGrid_Abs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid_Abs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Abs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Abs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Abs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Abs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Abs.Location = new System.Drawing.Point(50, 590);
            this.dataGrid_Abs.Name = "dataGrid_Abs";
            this.dataGrid_Abs.RowHeadersVisible = false;
            this.dataGrid_Abs.RowHeadersWidth = 51;
            this.dataGrid_Abs.RowTemplate.Height = 24;
            this.dataGrid_Abs.Size = new System.Drawing.Size(1268, 239);
            this.dataGrid_Abs.TabIndex = 46;
            this.dataGrid_Abs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Abs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_Abs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Abs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_Abs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Abs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Abs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Abs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid_Abs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Abs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Abs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_Abs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Abs.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGrid_Abs.ThemeStyle.ReadOnly = false;
            this.dataGrid_Abs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Abs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Abs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Abs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_Abs.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid_Abs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Abs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Abscence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 862);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid_Abs);
            this.Controls.Add(this.Field_Code);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.Field_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.Field_Nom);
            this.Controls.Add(this.Field_CNE);
            this.Controls.Add(this.picker_Date);
            this.Controls.Add(this.Field_Heures);
            this.Controls.Add(this.combo_Matiere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Abscence";
            this.Text = "Abscence";
            this.Load += new System.EventHandler(this.Abscence_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Abs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox combo_Matiere;
        private Guna.UI2.WinForms.Guna2TextBox Field_Heures;
        private Guna.UI2.WinForms.Guna2DateTimePicker picker_Date;
        private Guna.UI2.WinForms.Guna2TextBox Field_CNE;
        private Guna.UI2.WinForms.Guna2TextBox Field_Nom;
        private Guna.UI2.WinForms.Guna2TextBox Field_Search;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2Button button_Supprimer;
        private Guna.UI2.WinForms.Guna2Button button_Modifier;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox Picture_Home;
        private Guna.UI2.WinForms.Guna2TextBox Field_Code;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_Abs;
    }
}