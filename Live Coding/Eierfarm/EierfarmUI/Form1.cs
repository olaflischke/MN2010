using EierfarmBl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EierfarmUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNeuesHuhn_Click(object sender, EventArgs e)
        {
            Huhn huhn = new Huhn("Neues Huhn");

            huhn.EigenschaftGeaendert += Gefluegel_EigenschaftGeaendert;

            cbxTier.Items.Add(huhn);
            cbxTier.SelectedItem = huhn;
        }

        private void Gefluegel_EigenschaftGeaendert(object sender, EventArgs e)
        {
            //MessageBox.Show($"Tier {(sender as Gefluegel).Name} hat Eigenschaft geändert");
            pgdTier.SelectedObject = sender as IEileger;
        }

        private void btnNeueGans_Click(object sender, EventArgs e)
        {
            Gans gans = new Gans() { Name = "Neue Gans", Gewicht = 2000 };

            gans.EigenschaftGeaendert += Gefluegel_EigenschaftGeaendert;

            cbxTier.Items.Add(gans);
            cbxTier.SelectedItem = gans;
        }

        private void cbxTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            pgdTier.SelectedObject = cbxTier.SelectedItem;
        }

        private void btnFuettern_Click(object sender, EventArgs e)
        {
            // SaveCast - liefert null, wenn Cast fehlschlägt.
            Gefluegel tier = cbxTier.SelectedItem as Gefluegel;
            if (tier != null)
            {
                tier.Fressen();
            }
        }

        private void btnEiLegen_Click(object sender, EventArgs e)
        {
            if (cbxTier.SelectedItem is IEileger tier)
            {
                tier.EiLegen();
            }
        }
    }
}
