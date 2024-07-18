namespace EvSatinAlmak;

public class Emlakci : Kisi
{
    public Emlakci(ITransfer transfer) : base(transfer)
    {
        
    }

    public void KomisyonAl(int tutar)
    {
        Console.WriteLine($"Emlakci: {tutar}TL kadar komisyon alinmistir.");
    }
}