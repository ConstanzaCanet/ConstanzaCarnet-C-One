using System;

namespace ConsoleCalsss
{
    internal class Product
    {
        private int Id;
        private string description;
        private int cost;
        private int salesPrice;
        private int stock;
        private User IdUser;


        public Product()
        {
            Id = 0;
            description = String.Empty;
            cost = 0;
            salesPrice = 0;
            stock = 0;
            //Aqui no estoy segura de que sea bueno crear un usuario sin nada
            //Tampoco estoy segura de si lo he declarado bien al tipo... espero la devo, gracias
            //IdUser = new User();  
        }


        public Product(int id, string description, int cost, int salesPrice, int stock, string idUser)
        {
            Id = id;
            this.description = description;
            this.cost = cost;
            this.salesPrice = salesPrice;
            this.stock = stock;
            IdUser = IdUser;
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

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }   
        }
        public int Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;
            }       
        }
        public int SalesPrice
        {
            get
            {
                return this.salesPrice;
            }
            set
            {
                this.salesPrice = value;
            }       
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }
        public User IDUser
        {
            get
            {
                return this.IdUser;
            }
            set
            {
                this.IdUser = value;
            }               
        }


    }
}
