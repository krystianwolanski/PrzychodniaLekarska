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
    public partial class DodajWizyteForm : Form
    {
        Object ACursor;
        public DodajWizyteForm()
        {
            InitializeComponent();
        }

        private void DodajWizyteForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaSet.CHOROBY' . Możesz go przenieść lub usunąć.
            this.cHOROBYTableAdapter.Fill(this.przychodniaSet.CHOROBY);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaSet.LEKI' . Możesz go przenieść lub usunąć.
            this.lEKITableAdapter.Fill(this.przychodniaSet.LEKI);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaSet.PACJENCI' . Możesz go przenieść lub usunąć.
            this.pACJENCITableAdapter.Fill(this.przychodniaSet.PACJENCI);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaSet.LEKARZE' . Możesz go przenieść lub usunąć.
            this.lEKARZETableAdapter.Fill(this.przychodniaSet.LEKARZE);

        }

        private void DodajWizyte_Click(object sender, EventArgs e)
        {
            
            string id_lekarza = idLekarzeComboBox.Text;
            string id_pacjenta = idPacjentacomboBox.Text;
            string id_leku = LekcomboBox.Text;
            string id_choroby = ChorobacomboBox.Text;
            DateTime data_rejestracji = data_rejestracjiDP.Value;
            DateTime data_wizyty = dataWizytyDP.Value;

            queriesTableAdapter1.WIZYTY_TAPI_INS(Decimal.Parse(id_lekarza), data_wizyty, Decimal.Parse(id_pacjenta), data_rejestracji);
            queriesTableAdapter1.RECEPTY_TAPI_INS("");
            string id_recepty = queriesTableAdapter1.RECEPTY_TAPI_GETMAXID(out ACursor).ToString();
            string id_wizyty = queriesTableAdapter1.WIZYTY_TAPI_GETMAXID(out ACursor).ToString();
            queriesTableAdapter1.WIZYTY_RECEPTY_TAPI_INS(Decimal.Parse(id_recepty), Decimal.Parse(id_wizyty));

            queriesTableAdapter1.WIZYTY_CHOROBY_TAPI_INS(Decimal.Parse(id_wizyty), Decimal.Parse(id_choroby));
            queriesTableAdapter1.LEKARSTWA_RECEPTY_TAPI_INS(Decimal.Parse(id_recepty), Decimal.Parse(id_leku));
            
            this.Close();



        }
    }
}
