namespace PrzychodniaLekarska3
{
    partial class DodajWizyteForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idLekarzeComboBox = new System.Windows.Forms.ComboBox();
            this.lEKARZEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet = new PrzychodniaLekarska3.PrzychodniaSet();
            this.idPacjentacomboBox = new System.Windows.Forms.ComboBox();
            this.pACJENCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_rejestracjiDP = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dataWizytyDP = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DodajWizyte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lEKARZETableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.LEKARZETableAdapter();
            this.pACJENCITableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.PACJENCITableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.LekcomboBox = new System.Windows.Forms.ComboBox();
            this.lEKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lEKITableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.LEKITableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.ChorobacomboBox = new System.Windows.Forms.ComboBox();
            this.cHOROBYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHOROBYTableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.CHOROBYTableAdapter();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            this.receptyTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.RECEPTYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lEKARZEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOROBYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(182, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data rejestracji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(182, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data wizyty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(182, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id lekarza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(182, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id pacjenta";
            // 
            // idLekarzeComboBox
            // 
            this.idLekarzeComboBox.DataSource = this.lEKARZEBindingSource;
            this.idLekarzeComboBox.DisplayMember = "ID_LEKARZA";
            this.idLekarzeComboBox.FormattingEnabled = true;
            this.idLekarzeComboBox.Location = new System.Drawing.Point(307, 104);
            this.idLekarzeComboBox.Name = "idLekarzeComboBox";
            this.idLekarzeComboBox.Size = new System.Drawing.Size(121, 21);
            this.idLekarzeComboBox.TabIndex = 1;
            // 
            // lEKARZEBindingSource
            // 
            this.lEKARZEBindingSource.DataMember = "LEKARZE";
            this.lEKARZEBindingSource.DataSource = this.przychodniaSet;
            // 
            // przychodniaSet
            // 
            this.przychodniaSet.DataSetName = "PrzychodniaSet";
            this.przychodniaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idPacjentacomboBox
            // 
            this.idPacjentacomboBox.DataSource = this.pACJENCIBindingSource;
            this.idPacjentacomboBox.DisplayMember = "ID_PACJENTA";
            this.idPacjentacomboBox.FormattingEnabled = true;
            this.idPacjentacomboBox.Location = new System.Drawing.Point(328, 139);
            this.idPacjentacomboBox.Name = "idPacjentacomboBox";
            this.idPacjentacomboBox.Size = new System.Drawing.Size(121, 21);
            this.idPacjentacomboBox.TabIndex = 2;
            // 
            // pACJENCIBindingSource
            // 
            this.pACJENCIBindingSource.DataMember = "PACJENCI";
            this.pACJENCIBindingSource.DataSource = this.przychodniaSet;
            // 
            // data_rejestracjiDP
            // 
            this.data_rejestracjiDP.BackColor = System.Drawing.Color.DodgerBlue;
            this.data_rejestracjiDP.BorderRadius = 0;
            this.data_rejestracjiDP.ForeColor = System.Drawing.Color.White;
            this.data_rejestracjiDP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.data_rejestracjiDP.FormatCustom = null;
            this.data_rejestracjiDP.Location = new System.Drawing.Point(347, 18);
            this.data_rejestracjiDP.Name = "data_rejestracjiDP";
            this.data_rejestracjiDP.Size = new System.Drawing.Size(157, 35);
            this.data_rejestracjiDP.TabIndex = 3;
            this.data_rejestracjiDP.Value = new System.DateTime(2019, 6, 3, 3, 28, 40, 202);
            // 
            // dataWizytyDP
            // 
            this.dataWizytyDP.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataWizytyDP.BorderRadius = 0;
            this.dataWizytyDP.ForeColor = System.Drawing.Color.White;
            this.dataWizytyDP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dataWizytyDP.FormatCustom = null;
            this.dataWizytyDP.Location = new System.Drawing.Point(314, 60);
            this.dataWizytyDP.Name = "dataWizytyDP";
            this.dataWizytyDP.Size = new System.Drawing.Size(157, 35);
            this.dataWizytyDP.TabIndex = 3;
            this.dataWizytyDP.Value = new System.DateTime(2019, 6, 3, 3, 28, 40, 202);
            // 
            // DodajWizyte
            // 
            this.DodajWizyte.Active = false;
            this.DodajWizyte.Activecolor = System.Drawing.Color.Orange;
            this.DodajWizyte.BackColor = System.Drawing.Color.Orange;
            this.DodajWizyte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DodajWizyte.BorderRadius = 0;
            this.DodajWizyte.ButtonText = "Dodaj";
            this.DodajWizyte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DodajWizyte.DisabledColor = System.Drawing.Color.Gray;
            this.DodajWizyte.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.DodajWizyte.Iconcolor = System.Drawing.Color.Transparent;
            this.DodajWizyte.Iconimage = null;
            this.DodajWizyte.Iconimage_right = null;
            this.DodajWizyte.Iconimage_right_Selected = null;
            this.DodajWizyte.Iconimage_Selected = null;
            this.DodajWizyte.IconMarginLeft = 0;
            this.DodajWizyte.IconMarginRight = 0;
            this.DodajWizyte.IconRightVisible = true;
            this.DodajWizyte.IconRightZoom = 0D;
            this.DodajWizyte.IconVisible = true;
            this.DodajWizyte.IconZoom = 90D;
            this.DodajWizyte.IsTab = false;
            this.DodajWizyte.Location = new System.Drawing.Point(328, 279);
            this.DodajWizyte.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DodajWizyte.Name = "DodajWizyte";
            this.DodajWizyte.Normalcolor = System.Drawing.Color.Orange;
            this.DodajWizyte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.DodajWizyte.OnHoverTextColor = System.Drawing.Color.White;
            this.DodajWizyte.selected = false;
            this.DodajWizyte.Size = new System.Drawing.Size(118, 50);
            this.DodajWizyte.TabIndex = 33;
            this.DodajWizyte.Text = "Dodaj";
            this.DodajWizyte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DodajWizyte.Textcolor = System.Drawing.Color.White;
            this.DodajWizyte.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajWizyte.Click += new System.EventHandler(this.DodajWizyte_Click);
            // 
            // lEKARZETableAdapter
            // 
            this.lEKARZETableAdapter.ClearBeforeFill = true;
            // 
            // pACJENCITableAdapter
            // 
            this.pACJENCITableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(182, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lek";
            // 
            // LekcomboBox
            // 
            this.LekcomboBox.DataSource = this.lEKIBindingSource;
            this.LekcomboBox.DisplayMember = "ID_LEKARSTWA";
            this.LekcomboBox.FormattingEnabled = true;
            this.LekcomboBox.Location = new System.Drawing.Point(251, 173);
            this.LekcomboBox.Name = "LekcomboBox";
            this.LekcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LekcomboBox.TabIndex = 34;
            // 
            // lEKIBindingSource
            // 
            this.lEKIBindingSource.DataMember = "LEKI";
            this.lEKIBindingSource.DataSource = this.przychodniaSet;
            // 
            // lEKITableAdapter
            // 
            this.lEKITableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(182, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choroba";
            // 
            // ChorobacomboBox
            // 
            this.ChorobacomboBox.DataSource = this.cHOROBYBindingSource;
            this.ChorobacomboBox.DisplayMember = "ID_CHOROBY";
            this.ChorobacomboBox.FormattingEnabled = true;
            this.ChorobacomboBox.Location = new System.Drawing.Point(290, 212);
            this.ChorobacomboBox.Name = "ChorobacomboBox";
            this.ChorobacomboBox.Size = new System.Drawing.Size(121, 21);
            this.ChorobacomboBox.TabIndex = 34;
            // 
            // cHOROBYBindingSource
            // 
            this.cHOROBYBindingSource.DataMember = "CHOROBY";
            this.cHOROBYBindingSource.DataSource = this.przychodniaSet;
            // 
            // cHOROBYTableAdapter
            // 
            this.cHOROBYTableAdapter.ClearBeforeFill = true;
            // 
            // receptyTableAdapter1
            // 
            this.receptyTableAdapter1.ClearBeforeFill = true;
            // 
            // DodajWizyteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 408);
            this.Controls.Add(this.ChorobacomboBox);
            this.Controls.Add(this.LekcomboBox);
            this.Controls.Add(this.DodajWizyte);
            this.Controls.Add(this.dataWizytyDP);
            this.Controls.Add(this.data_rejestracjiDP);
            this.Controls.Add(this.idPacjentacomboBox);
            this.Controls.Add(this.idLekarzeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajWizyteForm";
            this.Text = "DodajWizyteForm";
            this.Load += new System.EventHandler(this.DodajWizyteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lEKARZEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOROBYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idLekarzeComboBox;
        private System.Windows.Forms.ComboBox idPacjentacomboBox;
        private Bunifu.Framework.UI.BunifuDatepicker data_rejestracjiDP;
        private Bunifu.Framework.UI.BunifuDatepicker dataWizytyDP;
        private Bunifu.Framework.UI.BunifuFlatButton DodajWizyte;
        private PrzychodniaSet przychodniaSet;
        private System.Windows.Forms.BindingSource lEKARZEBindingSource;
        private PrzychodniaSetTableAdapters.LEKARZETableAdapter lEKARZETableAdapter;
        private System.Windows.Forms.BindingSource pACJENCIBindingSource;
        private PrzychodniaSetTableAdapters.PACJENCITableAdapter pACJENCITableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LekcomboBox;
        private System.Windows.Forms.BindingSource lEKIBindingSource;
        private PrzychodniaSetTableAdapters.LEKITableAdapter lEKITableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ChorobacomboBox;
        private System.Windows.Forms.BindingSource cHOROBYBindingSource;
        private PrzychodniaSetTableAdapters.CHOROBYTableAdapter cHOROBYTableAdapter;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private PrzychodniaSetTableAdapters.RECEPTYTableAdapter receptyTableAdapter1;
    }
}