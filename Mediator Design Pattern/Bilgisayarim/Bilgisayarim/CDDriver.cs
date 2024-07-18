namespace Bilgisayarim;

public class CDDriver : Birim
{
    public CDDriver(IAnakart anakart) : base(anakart)
    {
        
    }

    private string _cdData;
    public string CDData => _cdData;

    public void CDOku()
    {
        _cdData = "goruntu1,goruntu2,goruntu3*ses1,ses2,ses3";
        _anakart.Degistir(this);
    }
}