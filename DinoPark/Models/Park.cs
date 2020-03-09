namespace DinoPark
{
  public class Park
  {
    public List<Dino> DinoList {get; set;} = new List<Dino>();
    public void AddDino(Dino dinoToAdd)
    {
      _dinos.Add(dinoToAdd);
    }
  }
}