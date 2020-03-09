namespace DinoPark
{
  public class Dino
  {
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public Dino(string name, string species, int age)
    {
      Name = name;
      Species = species;
      Age = age;
    }
  }
}