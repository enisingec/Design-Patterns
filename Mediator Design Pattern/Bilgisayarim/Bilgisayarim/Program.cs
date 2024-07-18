namespace Bilgisayarim;

class Program
{
    static void Main(string[] args)
    {
        Anakart anakart = new Anakart();

        // Colleague'ler olusuruluyor...
        CDDriver cdDriver = new CDDriver(anakart);
        CPU cpu = new CPU(anakart);
        EkranKarti ekranKarti = new EkranKarti(anakart);
        SesKarti sesKarti = new SesKarti(anakart);

        // Mediator'a colleague'ler bildiriyor...
        anakart.CDDriver = cdDriver;
        anakart.CPU = cpu;
        anakart.EkranKarti = ekranKarti;
        anakart.SesKarti = sesKarti;

        cdDriver.CDOku();
    }
}