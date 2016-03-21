using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSR.Entities;
using FSR.Repositories;
using System.Configuration;
using System.Reflection;
using FSR.Repositories.Classes;
using FSR.Repositories.Interfaces;

namespace FSR.DesktopUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            _sqlSeatStatusRepository = new SqlSeatStatusRepository(ConfigurationManager.ConnectionStrings["FSR"].ConnectionString);

            InitializeComponent();

            dgvSeatStatuses.DataSource = _sqlSeatStatusRepository.GetAllSeatStatuses();
        }

        private readonly ISeatStatusRepository _sqlSeatStatusRepository;

        private void dtgSeatStatus_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSeatStatuses.Rows)
            {
                if (row.Cells[10].Value.ToString() == "0") 
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen; 
                }
                else if (row.Cells[10].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void btnPriceList_Click(object sender, EventArgs e)
        {
            PriceListForm frmPriceList = new PriceListForm();
            frmPriceList.Show();
        }

        private void dgvSeatStatuses_SelectionChanged(object sender, EventArgs e)
        {
            dgvSeatStatuses.ClearSelection();
        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            int personId;
            bool checkParse = int.TryParse(txtFindById.Text, out personId);
            if(!checkParse)
            {
                MessageBox.Show(this, "Invalid format of person Id", "Converting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SeatStatus seatStatus = _sqlSeatStatusRepository.GetSeatStatusByPersonId(personId);
            if (seatStatus == null)
            {
                MessageBox.Show(this, "Invalid person Id", "Person Id Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FlightInfoForm frmFlightInfo = new FlightInfoForm();
                frmFlightInfo.txtFlightInfo.Text = _sqlSeatStatusRepository.GetSeatStatusByPersonId(personId).ToString();
                frmFlightInfo.Show();
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            ReserveForm frmReserve = new ReserveForm();
            frmReserve.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSeatStatuses.DataSource = null;
            dgvSeatStatuses.DataSource = _sqlSeatStatusRepository.GetAllSeatStatuses();
        }

        private void btnCancelReserve_Click(object sender, EventArgs e)
        {
            CancelReserveForm frmCancelReserve = new CancelReserveForm();
            frmCancelReserve.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoForm frmInfo = new InfoForm();
            frmInfo.Show();
        }
    }
}
