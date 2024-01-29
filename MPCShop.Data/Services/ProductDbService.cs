namespace MPCShop.Data.Services;

public class ProductDbService(MPCShopContext db, IMapper mapper) : DbService(db, mapper)
{
    public override async Task<List<TDto>> GetAsync<TEntity, TDto>()
    {
        //IncludeNavigationsFor<Filter>();
        IncludeNavigationsFor<Color>();
        IncludeNavigationsFor<Category>();
        IncludeNavigationsFor<Size>();
        IncludeNavigationsFor<Brand>();
        IncludeNavigationsFor<Season>();

        var result = await base.GetAsync<TEntity, TDto>();
        return result;
    }
}