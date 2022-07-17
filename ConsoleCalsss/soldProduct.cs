using System;


namespace ConsoleCalsss
{
    internal class soldProduct
    {
        private int Id;
        private Product IdProduct;
        private int stock;
        private int IdSale;

        public soldProduct()
        {
            Id = 0;
            IdProduct = new Product();
            stock = 0;
            IdSale = 0;
        }

        public soldProduct(int id, Product idProduct, int stock, int idSale)
        {
            this.Id = id;
            this.IdProduct = idProduct;
            this.stock = stock;
            this.IdSale = idSale;
        }

        //setters & getters
        public int ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        public int IDProduct
        {
            get { return this.IDProduct; }
            set { this.IDProduct = value; }
        }
        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }
        public int IDSale
        {
            get { return this.IdSale; }
            set { this.IdSale = value; }
        }

    
    }

}
