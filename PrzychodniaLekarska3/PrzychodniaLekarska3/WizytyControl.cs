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
    public partial class WizytyControl : UserControl
    {
        Object acursor;
        public WizytyControl()
        {
            InitializeComponent();
            this.wIZYTY_TAPI_WYSWIETL_WIZYTYTableAdapter.Fill(przychodniaSet.WIZYTY_TAPI_WYSWIETL_WIZYTY, out acursor);
        }

        private void dodajWizyte_Click(object sender, EventArgs e)
        {
            DodajWizyteForm dw = new DodajWizyteForm();
            dw.ShowDialog();

            this.wIZYTY_TAPI_WYSWIETL_WIZYTYTableAdapter.Fill(przychodniaSet.WIZYTY_TAPI_WYSWIETL_WIZYTY, out acursor);
        }
    }
}
