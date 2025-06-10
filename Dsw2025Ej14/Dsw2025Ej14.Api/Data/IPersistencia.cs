using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public interface IPersistencia
    {
        List<Product> GetProductsActive();
    }
}