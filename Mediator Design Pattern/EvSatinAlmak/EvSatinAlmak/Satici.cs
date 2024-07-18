namespace EvSatinAlmak;

public class Satici : Kisi
{
    public Satici(ITransfer transfer) : base(transfer)
    {
        
    }

    public void ParaAl(int tutar)
    {
        Console.WriteLine($"Satici: {tutar} TL kadar konut bedeli alinmistir.");
        _transfer.ParsaGonder(this, tutar);
    }
}