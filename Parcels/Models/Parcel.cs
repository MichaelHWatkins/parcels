namespace Parcels.Models
{
  public class Parcel
  {
    public int Width {get; set;}
    public int Height {get; set;}
    public int Depth {get; set;}
    public int Weight {get; set;}
    public Parcel(string width, string height, string depth, string weight)
    {
      Width = int.Parse(width);
      Height = int.Parse(height);
      Depth  = int.Parse(depth);
      Weight = int.Parse(weight);
    }

    public int Volume()
    {
      return Width * Height * Depth;
    }

    public int CostToShip()
    {
      return Volume() * Weight;
    }
  }
} 
