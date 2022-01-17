using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Mandys_IT3
{
    public partial class limitVyberiN : Form
    {
        Ucet ucet1;
        public limitVyberiN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucet1 = new Ucet("Michal Mandys", 3500);
            Vypis(ucet1);
        }
        private void Vypis(Ucet ucet)
        {
            vypisJmeno.Text = ucet.jmeno;
            vypisZustatek.Text = "" + ucet.zustatek;
        }

        private void vklad_Click(object sender, EventArgs e)
        {
            ucet1.Vklad((int)vkladCisla.Value);
            Vypis(ucet1);
            // vypisZustatek.Text = "" + ucet1.zustatek;
        }

        private void vybrat_Click(object sender, EventArgs e)
        {
            ucet1.Vyber((int)vyberCisla.Value);
            Vypis(ucet1);
        }

        private void platba_Click(object sender, EventArgs e)
        {
            ucet1.Plat((int)platbaCisla.Value);
            Vypis(ucet1);
        }

        //private void limitVyberu_ValueChanged(object sender, EventArgs e)
        //{
        //    ucet1.Limit((int)limitVyberuN.Value);
        //    Vypis(ucet1);
        //}
    }
}
