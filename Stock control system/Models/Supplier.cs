namespace Stock_control_system.Models
{
    public class Supplier
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private Address? Address { get; set; }
        private string CNPJ { get; set; }

    }
}
