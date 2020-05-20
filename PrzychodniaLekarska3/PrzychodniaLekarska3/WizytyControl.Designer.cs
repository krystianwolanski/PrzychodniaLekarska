namespace PrzychodniaLekarska3
{
    partial class WizytyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizytyControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dodajWizyte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.wIZYTYTAPIWYSWIETLWIZYTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet = new PrzychodniaLekarska3.PrzychodniaSet();
            this.wIZYTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wIZYTYTableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.WIZYTYTableAdapter();
            this.wIZYTYRECEPTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wIZYTY_RECEPTYTableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.WIZYTY_RECEPTYTableAdapter();
            this.wIZYTY_TAPI_WYSWIETL_WIZYTYTableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.WIZYTY_TAPI_WYSWIETL_WIZYTYTableAdapter();
            this.iDWIZYTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAREJESTRACJIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAWIZYTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imięLekarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoLekarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imięPacjentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoPacjentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaChorobyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRECEPTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTYTAPIWYSWIETLWIZYTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTYRECEPTYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajWizyte
            // 
            this.dodajWizyte.Active = false;
            this.dodajWizyte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajWizyte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajWizyte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodajWizyte.BorderRadius = 0;
            this.dodajWizyte.ButtonText = "  Dodaj wizytę";
            this.dodajWizyte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajWizyte.DisabledColor = System.Drawing.Color.Gray;
            this.dodajWizyte.Iconcolor = System.Drawing.Color.Transparent;
            this.dodajWizyte.Iconimage = ((System.Drawing.Image)(resources.GetObject("dodajWizyte.Iconimage")));
            this.dodajWizyte.Iconimage_right = null;
            this.dodajWizyte.Iconimage_right_Selected = null;
            this.dodajWizyte.Iconimage_Selected = null;
            this.dodajWizyte.IconMarginLeft = 0;
            this.dodajWizyte.IconMarginRight = 0;
            this.dodajWizyte.IconRightVisible = true;
            this.dodajWizyte.IconRightZoom = 0D;
            this.dodajWizyte.IconVisible = true;
            this.dodajWizyte.IconZoom = 40D;
            this.dodajWizyte.IsTab = false;
            this.dodajWizyte.Location = new System.Drawing.Point(665, 31);
            this.dodajWizyte.Name = "dodajWizyte";
            this.dodajWizyte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dodajWizyte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dodajWizyte.OnHoverTextColor = System.Drawing.Color.White;
            this.dodajWizyte.selected = false;
            this.dodajWizyte.Size = new System.Drawing.Size(133, 35);
            this.dodajWizyte.TabIndex = 4;
            this.dodajWizyte.Text = "  Dodaj wizytę";
            this.dodajWizyte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajWizyte.Textcolor = System.Drawing.Color.White;
            this.dodajWizyte.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajWizyte.Click += new System.EventHandler(this.dodajWizyte_Click);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = true;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoGenerateColumns = false;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 45;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDWIZYTYDataGridViewTextBoxColumn,
            this.dATAREJESTRACJIDataGridViewTextBoxColumn,
            this.dATAWIZYTYDataGridViewTextBoxColumn,
            this.imięLekarzaDataGridViewTextBoxColumn,
            this.nazwiskoLekarzaDataGridViewTextBoxColumn,
            this.imięPacjentaDataGridViewTextBoxColumn,
            this.nazwiskoPacjentaDataGridViewTextBoxColumn,
            this.nazwaChorobyDataGridViewTextBoxColumn,
            this.iDRECEPTYDataGridViewTextBoxColumn});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.DataSource = this.wIZYTYTAPIWYSWIETLWIZYTYBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(0, 113);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(824, 462);
            this.bunifuDataGridView1.TabIndex = 3;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // wIZYTYTAPIWYSWIETLWIZYTYBindingSource
            // 
            this.wIZYTYTAPIWYSWIETLWIZYTYBindingSource.DataMember = "WIZYTY_TAPI_WYSWIETL_WIZYTY";
            this.wIZYTYTAPIWYSWIETLWIZYTYBindingSource.DataSource = this.przychodniaSet;
            // 
            // przychodniaSet
            // 
            this.przychodniaSet.DataSetName = "PrzychodniaSet";
            this.przychodniaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wIZYTYBindingSource
            // 
            this.wIZYTYBindingSource.DataMember = "WIZYTY";
            this.wIZYTYBindingSource.DataSource = this.przychodniaSet;
            // 
            // wIZYTYTableAdapter
            // 
            this.wIZYTYTableAdapter.ClearBeforeFill = true;
            // 
            // wIZYTYRECEPTYBindingSource
            // 
            this.wIZYTYRECEPTYBindingSource.DataMember = "WIZYTY_RECEPTY";
            this.wIZYTYRECEPTYBindingSource.DataSource = this.przychodniaSet;
            // 
            // wIZYTY_RECEPTYTableAdapter
            // 
            this.wIZYTY_RECEPTYTableAdapter.ClearBeforeFill = true;
            // 
            // wIZYTY_TAPI_WYSWIETL_WIZYTYTableAdapter
            // 
            this.wIZYTY_TAPI_WYSWIETL_WIZYTYTableAdapter.ClearBeforeFill = true;
            // 
            // iDWIZYTYDataGridViewTextBoxColumn
            // 
            this.iDWIZYTYDataGridViewTextBoxColumn.DataPropertyName = "ID_WIZYTY";
            this.iDWIZYTYDataGridViewTextBoxColumn.HeaderText = "ID_WIZYTY";
            this.iDWIZYTYDataGridViewTextBoxColumn.Name = "iDWIZYTYDataGridViewTextBoxColumn";
            this.iDWIZYTYDataGridViewTextBoxColumn.Visible = false;
            // 
            // dATAREJESTRACJIDataGridViewTextBoxColumn
            // 
            this.dATAREJESTRACJIDataGridViewTextBoxColumn.DataPropertyName = "DATA_REJESTRACJI";
            this.dATAREJESTRACJIDataGridViewTextBoxColumn.HeaderText = "DATA_REJESTRACJI";
            this.dATAREJESTRACJIDataGridViewTextBoxColumn.Name = "dATAREJESTRACJIDataGridViewTextBoxColumn";
            // 
            // dATAWIZYTYDataGridViewTextBoxColumn
            // 
            this.dATAWIZYTYDataGridViewTextBoxColumn.DataPropertyName = "DATA_WIZYTY";
            this.dATAWIZYTYDataGridViewTextBoxColumn.HeaderText = "DATA_WIZYTY";
            this.dATAWIZYTYDataGridViewTextBoxColumn.Name = "dATAWIZYTYDataGridViewTextBoxColumn";
            // 
            // imięLekarzaDataGridViewTextBoxColumn
            // 
            this.imięLekarzaDataGridViewTextBoxColumn.DataPropertyName = "Imię Lekarza";
            this.imięLekarzaDataGridViewTextBoxColumn.HeaderText = "Imię Lekarza";
            this.imięLekarzaDataGridViewTextBoxColumn.Name = "imięLekarzaDataGridViewTextBoxColumn";
            // 
            // nazwiskoLekarzaDataGridViewTextBoxColumn
            // 
            this.nazwiskoLekarzaDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko Lekarza";
            this.nazwiskoLekarzaDataGridViewTextBoxColumn.HeaderText = "Nazwisko Lekarza";
            this.nazwiskoLekarzaDataGridViewTextBoxColumn.Name = "nazwiskoLekarzaDataGridViewTextBoxColumn";
            // 
            // imięPacjentaDataGridViewTextBoxColumn
            // 
            this.imięPacjentaDataGridViewTextBoxColumn.DataPropertyName = "Imię Pacjenta";
            this.imięPacjentaDataGridViewTextBoxColumn.HeaderText = "Imię Pacjenta";
            this.imięPacjentaDataGridViewTextBoxColumn.Name = "imięPacjentaDataGridViewTextBoxColumn";
            // 
            // nazwiskoPacjentaDataGridViewTextBoxColumn
            // 
            this.nazwiskoPacjentaDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko Pacjenta";
            this.nazwiskoPacjentaDataGridViewTextBoxColumn.HeaderText = "Nazwisko Pacjenta";
            this.nazwiskoPacjentaDataGridViewTextBoxColumn.Name = "nazwiskoPacjentaDataGridViewTextBoxColumn";
            // 
            // nazwaChorobyDataGridViewTextBoxColumn
            // 
            this.nazwaChorobyDataGridViewTextBoxColumn.DataPropertyName = "Nazwa choroby";
            this.nazwaChorobyDataGridViewTextBoxColumn.HeaderText = "Nazwa choroby";
            this.nazwaChorobyDataGridViewTextBoxColumn.Name = "nazwaChorobyDataGridViewTextBoxColumn";
            // 
            // iDRECEPTYDataGridViewTextBoxColumn
            // 
            this.iDRECEPTYDataGridViewTextBoxColumn.DataPropertyName = "ID_RECEPTY";
            this.iDRECEPTYDataGridViewTextBoxColumn.HeaderText = "ID_RECEPTY";
            this.iDRECEPTYDataGridViewTextBoxColumn.Name = "iDRECEPTYDataGridViewTextBoxColumn";
            // 
            // WizytyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dodajWizyte);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Name = "WizytyControl";
            this.Size = new System.Drawing.Size(824, 575);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTYTAPIWYSWIETLWIZYTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTYRECEPTYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton dodajWizyte;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private PrzychodniaSet przychodniaSet;
        private System.Windows.Forms.BindingSource wIZYTYBindingSource;
        private PrzychodniaSetTableAdapters.WIZYTYTableAdapter wIZYTYTableAdapter;
        private System.Windows.Forms.BindingSource wIZYTYRECEPTYBindingSource;
        private PrzychodniaSetTableAdapters.WIZYTY_RECEPTYTableAdapter wIZYTY_RECEPTYTableAdapter;
        private System.Windows.Forms.BindingSource wIZYTYTAPIWYSWIETLWIZYTYBindingSource;
        private PrzychodniaSetTableAdapters.WIZYTY_TAPI_WYSWIETL_WIZYTYTableAdapter wIZYTY_TAPI_WYSWIETL_WIZYTYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWIZYTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAREJESTRACJIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAWIZYTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięLekarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoLekarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięPacjentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoPacjentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaChorobyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRECEPTYDataGridViewTextBoxColumn;
    }
}
