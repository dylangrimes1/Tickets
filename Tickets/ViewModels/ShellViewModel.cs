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
        // List of all the strings and variables used
        private string _firstName;
        private string _lastName;
        private TicketModel _selectedTicket;
        private BindableCollection<TicketModel> _tickets = new BindableCollection<TicketModel>();
        private string _ticketName;
        private BindableCollection<TicketModel> _bList = new BindableCollection<TicketModel>();
        private BindableCollection<TicketModel> _pList = new BindableCollection<TicketModel>();
        private double _totalPrice = 0;
        private string _nameDisplayed = "Hidden";
        public ShellViewModel()
        {
            Tickets.Add(new TicketModel { TicketName = "Adult (£10)", Price = 10 });
            Tickets.Add(new TicketModel { TicketName = "Member (£7.50)", Price = 7.50 });
            Tickets.Add(new TicketModel { TicketName = "Child (£5)", Price = 5 });
        }

        // sets the variable for the Name that will be displayed
        public string NameDisplayed //Public variant
        {
            get { return _nameDisplayed; }
            set
            {
                _nameDisplayed = value;
                NotifyOfPropertyChange(() => NameDisplayed);
            }
        }


        // sets the variable for the Total Price
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        // Sets the variable for ticket name
        public string TicketName
        {
            get { return _ticketName; }
            set { _ticketName = value; }
        }

        // Sets the variable for the BList (Basket List)
        public BindableCollection<TicketModel> BList
        {
            get { return _bList; }
            set { _bList = value; }
        }

        // Sets the variable for the PList (Price List)
        public BindableCollection<TicketModel> PList
        {
            get { return _pList; }
            set { _pList = value; }
        }

        // Sets the variable for the Tickets
        public BindableCollection<TicketModel> Tickets
        {
            get { return _tickets; }
            set { _tickets = value; }
        }

        // First Name variable
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

        // Last name variable
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

        // Links the first name and last name to create Full Name
        public string FullName
        {
            get { return $"{ FirstName } {LastName}"; }
        }

        
        // sets the variable for the selected ticket
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

        // Code for the button that clears the text
        public bool CanClearText(string firstName, string lastName)
        {
            return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
        }

        // Code for the Add To Order button
        public void AddToOrder()

        {
            BList.Add(SelectedTicket); // Adds selected ticket to the BList
            PList.Add(SelectedTicket);
            TotalPrice += SelectedTicket.Price; // Adds the price of the SelectedTicket to the Total Price
            NotifyOfPropertyChange(() => TotalPrice); // Notifies the change of the TotalPrice so that it can be displayed
        }

        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }


        //Code for when the Pie and Pint button is clicked
        public void PiePint()
        {
            BList.Add(new TicketModel { TicketName = "Pie + Pint (£5)", Price = 5 }); // Adds the Pie and Pint to the Blist
            PList.Add(new TicketModel { TicketName = "Pie + Pint (£5)", Price = 5 });
            TotalPrice += 5; // Adds 5 to the Total Price
            NotifyOfPropertyChange(() => TotalPrice); // Notifies the change of the TotalPrice so that it can be displayed
        }

        // Code for when the Tour button is clicked
        public void Tour()
        {
            BList.Add(new TicketModel { TicketName = "Tour Of Grounds (£3)", Price = 3 }); // Adds the tour of grounds to the BList
            PList.Add(new TicketModel { TicketName = "Tour Of Grounds (£3)", Price = 3 });
            TotalPrice += 3; // Adds 3 to the Total Price
            NotifyOfPropertyChange(() => TotalPrice); // Notifies the change of the TotalPrice so that it can be displayed
        }

        // Code for when the Front Row button is clicked
        public void FrontRow()
        {
            BList.Add(new TicketModel { TicketName = "Front Row (£8)", Price = 8 }); // Adds Front Row to the BList
            PList.Add(new TicketModel { TicketName = "Front Row (£8)", Price = 8 });
            TotalPrice += 8; // Adds 8 to the total price
            NotifyOfPropertyChange(() => TotalPrice); // Notifies the change of the TotalPrice so that it can be displayed
        }
        
        // Code for when the confirm order button is clicked
        public void Confirmed()
        {
            NameDisplayed = "Visible"; // Sets the name to visible
        }
    }
}
 