namespace Laba
{
    internal class Product
    {
        public Product(int idProduct, string productName, string productMatereal, string productCategory, double productPrice)
        {
            IdProduct = idProduct;
            this.productName = productName;
            this.productMatereal = productMatereal;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
        }
        private int idProduct;
        private string productName;
        private string productMatereal;
        private double productPrice;
        private string productCategory;
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductDescription { get => productMatereal; set => productMatereal = value; }
        public string ProductCategory { get => productCategory; set => productCategory = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
    }
}