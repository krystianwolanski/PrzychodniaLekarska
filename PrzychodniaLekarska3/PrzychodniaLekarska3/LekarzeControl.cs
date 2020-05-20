using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace PrzychodniaLekarska3
{
    public partial class LekarzeControl : UserControl
    {
        public static Object ACURSOR;
        public LekarzeControl()
        {
            
            InitializeComponent();
            
           //this.wYSWIETL_LEKARZYTableAdapter.Fill(this.wyswietlLekarzy.WYSWIETL_LEKARZY, out ACURSOR);
          //  this.lEKARZE_TAPI_WYSWIETL_LEKARZYTableAdapter.Fill(this.przychodniaSet.LEKARZE_TAPI_WYSWIETL_LEKARZY, out ACURSOR);
            this.lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter.Fill(this.przychodniaSet.LEKARZE_TAPI_WYSWIETL_LEKARZY1, out ACURSOR);
    
        }
    
            
            

        private void LekarzSearch_TextChange(object sender, EventArgs e)
        {
            //lEKARZEBindingSource.Filter = string.Format("imię LIKE '%{0}%' or nazwisko LIKE '%{1}%'", LekarzSearch.Text, LekarzSearch.Text);
            //            datagridLekarze5.DataSource = db.LEKARZE.Where(x => x.IMIĘ.Contains(LekarzSearch.Text) || x.NAZWISKO.Contains(LekarzSearch.Text)).ToList();
        }
       

        public static DataGridViewRow row;

        private void edytujLekarza_Click_1(object sender, EventArgs e)
        {
            row = datagridLekarze5.SelectedRows[0];
    
            Console.WriteLine(datagridLekarze5.Columns[0].Name);
            EdycjaLekarza edycjaLekarza = new EdycjaLekarza();
            edycjaLekarza.ShowDialog();

            this.lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter.Fill(this.przychodniaSet.LEKARZE_TAPI_WYSWIETL_LEKARZY1, out ACURSOR);
        }

        private void spejcalizacjaLekarzaTB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void nazwiskoLekarzaTB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dodajLekarza_Click(object sender, EventArgs e)
        {
            string imie_lekarza = imieLekarzaTB.Text;
            string nazwisko_lekarza = nazwiskoLekarzaTB.Text;
            string specjalizacja = specjalizacjaLekarzaTB.Text;

            this.queriesTableAdapter1.LEKARZE_TAPI_INS(imie_lekarza, specjalizacja, nazwisko_lekarza);

            this.lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter.Fill(this.przychodniaSet.LEKARZE_TAPI_WYSWIETL_LEKARZY1, out ACURSOR);

            imieLekarzaTB.Text = "";
            nazwiskoLekarzaTB.Text = "";
            specjalizacjaLekarzaTB.Text = "";
            
        }

        private void datagridLekarze5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usunLekarza_Click(object sender, EventArgs e)
        {
            row = datagridLekarze5.SelectedRows[0];
            string id_lekarza = LekarzeControl.row.Cells["iDLEKARZADataGridViewTextBoxColumn"].Value.ToString();
            
            this.queriesTableAdapter1.LEKARZE_TAPI_DEL(decimal.Parse(id_lekarza));
            this.lEKARZE_TAPI_WYSWIETL_LEKARZY1TableAdapter.Fill(this.przychodniaSet.LEKARZE_TAPI_WYSWIETL_LEKARZY1, out ACURSOR);

        }
    }
}

