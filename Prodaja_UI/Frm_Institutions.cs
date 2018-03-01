using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Prodaja_DAL;

namespace Prodaja_UI
{
    public partial class Frm_Institutions : Form
    {
        DSInstitutions dsInstitutions = new DSInstitutions();

        public Frm_Institutions()
        {
            InitializeComponent();
        }

        private void Frm_Institutions_Load(object sender, EventArgs e)
        {

            //DAInstitutions.GetInstitutions(dtInstitution);
            DAInstitutions.GetAllTerritories(dsInstitutions.Institution);
            DSInstitutions.InstitutionRow territory = dsInstitutions.Institution.NewInstitutionRow();
            

            cbxTerritories.DataSource = dsInstitutions.Institution;
            cbxTerritories.DisplayMember = "Teren farma all";
            cbxTerritories.ValueMember = "Teren farma all";

            btnTrazi_Click(null, null);
            //dgInstitutions.DataSource = dtInstitution;
            
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            DAInstitutions.GetInstitutionsByName(dsInstitutions.Institution, txtGrad.Text, txtInstitucija.Text, cbxTerritories.ValueMember);
            
            dgInstitutions.AutoGenerateColumns = false;
            dgInstitutions.DataSource = dsInstitutions.Institution;
            lblNumber.Text = dsInstitutions.Institution.Count.ToString();
        }
    }
}
