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
    public partial class EdycjaBadania : Form
    {
        public EdycjaBadania()
        {
            InitializeComponent();

            TypTB.Text = BadaniaControl.rowBadania.Cells["tYPDataGridViewTextBoxColumn"].Value.ToString();
            PodtypTB.Text = BadaniaControl.rowBadania.Cells["pODTYPDataGridViewTextBoxColumn"].Value.ToString();
            NazwaTB.Text = BadaniaControl.rowBadania.Cells["nAZWADataGridViewTextBoxColumn"].Value.ToString();
            CenaTB.Text = BadaniaControl.rowBadania.Cells["cENADataGridViewTextBoxColumn"].Value.ToString();

            CenaTB.SelectionStart = CenaTB.Text.Length;
        }

        private void EdytujBadanie_Click(object sender, EventArgs e)
        {
            string typ = TypTB.Text;
            string podtyp = PodtypTB.Text;
            string nazwa = NazwaTB.Text;
            string cena = CenaTB.Text;
            string id_badania = BadaniaControl.rowBadania.Cells["iDBADANIADataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.BADANIA_TAPI_UPD(Decimal.Parse(id_badania), typ, cena, podtyp, nazwa);
            this.Close();
        }
    }
}
