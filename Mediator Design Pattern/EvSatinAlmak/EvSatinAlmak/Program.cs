namespace EvSatinAlmak;

class Program
{
    static void Main(string[] args)
    {
        Transfer transfer = new Transfer();

        Alici alici = new Alici(transfer);
        Emlakci emlakci = new Emlakci(transfer);
        Satici satici = new Satici(transfer);

        transfer.Alici = alici;
        transfer.Emlakci = emlakci;
        transfer.Satici = satici;
        
        alici.KonutParasiOde(200000);
        Console.WriteLine("------------------------------");
        alici.KonutParasiOde(100000);
    }
}