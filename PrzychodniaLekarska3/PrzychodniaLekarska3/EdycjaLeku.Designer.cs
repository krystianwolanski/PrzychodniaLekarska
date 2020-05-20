namespace PrzychodniaLekarska3
{
    partial class EdycjaLeku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdycjaLeku));
            this.nazwaLekuLabel = new System.Windows.Forms.Label();
            this.opisLekuTB = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.edytujLek = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nazwaLekuTextBox = new System.Windows.Forms.TextBox();
            this.lekI_TAPI_WYSWIETL_LEKITableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.LEKI_TAPI_WYSWIETL_LEKITableAdapter();
            this.przychodniaSet1 = new PrzychodniaLekarska3.PrzychodniaSet();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazwaLekuLabel
            // 
            this.nazwaLekuLabel.AutoSize = true;
            this.nazwaLekuLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaLekuLabel.Location = new System.Drawing.Point(56, 57);
            this.nazwaLekuLabel.Name = "nazwaLekuLabel";
            this.nazwaLekuLabel.Size = new System.Drawing.Size(93, 30);
            this.nazwaLekuLabel.TabIndex = 0;
            this.nazwaLekuLabel.Text = "Nazwa";
            // 
            // opisLekuTB
            // 
            this.opisLekuTB.AcceptsReturn = false;
            this.opisLekuTB.AcceptsTab = false;
            this.opisLekuTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.opisLekuTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.opisLekuTB.BackColor = System.Drawing.Color.White;
            this.opisLekuTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opisLekuTB.BackgroundImage")));
            this.opisLekuTB.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.opisLekuTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.opisLekuTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.opisLekuTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.opisLekuTB.BorderRadius = 1;
            this.opisLekuTB.BorderThickness = 2;
            this.opisLekuTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.opisLekuTB.DefaultFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisLekuTB.DefaultText = "";
            this.opisLekuTB.FillColor = System.Drawing.Color.White;
            this.opisLekuTB.HideSelection = true;
            this.opisLekuTB.IconLeft = null;
            this.opisLekuTB.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.opisLekuTB.IconPadding = 10;
            this.opisLekuTB.IconRight = null;
            this.opisLekuTB.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.opisLekuTB.Location = new System.Drawing.Point(59, 113);
            this.opisLekuTB.MaxLength = 32767;
            this.opisLekuTB.MinimumSize = new System.Drawing.Size(100, 35);
            this.opisLekuTB.Modified = false;
            this.opisLekuTB.Name = "opisLekuTB";
            this.opisLekuTB.PasswordChar = '\0';
            this.opisLekuTB.ReadOnly = false;
            this.opisLekuTB.SelectedText = "";
            this.opisLekuTB.SelectionLength = 0;
            this.opisLekuTB.SelectionStart = 0;
            this.opisLekuTB.ShortcutsEnabled = true;
            this.opisLekuTB.Size = new System.Drawing.Size(335, 147);
            this.opisLekuTB.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.opisLekuTB.TabIndex = 45;
            this.opisLekuTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.opisLekuTB.TextMarginLeft = 5;
            this.opisLekuTB.TextPlaceholder = "Opis";
            this.opisLekuTB.UseSystemPasswordChar = false;
            // 
            // edytujLek
            // 
            this.edytujLek.Active = false;
            this.edytujLek.Activecolor = System.Drawing.Color.Orange;
            this.edytujLek.BackColor = System.Drawing.Color.Orange;
            this.edytujLek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujLek.BorderRadius = 0;
            this.edytujLek.ButtonText = "Edytuj";
            this.edytujLek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujLek.DisabledColor = System.Drawing.Color.Gray;
            this.edytujLek.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujLek.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujLek.Iconimage = null;
            this.edytujLek.Iconimage_right = null;
            this.edytujLek.Iconimage_right_Selected = null;
            this.edytujLek.Iconimage_Selected = null;
            this.edytujLek.IconMarginLeft = 0;
            this.edytujLek.IconMarginRight = 0;
            this.edytujLek.IconRightVisible = true;
            this.edytujLek.IconRightZoom = 0D;
            this.edytujLek.IconVisible = true;
            this.edytujLek.IconZoom = 90D;
            this.edytujLek.IsTab = false;
            this.edytujLek.Location = new System.Drawing.Point(233, 304);
            this.edytujLek.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujLek.Name = "edytujLek";
            this.edytujLek.Normalcolor = System.Drawing.Color.Orange;
            this.edytujLek.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujLek.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujLek.selected = false;
            this.edytujLek.Size = new System.Drawing.Size(118, 50);
            this.edytujLek.TabIndex = 46;
            this.edytujLek.Text = "Edytuj";
            this.edytujLek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujLek.Textcolor = System.Drawing.Color.White;
            this.edytujLek.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujLek.Click += new System.EventHandler(this.edytujLek_Click);
            // 
            // nazwaLekuTextBox
            // 
            this.nazwaLekuTextBox.Location = new System.Drawing.Point(166, 68);
            this.nazwaLekuTextBox.Name = "nazwaLekuTextBox";
            this.nazwaLekuTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaLekuTextBox.TabIndex = 47;
            // 
            // lekI_TAPI_WYSWIETL_LEKITableAdapter1
            // 
            this.lekI_TAPI_WYSWIETL_LEKITableAdapter1.ClearBeforeFill = true;
            // 
            // przychodniaSet1
            // 
            this.przychodniaSet1.DataSetName = "PrzychodniaSet";
            this.przychodniaSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EdycjaLeku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 389);
            this.Controls.Add(this.nazwaLekuTextBox);
            this.Controls.Add(this.edytujLek);
            this.Controls.Add(this.opisLekuTB);
            this.Controls.Add(this.nazwaLekuLabel);
            this.Name = "EdycjaLeku";
            this.Text = "EdycjaLeku";
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazwaLekuLabel;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox opisLekuTB;
        private Bunifu.Framework.UI.BunifuFlatButton edytujLek;
        private System.Windows.Forms.TextBox nazwaLekuTextBox;
        private PrzychodniaSetTableAdapters.LEKI_TAPI_WYSWIETL_LEKITableAdapter lekI_TAPI_WYSWIETL_LEKITableAdapter1;
        private PrzychodniaSet przychodniaSet1;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}