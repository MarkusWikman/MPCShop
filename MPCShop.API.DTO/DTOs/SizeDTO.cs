namespace MPCShop.API.DTO.DTOs;
public class SizePostDTO
{
    public string Name { get; set; } = string.Empty;
}
public class SizePutDTO : SizePostDTO
{
    public int Id { get; set; }
}
public class SizeGetDTO : SizePutDTO
{
    public bool IsSelected { get; set; }
}
