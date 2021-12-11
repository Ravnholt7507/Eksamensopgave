using System;
using System.Text.RegularExpressions;


namespace Eksamensopgave
{
    public class User : IComparable 
    {
        public User(string firstname, string lastname, string username, string email, decimal balance)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Email = email;
            Balance = balance;
        }

        public int ID { get; set; }

        private string _Firstname;
        public string Firstname
        {
            get { return _Firstname; }
            set
            {
                if (value != null)
                {
                    _Firstname = value;
                } 
            } 
        }

        private string _Lastname;
        public string Lastname
        {
            get { return _Lastname; }
            set
            {
                if (value != null)
                {
                    _Lastname = value;
                }
            }
        }

        private string _Username;
        public string Username 
        {
            get { return _Username; }
            set 
            {
                Regex strPattern = new Regex("^[0-9a-z_]*$");
                if (strPattern.IsMatch(value))
                {
                    _Username = value;
                }
            } 
        }

        string _Email;
        public string Email
        {
            get { return _Email; }
            set 
            {
                Regex strPattern = new Regex("^[0-9A-Za-z_.-]*@[A-Za-z0-9]{1}[A-Za-z0-9-.].[.]{1}(com|dk)$");
                if (strPattern.IsMatch(value))
                {
                    _Email = value;
                }
            }
        }
        public decimal Balance { get; set; }

        public int CompareTo(object obj)
        {
            return ID.CompareTo(((User)obj).ID);
        }
    }
      
}
