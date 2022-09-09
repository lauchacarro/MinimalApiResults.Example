using MinimalApiResults.Example.Dto;
using MinimalApiResults.Example.Entities;

namespace MinimalApiResults.Example.Services;

public interface IProductService
{
    Result<ProductDto> Create(CreateProductRequest request);
}

public class ProductService : IProductService
{
    public Result<ProductDto> Create(CreateProductRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
        {
            return "El nombre es Requerido";
        }


        if (request.Stock <= 0)
        {
            return "El Stock debe ser mayor a cero.";
        }


        Product product = new(request.Name, request.Stock);

        // Agrego el Product a la DB con EntityFrameworkCore

        // _context.Product.Add(product);
        // await _context.SaveChangesAsync();


        ProductDto result = new(product.Id, product.Name, product.Stock);

        return result;
    }
}
