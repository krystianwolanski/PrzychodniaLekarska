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
    public partial class LekiControl : UserControl
    {
        Object acursor;
        public static DataGridViewRow rowLeki;
        public LekiControl()
        {
            InitializeComponent();
            this.lEKI_TAPI_WYSWIETL_LEKITableAdapter.Fill(przychodniaSet.LEKI_TAPI_WYSWIETL_LEKI, out acursor);
        }

        private void dodajLek_Click(object sender, EventArgs e)
        {
            string nazwa = nazwaLekuTB.Text;
            string opis = opisLekuTB.Text;

            this.queriesTableAdapter1.LEKI_TAPI_INS(nazwa, opis);

            this.lEKI_TAPI_WYSWIETL_LEKITableAdapter.Fill(przychodniaSet.LEKI_TAPI_WYSWIETL_LEKI, out acursor);

            nazwaLekuTB.Text = "";
            opisLekuTB.Text = "";
            
        }

        private void usunLek_Click(object sender, EventArgs e)
        {
            rowLeki = datagridLeki.SelectedRows[0];
            Console.WriteLine(datagridLeki.Columns[0].Name);
            string id_leku = rowLeki.Cells["iDLEKARSTWADataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.LEKI_TAPI_DEL(Decimal.Parse(id_leku));
            this.lEKI_TAPI_WYSWIETL_LEKITableAdapter.Fill(przychodniaSet.LEKI_TAPI_WYSWIETL_LEKI, out acursor);
        }

        private void edytujLek_Click(object sender, EventArgs e)
        {
            rowLeki = datagridLeki.SelectedRows[0];

            //Console.WriteLine(datagridPacjenci.Columns[1].Name);
            EdycjaLeku edycjaLeku = new EdycjaLeku();
            edycjaLeku.ShowDialog();

            this.lEKI_TAPI_WYSWIETL_LEKITableAdapter.Fill(przychodniaSet.LEKI_TAPI_WYSWIETL_LEKI, out acursor);
        }
    }
}
