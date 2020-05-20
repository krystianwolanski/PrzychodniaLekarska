namespace PrzychodniaLekarska3
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.MedicineClinicLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.kartaBadanButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BadaniaButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChorobyButtton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LekiButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.WizytyButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PacjenciButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LekarzeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.wYSWIETLLEKARZYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wYSWIETLLEKARZYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.MedicineClinicLabel);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.kartaBadanButton);
            this.panel1.Controls.Add(this.BadaniaButton);
            this.panel1.Controls.Add(this.ChorobyButtton);
            this.panel1.Controls.Add(this.LekiButton);
            this.panel1.Controls.Add(this.WizytyButton);
            this.panel1.Controls.Add(this.PacjenciButton);
            this.panel1.Controls.Add(this.LekarzeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 618);
            this.panel1.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 164);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 47);
            this.SidePanel.TabIndex = 9;
            // 
            // MedicineClinicLabel
            // 
            this.MedicineClinicLabel.AutoEllipsis = false;
            this.MedicineClinicLabel.CursorType = null;
            this.MedicineClinicLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.MedicineClinicLabel.ForeColor = System.Drawing.Color.White;
            this.MedicineClinicLabel.Location = new System.Drawing.Point(28, 87);
            this.MedicineClinicLabel.Name = "MedicineClinicLabel";
            this.MedicineClinicLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MedicineClinicLabel.Size = new System.Drawing.Size(117, 22);
            this.MedicineClinicLabel.TabIndex = 8;
            this.MedicineClinicLabel.Text = "Medicine Clinic";
            this.MedicineClinicLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MedicineClinicLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 58F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(176, 96);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "M";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // kartaBadanButton
            // 
            this.kartaBadanButton.Active = false;
            this.kartaBadanButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.kartaBadanButton.BackColor = System.Drawing.Color.Transparent;
            this.kartaBadanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kartaBadanButton.BorderRadius = 0;
            this.kartaBadanButton.ButtonText = "Karta Badań";
            this.kartaBadanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kartaBadanButton.DisabledColor = System.Drawing.Color.Gray;
            this.kartaBadanButton.Iconcolor = System.Drawing.Color.Transparent;
            this.kartaBadanButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("kartaBadanButton.Iconimage")));
            this.kartaBadanButton.Iconimage_right = null;
            this.kartaBadanButton.Iconimage_right_Selected = null;
            this.kartaBadanButton.Iconimage_Selected = null;
            this.kartaBadanButton.IconMarginLeft = 33;
            this.kartaBadanButton.IconMarginRight = 0;
            this.kartaBadanButton.IconRightVisible = true;
            this.kartaBadanButton.IconRightZoom = 0D;
            this.kartaBadanButton.IconVisible = true;
            this.kartaBadanButton.IconZoom = 63D;
            this.kartaBadanButton.IsTab = false;
            this.kartaBadanButton.Location = new System.Drawing.Point(-3, 451);
            this.kartaBadanButton.Margin = new System.Windows.Forms.Padding(0);
            this.kartaBadanButton.Name = "kartaBadanButton";
            this.kartaBadanButton.Normalcolor = System.Drawing.Color.Transparent;
            this.kartaBadanButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.kartaBadanButton.OnHoverTextColor = System.Drawing.Color.White;
            this.kartaBadanButton.selected = false;
            this.kartaBadanButton.Size = new System.Drawing.Size(176, 48);
            this.kartaBadanButton.TabIndex = 3;
            this.kartaBadanButton.Text = "Karta Badań";
            this.kartaBadanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kartaBadanButton.Textcolor = System.Drawing.Color.White;
            this.kartaBadanButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kartaBadanButton.Click += new System.EventHandler(this.KartaBadanButton_Click);
            // 
            // BadaniaButton
            // 
            this.BadaniaButton.Active = false;
            this.BadaniaButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.BadaniaButton.BackColor = System.Drawing.Color.Transparent;
            this.BadaniaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BadaniaButton.BorderRadius = 0;
            this.BadaniaButton.ButtonText = "  Badania";
            this.BadaniaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BadaniaButton.DisabledColor = System.Drawing.Color.Gray;
            this.BadaniaButton.Iconcolor = System.Drawing.Color.Transparent;
            this.BadaniaButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("BadaniaButton.Iconimage")));
            this.BadaniaButton.Iconimage_right = null;
            this.BadaniaButton.Iconimage_right_Selected = null;
            this.BadaniaButton.Iconimage_Selected = null;
            this.BadaniaButton.IconMarginLeft = 33;
            this.BadaniaButton.IconMarginRight = 0;
            this.BadaniaButton.IconRightVisible = true;
            this.BadaniaButton.IconRightZoom = 0D;
            this.BadaniaButton.IconVisible = true;
            this.BadaniaButton.IconZoom = 68D;
            this.BadaniaButton.IsTab = false;
            this.BadaniaButton.Location = new System.Drawing.Point(0, 403);
            this.BadaniaButton.Margin = new System.Windows.Forms.Padding(0);
            this.BadaniaButton.Name = "BadaniaButton";
            this.BadaniaButton.Normalcolor = System.Drawing.Color.Transparent;
            this.BadaniaButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.BadaniaButton.OnHoverTextColor = System.Drawing.Color.White;
            this.BadaniaButton.selected = false;
            this.BadaniaButton.Size = new System.Drawing.Size(176, 48);
            this.BadaniaButton.TabIndex = 3;
            this.BadaniaButton.Text = "  Badania";
            this.BadaniaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BadaniaButton.Textcolor = System.Drawing.Color.White;
            this.BadaniaButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BadaniaButton.Click += new System.EventHandler(this.BadaniaButton_Click);
            // 
            // ChorobyButtton
            // 
            this.ChorobyButtton.Active = false;
            this.ChorobyButtton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.ChorobyButtton.BackColor = System.Drawing.Color.Transparent;
            this.ChorobyButtton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChorobyButtton.BorderRadius = 0;
            this.ChorobyButtton.ButtonText = "   Choroby";
            this.ChorobyButtton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChorobyButtton.DisabledColor = System.Drawing.Color.Gray;
            this.ChorobyButtton.Iconcolor = System.Drawing.Color.Transparent;
            this.ChorobyButtton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ChorobyButtton.Iconimage")));
            this.ChorobyButtton.Iconimage_right = null;
            this.ChorobyButtton.Iconimage_right_Selected = null;
            this.ChorobyButtton.Iconimage_Selected = null;
            this.ChorobyButtton.IconMarginLeft = 33;
            this.ChorobyButtton.IconMarginRight = 0;
            this.ChorobyButtton.IconRightVisible = true;
            this.ChorobyButtton.IconRightZoom = 0D;
            this.ChorobyButtton.IconVisible = true;
            this.ChorobyButtton.IconZoom = 65D;
            this.ChorobyButtton.IsTab = false;
            this.ChorobyButtton.Location = new System.Drawing.Point(0, 355);
            this.ChorobyButtton.Margin = new System.Windows.Forms.Padding(0);
            this.ChorobyButtton.Name = "ChorobyButtton";
            this.ChorobyButtton.Normalcolor = System.Drawing.Color.Transparent;
            this.ChorobyButtton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.ChorobyButtton.OnHoverTextColor = System.Drawing.Color.White;
            this.ChorobyButtton.selected = false;
            this.ChorobyButtton.Size = new System.Drawing.Size(176, 48);
            this.ChorobyButtton.TabIndex = 3;
            this.ChorobyButtton.Text = "   Choroby";
            this.ChorobyButtton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChorobyButtton.Textcolor = System.Drawing.Color.White;
            this.ChorobyButtton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChorobyButtton.Click += new System.EventHandler(this.ChorobyButton_Click);
            // 
            // LekiButton
            // 
            this.LekiButton.Active = false;
            this.LekiButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.LekiButton.BackColor = System.Drawing.Color.Transparent;
            this.LekiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LekiButton.BorderRadius = 0;
            this.LekiButton.ButtonText = "   Leki";
            this.LekiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LekiButton.DisabledColor = System.Drawing.Color.Gray;
            this.LekiButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LekiButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("LekiButton.Iconimage")));
            this.LekiButton.Iconimage_right = null;
            this.LekiButton.Iconimage_right_Selected = null;
            this.LekiButton.Iconimage_Selected = null;
            this.LekiButton.IconMarginLeft = 34;
            this.LekiButton.IconMarginRight = 0;
            this.LekiButton.IconRightVisible = true;
            this.LekiButton.IconRightZoom = 0D;
            this.LekiButton.IconVisible = true;
            this.LekiButton.IconZoom = 61D;
            this.LekiButton.IsTab = false;
            this.LekiButton.Location = new System.Drawing.Point(0, 307);
            this.LekiButton.Margin = new System.Windows.Forms.Padding(0);
            this.LekiButton.Name = "LekiButton";
            this.LekiButton.Normalcolor = System.Drawing.Color.Transparent;
            this.LekiButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.LekiButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LekiButton.selected = false;
            this.LekiButton.Size = new System.Drawing.Size(176, 48);
            this.LekiButton.TabIndex = 3;
            this.LekiButton.Text = "   Leki";
            this.LekiButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LekiButton.Textcolor = System.Drawing.Color.White;
            this.LekiButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LekiButton.Click += new System.EventHandler(this.LekiButton_Click);
            // 
            // WizytyButton
            // 
            this.WizytyButton.Active = false;
            this.WizytyButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.WizytyButton.BackColor = System.Drawing.Color.Transparent;
            this.WizytyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WizytyButton.BorderRadius = 0;
            this.WizytyButton.ButtonText = "   Wizyty";
            this.WizytyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WizytyButton.DisabledColor = System.Drawing.Color.Gray;
            this.WizytyButton.Iconcolor = System.Drawing.Color.Transparent;
            this.WizytyButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("WizytyButton.Iconimage")));
            this.WizytyButton.Iconimage_right = null;
            this.WizytyButton.Iconimage_right_Selected = null;
            this.WizytyButton.Iconimage_Selected = null;
            this.WizytyButton.IconMarginLeft = 33;
            this.WizytyButton.IconMarginRight = 0;
            this.WizytyButton.IconRightVisible = true;
            this.WizytyButton.IconRightZoom = 0D;
            this.WizytyButton.IconVisible = true;
            this.WizytyButton.IconZoom = 56D;
            this.WizytyButton.IsTab = true;
            this.WizytyButton.Location = new System.Drawing.Point(0, 259);
            this.WizytyButton.Margin = new System.Windows.Forms.Padding(0);
            this.WizytyButton.Name = "WizytyButton";
            this.WizytyButton.Normalcolor = System.Drawing.Color.Transparent;
            this.WizytyButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.WizytyButton.OnHoverTextColor = System.Drawing.Color.White;
            this.WizytyButton.selected = false;
            this.WizytyButton.Size = new System.Drawing.Size(176, 48);
            this.WizytyButton.TabIndex = 3;
            this.WizytyButton.Text = "   Wizyty";
            this.WizytyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WizytyButton.Textcolor = System.Drawing.Color.White;
            this.WizytyButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WizytyButton.Click += new System.EventHandler(this.WizytyButton_Click);
            // 
            // PacjenciButton
            // 
            this.PacjenciButton.Active = false;
            this.PacjenciButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.PacjenciButton.BackColor = System.Drawing.Color.Transparent;
            this.PacjenciButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PacjenciButton.BorderRadius = 0;
            this.PacjenciButton.ButtonText = "  Pacjenci";
            this.PacjenciButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PacjenciButton.DisabledColor = System.Drawing.Color.Gray;
            this.PacjenciButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PacjenciButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("PacjenciButton.Iconimage")));
            this.PacjenciButton.Iconimage_right = null;
            this.PacjenciButton.Iconimage_right_Selected = null;
            this.PacjenciButton.Iconimage_Selected = null;
            this.PacjenciButton.IconMarginLeft = 30;
            this.PacjenciButton.IconMarginRight = 0;
            this.PacjenciButton.IconRightVisible = true;
            this.PacjenciButton.IconRightZoom = 0D;
            this.PacjenciButton.IconVisible = true;
            this.PacjenciButton.IconZoom = 69D;
            this.PacjenciButton.IsTab = false;
            this.PacjenciButton.Location = new System.Drawing.Point(0, 211);
            this.PacjenciButton.Margin = new System.Windows.Forms.Padding(0);
            this.PacjenciButton.Name = "PacjenciButton";
            this.PacjenciButton.Normalcolor = System.Drawing.Color.Transparent;
            this.PacjenciButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.PacjenciButton.OnHoverTextColor = System.Drawing.Color.White;
            this.PacjenciButton.selected = false;
            this.PacjenciButton.Size = new System.Drawing.Size(176, 48);
            this.PacjenciButton.TabIndex = 3;
            this.PacjenciButton.Text = "  Pacjenci";
            this.PacjenciButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PacjenciButton.Textcolor = System.Drawing.Color.White;
            this.PacjenciButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PacjenciButton.Click += new System.EventHandler(this.PacjenciButton_Click);
            // 
            // LekarzeButton
            // 
            this.LekarzeButton.Active = false;
            this.LekarzeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.LekarzeButton.BackColor = System.Drawing.Color.Transparent;
            this.LekarzeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LekarzeButton.BorderRadius = 0;
            this.LekarzeButton.ButtonText = "   Lekarze";
            this.LekarzeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LekarzeButton.DisabledColor = System.Drawing.Color.Gray;
            this.LekarzeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LekarzeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("LekarzeButton.Iconimage")));
            this.LekarzeButton.Iconimage_right = null;
            this.LekarzeButton.Iconimage_right_Selected = null;
            this.LekarzeButton.Iconimage_Selected = null;
            this.LekarzeButton.IconMarginLeft = 30;
            this.LekarzeButton.IconMarginRight = 0;
            this.LekarzeButton.IconRightVisible = true;
            this.LekarzeButton.IconRightZoom = 0D;
            this.LekarzeButton.IconVisible = true;
            this.LekarzeButton.IconZoom = 62D;
            this.LekarzeButton.IsTab = false;
            this.LekarzeButton.Location = new System.Drawing.Point(0, 163);
            this.LekarzeButton.Name = "LekarzeButton";
            this.LekarzeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.LekarzeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.LekarzeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LekarzeButton.selected = false;
            this.LekarzeButton.Size = new System.Drawing.Size(176, 48);
            this.LekarzeButton.TabIndex = 3;
            this.LekarzeButton.Text = "   Lekarze";
            this.LekarzeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LekarzeButton.Textcolor = System.Drawing.Color.White;
            this.LekarzeButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LekarzeButton.Click += new System.EventHandler(this.LekarzeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(140)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 44);
            this.panel2.TabIndex = 4;
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(176, 41);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(824, 577);
            this.panelContainer.TabIndex = 7;
            // 
            // wYSWIETLLEKARZYBindingSource
            // 
            this.wYSWIETLLEKARZYBindingSource.DataMember = "WYSWIETL_LEKARZY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wYSWIETLLEKARZYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton LekarzeButton;
        private Bunifu.Framework.UI.BunifuFlatButton LekiButton;
        private Bunifu.Framework.UI.BunifuFlatButton WizytyButton;
        private Bunifu.Framework.UI.BunifuFlatButton PacjenciButton;
        private Bunifu.UI.WinForms.BunifuLabel MedicineClinicLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton ChorobyButtton;
        private System.Windows.Forms.BindingSource wYSWIETLLEKARZYBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton BadaniaButton;
        private Bunifu.Framework.UI.BunifuFlatButton kartaBadanButton;
    }
}

