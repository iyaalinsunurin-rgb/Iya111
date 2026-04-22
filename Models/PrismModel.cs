namespace Graciel17.Models;

public class PrismModel
{
    public double MainLength { get; set; }
    public double MainWidth { get; set; }
    public double MainHeight { get; set; }

    public double CutLength { get; set; }
    public double CutWidth { get; set; }
    public double CutHeight { get; set; }

    public double MainVolume => MainLength * MainWidth * MainHeight;
    public double CutVolume => CutLength * CutWidth * CutHeight;
    public double FinalVolume => MainVolume - CutVolume;
}