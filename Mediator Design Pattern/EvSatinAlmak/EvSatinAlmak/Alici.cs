namespace EvSatinAlmak;

public class Alici : Kisi
{
    public Alici(ITransfer transfer) : base(transfer)
    {
        
    }

    public void KonutParasiOde(int tutar)
    {
        Console.WriteLine("Alici: Odeme yapilmistir.");
        _transfer.ParsaGonder(this, tutar);
    }
}