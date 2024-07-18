namespace EvTasimak;

class Program
{
    static void Main(string[] args)
    {
        Nakliye nakliye = new Nakliye();
        
        XFirma xfirma = new XFirma(nakliye);
        YFirma yfirma = new YFirma(nakliye);
        ZFirma zfirma = new ZFirma(nakliye);

        nakliye.XFirma = xfirma;
        nakliye.YFirma = yfirma;
        nakliye.ZFirma = zfirma;
        
        xfirma.NekliyeyeBasla();
    }
}