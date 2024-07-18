namespace Bilgisayarim;

public class SesKarti : Birim
{
    public SesKarti(IAnakart anakart) : base(anakart)
    {
        
    }

    public void SesVer(string sesData)
    {
        string[] datas = sesData.Split(",");
        foreach (var VARIABLE in datas)
        {
            Console.WriteLine($"Gelen ses: {VARIABLE}");
        }
    }
}