using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSR.Entities
{
    public class SeatStatus
    {
        #region Constructors

        public SeatStatus(User user, Person person, Seat seat)
        {
            _user = user;
            _person = person;
            _seat = seat;
        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public string UserName
        {
            get
            {
                return _user.Name;
            }
        }
        public string UserSurname
        {
            get
            {
                return _user.Surname;
            }
        }
        public int PersonId
        {
            get
            {
                return _person.Id;
            }
        }
        public string PersonName
        {
            get
            {
                return _person.Name;
            }
        }
        public string PesronSurname
        {
            get
            {
                return _person.Surname;
            }
        }
        public int SeatNumber
        {
            get
            {
                return _seat.Number;
            }
        }
        public int FlightId
        {
            get
            {
                return _seat.GetFlightInfo().Id;
            }
        }
        public string FlightDepature
        {
            get
            {
                return _seat.GetFlightInfo().Depature;
            }
        }
        public string FlightDestination
        {
            get
            {
                return _seat.GetFlightInfo().Destination;
            }
        }

        #endregion

        #region Methods

        public User GetUserInfo()
        {
            return _user;
        }
        public Person GetPersonInfo()
        {
            return _person;
        }
        public Seat GetSeatInfo()
        {
            return _seat;
        }
        public int Status { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID реєстрації: {Id}");
            sb.AppendLine($"ID реєстратора : {_user.Id}");
            sb.AppendLine($"Ім'я реєстратора: {_user.Name}");
            sb.AppendLine($"Прізвище реєстратора: {_user.Surname}");
            sb.AppendLine($"ID замовника: {_person.Id}");
            sb.AppendLine($"Ім'я замовника: {_person.Name}");
            sb.AppendLine($"Прізвище замовника: {_person.Surname}");
            sb.AppendLine($"ID місця: {_seat.Id}");
            sb.AppendLine($"Номер місця: {_seat.Number}");
            sb.AppendLine($"ID польоту: {_seat.GetFlightInfo().Id}");
            sb.AppendLine($"Час вильоту: {_seat.GetFlightInfo().DepatureTime}");
            sb.AppendLine($"Час прибуття: {_seat.GetFlightInfo().ArrivalTime}");
            sb.AppendLine($"Місце вильоту: {_seat.GetFlightInfo().Depature}");
            sb.AppendLine($"Місце прибуття: {_seat.GetFlightInfo().Destination}");
            sb.Append($"Статус місця: {Status}");

            return sb.ToString();
        }

        #endregion

        #region Private Fields

        private User _user;
        private Person _person;
        private Seat _seat;

        #endregion
    }
}
