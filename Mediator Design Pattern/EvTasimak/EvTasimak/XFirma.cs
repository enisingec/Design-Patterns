namespace EvTasimak;

public class XFirma : Firma
{
    public XFirma(INakliye nakliye) : base(nakliye)
    {
        
    }

    public override void NekliyeyeBasla()
    {
        Console.WriteLine("Igdar'dan esyalar yuklendi.");
        _nakliye.MaliDevret(this);
    }
}
