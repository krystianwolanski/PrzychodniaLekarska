namespace PrzychodniaLekarska3
{
    partial class EdycjaLekarza
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
            this.edytujLekarza = new Bunifu.Framework.UI.BunifuFlatButton();
            this.specjalizacjaLekarzaTB = new System.Windows.Forms.TextBox();
            this.nazwiskoLekarzaTB = new System.Windows.Forms.TextBox();
            this.imieLekarzaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaSet = new PrzychodniaLekarska3.PrzychodniaSet();
            this.lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.LEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // edytujLekarza
            // 
            this.edytujLekarza.Active = false;
            this.edytujLekarza.Activecolor = System.Drawing.Color.Orange;
            this.edytujLekarza.BackColor = System.Drawing.Color.Orange;
            this.edytujLekarza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edytujLekarza.BorderRadius = 0;
            this.edytujLekarza.ButtonText = "Edytuj";
            this.edytujLekarza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edytujLekarza.DisabledColor = System.Drawing.Color.Gray;
            this.edytujLekarza.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.edytujLekarza.Iconcolor = System.Drawing.Color.Transparent;
            this.edytujLekarza.Iconimage = null;
            this.edytujLekarza.Iconimage_right = null;
            this.edytujLekarza.Iconimage_right_Selected = null;
            this.edytujLekarza.Iconimage_Selected = null;
            this.edytujLekarza.IconMarginLeft = 0;
            this.edytujLekarza.IconMarginRight = 0;
            this.edytujLekarza.IconRightVisible = true;
            this.edytujLekarza.IconRightZoom = 0D;
            this.edytujLekarza.IconVisible = true;
            this.edytujLekarza.IconZoom = 90D;
            this.edytujLekarza.IsTab = false;
            this.edytujLekarza.Location = new System.Drawing.Point(235, 191);
            this.edytujLekarza.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edytujLekarza.Name = "edytujLekarza";
            this.edytujLekarza.Normalcolor = System.Drawing.Color.Orange;
            this.edytujLekarza.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.edytujLekarza.OnHoverTextColor = System.Drawing.Color.White;
            this.edytujLekarza.selected = false;
            this.edytujLekarza.Size = new System.Drawing.Size(118, 50);
            this.edytujLekarza.TabIndex = 25;
            this.edytujLekarza.Text = "Edytuj";
            this.edytujLekarza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edytujLekarza.Textcolor = System.Drawing.Color.White;
            this.edytujLekarza.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujLekarza.Click += new System.EventHandler(this.edytujLekarza_Click);
            // 
            // specjalizacjaLekarzaTB
            // 
            this.specjalizacjaLekarzaTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specjalizacjaLekarzaTB.Location = new System.Drawing.Point(303, 106);
            this.specjalizacjaLekarzaTB.Name = "specjalizacjaLekarzaTB";
            this.specjalizacjaLekarzaTB.Size = new System.Drawing.Size(106, 22);
            this.specjalizacjaLekarzaTB.TabIndex = 22;
            // 
            // nazwiskoLekarzaTB
            // 
            this.nazwiskoLekarzaTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwiskoLekarzaTB.Location = new System.Drawing.Point(265, 72);
            this.nazwiskoLekarzaTB.Name = "nazwiskoLekarzaTB";
            this.nazwiskoLekarzaTB.Size = new System.Drawing.Size(106, 22);
            this.nazwiskoLekarzaTB.TabIndex = 23;
            // 
            // imieLekarzaTB
            // 
            this.imieLekarzaTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieLekarzaTB.Location = new System.Drawing.Point(235, 39);
            this.imieLekarzaTB.Name = "imieLekarzaTB";
            this.imieLekarzaTB.Size = new System.Drawing.Size(106, 22);
            this.imieLekarzaTB.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(156, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Specjalizacja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(156, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(156, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Imię";
            // 
            // lEKARZETAPIWYSWIETLLEKARZY1BindingSource
            // 
            this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource.DataMember = "LEKARZE_TAPI_WYSWIETL_LEKARZY1";
            this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource.DataSource = this.przychodniaSet;
            // 
            // przychodniaSet
            // 
            this.przychodniaSet.DataSetName = "PrzychodniaSet";
            this.przychodniaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter
            // 
            this.lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter.ClearBeforeFill = true;
            // 
            // EdycjaLekarza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 318);
            this.Controls.Add(this.edytujLekarza);
            this.Controls.Add(this.specjalizacjaLekarzaTB);
            this.Controls.Add(this.nazwiskoLekarzaTB);
            this.Controls.Add(this.imieLekarzaTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdycjaLekarza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EdycjaLekarza";
            ((System.ComponentModel.ISupportInitialize)(this.lEKARZETAPIWYSWIETLLEKARZY1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton edytujLekarza;
        private System.Windows.Forms.TextBox specjalizacjaLekarzaTB;
        private System.Windows.Forms.TextBox nazwiskoLekarzaTB;
        private System.Windows.Forms.TextBox imieLekarzaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource lEKARZETAPIWYSWIETLLEKARZY1BindingSource;
        private PrzychodniaSet przychodniaSet;
        private PrzychodniaSetTableAdapters.LEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter;
    }
}