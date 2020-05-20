using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzychodniaLekarska3
{
    public partial class BadaniaControl : UserControl
    {
        Object acursor;
        public static DataGridViewRow rowBadania;
        public BadaniaControl()
        {
            InitializeComponent();
            
            this.bADANIA_TAPI_WYSWIETL_BADANIATableAdapter.Fill(przychodniaSet.BADANIA_TAPI_WYSWIETL_BADANIA, out acursor);
        }

        private void dodajBadanie_Click(object sender, EventArgs e)
        {
            string typ = typBadaniaTB.Text;
            string podtyp = podtypBadaniaTB.Text;
            string nazwa = NazwaBadaniaTB.Text;
            string cena = CenaBadaniaTB.Text;

            this.queriesTableAdapter1.BADANIA_TAPI_INS(typ, cena, podtyp, nazwa);

            this.bADANIA_TAPI_WYSWIETL_BADANIATableAdapter.Fill(przychodniaSet.BADANIA_TAPI_WYSWIETL_BADANIA, out acursor);

            typBadaniaTB.Text = "";
            podtypBadaniaTB.Text = "";
            NazwaBadaniaTB.Text = "";
            CenaBadaniaTB.Text = "";
        }

        private void usunBadanie_Click(object sender, EventArgs e)
        {
            rowBadania = dataGridBadania.SelectedRows[0];
            //Console.WriteLine(datagridLeki.Columns[0].Name);
            string id_badania = rowBadania.Cells["iDBADANIADataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.BADANIA_TAPI_DEL(Decimal.Parse(id_badania));
            this.bADANIA_TAPI_WYSWIETL_BADANIATableAdapter.Fill(przychodniaSet.BADANIA_TAPI_WYSWIETL_BADANIA, out acursor);
        }

        private void edytujBadanie_Click(object sender, EventArgs e)
        {
            rowBadania = dataGridBadania.SelectedRows[0];

            //Console.WriteLine(datagridPacjenci.Columns[1].Name);
            EdycjaBadania edycjaBadania = new EdycjaBadania();
            edycjaBadania.ShowDialog();

            this.bADANIA_TAPI_WYSWIETL_BADANIATableAdapter.Fill(przychodniaSet.BADANIA_TAPI_WYSWIETL_BADANIA, out acursor);
        }
    }
}
