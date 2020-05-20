namespace PrzychodniaLekarska3
{
    partial class EdycjaBadania
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
            this.EdytujBadanie = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NazwaTB = new System.Windows.Forms.TextBox();
            this.PodtypTB = new System.Windows.Forms.TextBox();
            this.TypTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CenaTB = new System.Windows.Forms.TextBox();
            this.queriesTableAdapter1 = new PrzychodniaLekarska3.PrzychodniaSetTableAdapters.QueriesTableAdapter();
            this.SuspendLayout();
            // 
            // EdytujBadanie
            // 
            this.EdytujBadanie.Active = false;
            this.EdytujBadanie.Activecolor = System.Drawing.Color.Orange;
            this.EdytujBadanie.BackColor = System.Drawing.Color.Orange;
            this.EdytujBadanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EdytujBadanie.BorderRadius = 0;
            this.EdytujBadanie.ButtonText = "Edytuj";
            this.EdytujBadanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdytujBadanie.DisabledColor = System.Drawing.Color.Gray;
            this.EdytujBadanie.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.EdytujBadanie.Iconcolor = System.Drawing.Color.Transparent;
            this.EdytujBadanie.Iconimage = null;
            this.EdytujBadanie.Iconimage_right = null;
            this.EdytujBadanie.Iconimage_right_Selected = null;
            this.EdytujBadanie.Iconimage_Selected = null;
            this.EdytujBadanie.IconMarginLeft = 0;
            this.EdytujBadanie.IconMarginRight = 0;
            this.EdytujBadanie.IconRightVisible = true;
            this.EdytujBadanie.IconRightZoom = 0D;
            this.EdytujBadanie.IconVisible = true;
            this.EdytujBadanie.IconZoom = 90D;
            this.EdytujBadanie.IsTab = false;
            this.EdytujBadanie.Location = new System.Drawing.Point(232, 196);
            this.EdytujBadanie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.EdytujBadanie.Name = "EdytujBadanie";
            this.EdytujBadanie.Normalcolor = System.Drawing.Color.Orange;
            this.EdytujBadanie.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.EdytujBadanie.OnHoverTextColor = System.Drawing.Color.White;
            this.EdytujBadanie.selected = false;
            this.EdytujBadanie.Size = new System.Drawing.Size(118, 50);
            this.EdytujBadanie.TabIndex = 32;
            this.EdytujBadanie.Text = "Edytuj";
            this.EdytujBadanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EdytujBadanie.Textcolor = System.Drawing.Color.White;
            this.EdytujBadanie.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdytujBadanie.Click += new System.EventHandler(this.EdytujBadanie_Click);
            // 
            // NazwaTB
            // 
            this.NazwaTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaTB.Location = new System.Drawing.Point(244, 111);
            this.NazwaTB.Name = "NazwaTB";
            this.NazwaTB.Size = new System.Drawing.Size(106, 22);
            this.NazwaTB.TabIndex = 29;
            // 
            // PodtypTB
            // 
            this.PodtypTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PodtypTB.Location = new System.Drawing.Point(262, 77);
            this.PodtypTB.Name = "PodtypTB";
            this.PodtypTB.Size = new System.Drawing.Size(106, 22);
            this.PodtypTB.TabIndex = 30;
            // 
            // TypTB
            // 
            this.TypTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypTB.Location = new System.Drawing.Point(232, 44);
            this.TypTB.Name = "TypTB";
            this.TypTB.Size = new System.Drawing.Size(106, 22);
            this.TypTB.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(153, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(153, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Podtyp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(153, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(153, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cena";
            // 
            // CenaTB
            // 
            this.CenaTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CenaTB.Location = new System.Drawing.Point(232, 143);
            this.CenaTB.Name = "CenaTB";
            this.CenaTB.Size = new System.Drawing.Size(106, 22);
            this.CenaTB.TabIndex = 29;
            // 
            // EdycjaBadania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 318);
            this.Controls.Add(this.EdytujBadanie);
            this.Controls.Add(this.CenaTB);
            this.Controls.Add(this.NazwaTB);
            this.Controls.Add(this.PodtypTB);
            this.Controls.Add(this.TypTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdycjaBadania";
            this.Text = "EdycjaBadania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton EdytujBadanie;
        private System.Windows.Forms.TextBox NazwaTB;
        private System.Windows.Forms.TextBox PodtypTB;
        private System.Windows.Forms.TextBox TypTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CenaTB;
        private PrzychodniaSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}