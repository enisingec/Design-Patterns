namespace EvTasimak;

public class Nakliye: INakliye
{
    private XFirma _xFirma;
    private YFirma _yFirma;
    private ZFirma _zFirma;
    
    public XFirma XFirma
    {
        set => _xFirma = value;
    }
    
    public YFirma YFirma
    {
        set => _yFirma = value;
    }
    
    public ZFirma ZFirma
    {
        set => _zFirma = value;
    }
    public void MaliDevret(Firma firma)
    {
        if (firma is XFirma)
        {
            Console.WriteLine("Esyalar sivas'ta tekrar nakledilmek uzere indirildi.\n");
            _yFirma.NekliyeyeBasla();
        }
        else if (firma is YFirma)
        {
            Console.WriteLine("Esyalar Ankara'da tekrar nakledilmek uzere indirildi.\n");
            _zFirma.NekliyeyeBasla();
        }
        else
        {
            Console.WriteLine("Esyalar Edirneye vardi...");
        }
        
    }
}