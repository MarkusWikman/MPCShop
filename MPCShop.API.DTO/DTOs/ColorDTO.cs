namespace MPCShop.API.DTO.DTOs;
public class ColorPostDTO
{
    public string Name { get; set; } = string.Empty;
    public OptionType OptionType { get; set; }
    public string TextColor { get; set; } = string.Empty;
    public string BGColor { get; set; } = string.Empty;
}
public class ColorPutDTO : ColorPostDTO
{
    public int Id { get; set; }
}
public class ColorGetDTO : ColorPutDTO
{
    public bool IsSelected { get; set; }
    //public List<FilterGetDTO>? Filters { get; set; }
}
