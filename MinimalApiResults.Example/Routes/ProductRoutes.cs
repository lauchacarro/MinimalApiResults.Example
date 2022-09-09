using MinimalApiResults.Example.Dto;
using MinimalApiResults.Example.Services;

namespace MinimalApiResults.Example.Routes
{
    public static class ProductRoutes
    {
        const string PATH = "/Products";

        public static IEndpointRouteBuilder MapProducts(this IEndpointRouteBuilder endpoint)
        {
            endpoint.MapPost(PATH, (IProductService service, CreateProductRequest request)
                => service.Create(request).ToHttpResult());

            return endpoint;
        }
    }
}
