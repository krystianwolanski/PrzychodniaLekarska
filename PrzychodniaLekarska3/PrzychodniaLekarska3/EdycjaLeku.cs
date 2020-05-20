using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzychodniaLekarska3
{
    public partial class EdycjaLeku : Form
    {
        public EdycjaLeku()
        {
            InitializeComponent();

            nazwaLekuTextBox.Text = LekiControl.rowLeki.Cells["nAZWADataGridViewTextBoxColumn"].Value.ToString();
            opisLekuTB.Text = LekiControl.rowLeki.Cells["oPISDataGridViewTextBoxColumn"].Value.ToString();
           
            opisLekuTB.SelectionStart = opisLekuTB.Text.Length;
        }

        private void edytujLek_Click(object sender, EventArgs e)
        {
            string nazwa = nazwaLekuTextBox.Text;
            string opis = opisLekuTB.Text;
            string id_leku = LekiControl.rowLeki.Cells["iDLEKARSTWADataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.LEKI_TAPI_UPD(Decimal.Parse(id_leku), nazwa, opis);
            this.Close();

          
        
        }
    }
}
