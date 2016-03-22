using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSR.Repositories.Classes;
using FSR.Repositories.Interfaces;
using System.Configuration;

namespace FSR.DesktopUI.Forms
{
    public partial class PriceListForm : Form
    {
        #region Constructors

        public PriceListForm()
        {
            _sqlSeatRepository = new SqlSeatRepository(ConfigurationManager.ConnectionStrings["FSR"].ConnectionString);

            InitializeComponent();

            dgvSeats.DataSource = _sqlSeatRepository.GetAllSeats();

        }

        #endregion

        #region Methods

        private void dgvSeats_SelectionChanged(object sender, EventArgs e)
        {
            dgvSeats.ClearSelection();
        }

        #endregion

        #region Private Fields

        public readonly ISeatRepository _sqlSeatRepository;

        #endregion
    }
}
