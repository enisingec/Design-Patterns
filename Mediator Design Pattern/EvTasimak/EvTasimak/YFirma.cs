namespace EvTasimak;

public class YFirma : Firma
{
    public YFirma(INakliye nakliye) : base(nakliye)
    {
        
    }

    public override void NekliyeyeBasla()
    {
        Console.WriteLine("Sivastan esyalar yuklendi.");
        _nakliye.MaliDevret(this);
    }
}