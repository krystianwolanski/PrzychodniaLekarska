namespace PrzychodniaLekarska3
{
    partial class EdycjaPacjenta
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
            this.edytujPacjenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.peselPacjentaTB = new System.Windows.Forms.TextBox();
            this.nazwiskoPacjentaTB = new System.Windows.Forms.TextBox();
            this.imiePacjentaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            this.pacjencI_TAPI_WYSWIETL_PACJENTOWTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.PACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter();
            this.przychodniaSet1 = new PrzychodniaLekarska3.PrzychodniaSet();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // edytujPacjenta
            // 
            this.edytujPacjenta.Active = false;
            this.edytujPacjenta.Activecolor = System.Drawing.Color.Orange;
            this.edytujPacjenta.BackColor = System.Drawing.Color.Orange;
            this.edytujPacjenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujPacjenta.BorderRadius = 0;
            this.edytujPacjenta.ButtonText = "Edytuj";
            this.edytujPacjenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujPacjenta.DisabledColor = System.Drawing.Color.Gray;
            this.edytujPacjenta.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujPacjenta.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujPacjenta.Iconimage = null;
            this.edytujPacjenta.Iconimage_right = null;
            this.edytujPacjenta.Iconimage_right_Selected = null;
            this.edytujPacjenta.Iconimage_Selected = null;
            this.edytujPacjenta.IconMarginLeft = 0;
            this.edytujPacjenta.IconMarginRight = 0;
            this.edytujPacjenta.IconRightVisible = true;
            this.edytujPacjenta.IconRightZoom = 0D;
            this.edytujPacjenta.IconVisible = true;
            this.edytujPacjenta.IconZoom = 90D;
            this.edytujPacjenta.IsTab = false;
            this.edytujPacjenta.Location = new System.Drawing.Point(240, 197);
            this.edytujPacjenta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujPacjenta.Name = "edytujPacjenta";
            this.edytujPacjenta.Normalcolor = System.Drawing.Color.Orange;
            this.edytujPacjenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujPacjenta.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujPacjenta.selected = false;
            this.edytujPacjenta.Size = new System.Drawing.Size(118, 50);
            this.edytujPacjenta.TabIndex = 32;
            this.edytujPacjenta.Text = "Edytuj";
            this.edytujPacjenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujPacjenta.Textcolor = System.Drawing.Color.White;
            this.edytujPacjenta.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujPacjenta.Click += new System.EventHandler(this.edytujPacjenta_Click);
            // 
            // peselPacjentaTB
            // 
            this.peselPacjentaTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peselPacjentaTB.Location = new System.Drawing.Point(252, 112);
            this.peselPacjentaTB.Name = "peselPacjentaTB";
            this.peselPacjentaTB.Size = new System.Drawing.Size(106, 22);
            this.peselPacjentaTB.TabIndex = 29;
            // 
            // nazwiskoPacjentaTB
            // 
            this.nazwiskoPacjentaTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwiskoPacjentaTB.Location = new System.Drawing.Point(270, 78);
            this.nazwiskoPacjentaTB.Name = "nazwiskoPacjentaTB";
            this.nazwiskoPacjentaTB.Size = new System.Drawing.Size(106, 22);
            this.nazwiskoPacjentaTB.TabIndex = 30;
            // 
            // imiePacjentaTB
            // 
            this.imiePacjentaTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imiePacjentaTB.Location = new System.Drawing.Point(240, 45);
            this.imiePacjentaTB.Name = "imiePacjentaTB";
            this.imiePacjentaTB.Size = new System.Drawing.Size(106, 22);
            this.imiePacjentaTB.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(163, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pesel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(161, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(161, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Imię";
            // 
            // pacjencI_TAPI_WYSWIETL_PACJENTOWTableAdapter1
            // 
            this.pacjencI_TAPI_WYSWIETL_PACJENTOWTableAdapter1.ClearBeforeFill = true;
            // 
            // przychodniaSet1
            // 
            this.przychodniaSet1.DataSetName = "PrzychodniaSet";
            this.przychodniaSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EdycjaPacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 318);
            this.Controls.Add(this.edytujPacjenta);
            this.Controls.Add(this.peselPacjentaTB);
            this.Controls.Add(this.nazwiskoPacjentaTB);
            this.Controls.Add(this.imiePacjentaTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdycjaPacjenta";
            this.Text = "EdycjaPacjenta";
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton edytujPacjenta;
        private System.Windows.Forms.TextBox peselPacjentaTB;
        private System.Windows.Forms.TextBox nazwiskoPacjentaTB;
        private System.Windows.Forms.TextBox imiePacjentaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private PrzychodniaSetTableAdapters.PACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter pacjencI_TAPI_WYSWIETL_PACJENTOWTableAdapter1;
        private PrzychodniaSet przychodniaSet1;
    }
}