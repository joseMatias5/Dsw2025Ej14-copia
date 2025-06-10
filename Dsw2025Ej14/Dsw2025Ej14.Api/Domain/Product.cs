namespace Dsw2025Ej14.Api.Domain
{
    public class Product
    {
        private string sku;
        private string name;
        private decimal currentUnitPrice;
        private bool isActive;

        public string Name { get => name; set => name = value; }
        public string Sku { get => sku; set => sku = value; }
        public decimal CurrentUnitPrice { get => currentUnitPrice; set => currentUnitPrice = value; }
        public bool IsActive { get => isActive; set => isActive = value; }

    }
}
