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
    public partial class Form1 : Form
    {
        private LekarzeControl lc;
        private PacjenciControl pc;
        private WizytyControl wizyty;
        private LekiControl lekiControl;
        private ChorobyControl chorobyControl;
        private BadaniaControl badaniaControl;
        private KartaBadanControl kartaBadanControl;
        
        
        //static Form1 _obj;

        //public static Form1 Instance
        //{
        //    get
        //    {
        //        if (_obj == null)
        //        {
        //            _obj = new Form1();
        //        }
        //        return _obj;
        //    }
        //}

        public Panel PnlContainer
        {
            get
            {
                return panelContainer;
            }
            set
            {
                panelContainer = value;
            }
        }


        public Form1()
        {
            lc = new LekarzeControl();
            pc = new PacjenciControl();
            wizyty = new WizytyControl();
            lekiControl = new LekiControl();
            chorobyControl = new ChorobyControl();
            badaniaControl = new BadaniaControl();
            kartaBadanControl = new KartaBadanControl();

            InitializeComponent();

            SidePanel.Height = LekarzeButton.Height - 1;
            SidePanel.Top = LekarzeButton.Top;

        }

        private void LekarzeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = LekarzeButton.Height - 1;
            SidePanel.Top = LekarzeButton.Top;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(lc);
        }

        private void PacjenciButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = PacjenciButton.Height - 1;
            SidePanel.Top = PacjenciButton.Top;

            
            pc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(pc);
           
        }

        private void WizytyButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = WizytyButton.Height - 1;
            SidePanel.Top = WizytyButton.Top;

            wizyty.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(wizyty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_obj = this;
            
            lc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(lc);
            
            

        }

        private void LekiButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = LekiButton.Height - 1;
            SidePanel.Top = LekiButton.Top;

            lekiControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(lekiControl);
        }

        private void ChorobyButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ChorobyButtton.Height - 1;
            SidePanel.Top = ChorobyButtton.Top;

            chorobyControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(chorobyControl);
        }

        private void BadaniaButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BadaniaButton.Height - 1;
            SidePanel.Top = BadaniaButton.Top;

            badaniaControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(badaniaControl);
        }

        private void KartaBadanButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = kartaBadanButton.Height - 1;
            SidePanel.Top = kartaBadanButton.Top;

            kartaBadanControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(kartaBadanControl);
        }
    }
}
