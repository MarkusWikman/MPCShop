namespace MPCShop.Data.Services;

public class ProductDbService(MPCShopContext db, IMapper mapper) : DbService(db, mapper)
{
    public async Task<List<ProductGetDTO>> GetProductsByCategoryAsync(int categoryId)
    {
        //IncludeNavigationsFor<Filter>();
        IncludeNavigationsFor<Color>();
        IncludeNavigationsFor<Category>();
        IncludeNavigationsFor<Size>();
        IncludeNavigationsFor<Brand>();
        IncludeNavigationsFor<Season>();

        var productIds = GetAsync<ProductCategory>(pc => pc.CategoryId.Equals(categoryId))
            .Select(pc => pc.ProductId);
        var products = await GetAsync<Product>(p => productIds.Contains(p.Id)).ToListAsync();
        return MapList<Product, ProductGetDTO>(products);
    }
    public List<TDto> MapList<TEntity, TDto>(List<TEntity> entities)
    where TEntity : class
    where TDto : class
    {
        return mapper.Map<List<TDto>>(entities);
    }
}