using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class TapTagAdministration : Form
    {
        public TapTagAdministration()
        {
            InitializeComponent();
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicheParametres frm = new FicheParametres();
            frm.ShowDialog();
        }

        private void commerciauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableCommerciaux frm = new TableCommerciaux();
            frm.ShowDialog(); // Or frm.Show();
        }

        private void banquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableBanque frm = new TableBanque();
            frm.ShowDialog();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersList frm = new frmCustomersList();
            frm.ShowDialog();
        }

        private void fournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierTableForm frm = new SupplierTableForm();
            frm.ShowDialog();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frm = new frmUsersList();
            frm.ShowDialog();
        }

        private void pDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablePda frm = new TablePda();
            frm.ShowDialog();
        }

        private void unitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableUnites frm = new TableUnites();
            frm.ShowDialog();
        }

        private void imprimantesDeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableImpression frm = new TableImpression();
            frm.ShowDialog();
        }

        private void dépôtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableDepots frm = new TableDepots();
            frm.ShowDialog();
        }

        private void tableZonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableZone frm = new TableZone();
            frm.ShowDialog();
        }

        private void tableRayonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableRayon frm = new TableRayon();
            frm.ShowDialog();
        }

        private void tableDesÉchantillonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableEchantillons frm = new TableEchantillons();
            frm.ShowDialog();
        }

        private void listeDesArticlesParFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeArticlesFournisseur frm = new ListeArticlesFournisseur();
            frm.ShowDialog();
        }

        private void tablePromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablePromotions frm = new TablePromotions();
            frm.ShowDialog();
        }

        private void générationCodeBarreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImpressionBarcode frm = new FormImpressionBarcode();
            frm.ShowDialog();
        }

        private void suiviArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSuiviArticle frm = new FormSuiviArticle();
            frm.ShowDialog();
        }

        private void ficheTechniqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableFichesTechniques frm = new TableFichesTechniques();
            frm.ShowDialog();
        }

        private void ordreDeFabricationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOrdresFabrication frm = new TableOrdresFabrication();
            frm.ShowDialog();
        }

        private void machinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableMachines frm = new TableMachines();
            frm.ShowDialog();
        }

        private void responsablesDeProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableResponsables frm = new TableResponsables();
            frm.ShowDialog();
        }

        private void situationDesArticlesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSituationArticlesProduits frm = new FormSituationArticlesProduits();
            frm.ShowDialog();
        }

        private void situationDeLaProductionParArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSituationProductionArticle frm = new FormSituationProductionArticle();
            frm.ShowDialog();
        }

        private void bonDeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableBonCommande frm = new TableBonCommande();
            frm.ShowDialog();
        }

        private void tableDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableDevis frm = new TableDevis();
            frm.ShowDialog();
        }

        private void dépensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpensesList frm = new frmExpensesList();
            frm.ShowDialog();
        }

        private void tableAchatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeTicketPurchase frm = new ListeTicketPurchase();
            frm.ShowDialog();
        }

        private void rubriqueDépenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpensesList frm = new frmExpensesList();
            frm.ShowDialog();

        }

        private void tableBonDeLivraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableBonLivraison frm = new TableBonLivraison();
            frm.ShowDialog();
        }

        private void transformerBLEnFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBlToFacture frm = new FormBlToFacture();
            frm.ShowDialog();
        }

        private void tableFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableFacture frm = new TableFacture();
            frm.ShowDialog();
        }

        private void tableCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void etatJournalierToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // Open the report and tell it to load data for today.
            var today = DateTime.Today;
            var frm = new TAPTAGPOS.FormSituationReport(today, today);
            frm.Show();
        }

        private void etatPériodiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the report and let the user choose the dates.
            var frm = new TAPTAGPOS.FormSituationReport();
            frm.Show();
        }

        private void عمولةالبائعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormVentesParVendeur();
            frm.Show();
        }

        private void mouvementBancaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormMouvementBancaire();
            frm.Show();
        }

        private void historiqueDépensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.frmExpensesList();
            frm.Show();
        }

        private void ventesParFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormStatistiquesVentes();
            frm.Show();
        }

        private void ventesParArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormStatistiquesVentesArticle();
            frm.Show();
        }

        private void ventesParMoisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormVentesParMois();
            frm.Show();
        }

        private void venteParVendeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormJournalVentes();
            frm.Show();
        }

        private void situationDesVentesDesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormEtatVentesArticles();
            frm.Show();
        }

        private void etatDuStockPrécédenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormMouvementStock();
            frm.Show();
        }

        private void détailCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormDetailCA();
            frm.Show();
        }

        private void relevéBancaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormReleveBancaire();
            frm.Show();
        }

        private void situationChèquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.ClientChecksForm();
            frm.Show();
        }

        private void etatGlobalDuStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormEtatGlobalStock();
            frm.Show();
        }

        private void mouvementStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormStock();
            frm.Show();
        }

        private void تصحيحالمخزونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.FormStockCorrection();
            frm.Show();
        }

        private void sociétésDeTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.TableTransports();
            frm.Show();
        }

        private void bordereauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TAPTAGPOS.TableBordereaux();
            frm.Show();
        }
    }
}
