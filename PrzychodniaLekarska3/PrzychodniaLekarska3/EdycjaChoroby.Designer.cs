namespace PrzychodniaLekarska3
{
    partial class EdycjaChoroby
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
            this.edytujChorobe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.typChorobyTB = new System.Windows.Forms.TextBox();
            this.nazwaChorobyTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            this.chorobY_TAPI_WYSWIETL_CHOROBYTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.CHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter();
            this.przychodniaSet1 = new PrzychodniaLekarska3.PrzychodniaSet();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet1)).BeginInit();
            this.SuspendLayout();
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
            this.edytujChorobe.Location = new System.Drawing.Point(213, 187);
            this.edytujChorobe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujChorobe.Name = "edytujChorobe";
            this.edytujChorobe.Normalcolor = System.Drawing.Color.Orange;
            this.edytujChorobe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujChorobe.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujChorobe.selected = false;
            this.edytujChorobe.Size = new System.Drawing.Size(118, 50);
            this.edytujChorobe.TabIndex = 39;
            this.edytujChorobe.Text = "Edytuj";
            this.edytujChorobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujChorobe.Textcolor = System.Drawing.Color.White;
            this.edytujChorobe.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujChorobe.Click += new System.EventHandler(this.edytujChorobe_Click);
            // 
            // typChorobyTB
            // 
            this.typChorobyTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typChorobyTB.Location = new System.Drawing.Point(213, 82);
            this.typChorobyTB.Name = "typChorobyTB";
            this.typChorobyTB.Size = new System.Drawing.Size(106, 22);
            this.typChorobyTB.TabIndex = 37;
            // 
            // nazwaChorobyTB
            // 
            this.nazwaChorobyTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaChorobyTB.Location = new System.Drawing.Point(225, 49);
            this.nazwaChorobyTB.Name = "nazwaChorobyTB";
            this.nazwaChorobyTB.Size = new System.Drawing.Size(106, 22);
            this.nazwaChorobyTB.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(148, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Typ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(146, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nazwa";
            // 
            // chorobY_TAPI_WYSWIETL_CHOROBYTableAdapter1
            // 
            this.chorobY_TAPI_WYSWIETL_CHOROBYTableAdapter1.ClearBeforeFill = true;
            // 
            // przychodniaSet1
            // 
            this.przychodniaSet1.DataSetName = "PrzychodniaSet";
            this.przychodniaSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EdycjaChoroby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 318);
            this.Controls.Add(this.edytujChorobe);
            this.Controls.Add(this.typChorobyTB);
            this.Controls.Add(this.nazwaChorobyTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdycjaChoroby";
            this.Text = "EdycjaChoroby";
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton edytujChorobe;
        private System.Windows.Forms.TextBox typChorobyTB;
        private System.Windows.Forms.TextBox nazwaChorobyTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private PrzychodniaSetTableAdapters.CHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter chorobY_TAPI_WYSWIETL_CHOROBYTableAdapter1;
        private PrzychodniaSet przychodniaSet1;
    }
}