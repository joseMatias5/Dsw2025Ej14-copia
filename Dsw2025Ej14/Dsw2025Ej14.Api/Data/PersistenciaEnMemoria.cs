namespace Dsw2025Ej14.Api.Data;

using System.Text.Json;
using Dsw2025Ej14.Api.Domain;
using Microsoft.Azure.Amqp;

public class PersistenciaEnMemoria : IPersistencia
{
    private List<Product> _products = [];
    private PersistenciaEnMemoria()
    {
        LoadProducts();
    }

    private void LoadProducts()
    {
        var json = File.ReadAllTextAsync("products.json");
        var products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        }) ?? [];
        if (products != null)
        {
            _products = products;
        }
    }

    public List<Product> GetProductsActive() => _products.Where(p => p.IsActive).ToList();
}
