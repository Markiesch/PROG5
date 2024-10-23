namespace NinjaManager.Data.Models;

public class NinjaEquipment
{
    public int NinjaId { get; set; }
    public int EquipmentId { get; set; }
    public int BuyPrice { get; set; }
    
    public Ninja Ninja { get; set; }
    public Equipment Equipment { get; set; }
}