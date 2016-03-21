using FSR.Repositories.Classes;
using FSR.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSR.DesktopUI.Code;

namespace FSR.DesktopUI.Forms
{
    public partial class ReserveForm : Form
    {
        public ReserveForm()
        {
            _sqlPersonRepository = new SqlPersonRepository(ConfigurationManager.ConnectionStrings["FSR"].ConnectionString);
            InitializeComponent();
        }

        private readonly IPersonRepository _sqlPersonRepository;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            int userId = CurrentUser.Id;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int flightId;
            int seat;
            bool checkFlightParse = int.TryParse(txtFlightId.Text, out flightId);
            bool checkSeatParse = int.TryParse(txtSeat.Text, out seat);
            if (checkFlightParse && checkSeatParse)
            {
                _sqlPersonRepository.MakeReserveation(userId, name, surname, flightId, seat);
            }
        }
    }
}
