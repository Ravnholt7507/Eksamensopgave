namespace Eksamensopgave
{
    class Product 
    {
        public Product(string name, decimal price, bool active, bool canbeboughtoncredit)
        {
            Name = name;
            Price = price;
            Active = active;
            CanBeBoughtOnCredit = canbeboughtoncredit;
        }

        public int ID { get; set; }

        private string _Name;
        public string Name 
        {
            get { return _Name; }
            set
            {
                if(value != null)
                {
                    _Name = value;
                }
            }
        }

        private decimal _Price;
        public decimal Price 
        {
            get { return _Price; }
            set { _Price = value; }
        }

        private bool _Active;
        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }

        private bool _CanBeBougtOnCredit;
        public bool CanBeBoughtOnCredit
        {
            get { return _CanBeBougtOnCredit; }
            set { _CanBeBougtOnCredit = value; }
        }

        public override string ToString()
        {
            return ID + " " + Name + " " + Price;
        }


    }
      
}
