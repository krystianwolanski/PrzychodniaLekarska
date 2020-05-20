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
    public partial class EdycjaChoroby : Form
    {
        public EdycjaChoroby()
        {
            InitializeComponent();
            nazwaChorobyTB.Text = ChorobyControl.rowChoroby.Cells["nAZWADataGridViewTextBoxColumn"].Value.ToString();
            typChorobyTB.Text = ChorobyControl.rowChoroby.Cells["tYPDataGridViewTextBoxColumn"].Value.ToString();

            typChorobyTB.SelectionStart = typChorobyTB.Text.Length;
        }

        private void edytujChorobe_Click(object sender, EventArgs e)
        {
            string nazwa = nazwaChorobyTB.Text;
            string typ = typChorobyTB.Text;
            string id_choroby = ChorobyControl.rowChoroby.Cells["iDCHOROBYDataGridViewTextBoxColumn"].Value.ToString();

            this.queriesTableAdapter1.CHOROBY_TAPI_UPD(Decimal.Parse(id_choroby), typ, nazwa);
           
            this.Close();
            Object acursor;
            chorobY_TAPI_WYSWIETL_CHOROBYTableAdapter1.Fill(przychodniaSet1.CHOROBY_TAPI_WYSWIETL_CHOROBY, out acursor);
        }
    }
}
