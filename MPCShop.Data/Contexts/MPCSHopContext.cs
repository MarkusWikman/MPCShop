﻿namespace MPCShop.Data.Contexts;

public class MPCShopContext(DbContextOptions<MPCShopContext> builder) : DbContext(builder)
{
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Filter> Filters => Set<Filter>();
    public DbSet<Size> Sizes => Set<Size>();
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<CategoryFilter> CategoryFilters => Set<CategoryFilter>();
    public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
    public DbSet<ProductSize> ProductSizes => Set<ProductSize>();
    public DbSet<ProductColor> ProductColors => Set<ProductColor>();
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<ProductBrand> ProductBrands => Set<ProductBrand>();
    public DbSet<Season> Seasons => Set<Season>();
    public DbSet<ProductSeason> ProductSeasons => Set<ProductSeason>();



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Composite Keys ("Unique IDs for key combinations") 
        builder.Entity<ProductColor>()
           .HasKey(pc => new { pc.ProductId, pc.ColorId });
        builder.Entity<ProductSize>()
            .HasKey(ps => new { ps.ProductId, ps.SizeId });
        builder.Entity<ProductCategory>()
            .HasKey(pc => new { pc.ProductId, pc.CategoryId });
        builder.Entity<CategoryFilter>()
            .HasKey(cf => new { cf.CategoryId, cf.FilterId });
        builder.Entity<ProductSeason>()
            .HasKey(ps => new { ps.ProductId, ps.SeasonId });
        builder.Entity<ProductBrand>()
    .HasKey(pb => new { pb.ProductId, pb.BrandId });

        #endregion

        #region CategoryFilter Many-to-Many Relationship

        builder.Entity<Category>()
            .HasMany(c => c.Filters)
            .WithMany(f => f.Categories)
            .UsingEntity<CategoryFilter>();

        #endregion


        #region ProductCategory Many-to-Many Relationship
        builder.Entity<Product>()
            .HasMany(p => p.Categories)
            .WithMany(c => c.Products)
            .UsingEntity<ProductCategory>();
        #endregion

        #region ProductSize Many-to-Many Relationship
        builder.Entity<Product>()
            .HasMany(p => p.Sizes)
            .WithMany(c => c.Products)
            .UsingEntity<ProductSize>();
        #endregion

        #region ProductColor Many-to-Many Relationship
        //builder.Entity<Product>()
        //    .HasMany(p => p.Colors)
        //    .WithMany(c => c.Products)
        //    .UsingEntity<ProductColor>();
        #endregion
        #region ProductBrand Many-to-Many Relationship

        builder.Entity<Product>()
            .HasMany(p => p.Brands)
            .WithMany(b => b.Products)
            .UsingEntity<ProductBrand>();

        #endregion
        #region ProductSeason Many-to-Many Relationship

        builder.Entity<Product>()
            .HasMany(p => p.Seasons)
            .WithMany(s => s.Products)
            .UsingEntity<ProductSeason>();

        #endregion

    }
}
