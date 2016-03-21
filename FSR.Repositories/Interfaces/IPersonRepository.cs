using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSR.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        void MakeReserveation(int userId, string personName, string personSurname, int flightId, int seat);
        void CancelReservation(int userId, int seatStatusId);
    }
}
