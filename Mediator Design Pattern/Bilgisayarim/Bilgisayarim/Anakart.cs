namespace Bilgisayarim;

public class Anakart : IAnakart
{
    private CDDriver _cdDriver;
    private CPU _cpu;
    private EkranKarti _ekranKarti;
    private SesKarti _sesKarti;
    
    public CDDriver CDDriver
    {
        set => _cdDriver = value;
    }

    public CPU CPU
    {
        set => _cpu = value;
    }

    public EkranKarti EkranKarti
    {
        set => _ekranKarti = value;
    }

    public SesKarti SesKarti
    {
        set => _sesKarti = value;
    }
    
    public void Degistir(Birim birim)
    {
        if (birim is CDDriver)
        {
            string cdData = _cdDriver.CDData;
            _cpu.DataIsle(cdData);
        }
        else if(birim is CPU)
        {
            string videoData = _cpu.VideoData;
            string sesData = _cpu.SesData;
            _ekranKarti.GorselVer(videoData);
            _sesKarti.SesVer(sesData);
        }
    }
}