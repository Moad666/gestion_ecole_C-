namespace gestionEcole
{
    partial class Bulletin
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
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Picture_Home = new FontAwesome.Sharp.IconPictureBox();
            this.dataGrid_Bulletin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Field_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.combo_CNE = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Periode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picker_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.button_Export = new Guna.UI2.WinForms.Guna2Button();
            this.Field_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.button_Supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.button_Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Bulletin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label4);
            this.panel_Title.Controls.Add(this.Picture_Home);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1344, 75);
            this.panel_Title.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bulletin";
            // 
            // Picture_Home
            // 
            this.Picture_Home.BackColor = System.Drawing.SystemColors.Control;
            this.Picture_Home.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.Picture_Home.IconColor = System.Drawing.Color.White;
            this.Picture_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Picture_Home.IconSize = 40;
            this.Picture_Home.Location = new System.Drawing.Point(21, 25);
            this.Picture_Home.Name = "Picture_Home";
            this.Picture_Home.Size = new System.Drawing.Size(40, 40);
            this.Picture_Home.TabIndex = 0;
            this.Picture_Home.TabStop = false;
            // 
            // dataGrid_Bulletin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid_Bulletin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Bulletin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Bulletin.ColumnHeadersHeight = 18;
            this.dataGrid_Bulletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Bulletin.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Bulletin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Bulletin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Bulletin.Location = new System.Drawing.Point(21, 545);
            this.dataGrid_Bulletin.Name = "dataGrid_Bulletin";
            this.dataGrid_Bulletin.RowHeadersVisible = false;
            this.dataGrid_Bulletin.RowHeadersWidth = 51;
            this.dataGrid_Bulletin.RowTemplate.Height = 24;
            this.dataGrid_Bulletin.Size = new System.Drawing.Size(1276, 270);
            this.dataGrid_Bulletin.TabIndex = 45;
            this.dataGrid_Bulletin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Bulletin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_Bulletin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Bulletin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_Bulletin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Bulletin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Bulletin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Bulletin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid_Bulletin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Bulletin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Bulletin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_Bulletin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Bulletin.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGrid_Bulletin.ThemeStyle.ReadOnly = false;
            this.dataGrid_Bulletin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Bulletin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Bulletin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Bulletin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_Bulletin.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid_Bulletin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_Bulletin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Field_ID
            // 
            this.Field_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Field_ID.DefaultText = "";
            this.Field_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Field_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Field_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Field_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Field_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Field_ID.Location = new System.Drawing.Point(49, 218);
            this.Field_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_ID.Name = "Field_ID";
            this.Field_ID.PasswordChar = '\0';
            this.Field_ID.PlaceholderText = "";
            this.Field_ID.SelectedText = "";
            this.Field_ID.Size = new System.Drawing.Size(229, 31);
            this.Field_ID.TabIndex = 46;
            // 
            // combo_CNE
            // 
            this.combo_CNE.BackColor = System.Drawing.Color.Transparent;
            this.combo_CNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_CNE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_CNE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_CNE.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_CNE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_CNE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_CNE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_CNE.ItemHeight = 30;
            this.combo_CNE.Location = new System.Drawing.Point(367, 213);
            this.combo_CNE.Name = "combo_CNE";
            this.combo_CNE.Size = new System.Drawing.Size(229, 36);
            this.combo_CNE.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "CNE";
            // 
            // combo_Periode
            // 
            this.combo_Periode.BackColor = System.Drawing.Color.Transparent;
            this.combo_Periode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_Periode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_Periode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Periode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Periode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_Periode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_Periode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_Periode.ItemHeight = 30;
            this.combo_Periode.Location = new System.Drawing.Point(671, 213);
            this.combo_Periode.Name = "combo_Periode";
            this.combo_Periode.Size = new System.Drawing.Size(229, 36);
            this.combo_Periode.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(751, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Periode";
            // 
            // picker_Date
            // 
            this.picker_Date.Checked = true;
            this.picker_Date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picker_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.picker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.picker_Date.Location = new System.Drawing.Point(971, 213);
            this.picker_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.picker_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.picker_Date.Name = "picker_Date";
            this.picker_Date.Size = new System.Drawing.Size(305, 36);
            this.picker_Date.TabIndex = 51;
            this.picker_Date.Value = new System.DateTime(2023, 1, 16, 20, 32, 56, 673);
            // 
            // button_Export
            // 
            this.button_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Export.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Export.ForeColor = System.Drawing.Color.White;
            this.button_Export.Location = new System.Drawing.Point(720, 415);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(180, 45);
            this.button_Export.TabIndex = 57;
            this.button_Export.Text = "Export";
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
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
            this.Field_Search.Location = new System.Drawing.Point(1139, 430);
            this.Field_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Field_Search.Name = "Field_Search";
            this.Field_Search.PasswordChar = '\0';
            this.Field_Search.PlaceholderText = "";
            this.Field_Search.SelectedText = "";
            this.Field_Search.Size = new System.Drawing.Size(193, 30);
            this.Field_Search.TabIndex = 56;
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
            this.button_Search.Location = new System.Drawing.Point(953, 415);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(180, 45);
            this.button_Search.TabIndex = 55;
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
            this.button_Supprimer.Location = new System.Drawing.Point(496, 415);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(180, 45);
            this.button_Supprimer.TabIndex = 54;
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
            this.button_Modifier.Location = new System.Drawing.Point(260, 415);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(180, 45);
            this.button_Modifier.TabIndex = 53;
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
            this.button_Add.Location = new System.Drawing.Point(21, 415);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 45);
            this.button_Add.TabIndex = 52;
            this.button_Add.Text = "Ajouter";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Bulletin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 853);
            this.ControlBox = false;
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.Field_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.picker_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_Periode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_CNE);
            this.Controls.Add(this.Field_ID);
            this.Controls.Add(this.dataGrid_Bulletin);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bulletin";
            this.Text = "Bulletin";
            this.Load += new System.EventHandler(this.Bulletin_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Bulletin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox Picture_Home;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_Bulletin;
        private Guna.UI2.WinForms.Guna2TextBox Field_ID;
        private Guna.UI2.WinForms.Guna2ComboBox combo_CNE;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox combo_Periode;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker picker_Date;
        private Guna.UI2.WinForms.Guna2Button button_Export;
        private Guna.UI2.WinForms.Guna2TextBox Field_Search;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2Button button_Supprimer;
        private Guna.UI2.WinForms.Guna2Button button_Modifier;
        private Guna.UI2.WinForms.Guna2Button button_Add;
    }
}