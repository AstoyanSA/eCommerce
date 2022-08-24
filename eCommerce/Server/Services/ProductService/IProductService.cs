namespace eCommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId); 
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryUrlAsync(string categoryUrl);
    }
}
