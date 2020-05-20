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
    public partial class EdycjaPacjenta : Form
    {
        public EdycjaPacjenta()
        {
            InitializeComponent();

            imiePacjentaTB.Text = PacjenciControl.rowPacjenci.Cells["iMIĘDataGridViewTextBoxColumn"].Value.ToString();
            nazwiskoPacjentaTB.Text = PacjenciControl.rowPacjenci.Cells["nAZWISKODataGridViewTextBoxColumn"].Value.ToString();
            peselPacjentaTB.Text = PacjenciControl.rowPacjenci.Cells["pESELDataGridViewTextBoxColumn"].Value.ToString();
            peselPacjentaTB.SelectionStart = peselPacjentaTB.Text.Length;
        }

        private void edytujPacjenta_Click(object sender, EventArgs e)
        {
            string imie = imiePacjentaTB.Text;
            string nazwisko = nazwiskoPacjentaTB.Text;
            string pesel = peselPacjentaTB.Text;
            string id_pacjenta = PacjenciControl.rowPacjenci.Cells["iDPacjentaDataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.PACJENCI_TAPI_UPD(imie, Decimal.Parse(pesel), Decimal.Parse(id_pacjenta), nazwisko);

            this.Close();

        }
    }
}
