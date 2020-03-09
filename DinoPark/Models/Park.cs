using System.Collections.Generic;

namespace DinoPark.Models
{
  public class Park
  {
    public List<Dino> DinoList {get; set;} = new List<Dino>();
    public void AddDino(Dino dinoToAdd)
    {
      DinoList.Add(dinoToAdd);
    }
  }
}