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
    public partial class LekarzeControl : UserControl
    {
        
        public LekarzeControl()
        {
            
            InitializeComponent();
            this.lEKARZETableAdapter.Fill(this.wYSWIETLLEKARZYBindingSource1);
        }
    
            
            

        private void LekarzSearch_TextChange(object sender, EventArgs e)
        {
            lEKARZEBindingSource.Filter = string.Format("imię LIKE '%{0}%' or nazwisko LIKE '%{1}%'", LekarzSearch.Text, LekarzSearch.Text);
            //            datagridLekarze5.DataSource = db.LEKARZE.Where(x => x.IMIĘ.Contains(LekarzSearch.Text) || x.NAZWISKO.Contains(LekarzSearch.Text)).ToList();
        }

        public static DataGridViewRow row;
        private void edytujLekarza_Click_1(object sender, EventArgs e)
        {
            row = datagridLekarze5.SelectedRows[0];
            Console.WriteLine(datagridLekarze5.Columns[0].Name);
            EdycjaLekarza edycjaLekarza = new EdycjaLekarza();
            edycjaLekarza.ShowDialog();
        }

        private void spejcalizacjaLekarzaTB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void nazwiskoLekarzaTB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dodajLekarza_Click(object sender, EventArgs e)
        {
            
        }

        private void datagridLekarze5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

