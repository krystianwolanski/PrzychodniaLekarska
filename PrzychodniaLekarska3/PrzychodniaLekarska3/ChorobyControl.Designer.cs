namespace PrzychodniaLekarska3
{
    partial class ChorobyControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ChorobyLabel = new System.Windows.Forms.Label();
            this.TypChorobyTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NazwaChorobyTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dodajChorobe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.datagridChoroby = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.usunChorobe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edytujChorobe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.iDCHOROBYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHOROBYTAPIWYSWIETLCHOROBYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet = new PrzychodniaLekarska3.PrzychodniaSet();
            this.cHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.CHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridChoroby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOROBYTAPIWYSWIETLCHOROBYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ChorobyLabel
            // 
            this.ChorobyLabel.AutoSize = true;
            this.ChorobyLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChorobyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ChorobyLabel.Location = new System.Drawing.Point(51, 62);
            this.ChorobyLabel.Name = "ChorobyLabel";
            this.ChorobyLabel.Size = new System.Drawing.Size(139, 36);
            this.ChorobyLabel.TabIndex = 28;
            this.ChorobyLabel.Text = "Choroby";
            // 
            // TypChorobyTB
            // 
            this.TypChorobyTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TypChorobyTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TypChorobyTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TypChorobyTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypChorobyTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypChorobyTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TypChorobyTB.HintForeColor = System.Drawing.Color.Empty;
            this.TypChorobyTB.HintText = "Typ";
            this.TypChorobyTB.isPassword = false;
            this.TypChorobyTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.TypChorobyTB.LineIdleColor = System.Drawing.Color.Gray;
            this.TypChorobyTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.TypChorobyTB.LineThickness = 4;
            this.TypChorobyTB.Location = new System.Drawing.Point(57, 211);
            this.TypChorobyTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TypChorobyTB.MaxLength = 32767;
            this.TypChorobyTB.Name = "TypChorobyTB";
            this.TypChorobyTB.Size = new System.Drawing.Size(335, 43);
            this.TypChorobyTB.TabIndex = 29;
            this.TypChorobyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NazwaChorobyTB
            // 
            this.NazwaChorobyTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NazwaChorobyTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NazwaChorobyTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NazwaChorobyTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NazwaChorobyTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaChorobyTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.NazwaChorobyTB.HintForeColor = System.Drawing.Color.Empty;
            this.NazwaChorobyTB.HintText = "Nazwa";
            this.NazwaChorobyTB.isPassword = false;
            this.NazwaChorobyTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.NazwaChorobyTB.LineIdleColor = System.Drawing.Color.Gray;
            this.NazwaChorobyTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.NazwaChorobyTB.LineThickness = 4;
            this.NazwaChorobyTB.Location = new System.Drawing.Point(57, 147);
            this.NazwaChorobyTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NazwaChorobyTB.MaxLength = 32767;
            this.NazwaChorobyTB.Name = "NazwaChorobyTB";
            this.NazwaChorobyTB.Size = new System.Drawing.Size(335, 43);
            this.NazwaChorobyTB.TabIndex = 30;
            this.NazwaChorobyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dodajChorobe
            // 
            this.dodajChorobe.Active = false;
            this.dodajChorobe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajChorobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajChorobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodajChorobe.BorderRadius = 0;
            this.dodajChorobe.ButtonText = "Dodaj";
            this.dodajChorobe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajChorobe.DisabledColor = System.Drawing.Color.Gray;
            this.dodajChorobe.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dodajChorobe.Iconcolor = System.Drawing.Color.Transparent;
            this.dodajChorobe.Iconimage = null;
            this.dodajChorobe.Iconimage_right = null;
            this.dodajChorobe.Iconimage_right_Selected = null;
            this.dodajChorobe.Iconimage_Selected = null;
            this.dodajChorobe.IconMarginLeft = 0;
            this.dodajChorobe.IconMarginRight = 0;
            this.dodajChorobe.IconRightVisible = true;
            this.dodajChorobe.IconRightZoom = 0D;
            this.dodajChorobe.IconVisible = true;
            this.dodajChorobe.IconZoom = 90D;
            this.dodajChorobe.IsTab = false;
            this.dodajChorobe.Location = new System.Drawing.Point(57, 300);
            this.dodajChorobe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dodajChorobe.Name = "dodajChorobe";
            this.dodajChorobe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajChorobe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dodajChorobe.OnHoverTextColor = System.Drawing.Color.White;
            this.dodajChorobe.selected = false;
            this.dodajChorobe.Size = new System.Drawing.Size(118, 50);
            this.dodajChorobe.TabIndex = 31;
            this.dodajChorobe.Text = "Dodaj";
            this.dodajChorobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dodajChorobe.Textcolor = System.Drawing.Color.White;
            this.dodajChorobe.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajChorobe.Click += new System.EventHandler(this.dodajChorobe_Click);
            // 
            // datagridChoroby
            // 
            this.datagridChoroby.AllowCustomTheming = true;
            this.datagridChoroby.AllowUserToAddRows = false;
            this.datagridChoroby.AllowUserToDeleteRows = false;
            this.datagridChoroby.AllowUserToResizeColumns = false;
            this.datagridChoroby.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.datagridChoroby.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.datagridChoroby.AutoGenerateColumns = false;
            this.datagridChoroby.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridChoroby.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridChoroby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridChoroby.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridChoroby.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridChoroby.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datagridChoroby.ColumnHeadersHeight = 40;
            this.datagridChoroby.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCHOROBYDataGridViewTextBoxColumn,
            this.nAZWADataGridViewTextBoxColumn,
            this.tYPDataGridViewTextBoxColumn});
            this.datagridChoroby.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridChoroby.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridChoroby.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridChoroby.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridChoroby.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridChoroby.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datagridChoroby.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridChoroby.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridChoroby.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.datagridChoroby.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridChoroby.CurrentTheme.Name = null;
            this.datagridChoroby.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridChoroby.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.datagridChoroby.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridChoroby.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridChoroby.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridChoroby.DataSource = this.cHOROBYTAPIWYSWIETLCHOROBYBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridChoroby.DefaultCellStyle = dataGridViewCellStyle9;
            this.datagridChoroby.EnableHeadersVisualStyles = false;
            this.datagridChoroby.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.datagridChoroby.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datagridChoroby.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridChoroby.HeaderForeColor = System.Drawing.Color.White;
            this.datagridChoroby.Location = new System.Drawing.Point(446, 0);
            this.datagridChoroby.Name = "datagridChoroby";
            this.datagridChoroby.ReadOnly = true;
            this.datagridChoroby.RowHeadersVisible = false;
            this.datagridChoroby.RowTemplate.Height = 40;
            this.datagridChoroby.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridChoroby.Size = new System.Drawing.Size(378, 463);
            this.datagridChoroby.TabIndex = 32;
            this.datagridChoroby.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // usunChorobe
            // 
            this.usunChorobe.Active = false;
            this.usunChorobe.Activecolor = System.Drawing.Color.DarkRed;
            this.usunChorobe.BackColor = System.Drawing.Color.DarkRed;
            this.usunChorobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usunChorobe.BorderRadius = 0;
            this.usunChorobe.ButtonText = "Usuń";
            this.usunChorobe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usunChorobe.DisabledColor = System.Drawing.Color.Gray;
            this.usunChorobe.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.usunChorobe.Iconcolor = System.Drawing.Color.Transparent;
            this.usunChorobe.Iconimage = null;
            this.usunChorobe.Iconimage_right = null;
            this.usunChorobe.Iconimage_right_Selected = null;
            this.usunChorobe.Iconimage_Selected = null;
            this.usunChorobe.IconMarginLeft = 0;
            this.usunChorobe.IconMarginRight = 0;
            this.usunChorobe.IconRightVisible = true;
            this.usunChorobe.IconRightZoom = 0D;
            this.usunChorobe.IconVisible = true;
            this.usunChorobe.IconZoom = 90D;
            this.usunChorobe.IsTab = false;
            this.usunChorobe.Location = new System.Drawing.Point(650, 491);
            this.usunChorobe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usunChorobe.Name = "usunChorobe";
            this.usunChorobe.Normalcolor = System.Drawing.Color.DarkRed;
            this.usunChorobe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usunChorobe.OnHoverTextColor = System.Drawing.Color.White;
            this.usunChorobe.selected = false;
            this.usunChorobe.Size = new System.Drawing.Size(118, 50);
            this.usunChorobe.TabIndex = 33;
            this.usunChorobe.Text = "Usuń";
            this.usunChorobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usunChorobe.Textcolor = System.Drawing.Color.White;
            this.usunChorobe.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunChorobe.Click += new System.EventHandler(this.usunChorobe_Click);
            // 
            // edytujChorobe
            // 
            this.edytujChorobe.Active = false;
            this.edytujChorobe.Activecolor = System.Drawing.Color.Orange;
            this.edytujChorobe.BackColor = System.Drawing.Color.Orange;
            this.edytujChorobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujChorobe.BorderRadius = 0;
            this.edytujChorobe.ButtonText = "Edytuj";
            this.edytujChorobe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujChorobe.DisabledColor = System.Drawing.Color.Gray;
            this.edytujChorobe.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujChorobe.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujChorobe.Iconimage = null;
            this.edytujChorobe.Iconimage_right = null;
            this.edytujChorobe.Iconimage_right_Selected = null;
            this.edytujChorobe.Iconimage_Selected = null;
            this.edytujChorobe.IconMarginLeft = 0;
            this.edytujChorobe.IconMarginRight = 0;
            this.edytujChorobe.IconRightVisible = true;
            this.edytujChorobe.IconRightZoom = 0D;
            this.edytujChorobe.IconVisible = true;
            this.edytujChorobe.IconZoom = 90D;
            this.edytujChorobe.IsTab = false;
            this.edytujChorobe.Location = new System.Drawing.Point(505, 491);
            this.edytujChorobe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujChorobe.Name = "edytujChorobe";
            this.edytujChorobe.Normalcolor = System.Drawing.Color.Orange;
            this.edytujChorobe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujChorobe.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujChorobe.selected = false;
            this.edytujChorobe.Size = new System.Drawing.Size(118, 50);
            this.edytujChorobe.TabIndex = 34;
            this.edytujChorobe.Text = "Edytuj";
            this.edytujChorobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujChorobe.Textcolor = System.Drawing.Color.White;
            this.edytujChorobe.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujChorobe.Click += new System.EventHandler(this.edytujChorobe_Click);
            // 
            // iDCHOROBYDataGridViewTextBoxColumn
            // 
            this.iDCHOROBYDataGridViewTextBoxColumn.DataPropertyName = "ID_CHOROBY";
            this.iDCHOROBYDataGridViewTextBoxColumn.HeaderText = "ID_CHOROBY";
            this.iDCHOROBYDataGridViewTextBoxColumn.Name = "iDCHOROBYDataGridViewTextBoxColumn";
            this.iDCHOROBYDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCHOROBYDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.HeaderText = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.Name = "nAZWADataGridViewTextBoxColumn";
            this.nAZWADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tYPDataGridViewTextBoxColumn
            // 
            this.tYPDataGridViewTextBoxColumn.DataPropertyName = "TYP";
            this.tYPDataGridViewTextBoxColumn.HeaderText = "TYP";
            this.tYPDataGridViewTextBoxColumn.Name = "tYPDataGridViewTextBoxColumn";
            this.tYPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cHOROBYTAPIWYSWIETLCHOROBYBindingSource
            // 
            this.cHOROBYTAPIWYSWIETLCHOROBYBindingSource.DataMember = "CHOROBY_TAPI_WYSWIETL_CHOROBY";
            this.cHOROBYTAPIWYSWIETLCHOROBYBindingSource.DataSource = this.przychodniaSet;
            // 
            // przychodniaSet
            // 
            this.przychodniaSet.DataSetName = "PrzychodniaSet";
            this.przychodniaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter
            // 
            this.cHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter.ClearBeforeFill = true;
            // 
            // ChorobyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usunChorobe);
            this.Controls.Add(this.edytujChorobe);
            this.Controls.Add(this.datagridChoroby);
            this.Controls.Add(this.dodajChorobe);
            this.Controls.Add(this.TypChorobyTB);
            this.Controls.Add(this.NazwaChorobyTB);
            this.Controls.Add(this.ChorobyLabel);
            this.Name = "ChorobyControl";
            this.Size = new System.Drawing.Size(824, 575);
            ((System.ComponentModel.ISupportInitialize)(this.datagridChoroby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOROBYTAPIWYSWIETLCHOROBYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChorobyLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TypChorobyTB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NazwaChorobyTB;
        private Bunifu.Framework.UI.BunifuFlatButton dodajChorobe;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridChoroby;
        private Bunifu.Framework.UI.BunifuFlatButton usunChorobe;
        private Bunifu.Framework.UI.BunifuFlatButton edytujChorobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCHOROBYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cHOROBYTAPIWYSWIETLCHOROBYBindingSource;
        private PrzychodniaSet przychodniaSet;
        private PrzychodniaSetTableAdapters.CHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter cHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}
