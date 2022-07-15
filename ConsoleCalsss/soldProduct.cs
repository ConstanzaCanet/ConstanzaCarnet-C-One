using System;


namespace ConsoleCalsss
{
    internal class soldProduct
    {
        private int Id;
        private int IdProduct;
        private int stock;
        private int IdSale;

        public soldProduct()
        {
            Id = 0;
            IdProduct = 0;
            stock = 0;
            IdSale = 0;
        }

        public soldProduct(int id, int idProduct, int stock, int idSale)
        {
            this.Id = id;
            this.IdProduct = idProduct;
            this.stock = stock;
            this.IdSale = idSale;
        }   
    }
}
