namespace MenuApi.Models.Interfaces
{
  public interface IMenuItem
  {
    int Id { get; set; }
    string Name { get; set; }
    float Price { get; set; }
    int Calories { get; set; }
  }
}