namespace StockControlSystem.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Address? Address { get; set; }
        public string CNPJ { get; set; }

        public Supplier(string name, string description, string cnpj)
        { 
            Name = name;
            Description = description;
            CNPJ = cnpj;
        }
    }
}
