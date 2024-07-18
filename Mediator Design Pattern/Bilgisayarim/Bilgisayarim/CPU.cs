namespace Bilgisayarim;

public class CPU : Birim
{
    public CPU(IAnakart anakart) : base(anakart)
    {
        
    }

    public string _videoData;
    public string _sesData;

    public string VideoData => _videoData;
    public string SesData => _sesData;

    public void DataIsle(string cdData)
    {
        string[] array = cdData.Split("*");
        _videoData = array[0];
        _sesData = array[1];
        _anakart.Degistir(this);
    }
}