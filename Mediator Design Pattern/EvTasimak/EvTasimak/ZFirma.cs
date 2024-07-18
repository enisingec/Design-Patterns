namespace EvTasimak;

public class ZFirma : Firma
{
    public ZFirma(INakliye nakliye) : base(nakliye)
    {
        
    }

    public override void NekliyeyeBasla()
    {
        Console.WriteLine("Ankara'dan esyalar yuklendi.");
        _nakliye.MaliDevret(this);
    }
}