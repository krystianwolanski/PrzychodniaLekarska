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
    public partial class PacjenciControl : UserControl
    {
        public static DataGridViewRow rowPacjenci;
        public PacjenciControl()
        {
            InitializeComponent();
            this.pACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter.Fill(przychodniaSet.PACJENCI_TAPI_WYSWIETL_PACJENTOW, out LekarzeControl.ACURSOR);
        }

        private void dodajPacjenta_Click(object sender, EventArgs e)
        {
            string imie_pacjenta = imiePacjentaTB.Text;
            string nazwisko_pacjenta = nazwiskoPacjentaTB.Text;
            string pesel = peselPacjentaTB.Text;

            this.queriesTableAdapter1.PACJENCI_TAPI_INS(imie_pacjenta, Decimal.Parse(pesel), nazwisko_pacjenta);
            this.pACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter.Fill(przychodniaSet.PACJENCI_TAPI_WYSWIETL_PACJENTOW, out LekarzeControl.ACURSOR);

            imiePacjentaTB.Text = "";
            nazwiskoPacjentaTB.Text = "";
            peselPacjentaTB.Text = "";
        }

        private void usunPacjenta_Click(object sender, EventArgs e)
        {
            rowPacjenci = datagridPacjenci.SelectedRows[0];
      
            string id_pacjenta = rowPacjenci.Cells["iDPACJENTADataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.PACJENCI_TAPI_DEL(Decimal.Parse(id_pacjenta));
            this.pACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter.Fill(przychodniaSet.PACJENCI_TAPI_WYSWIETL_PACJENTOW, out LekarzeControl.ACURSOR);
        }

        private void edytujPacjenta_Click(object sender, EventArgs e)
        {
            rowPacjenci = datagridPacjenci.SelectedRows[0];

            Console.WriteLine(datagridPacjenci.Columns[1].Name);
            EdycjaPacjenta edycjaPacjenta = new EdycjaPacjenta();
            edycjaPacjenta.ShowDialog();

            this.pACJENCI_TAPI_WYSWIETL_PACJENTOWTableAdapter.Fill(przychodniaSet.PACJENCI_TAPI_WYSWIETL_PACJENTOW, out LekarzeControl.ACURSOR);
        }
    }
}
