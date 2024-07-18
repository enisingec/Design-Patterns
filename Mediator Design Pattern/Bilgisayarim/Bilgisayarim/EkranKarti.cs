namespace Bilgisayarim;

public class EkranKarti : Birim
{
    public EkranKarti(IAnakart anakart) : base(anakart)
    {
        
    }

    public void GorselVer(string videoData)
    {
        string[] datas = videoData.Split(",");
        foreach (var VARIABLE in datas)
        {
            Console.WriteLine($"Gelen goruntu: {VARIABLE}");
        }
    }
}