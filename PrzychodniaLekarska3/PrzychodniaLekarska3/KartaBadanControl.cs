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
    public partial class KartaBadanControl : UserControl
    {
        Object acursor;
        public static DataGridViewRow rowKartaBadan;
        public KartaBadanControl()
        {
            InitializeComponent();
            this.kARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter.Fill(przychodniaSet1.KARTABADAN_TAPI_WYSWIETL_KARTEBADAN, out acursor);
            this.pACJENCITableAdapter.Fill(przychodniaSet1.PACJENCI);
            this.bADANIATableAdapter.Fill(przychodniaSet1.BADANIA);
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dodajKartaBadan_Click(object sender, EventArgs e)
        {
            string id_pacjenta = idPacjentaCB.Text;
            string id_badania = idBadaniaCB.Text;
            DateTime data_rejestracji = DataRejestracjiBadania.Value;
            DateTime data_badania = DataBadania.Value;

            this.queriesTableAdapter1.KARTABADAN_TAPI_INS(Decimal.Parse(id_badania), data_badania, Decimal.Parse(id_pacjenta), data_rejestracji);

            this.kARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter.Fill(przychodniaSet1.KARTABADAN_TAPI_WYSWIETL_KARTEBADAN, out acursor);

        }

        private void usunKartaBadan_Click(object sender, EventArgs e)
        {
            rowKartaBadan = datagridBadania.SelectedRows[0];
            //Console.WriteLine(datagridLeki.Columns[0].Name);
            string id_KartaBadan = rowKartaBadan.Cells["iDKARTABADANDataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.KARTABADAN_TAPI_DEL(Decimal.Parse(id_KartaBadan));
            this.kARTABADAN_TAPI_WYSWIETL_KARTEBADANTableAdapter.Fill(przychodniaSet1.KARTABADAN_TAPI_WYSWIETL_KARTEBADAN, out acursor);
        }
    }
}
