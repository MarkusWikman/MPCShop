namespace MPCShop.Data.Services;

public class CategoryDbService(MPCShopContext db, IMapper mapper) : DbService(db, mapper)
{
    public override async Task<List<TDto>> GetAsync<TEntity, TDto>()
    {
        //IncludeNavigationsFor<Filter>();
        //IncludeNavigationsFor<Product>();
        var result = await base.GetAsync<TEntity, TDto>();
        return result;
    }
}