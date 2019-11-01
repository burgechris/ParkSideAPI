namespace ParkSideAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string GoverningBody { get; set; }
    public string StateLocation { get; set; }
    public int Established { get; set; }
    public string Coordinates { get; set; }
    public string Area { get; set; }
    public string Website { get; set; }
  }
}