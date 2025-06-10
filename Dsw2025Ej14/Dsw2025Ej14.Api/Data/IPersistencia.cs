using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public interface IPersistencia
    {
        Product? GetBySku(string sku);
        List<Product> GetProductsActive();
    }
}