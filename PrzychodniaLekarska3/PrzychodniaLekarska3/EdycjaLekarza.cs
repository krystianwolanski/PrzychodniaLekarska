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
    public partial class EdycjaLekarza : Form
    {
        public EdycjaLekarza()
        {
            InitializeComponent();

            imieLekarzaTB.Text = LekarzeControl.row.Cells["imieLekarza"].Value.ToString();
            nazwiskoLekarzaTB.Text = LekarzeControl.row.Cells["nazwiskoLekarza"].Value.ToString();
            specjalizacjaLekarzaTB.Text = LekarzeControl.row.Cells["specjalizacjaLekarza"].Value.ToString();
            specjalizacjaLekarzaTB.SelectionStart = specjalizacjaLekarzaTB.Text.Length;
        }

        private void edytujLekarza_Click(object sender, EventArgs e)
        {
            string imie = imieLekarzaTB.Text;
            string nazwisko = nazwiskoLekarzaTB.Text;
            string specjalizacja = specjalizacjaLekarzaTB.Text;
            string id_lekarza = LekarzeControl.row.Cells["iDLEKARZADataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.LEKARZE_TAPI_UPD(Decimal.Parse(id_lekarza), imie, specjalizacja, nazwisko);

            this.Close();
            
            
            

        }
    }
}
