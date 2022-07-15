using System;

namespace ConsoleCalsss
{
    internal class Product
    {
        private int Id;
        private string description;
        private string cost;
        private int salesPrice;
        private int stock;
        private string IdUser;


        public Product()
        {
            Id = 0;
            description = String.Empty;
            cost = String.Empty;
            salesPrice = 0;
            stock = 0;
            IdUser = String.Empty;  
        }


        public Product(int id, string description, string cost, int salesPrice, int stock, string idUser)
        {
            Id = id;
            this.description = description;
            this.cost = cost;
            this.salesPrice = salesPrice;
            this.stock = stock;
            this.IdUser = idUser;
        }
    }
}
