using System;

namespace ConsoleCalsss
{
    internal class Sale
    {
        private int Id;
        private string coments;

        public Sale()
        {
            Id = 0;
            coments = String.Empty;
        }

        public Sale(int id, string coments)
        {
            this.Id = id;
            this.coments = coments;
        }

        //setters & getters
        public int ID
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }

        }
        
        public string Coments
        {
            get
            {
                return this.coments;
            }
            set
            {
                this.coments = value;
            }
        }

    }
}
