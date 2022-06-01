using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Models;

namespace Tickets.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _firstName;
        private string _lastName;
        private TicketModel _selectedTicket;
        private BindableCollection<TicketModel> _tickets = new BindableCollection<TicketModel>();
        private string _ticketName;
        private BindableCollection<TicketModel> _bList = new BindableCollection<TicketModel>();
        public ShellViewModel()
        {
            Tickets.Add(new TicketModel { TicketName = "Adult", Price = 10 });
            Tickets.Add(new TicketModel { TicketName = "Member", Price = 7.50 });
            Tickets.Add(new TicketModel { TicketName = "Child", Price = 5 });

            BList.Add(new TicketModel { TicketName = "Adult", Price = 10 });


        }



        public string TicketName
        {
            get { return _ticketName; }
            set { _ticketName = value; }
        }

        public BindableCollection<TicketModel> BList
        {
            get { return _bList; }
            set { _bList = value; }
        }

        public BindableCollection<TicketModel> Tickets
        {
            get { return _tickets; }
            set { _tickets = value; }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get { return $"{ FirstName } {LastName}"; }
        }

        

        public TicketModel SelectedTicket
        {
            get
            {
                return _selectedTicket;
            }

            set
            {
                _selectedTicket = value;
                NotifyOfPropertyChange(() => SelectedTicket);
            }
        }

        public bool CanClearText(string firstName, string lastName)
        {
            return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
        }

        public void AddToOrder()

        {
            BList.Add(SelectedTicket);
        }

        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }
    }
}
 