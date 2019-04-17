using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class ProductionActual : Form
    {
        RoofingCompanyEntities db;
        public ProductionActual(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductionActual_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ProductionProces.ToList();
        }
    }
}
