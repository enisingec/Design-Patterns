namespace EvSatinAlmak;

public class Transfer : ITransfer
{
    private Alici alici;
    private Emlakci emlakci;
    private Satici satici;
    
    public Alici Alici
    {
        set => alici = value;
    }
    
    public Emlakci Emlakci
    {
        set => emlakci = value;
    }
    
    public Satici Satici
    {
        set => satici = value;
    }
    
    public void ParsaGonder(Kisi kisi, int tutar)
    {
        if (kisi is Alici && tutar > 100000)
        {
            satici.ParaAl(tutar);
        }
        else if (kisi is Alici && tutar <= 100000)
        {
            emlakci.KomisyonAl(tutar * 10 / 100);
            satici.ParaAl(tutar);
        }
        else if (kisi is Satici && tutar > 100000)
        {
            emlakci.KomisyonAl(tutar * 3 / 100);
        }
        
    }
}