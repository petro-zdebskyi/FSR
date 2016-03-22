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
using FSR.DesktopUI.Code;
namespace FSR.DesktopUI.Forms
{
    public partial class CancelReserveForm : Form
    {
        #region Constructors

        public CancelReserveForm()
        {
            _sqlPersonRepository = new SqlPersonRepository(ConfigurationManager.ConnectionStrings["FSR"].ConnectionString);

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int userId = CurrentUser.Id;
            int seatStatusId;
            bool checkSeatStatusParse = int.TryParse(txtReservationId.Text, out seatStatusId);
            if (checkSeatStatusParse)
            {
                _sqlPersonRepository.CancelReservation(userId, seatStatusId);
            }
        }

        #endregion

        #region Private Fields

        private readonly IPersonRepository _sqlPersonRepository;

        #endregion
    }
}
