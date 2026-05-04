using Modeles;

namespace Laboratoire12_2
{
    public partial class CreditApp : Form
    {
        private Carte carteActive;

        public CreditApp()
        {
            InitializeComponent();

            // TODO 1


            // TODO 2
           

            #region NE_PAS_MODIFIER
            groupBox1.Visible = false;
            #endregion
        }

        private void RaffraichirDetailsCarte()
        {
            // TODO 3
        }

        private void btnEmprunter_Click(object sender, EventArgs e)
        {
            // TODO 4
        }

        private void btnRembourser_Click(object sender, EventArgs e)
        {
            // TODO 5
        }

        private void btnAjouterInterets_Click(object sender, EventArgs e)
        {
            // TODO 6
        }

#region NE_PAS_MODIFIER
        private void lstCartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCartes.SelectedItem != null)
            {
                carteActive = (Carte)lstCartes.SelectedItem;
                RaffraichirDetailsCarte();
                groupBox1.Visible = true;
            }
        }
        #endregion
    }
}
