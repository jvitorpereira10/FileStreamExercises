namespace ExercicioFixacaoArquivos.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; }

        public Product()
        {
        }
        public Product(string name, double itemPrice, int itemQuantity)
        {
            Name = name;
            ItemPrice = itemPrice;
            ItemQuantity = itemQuantity;
        }
        public double Total()
        {
            return ItemPrice * ItemQuantity;
        }
    }
}