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
    }
}
