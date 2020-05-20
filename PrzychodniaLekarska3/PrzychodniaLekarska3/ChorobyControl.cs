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
    public partial class ChorobyControl : UserControl
    {
        Object cursor;
        public static DataGridViewRow rowChoroby;
        public ChorobyControl()
        {
            InitializeComponent();
            
            this.cHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter.Fill(przychodniaSet.CHOROBY_TAPI_WYSWIETL_CHOROBY, out cursor);
        }

        private void dodajChorobe_Click(object sender, EventArgs e)
        {
            string nazwa = NazwaChorobyTB.Text;
            string typ = TypChorobyTB.Text;

            this.queriesTableAdapter1.CHOROBY_TAPI_INS(typ, nazwa);
            this.cHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter.Fill(przychodniaSet.CHOROBY_TAPI_WYSWIETL_CHOROBY, out cursor);

            NazwaChorobyTB.Text = "";
            TypChorobyTB.Text = "";
        }

        private void usunChorobe_Click(object sender, EventArgs e)
        {
            rowChoroby = datagridChoroby.SelectedRows[0];
            Console.WriteLine(datagridChoroby.Columns[0].Name);
            string id_choroby = rowChoroby.Cells["iDCHOROBYDataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.CHOROBY_TAPI_DEL(Decimal.Parse(id_choroby));
            this.cHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter.Fill(przychodniaSet.CHOROBY_TAPI_WYSWIETL_CHOROBY, out cursor);
        }

        private void edytujChorobe_Click(object sender, EventArgs e)
        {
            rowChoroby = datagridChoroby.SelectedRows[0];

            //Console.WriteLine(datagridChoroby.Columns[1].Name);
            EdycjaChoroby edycjaChoroby = new EdycjaChoroby();
            edycjaChoroby.ShowDialog();

            this.cHOROBY_TAPI_WYSWIETL_CHOROBYTableAdapter.Fill(przychodniaSet.CHOROBY_TAPI_WYSWIETL_CHOROBY, out cursor);
        }
    }
}
