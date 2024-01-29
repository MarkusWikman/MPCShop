﻿namespace MPCShop.Data.Entities;

public class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Category>? Categories { get; set; }
    public List<Size>? Sizes { get; set; }
    public List<Brand>? Brands { get; set; }
    public List<Season>? Seasons { get; set; }
    public List<Color>? Colors { get; set; }

}
